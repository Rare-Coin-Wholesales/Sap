using System;
using System.Collections.Generic;
using System.Linq;
using Sap.Api;
using Sap.Api.Domain.Invoices;
using Sap.Api.Tests;
using Sap.Core;
using Sap.Services.Security;
using Sql2023.Intranet.Services.Export;
using Sql2023.Intranet.Services.Logging;
using Xunit;
using ApiInvoice = Sap.Api.Domain.Invoices.Invoice;
using IntraInvoices = Sql2023.Intranet.Services.Invoices;
using ScarInvoices = ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices;

namespace Sap.Rcw.IntegrationTests
{
	public partial class InvoiceTests
	{
		#region Fields
		private const string ACCOUNTS_RECEIVABLE = "_SYS00000000010";
		private const string DOCUMENT_SERVICE = "dDocument_Service";
		private const string INCOME_SALES_RETAIL_CA = "_SYS00000000079";
		private const string INCOME_SALES_RETAIL_OUT_OF_STATE = "_SYS00000000080";
		private const string INCOME_SALES_WHOLESALE_CA = "_SYS00000000078";
		private const string RESOURCE = "Invoices";
		private const string TAX_EXEMPT = "EX";
		private const string TEST_COMPANY_DB = "A21384_RCW_T01";
		private static readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly IExportManager _exportManager = new ExportManager();
		private static readonly ILogger _logger = new DefaultLogger();
		private static readonly IntraInvoices.IInvoiceService _intranetInvoiceService = new IntraInvoices.InvoiceService();
		private static readonly ScarInvoices.IInvoiceService _scarWitchInvoiceService = new ScarInvoices.InvoiceService();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly ServiceLayer _serviceLayer = new ServiceLayer(BaseUrl, TEST_COMPANY_DB, Username, Password);
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

		/// <summary>
		/// Determines the Income Sales Account based on the State.
		/// </summary>
		/// <param name="x">The <see cref="Invoice"/>.</param>
		/// <returns>The AccountCode as a string.</returns>
		private static string DetermineAccount(Sql2023.Intranet.Domain.Invoice x)
		{
			if (x == null || String.IsNullOrWhiteSpace(x.ShipToState))
				return INCOME_SALES_RETAIL_OUT_OF_STATE;
			if (x.ShipToState.Equals("CA", StringComparison.OrdinalIgnoreCase) ||
				x.ShipToState.Equals("California", StringComparison.OrdinalIgnoreCase))
				return INCOME_SALES_RETAIL_CA;

			return INCOME_SALES_RETAIL_OUT_OF_STATE;
		}

		private static IList<Invoice_DocumentLine> GetDocumentLines(Sql2023.Intranet.Domain.Invoice x)
		{
			decimal lineTotal;
			var list = new List<Invoice_DocumentLine>();
			var lineItems = _intranetInvoiceService.GetLineItemsByInvoiceId(x.InvoiceID);

			if (lineItems == null || lineItems.Count == 0)
				return list;

			foreach (var item in lineItems.OrderBy(y => y.InvoiceLine).ToList()) {
				lineTotal = (item.Price ?? 0) * (item.QtyOrdered ?? 1);
				list.Add(new Invoice_DocumentLine {
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
					AccountCode = DetermineAccount(x),
				});
			}

			return list;
		}

		private static ApiInvoice ToInvoice(Sql2023.Intranet.Domain.Invoice x)
		{
			return new ApiInvoice {
				NumAtCard = x.InvoiceID.ToString(),
				DocType = DOCUMENT_SERVICE,
				CreationDate = x.DateEntered,
				DocDate = x.DateEntered,
				DocDueDate = x.DateEntered,
				TaxDate = x.DateEntered,
				UpdateDate = x.DateEntered,
				DocTotal = x.TotalSales,
				DocTotalSys = x.TotalSales,
				Address = x.ShipToAddress1,
				Address2 = x.ShipToAddress2,
				CardCode = $"{x.Cust_}",
				JournalMemo = $"A/R Invoices - {x.Cust_}",
				ControlAccount = ACCOUNTS_RECEIVABLE,
				DocumentLines = GetDocumentLines(x),
			};
		}
		#endregion

		[Fact]
		public async void Test_CancelInvoice()
		{
			AddErrorLogs();
			var invoice = await _serviceLayer.GetInvoiceAsync(23);
			invoice.ShouldNotBeNull();
			_serviceLayer.LogToCsv(new List<ApiInvoice> { invoice });

			await _serviceLayer.CancelAsync(invoice);
		}

		[Fact]
		public async void Test_CancelMultipleInvoices()
		{
			AddErrorLogs();
			ApiInvoice invoice;
			int[] tests = { 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 233 };

			foreach (var test in tests) {
				invoice = await _serviceLayer.GetInvoiceAsync(test);
				invoice.ShouldNotBeNull();

				await _serviceLayer.CancelAsync(invoice);
			}
		}

		/// <summary>
		/// Invoice => Invoice (A/R).
		/// </summary>
		[Fact]
		public async void Test_CreateMissingInvoices()
		{
			AddErrorLogs();
			var invoices = _intranetInvoiceService.GetRecent();

			if (invoices == null || invoices.Count == 0)
				return;

			_exportManager.ExportToCsv(invoices);
			var sapRcwInvoices = _scarWitchInvoiceService.GetAll();
			var missingInvoices = (from x in invoices // left join
								   from y in sapRcwInvoices.Where(y => y.NumAtCard.StartsWith(x.InvoiceID.ToString()) ||
																	   y.NumAtCard.EndsWith(x.InvoiceID.ToString())).DefaultIfEmpty()
								   where y == null || y.NumAtCard == null
								   select x).ToList();

			foreach (var invoice in missingInvoices) {
				var created = await _serviceLayer.TryCreateAsync(ToInvoice(invoice));

				if (created.Item1 == null)
					throw new Exception(created.Item2);
			}
		}
	}
}