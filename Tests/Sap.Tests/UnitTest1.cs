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

			var list = client.GetIncomingPaymentById(1);
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
	}
}