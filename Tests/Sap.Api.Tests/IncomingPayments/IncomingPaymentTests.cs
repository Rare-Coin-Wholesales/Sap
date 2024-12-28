using System;
using System.IO;
using System.Threading.Tasks;
using Sap.Core;
using Sap.Services.Security;
using Xunit;

namespace Sap.Api.Tests
{
	public partial class IncomingPaymentTests
	{
		private static readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly string Aabrc_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabrc_CompanyDb");
		private static readonly string Aabrc_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Aabrc_Password"));
		private static readonly string Aabrc_Username = CommonUtil.GetEnvironmentVariable("SAP_Aabrc_Username");
		private static readonly string Aabw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabw_CompanyDb");
		private static readonly string Aabw_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Aabw_Password"));
		private static readonly string Aabw_Username = CommonUtil.GetEnvironmentVariable("SAP_Aabw_Username");
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		private static readonly string Rcw_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Rcw_Username = CommonUtil.GetEnvironmentVariable("SAP_Rcw_Username");
		private static readonly ServiceLayer _serviceLayer = new ServiceLayer(BaseUrl, Rcw_CompanyDb, Rcw_Username, Rcw_Password);

		#region Utilities
		private void AddTraceLogs()
		{
			_serviceLayer.AfterCall(async call => {
				var log = string.Empty;
				log = $"{log}Request: {call.HttpRequestMessage.Method}  {call.HttpRequestMessage.RequestUri}{Environment.NewLine}";
				log = $"{log}Body sent: {call.RequestBody}{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";
				log = $"{log}Response: {call.HttpResponseMessage?.StatusCode}{Environment.NewLine}";
				log = $"{log}{await call.HttpResponseMessage?.Content?.ReadAsStringAsync()}";
				log = $"{log}Call duration: {(DateTime.UtcNow - call.StartedUtc).TotalSeconds:n3} seconds{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";

				WriteToJsonFile(log, "Response");
			});
		}

		private void WriteToJsonFile(string data, string entityName)
		{
			var now = DateTime.Now;
			var folder = $"C:/Logs/Sap.Api.Tests/{now:yyyy MM}/{now:dd}/";
			Directory.CreateDirectory(folder);
			File.WriteAllText($"{folder}{entityName} {now:HHmm ssff}.json", data);
		}
		#endregion

		[Fact]
		public async Task Test_GetIncomingPaymentsByDocDateAsync()
		{
			AddTraceLogs();
			var testDate = DateTime.Today.AddDays(-14);
			await _serviceLayer.GetIncomingPaymentsByDocDateAsync(testDate);
		}
	}
}