using System.Text;
using B1SLayer;
using Sap.Api;
using Sap.Api.Http;
using Sap.ApiToScarRcwMapper;
using Sap.Core;
using Sap.Services.Security;
using Sap.Tests;
using ScarletWitch.Sap_RareCoinWholesalers.Services.AccountCategories;
using ScarletWitch.Sap_RareCoinWholesalers.Services.AccountSegmentationCategories;
using ScarletWitch.Sap_RareCoinWholesalers.Services.AccountSegmentations;
using ScarletWitch.Sap_RareCoinWholesalers.Services.BillOfExchangeTransactions;
using ScarletWitch.Sap_RareCoinWholesalers.Services.ChartOfAccounts;
using ScarletWitch.Sap_RareCoinWholesalers.Services.ChecksforPayments;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Deposits;
using ScarletWitch.Sap_RareCoinWholesalers.Services.FAAccountDeterminations;
using ScarletWitch.Sap_RareCoinWholesalers.Services.GLAccountAdvancedRules;
using ScarletWitch.Sap_RareCoinWholesalers.Services.HouseBankAccounts;
using ScarletWitch.Sap_RareCoinWholesalers.Services.IncomingPayments;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices;
using ScarletWitch.Sap_RareCoinWholesalers.Services.JournalEntries;
using ScarletWitch.Sap_RareCoinWholesalers.Services.JournalEntryDocumentTypes;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseInvoices;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseOrders;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseQuotations;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseTaxInvoices;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Quotations;
using ScarletWitch.Sap_RareCoinWholesalers.Services.SalesTaxInvoices;
using ScarletWitch.Sap_RareCoinWholesalers.Services.TransactionCodes;
using ScarletWitch.Sap_RareCoinWholesalers.Services.VendorPayments;
using Sql2023.Intranet.Services.Export;
using Sql2023.WwwSPs.Services.TradingAccounts;
using Sql2023.WwwSPs.Services.TradingAccountTransactions;
using Web202209.SAP_RareCoinWholesalers.Services.CreditNotes;
using Web202209.SAP_RareCoinWholesalers.Services.PurchaseCreditNotes;

namespace Sap.Rcw.IntegrationTests
{
	public class IntegrationTest1
	{
		private static readonly EncryptionUtil _encryptionUtil = new();
		private static readonly Mapper _mapper = new();
		private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Test_CompanyDb = "A21384_RCW_T01";
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");

		private static SLConnection ServiceLayer = new SLConnection(BaseUrl, Rcw_CompanyDb, Username, Password);
		public static readonly ServiceLayer RcwServiceLayer = new ServiceLayer(BaseUrl, Rcw_CompanyDb, Username, Password);
		protected static readonly IInvoiceService _scarInvoiceService = new InvoiceService();
		protected static readonly IPurchaseInvoiceService _scarPurchaseInvoiceService = new PurchaseInvoiceService();
		protected static readonly ITradingAccountService _tradingAccountService = new TradingAccountService();
		protected static readonly ITradingAccountTransactionService _tradingAccountTransactionService = new TradingAccountTransactionService();
		/// <summary>Nov 1, 2024</summary>
		protected static readonly DateTime SapStartDate = new DateTime(2024, 11, 1);
		protected static readonly IExportManager _exportManager = new ExportManager();

		public static void WriteToCsvFile(string data, string entityName)
		{
			var now = DateTime.Now;
			var folder = $"C:/Logs/SAP Automation/{now:yyyy MM}/";
			Directory.CreateDirectory(folder);
			File.WriteAllText($"{folder}{entityName} {now:dd HHmm ssff}.csv", data);
		}

		[Fact]
		private static void Test_GetAPTransactions()
		{
			var tradingAccounts = _tradingAccountService.GetAll();
			var tradingAccountTransactions = _tradingAccountTransactionService.GetAPs();
			var sapPurchaseInvoices = _scarPurchaseInvoiceService.GetAllValid();
			sapPurchaseInvoices = sapPurchaseInvoices.Where(x => x.DocDate.Value >= SapStartDate).ToList();

			var query= from sap in sapPurchaseInvoices // Remember: AP BusinessPartners start with "V"
					   join ta in tradingAccounts on sap.CardCode equals ta.VendorId
					   select sap;

			var list= (from sap in query // left join
					   from tat in tradingAccountTransactions.Where(x => x.DocumentId == sap.NumAtCard && sap.CardCode == x.VendorId).DefaultIfEmpty()
					   where tat == null // || tat.DocumentId == null || tat.VendorId == null
					   select sap).ToList();

			var sb = new StringBuilder($"CardCode,NumAtCard{Environment.NewLine}");

			foreach (var item in list) {
				sb.Append($"\"{item.CardCode}\",");
				sb.Append($"\"{item.NumAtCard}\"{Environment.NewLine}"); //new line
			}

			WriteToCsvFile(sb.ToString(), "PurchaseInvoices");
		}

		[Fact]
		private static void Test_GetARTransactions()
		{
			var tradingAccounts = _tradingAccountService.GetAll();
			var tradingAccountTransactions = _tradingAccountTransactionService.GetARs();
			var sapInvoices = _scarInvoiceService.GetAllValid();
			sapInvoices = sapInvoices.Where(x => x.DocDate.Value >= SapStartDate).ToList();

			var query= from sap in sapInvoices
					   join ta in tradingAccounts on sap.CardCode equals ta.InsightCustomerId
					   select sap;

			var list= (from sap in query
					   from tat in tradingAccountTransactions.Where(x => x.DocumentId == sap.NumAtCard && sap.CardCode == x.InsightCustomerId).DefaultIfEmpty()
					   where tat == null || tat.DocumentId == null || tat.InsightCustomerId == null
					   select sap).ToList();

			var sb = new StringBuilder($"CardCode,NumAtCard{Environment.NewLine}");

			foreach (var item in list) {
				sb.Append($"\"{item.CardCode}\",");
				sb.Append($"\"{item.NumAtCard}\"{Environment.NewLine}"); //new line
			}

			WriteToCsvFile(sb.ToString(), "Invoices");
		}

		#region AccountCategory
		private readonly AccountCategoryService _accountCategoryService = new();

		[Fact]
		public void Test_AccountCategory_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountCategories();
			Assert.True(list.Any());

			_accountCategoryService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountCategoryService.Insert(_mapper.ToSql(v));
					Assert.True(true);
				}

				catch {
					Assert.True(false);
				}
			}
		}
		#endregion

		#region AccountSegmentationCategory
		private readonly AccountSegmentationCategoryService _accountSegmentationCategoryService = new();

		[Fact]
		public void Test_AccountSegmentationCategory_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountSegmentationCategories();
			Assert.True(list.Any());

			_accountSegmentationCategoryService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountSegmentationCategoryService.Insert(_mapper.ToSql(v));
					Assert.True(true);
				}

				catch {
					Assert.True(false);
				}
			}
		}
		#endregion

		#region AccountSegmentation
		private readonly AccountSegmentationService _accountSegmentationService = new();

		[Fact]
		public void Test_AccountSegmentation_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountSegmentations();
			Assert.True(list.Any());

			_accountSegmentationService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountSegmentationService.Insert(_mapper.ToSql(v));
					Assert.True(true);
				}

				catch {
					Assert.True(false);
				}
			}
		}
		#endregion

		#region BillOfExchangeTransaction
		private readonly BillOfExchangeTransactionService _billOfExchangeTransactionService = new();

		[Fact]
		public void Test_BillOfExchangeTransaction_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListBillOfExchangeTransactions();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_billOfExchangeTransactionService.TruncateTable();

				foreach (var v in list) {
					try {
						_billOfExchangeTransactionService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region ChartOfAccount
		private readonly ChartOfAccountService _chartOfAccountService = new();

		[Fact]
		public void Test_ChartOfAccount_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListChartOfAccounts();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_chartOfAccountService.TruncateTable();

				foreach (var v in list) {
					try {
						_chartOfAccountService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region ChecksforPayment
		private readonly ChecksforPaymentService _checksforPaymentService = new();

		[Fact]
		public void Test_ChecksforPayment_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListChecksforPayments();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_checksforPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_checksforPaymentService.Insert(_mapper.ToSql(v));
						Assert.True(true);

						foreach (var line in v.ChecksforPaymentLines) {
							try {
								line.CheckKey = v.CheckKey.ToString();
								_checksforPaymentService.Insert(_mapper.ToSql(line));
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
		}
		#endregion

		#region CreditNote
		[Fact]
		public async void Test_CreditNote_Integration()
		{
			ICreditNoteService _creditNoteService = new CreditNoteService();
			var list = await RcwServiceLayer.GetAllCreditNotesAsync();
			var dt = CommonUtil.ToDataTable(list);
			_creditNoteService.TruncateTable();

			if (_creditNoteService.TryBulkCopy(dt, out var errorMsg))
				true.ShouldEqual(true);
			else
				errorMsg.ShouldEqual("Failed");
		}
		#endregion

		#region Deposit
		private readonly DepositService _depositService = new();

		[Fact]
		public void Test_Deposit_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListDeposits();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_depositService.TruncateTable();

				foreach (var v in list) {
					try {
						_depositService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region FAAccountDetermination
		private readonly FAAccountDeterminationService _fAAccountDeterminationService = new();

		[Fact]
		public void Test_FAAccountDetermination_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListFAAccountDeterminations();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_fAAccountDeterminationService.TruncateTable();

				foreach (var v in list) {
					try {
						_fAAccountDeterminationService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region GLAccountAdvancedRule
		private readonly GLAccountAdvancedRuleService _gLAccountAdvancedRuleService = new();

		[Fact]
		public void Test_GLAccountAdvancedRule_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListGLAccountAdvancedRules();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_gLAccountAdvancedRuleService.TruncateTable();

				foreach (var v in list) {
					try {
						_gLAccountAdvancedRuleService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region HouseBankAccount
		private readonly HouseBankAccountService _houseBankAccountService = new();

		[Fact]
		public void Test_HouseBankAccount_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListHouseBankAccounts();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_houseBankAccountService.TruncateTable();

				foreach (var v in list) {
					try {
						_houseBankAccountService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region IncomingPayment
		private readonly IncomingPaymentService _incomingPaymentService = new();

		[Fact]
		public void Test_IncomingPayment_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			//var list = client.ListIncomingPayments();

			//if (list == null || list.Count == 0)
			//	Assert.False(false);
			//else {
			//	_incomingPaymentService.TruncateTable();

			//	foreach (var v in list) {
			//		try {
			//			_incomingPaymentService.Insert(_mapper.ToSql(v));
			//			Assert.True(true);
			//		}

			//		catch {
			//			Assert.True(false);
			//		}
			//	}
			//}
		}
		#endregion

		#region JournalEntry
		private readonly JournalEntryService _journalEntryService = new();

		[Fact]
		public void Test_JournalEntry_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListJournalEntries();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_journalEntryService.TruncateTable();

				foreach (var v in list) {
					try {
						_journalEntryService.Insert(_mapper.ToSql(v));
						Assert.True(true);

						foreach (var line in v.JournalEntryLines) {
							try {
								line.JdtNum = v.JdtNum;
								_journalEntryService.InsertJournalEntryLine(_mapper.ToSql(line));
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
		}
		#endregion

		#region JournalEntryDocumentType
		private readonly JournalEntryDocumentTypeService _journalEntryDocumentTypeService = new();

		[Fact]
		public void Test_JournalEntryDocumentType_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListJournalEntryDocumentTypes();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_journalEntryDocumentTypeService.TruncateTable();

				foreach (var v in list) {
					try {
						_journalEntryDocumentTypeService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region PurchaseCreditNote
		[Fact]
		public async void Test_PurchaseCreditNote_Integration()
		{
			var _purchaseCreditNoteService = new PurchaseCreditNoteService();
			var list = await RcwServiceLayer.GetAllPurchaseCreditNotesAsync();
			File.AppendAllText(@"C:\Logs\SAP Automation\2024 11\21\_.txt", $"list.Count: {list.Count}{Environment.NewLine}{Environment.NewLine}");
			//string json = JsonConvert.SerializeObject(list, Formatting.Indented);
			//File.AppendAllText(@"C:\Logs\SAP Automation\2024 11\21\_.txt", $"{json}{Environment.NewLine}{Environment.NewLine}");
			//DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);
			var dt = CommonUtil.ToDataTable(list);
			File.AppendAllText(@"C:\Logs\SAP Automation\2024 11\21\_.txt", $"dt.Columns.Count: {dt.Columns.Count}{Environment.NewLine}");
			_purchaseCreditNoteService.CheckColumnMappings(dt, "Import", "PurchaseCreditNote");
			_purchaseCreditNoteService.TruncateTable();

			if (_purchaseCreditNoteService.TryBulkCopy(dt, out var errorMsg))
				true.ShouldEqual(true);
			else
				errorMsg.ShouldEqual("Failed");
		}
		#endregion

		#region PurchaseOrder
		private readonly PurchaseOrderService _purchaseOrderService = new();

		[Fact]
		public void Test_PurchaseOrder_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseOrders();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_purchaseOrderService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseOrderService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region PurchaseQuotation
		private readonly PurchaseQuotationService _purchaseQuotationService = new();

		[Fact]
		public void Test_PurchaseQuotation_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseQuotations();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_purchaseQuotationService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseQuotationService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region PurchaseTaxInvoice
		private readonly PurchaseTaxInvoiceService _purchaseTaxInvoiceService = new();

		[Fact]
		public void Test_PurchaseTaxInvoice_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseTaxInvoices();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_purchaseTaxInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseTaxInvoiceService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region Quotation
		private readonly QuotationService _quotationService = new();

		[Fact]
		public void Test_Quotation_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListQuotations();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_quotationService.TruncateTable();

				foreach (var v in list) {
					try {
						_quotationService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region SalesTaxInvoice
		private readonly SalesTaxInvoiceService _salesTaxInvoiceService = new();

		[Fact]
		public void Test_SalesTaxInvoice_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListSalesTaxInvoices();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_salesTaxInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_salesTaxInvoiceService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region TransactionCode
		private readonly TransactionCodeService _transactionCodeService = new();

		[Fact]
		public void Test_TransactionCode_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListTransactionCodes();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_transactionCodeService.TruncateTable();

				foreach (var v in list) {
					try {
						_transactionCodeService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region VendorPayment
		private readonly VendorPaymentService _vendorPaymentService = new();

		[Fact]
		public void Test_VendorPayment_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Rcw_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListVendorPayments();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_vendorPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_vendorPaymentService.Insert(_mapper.ToSql(v));
						Assert.True(true);

						foreach (var line in v.PaymentChecks) {
							try {
								line.DocEntry = v.DocEntry;
								_vendorPaymentService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}

						foreach (var line in v.PaymentInvoices) {
							try {
								line.VendorPaymentDocEntry = v.DocEntry;
								_vendorPaymentService.Insert(_mapper.ToSql(line));
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
		}
		#endregion
	}
}