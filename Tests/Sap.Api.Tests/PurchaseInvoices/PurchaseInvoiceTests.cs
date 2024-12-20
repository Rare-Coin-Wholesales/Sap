using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Sap.Api;
using Sap.Api.Domain.PurchaseInvoices;
using Sap.Api.Tests;
using Sap.Core;
using Sap.Services.Security;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseInvoices;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.Export;
using Sql2023.Intranet.Services.Logging;
using Sql2023.Intranet.Services.Orders;
using Xunit;

namespace Sap.Api.Tests
{
	public partial class PurchaseInvoiceTests
	{
		#region Fields
		private const string ACCOUNTS_PAYABLE_TRADE = "_SYS00000000046";
		private const string AMEX_72006 = "_SYS00000000047";
		private const string DOCUMENT_SERVICE = "dDocument_Service";
		private const string INVENTORY_COIN = "_SYS00000000022";
		private const string TAX_EXEMPT = "EX";
		private const string TEST_COMPANY_DB = "A21384_RCW_T01";
		private static readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly IExportManager _exportManager = new ExportManager();
		private static readonly ILogger _logger = new DefaultLogger();
		private static readonly IOrderService _intranetOrderService = new OrderService();
		private static readonly IPurchaseInvoiceService _scarPurchaseInvoiceService = new PurchaseInvoiceService();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly ServiceLayer _serviceLayer = new ServiceLayer(BaseUrl, Rcw_CompanyDb, Username, Password);
		#endregion

		#region Utilities
		private void AddErrorLogs()
		{
			_serviceLayer.OnError(async call => {
				var log = string.Empty;
				log = $"{log}Request: {call.HttpRequestMessage.Method}  {call.HttpRequestMessage.RequestUri}{Environment.NewLine}";
				log = $"{log}Body sent: {call.RequestBody}{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";
				log = $"{log}Response: {call.HttpResponseMessage?.StatusCode}{Environment.NewLine}";
				log = $"{log}{await call.HttpResponseMessage?.Content?.ReadAsStringAsync()}";
				log = $"{log}Call duration: {(DateTime.UtcNow - call.StartedUtc).TotalSeconds:n3} seconds{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";

				_exportManager.WriteToFile(log, "Error");
			});
		}

		private static IList<PurchaseInvoice_DocumentLine> GetDocumentLines(Order x)
		{
			decimal lineTotal;
			var list = new List<PurchaseInvoice_DocumentLine>();
			var lineItems = _intranetOrderService.GetLineItemsByOrderId(x.OrderID);

			if (lineItems == null || lineItems.Count == 0)
				return list;

			foreach (var item in lineItems.OrderBy(y => y.OrderLine).ToList()) {
				lineTotal = (item.Price ?? 0) * (item.QtyOrdered ?? 1);
				list.Add(new PurchaseInvoice_DocumentLine {
					ItemDescription = $"Coin {item.CoinID}",
					Quantity = item.QtyOrdered,
					Price = item.Price,
					PriceAfterVAT = item.Price,
					Address = x.ShipToAddress1,
					LineTotal = lineTotal,
					TaxTotal = 0,
					TaxCode = TAX_EXEMPT,
					RowTotalSC = lineTotal,
					UnitPrice = item.Price,
					OpenAmount = item.Price,
					OpenAmountSC = item.Price,
					GrossPrice = lineTotal,
					GrossTotal = lineTotal,
					GrossTotalSC = lineTotal,
					AccountCode = INVENTORY_COIN,
				});
			}

			return list;
		}

		private static PurchaseInvoice ToPurchaseInvoice(Order x)
		{
			return new PurchaseInvoice {
				NumAtCard = x.OrderID.ToString(),
				DocType = DOCUMENT_SERVICE,
				CreationDate = x.DateEntered,
				DocDate = x.DateEntered,
				DocDueDate = x.DateEntered,
				TaxDate = x.DateEntered,
				UpdateDate = x.DateRevised,
				DocTotal = x.TotalSales / 10000, // Insight adds 4 extra zeros
				DocTotalSys = x.TotalSales / 10000,
				Address = x.ShipToAddress1,
				Address2 = x.ShipToAddress2,
				CardCode = $"V{x.Cust_}",
				JournalMemo = $"A/P Invoices - V{x.Cust_}",
				ControlAccount = AMEX_72006,
				DocumentLines = GetDocumentLines(x),
			};
		}
		#endregion

		[Fact]
		public async void Test_CancelPurchaseInvoice()
		{
			AddErrorLogs();
			var invoice = await _serviceLayer.GetPurchaseInvoiceAsync(398);
			invoice.ShouldNotBeNull();
			_serviceLayer.LogToCsv(new List<PurchaseInvoice> { invoice });

			await _serviceLayer.CancelAsync(invoice);
		}

		[Fact]
		public async void Test_CancelPurchaseInvoices()
		{
			AddErrorLogs();
			int[] tests = { 407, 408 };

			foreach (var test in tests) {
				var invoice = await _serviceLayer.GetPurchaseInvoiceAsync(test);
				invoice.ShouldNotBeNull();
				_serviceLayer.LogToCsv(new List<PurchaseInvoice> { invoice });

				await _serviceLayer.CancelAsync(invoice);
			}
		}

		/// <summary>
		/// Order => PurchaseInvoice (A/P).
		/// </summary>
		[Fact]
		public async Task Test_CreatePurchaseInvoicesAsync()
		{
			AddErrorLogs();
			var purchaseInvoices = _intranetOrderService.GetRecent();

			if (purchaseInvoices == null || purchaseInvoices.Count == 0)
				return;

			_exportManager.ExportToCsv(purchaseInvoices);
			var scarPurchaseInvoices = _scarPurchaseInvoiceService.GetAll();
			var missingPurchaseInvoices = (from x in purchaseInvoices // left join
										   from y in scarPurchaseInvoices.Where(y => y.NumAtCard.StartsWith(x.OrderID.ToString()) ||
																	   y.NumAtCard.EndsWith(x.OrderID.ToString())).DefaultIfEmpty()
										   where y == null || y.NumAtCard == null
										   select x).ToList();

			foreach (var purchaseInvoice in missingPurchaseInvoices) {
				var created = await _serviceLayer.TryCreateAsync(ToPurchaseInvoice(purchaseInvoice));

				if (created.Item1 == null)
					throw new Exception(created.Item2);
			}
		}
	}
}