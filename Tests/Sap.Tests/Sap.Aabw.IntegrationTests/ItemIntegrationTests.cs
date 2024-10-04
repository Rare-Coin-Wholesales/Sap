using B1SLayer;
using Sap.Api.Domain.Items;
using Sap.Core;
using Sap.Services.Security;
using Sap.Tests;

namespace Sap.Aabw.IntegrationTests
{
	public partial class ItemIntegrationTests
	{
		private const string RESOURCE = "Items";
		private static readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Password"));
		private static readonly string Aabw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabw_CompanyDb");
		private static readonly string Test_CompanyDb = "A21384_ABW_T01";
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly SLConnection ServiceLayer = new SLConnection(BaseUrl, Aabw_CompanyDb, Username, Password);

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

				var folder = $"C:/Logs/Sap.Tests/{DateTime.Now:yyyy MM}/";
				Directory.CreateDirectory(folder);
				File.WriteAllText($"{folder}Error {DateTime.Now:dd HHmm ssff}.log", log);
			});
		}

		[Fact]
		public async Task Test_GetAllAsync()
		{
			AddErrorLogs();
			var all = await ServiceLayer.Request("Items").GetAllAsync<Item>();
			all.ShouldNotBeNull();
		}
	}
}