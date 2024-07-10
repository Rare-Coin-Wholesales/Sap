using Sap.Core;
using Sap.Core.Http;

namespace Sap.Automation
{
	class Program
	{
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_CompanyDb");
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly string Password = CommonUtil.GetEncryptedEnvironmentVariable("SAP_Password");

		static void Main(string[] args)
		{
			Console.WriteLine("\nStarting SAP Automation . . .\n");
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");



			Console.WriteLine("\n\nEnding SAP Automation . . .\n\n");
		}
	}
}
