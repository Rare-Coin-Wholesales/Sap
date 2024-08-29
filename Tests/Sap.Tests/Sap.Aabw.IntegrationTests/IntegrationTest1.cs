using Sap.ApiToScarAabwMapper;
using B1SLayer;
using Sap.Api.Http;
using Sap.Core;
using Sap.Services.Security;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountCategories;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountSegmentationCategories;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountSegmentations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.BillOfExchangeTransactions;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.BusinessPartners;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.ChartOfAccounts;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.ChecksforPayments;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.CreditNotes;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.Deposits;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.FAAccountDeterminations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.GLAccountAdvancedRules;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.HouseBankAccounts;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.IncomingPayments;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.Items;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.JournalEntries;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.JournalEntryDocumentTypes;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseCreditNotes;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseOrders;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseQuotations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseTaxInvoices;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.Quotations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.SalesTaxInvoices;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.TransactionCodes;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.VendorPayments;

namespace Sap.Aabw.IntegrationTests
{
	public class IntegrationTest1
	{
		private static readonly EncryptionUtil _encryptionUtil = new();
		private static readonly Mapper _mapper = new();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_CompanyDb");
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Password"));
		private static SLConnection ServiceLayer = new SLConnection(BaseUrl, CompanyDb, Username, Password);

		#region AccountCategory
		private readonly AccountCategoryService _accountCategoryService = new();

		[Fact]
		public void Test_AccountCategory_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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

		#region BusinessPartner
		private readonly BusinessPartnerService _businessPartnerService = new();

		[Fact]
		public void Test_BusinessPartner_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListBusinessPartners();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_businessPartnerService.TruncateTable();

				foreach (var v in list) {
					try {
						_businessPartnerService.Insert(_mapper.ToSql(v));
						Assert.True(true);

						#region Insert BPAddress
						foreach (var line in v.BPAddresses) {
							try {
								_businessPartnerService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
						#endregion

						#region Insert BPIntrastatExtension
						//_businessPartnerService.Insert(_mapper.ToSql(v.BPIntrastatExtension));
						#endregion

						#region Insert BPPaymentMethod
						foreach (var line in v.BPPaymentMethods) {
							try {
								_businessPartnerService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
						#endregion

						#region Insert ContactEmployee
						foreach (var line in v.ContactEmployees) {
							try {
								_businessPartnerService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
						#endregion
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
		private readonly CreditNoteService _creditNoteService = new();

		[Fact]
		public void Test_CreditNote_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListCreditNotes();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_creditNoteService.TruncateTable();

				foreach (var v in list) {
					try {
						_creditNoteService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region Deposit
		private readonly DepositService _depositService = new();

		[Fact]
		public void Test_Deposit_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListIncomingPayments();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_incomingPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_incomingPaymentService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region Item
		private readonly ItemService _itemService = new();

		[Fact]
		public void Test_Item_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListItems();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_itemService.TruncateTable();

				foreach (var v in list) {
					try {
						_itemService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region JournalEntry
		private readonly JournalEntryService _journalEntryService = new();

		[Fact]
		public void Test_JournalEntry_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
		private readonly PurchaseCreditNoteService _purchaseCreditNoteService = new();

		[Fact]
		public void Test_PurchaseCreditNote_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseCreditNotes();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_purchaseCreditNoteService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseCreditNoteService.Insert(_mapper.ToSql(v));
						Assert.True(true);
					}

					catch {
						Assert.True(false);
					}
				}
			}
		}
		#endregion

		#region PurchaseOrder
		private readonly PurchaseOrderService _purchaseOrderService = new();

		[Fact]
		public void Test_PurchaseOrder_Integration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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
			var response = client.Login(CompanyDb, Username, Password);
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