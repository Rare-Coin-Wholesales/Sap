using B1SLayer;
using Sap.Api.Http;
using Sap.Core;
using Sap.Services.Security;

namespace Sap.Aabw.UnitTests
{
	public class UnitTest1
	{
		private static readonly EncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly string Aabw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabw_CompanyDb");
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Password"));
		private static readonly string Test_CompanyDb = "A21384_ABW_T02";
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		// make sure to keep this *after* setting the 4 variables
		private static SLConnection ServiceLayer = new SLConnection(BaseUrl, Test_CompanyDb, Username, Password);

		#region AccountCategories
		[Fact]
		public void Test_ListAccountCategories()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountCategories();
			Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetAccountCategoryById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetAccountCategoryById(-1);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region AccountSegmentationCategories
		[Fact]
		public void Test_ListAccountSegmentationCategories()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountSegmentationCategories();
			Assert.True(list.Any());
		}
		#endregion

		#region AccountSegmentations
		[Fact]
		public void Test_ListAccountSegmentations()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountSegmentations();
			Assert.True(list.Any());
		}
		#endregion

		#region BillOfExchangeTransactions
		[Fact]
		public void Test_ListBillOfExchangeTransactions()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListBillOfExchangeTransactions();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetBillOfExchangeTransactionById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetBillOfExchangeTransactionById(1);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region ChartOfAccounts
		[Fact]
		public void Test_ListChartOfAccounts()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListChartOfAccounts();
			Assert.True(list.Any());
		}
		#endregion

		#region CreditNotes
		[Fact]
		public void Test_ListCreditNotes()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			//var list = client.ListCreditNotes();
			//Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetCreditNoteById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			//var list = client.GetCreditNoteById(1);
			//Assert.NotNull(list);
			//Assert.NotEmpty(list.Result);
		}
		#endregion

		#region FAAccountDeterminations
		[Fact]
		public void Test_ListFAAccountDeterminations()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListFAAccountDeterminations();
			Assert.False(list.Any());
		}
		#endregion

		#region GLAccountAdvancedRules
		[Fact]
		public void Test_ListGLAccountAdvancedRules()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListGLAccountAdvancedRules();
			Assert.False(list.Any());
		}
		#endregion

		#region HouseBankAccounts
		[Fact]
		public void Test_ListHouseBankAccounts()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListHouseBankAccounts();
			Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetHouseBankAccountById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetHouseBankAccountById(1);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region IncomingPayments
		[Fact]
		public void Test_ListIncomingPayments()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			//var list = client.ListIncomingPayments();
			//Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetIncomingPaymentById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			//var list = client.GetIncomingPaymentById(5);
			//Assert.NotNull(list);
			//Assert.NotEmpty(list.Result);
		}
		#endregion

		#region JournalEntryDocumentTypes
		[Fact]
		public void Test_ListJournalEntryDocumentTypes()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListJournalEntryDocumentTypes();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetJournalEntryDocumentTypeById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetJournalEntryDocumentTypeById("type");
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region PurchaseCreditNotes
		[Fact]
		public void Test_ListPurchaseCreditNotes()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			//var list = client.ListPurchaseCreditNotes();
			//Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetPurchaseCreditNoteById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			//var list = client.GetPurchaseCreditNoteById(4);
			//Assert.NotNull(list);
			//Assert.NotEmpty(list.Result);
		}
		#endregion

		#region PurchaseOrders
		[Fact]
		public void Test_ListPurchaseOrders()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseOrders();
			Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetPurchaseOrderById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetPurchaseOrderById(6);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region PurchaseQuotations
		[Fact]
		public void Test_ListPurchaseQuotations()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseQuotations();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetPurchaseQuotationById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetPurchaseQuotationById(6);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region PurchaseTaxInvoices
		[Fact]
		public void Test_ListPurchaseTaxInvoices()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseTaxInvoices();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetPurchaseTaxInvoiceById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetPurchaseTaxInvoiceById(6);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region Quotations
		[Fact]
		public void Test_ListQuotations()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListQuotations();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetQuotationById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetQuotationById(6);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region SalesTaxInvoices
		[Fact]
		public void Test_ListSalesTaxInvoices()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListSalesTaxInvoices();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetSalesTaxInvoiceById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetSalesTaxInvoiceById(6);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region TransactionCodes
		[Fact]
		public void Test_ListTransactionCodes()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListTransactionCodes();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetTransactionCodeById()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(Test_CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetTransactionCodeById(1);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion
	}
}