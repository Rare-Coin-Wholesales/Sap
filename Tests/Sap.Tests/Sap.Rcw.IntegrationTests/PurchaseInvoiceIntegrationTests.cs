using B1SLayer;
using Sap.Api.Domain.PurchaseInvoices;
using Sap.Api.Services;
using Sap.ApiToScarRcwMapper;
using Sap.Core;
using Sap.Services.Security;
using Sap.Tests;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.Export;
using Sql2023.Intranet.Services.Logging;
using Sql2023.Intranet.Services.Orders;

namespace Sap.Rcw.IntegrationTests
{
	public partial class PurchaseInvoiceIntegrationTests
	{
		private const string ACCOUNTS_PAYABLE_TRADE = "_SYS00000000046";
		private const string DOCUMENT_SERVICE = "dDocument_Service";
		private const string INVENTORY_COIN = "_SYS00000000022";
		private const string RESOURCE = "PurchaseInvoices";
		private const string TAX_EXEMPT = "EX";
		private const string TEST_COMPANY_DB = "A21384_RCW_T01";
		private static readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly IExportManager _exportManager = new ExportManager();
		private static readonly ILogger _logger = new DefaultLogger();
		private static readonly IOrderService _orderService = new OrderService();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly SLConnection ServiceLayer = new SLConnection(BaseUrl, TEST_COMPANY_DB, Username, Password);

		#region Utilities
		private void AddErrorLogs()
		{
			ServiceLayer.OnError(async call => {
				var log = string.Empty;
				log = $"{log}Request: {call.HttpRequestMessage.Method}  {call.HttpRequestMessage.RequestUri}{Environment.NewLine}";
				log = $"{log}Body sent: {call.RequestBody}{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";
				log = $"{log}Response: {call.HttpResponseMessage?.StatusCode}{Environment.NewLine}";
				log = $"{log}{await call.HttpResponseMessage?.Content?.ReadAsStringAsync()}";
				log = $"{log}Call duration: {(DateTime.UtcNow - call.StartedUtc).TotalSeconds:n4} seconds{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";

				_exportManager.WriteToFile(log, "Error");
			});
		}

		private static IList<PurchaseInvoice_DocumentLine> GetDocumentLines(Order x)
		{
			decimal lineTotal;
			var list = new List<PurchaseInvoice_DocumentLine>();
			var lineItems = _orderService.GetLineItemsByOrderId(x.OrderID);

			if (lineItems == null || lineItems.Count == 0)
				return list;

			foreach (var item in lineItems) {
				lineTotal = (item.Price ?? 0) * (item.QtyOrdered ?? 1);
				list.Add(new PurchaseInvoice_DocumentLine {
					ItemDescription = item.CoinID.ToString(),
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
					DocEntry = x.OrderID,
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
				DocEntry = x.OrderID,
				DocNum = x.OrderID,
				DocType = DOCUMENT_SERVICE,
				CreationDate = x.DateEntered,
				DocDate = x.DateEntered,
				DocDueDate = x.DateEntered,
				TaxDate = x.DateEntered,
				UpdateDate = x.DateRevised,
				DocTotal = x.TotalSales,
				DocTotalSys = x.TotalSales,
				Address = x.ShipToAddress1,
				Address2 = x.ShipToAddress2,
				CardCode = $"V{x.Cust_}",
				JournalMemo = $"A/P Invoices - V{x.Cust_}",
				ControlAccount = ACCOUNTS_PAYABLE_TRADE,
				DocumentLines = GetDocumentLines(x),
			};
		}
		#endregion

		[Fact]
		public async Task Test_CreateAsync()
		{
			AddErrorLogs();
			var now = DateTime.Now;
			var data = new PurchaseInvoice {
				DocEntry = 51957,
				DocNum = 51957,
				CardCode = "V17810",
				ShipState = "MA",
				CreationDate = DateTime.Parse("2024-07-09 00:00:00.000"),
				DocDate = DateTime.Parse("2024-07-09 00:00:00.000"),
				UpdateDate = DateTime.Parse("2024-09-09 00:00:00.000"),
				DocumentLines = new List<PurchaseInvoice_DocumentLine>(),
			};

			data.DocumentLines.Add(new PurchaseInvoice_DocumentLine {
				LineNum = 0,
				ItemCode = "136377",
				ItemDescription = "136377",
				Quantity = 1,
				UnitPrice = 25500.00m,
				LineTotal = 25500.00m,
			});

			var _purchaseInvoiceService = new PurchaseInvoiceService(ServiceLayer);
			var created = await _purchaseInvoiceService.CreateAsync(data);
			created.ShouldNotBeNull();
		}

		/// <summary>
		/// Order => PurchaseInvoice (A/P).
		/// </summary>
		[Fact]
		public async Task Test_CreatePurchaseInvoicesAsync()
		{
			AddErrorLogs();
			var orders = _orderService.GetDistinctOrders();

			if (orders == null || orders.Count == 0)
				return;

			orders = orders.OrderBy(x => x.OrderID).Take(1).ToList();
			_exportManager.ExportToCsv(orders);
			PurchaseInvoice pi;
			var _purchaseInvoiceService = new PurchaseInvoiceService(ServiceLayer);

			foreach (var order in orders) {
				try {
					pi = ToPurchaseInvoice(order);
					var x = await _purchaseInvoiceService.CreateAsync(pi);
				}

				#region catch (Exception ex)
				catch (Exception ex) {
					if (ex.InnerException == null)
						_logger.InsertWarning(ex);
					else
						throw;
				}
				#endregion
			}
		}

		[Fact]
		public async Task Test_GetAllAsync()
		{
			var _purchaseInvoiceService = new PurchaseInvoiceService(ServiceLayer);
			var all = await _purchaseInvoiceService.GetAll();
			all.ShouldNotBeNull();
		}

		[Fact]
		public async Task Test_GetAllPurchaseInvoicesAsync()
		{
			var _mapper = new Mapper();
			var _purchaseInvoiceService = new ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseInvoices.PurchaseInvoiceService();
			var _purchaseInvoiceServiceNew = new Api.Services.PurchaseInvoiceService(ServiceLayer);
			var list = await _purchaseInvoiceServiceNew.GetAll();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_purchaseInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseInvoiceService.Insert(_mapper.ToSql(v));
						Assert.True(true);

						foreach (var line in v.DocumentLines) {
							try {
								_purchaseInvoiceService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
					}

					catch {
						Assert.True(false);
					}
				}
			}

			//var log = "DocEntry,DocNum,DocType,CardCode,Comments\r\n";

			//foreach (var v in list)
			//	log = String.Format($"{log}{v.DocEntry},{v.DocNum},{v.DocType},{v.CardCode},{v.Comments}{Environment.NewLine}");

			//var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			//Directory.CreateDirectory(folder);
			//File.WriteAllText(String.Format("{0}{1:dd HH mmss} Test_GetAllPurchaseInvoicesAsync.csv", folder, DateTime.Now), log);
		}
	}
}