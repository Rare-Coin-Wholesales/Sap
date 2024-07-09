using Sap.Core.Http;

namespace Sap.Tests
{
	public class UnitTest1
	{
		private const string BASE_URL = "https://htpc21384p01.cloudiax.com:50000/b1s/v1/";
		private const string COMPANY_DB = "A21384_ABW_T02";
		private const string USERNAME = "steveg";
		private const string PASSWORD = "Welcome@2"; // change this to Environment Variable

		#region AccountCategories
		[Fact]
		public void Test_ListAccountCategories()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountCategories();
			Assert.True(list.Any());
		}
		#endregion

		#region AccountSegmentationCategories
		[Fact]
		public void Test_ListAccountSegmentationCategories()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountSegmentationCategories();
			Assert.True(list.Any());
		}
		#endregion

		#region AccountSegmentations
		[Fact]
		public void Test_ListAccountSegmentations()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountSegmentations();
			Assert.True(list.Any());
		}
		#endregion

		#region BillOfExchangeTransactions
		[Fact]
		public void Test_ListBillOfExchangeTransactions()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListBillOfExchangeTransactions();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetBillOfExchangeTransactionById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
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
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListChartOfAccounts();
			Assert.True(list.Any());
		}
		#endregion

		#region ChecksforPayments
		[Fact]
		public void Test_ListChecksforPayments()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListChecksforPayments();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetChecksforPaymentById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetChecksforPaymentById(1);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region CreditNotes
		[Fact]
		public void Test_ListCreditNotes()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListCreditNotes();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetCreditNoteById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetCreditNoteById(1);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region Deposits
		[Fact]
		public void Test_ListDeposits()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListDeposits();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetDepositById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetDepositById(1);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region FAAccountDeterminations
		[Fact]
		public void Test_ListFAAccountDeterminations()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListFAAccountDeterminations();
			Assert.False(list.Any());
		}
		#endregion

		#region GLAccountAdvancedRules
		[Fact]
		public void Test_ListGLAccountAdvancedRules()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListGLAccountAdvancedRules();
			Assert.False(list.Any());
		}
		#endregion

		#region HouseBankAccounts
		[Fact]
		public void Test_ListHouseBankAccounts()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListHouseBankAccounts();
			Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetHouseBankAccountById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
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
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListIncomingPayments();
			Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetIncomingPaymentById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetIncomingPaymentById(5);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region Invoices
		[Fact]
		public void Test_ListInvoices()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListInvoices();
			Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetInvoiceById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetInvoiceById(5);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region JournalEntries
		[Fact]
		public void Test_ListJournalEntries()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListJournalEntries();
			Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetJournalEntryById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetJournalEntryById(4);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region JournalEntryDocumentTypes
		[Fact]
		public void Test_ListJournalEntryDocumentTypes()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListJournalEntryDocumentTypes();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetJournalEntryDocumentTypeById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
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
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseCreditNotes();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetPurchaseCreditNoteById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetPurchaseCreditNoteById(4);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region PurchaseInvoices
		[Fact]
		public void Test_ListPurchaseInvoices()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseInvoices();
			Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetPurchaseInvoiceById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetPurchaseInvoiceById(11);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region PurchaseOrders
		[Fact]
		public void Test_ListPurchaseOrders()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseOrders();
			Assert.True(list.Any());
		}

		[Fact]
		public void Test_GetPurchaseOrderById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
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
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseQuotations();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetPurchaseQuotationById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
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
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListPurchaseTaxInvoices();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetPurchaseTaxInvoiceById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
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
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListQuotations();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetQuotationById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
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
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListSalesTaxInvoices();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetSalesTaxInvoiceById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
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
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListTransactionCodes();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetTransactionCodeById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetTransactionCodeById(1);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion

		#region VendorPayments
		[Fact]
		public void Test_ListVendorPayments()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListVendorPayments();
			Assert.False(list.Any());
		}

		[Fact]
		public void Test_GetVendorPaymentById()
		{
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.GetVendorPaymentById(5);
			Assert.NotNull(list);
			Assert.NotEmpty(list.Result);
		}
		#endregion
	}
}