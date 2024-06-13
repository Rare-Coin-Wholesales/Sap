using Sap.Core.Http;

namespace Sap.Automation
{
	class Program
	{
		// Consider changing these to Environment Variables, *especially* the password
		private const string BASE_URL = "https://htpc21384p01.cloudiax.com:50000/b1s/v1/";
		private const string COMPANY_DB = "A21384_ABW_T02";
		private const string USERNAME = "manager";
		private const string PASSWORD = "ABWinery@1"; // change this to Environment Variable

		static void Main(string[] args)
		{
			Console.WriteLine("\nStarting SAP Automation . . .\n");
			var client = new SapClient(BASE_URL);
			var response = client.Login(COMPANY_DB, USERNAME, PASSWORD);
			Console.WriteLine($"Result: {response.Result}");



			Console.WriteLine("\n\nEnding SAP Automation . . .\n\n");
		}
	}
}
