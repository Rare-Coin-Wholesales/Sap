using B1SLayer;
using Sap.Api.Domain.Invoices;
using Sap.ApiToScarRcwMapper;
using Sap.Core;
using Sap.Services.Security;
using Sap.Tests;
using Sql2023.Intranet.Services.Export;
using Sql2023.Intranet.Services.Invoices;
using Sql2023.Intranet.Services.Logging;
using Invoice = Sap.Api.Domain.Invoices.Invoice;

namespace Sap.Rcw.IntegrationTests
{
	public partial class InvoiceIntegrationTests
	{
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
		private static readonly IInvoiceService _intranetInvoiceService = new Sql2023.Intranet.Services.Invoices.InvoiceService();
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

			foreach (var item in lineItems) {
				lineTotal = (item.Price ?? 0) * (item.QtyOrdered ?? 1);
				list.Add(new Invoice_DocumentLine {
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
					DocEntry = x.InvoiceID,
					GrossPrice = lineTotal,
					GrossTotal = lineTotal,
					GrossTotalSC = lineTotal,
					AccountCode = DetermineAccount(x),
				});
			}

			return list;
		}

		private static Invoice ToInvoice(Sql2023.Intranet.Domain.Invoice x)
		{
			return new Invoice {
				DocEntry = x.InvoiceID,
				DocNum = x.InvoiceID,
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
		public async Task Test_CreateAsync()
		{
			AddErrorLogs();
			var now = DateTime.Now;
			var data = new Api.Domain.Invoices.Invoice
            {
				DocEntry = 51957,
				DocNum = 51957,
				CardCode = "17810",
				ShipState = "MA",
				CreationDate = DateTime.Parse("2024-07-09 00:00:00.000"),
				DocDate = DateTime.Parse("2024-07-09 00:00:00.000"),
				UpdateDate = DateTime.Parse("2024-09-09 00:00:00.000"),
				DocumentLines = new List<Invoice_DocumentLine>(),
			};

			data.DocumentLines.Add(new Invoice_DocumentLine {
				LineNum = 0,
				ItemCode = "136377",
				ItemDescription = "136377",
				Quantity = 1,
				UnitPrice = 25500.00m,
				LineTotal = 25500.00m,
			});

			var _invoiceService = new Api.Services.InvoiceService(ServiceLayer);
			var created = await _invoiceService.CreateAsync(data);
			created.ShouldNotBeNull();
		}

		/// <summary>
		/// Invoice => Invoice (A/R).
		/// </summary>
		[Fact]
		public async Task Test_CreateInvoicesAsync()
		{
			AddErrorLogs();
			var invoices = _intranetInvoiceService.GetRecentInvoices();

			if (invoices == null || invoices.Count == 0)
				return;

			invoices = invoices.OrderBy(x => x.InvoiceID).Take(1).ToList();
			_exportManager.ExportToCsv(invoices);
            Api.Domain.Invoices.Invoice pi;
			var _apiInvoiceService = new Api.Services.InvoiceService(ServiceLayer);

			foreach (var invoice in invoices) {
				try {
					pi = ToInvoice(invoice);
					var x = await _apiInvoiceService.CreateAsync(pi);
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
			var _invoiceService = new Api.Services.InvoiceService(ServiceLayer);
			var all = await _invoiceService.GetAll();
			all.ShouldNotBeNull();
		}

		[Fact]
		public async Task Test_GetAllInvoicesAsync()
		{
			var _mapper = new Mapper();
			var _invoiceService = new ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices.InvoiceService();
			var _invoiceServiceNew = new Api.Services.InvoiceService(ServiceLayer);
			var list = await _invoiceServiceNew.GetAll();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_invoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_invoiceService.Insert(_mapper.ToSql(v));
						Assert.True(true);

						foreach (var line in v.DocumentLines) {
							try {
								_invoiceService.Insert(_mapper.ToSql(line));
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
			//File.WriteAllText(String.Format("{0}{1:dd HH mmss} Test_GetAllInvoicesAsync.csv", folder, DateTime.Now), log);
		}

		#region Prev
		//private static readonly EncryptionUtil _encryptionUtil = new();
		//private static readonly Mapper _mapper = new();
		//private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		//private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		//private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		//private static readonly string Test_CompanyDb = "A21384_RCW_T01";
		//private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");

		//private static SLConnection ServiceLayer = new SLConnection(BaseUrl, Rcw_CompanyDb, Username, Password);
		//private readonly ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices.InvoiceService _invoiceService = new();

		//[Fact]
		//public async Task Test_GetAllInvoicesAsync()
		//{
		//	var _invoiceServiceNew = new Api.Services.InvoiceService(ServiceLayer);
		//	var list = await _invoiceServiceNew.GetAll();

		//	if (list == null || list.Count == 0)
		//		Assert.False(false);
		//	else {
		//		_invoiceService.TruncateTable();

		//		foreach (var v in list) {
		//			try {
		//				_invoiceService.Insert(_mapper.ToSql(v));
		//				Assert.True(true);

		//				foreach (var line in v.DocumentLines) {
		//					try {
		//						_invoiceService.InsertDocumentLine(_mapper.ToSql(line));
		//						Assert.True(true);
		//					}

		//					catch {
		//						Assert.True(false);
		//					}
		//				}
		//			}

		//			catch {
		//				Assert.True(false);
		//			}
		//		}
		//	}

		//	//var log = "DocEntry,DocNum,DocType,CardCode,Comments\r\n";

		//	//foreach (var v in list)
		//	//	log = String.Format($"{log}{v.DocEntry},{v.DocNum},{v.DocType},{v.CardCode},{v.Comments}{Environment.NewLine}");

		//	//var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
		//	//Directory.CreateDirectory(folder);
		//	//File.WriteAllText(String.Format("{0}{1:dd HH mmss} Test_GetAllInvoicesAsync.csv", folder, DateTime.Now), log);
		//}
		#endregion
	}
}