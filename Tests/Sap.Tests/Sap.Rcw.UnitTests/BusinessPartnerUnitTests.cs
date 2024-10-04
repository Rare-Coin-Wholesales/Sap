using B1SLayer;
using Sap.Api.Domain.BusinessPartners;
using Sap.Core;
using Sap.Services.Security;

namespace Sap.Rcw.UnitTests
{
	public partial class BusinessPartnerUnitTests
	{
		private static readonly EncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Test_CompanyDb = "A21384_RCW_T01";
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		// make sure to keep this *after* setting the 4 variables
		private static SLConnection ServiceLayer = new SLConnection(BaseUrl, Test_CompanyDb, Username, Password);

		[Fact]
		public async Task Test_CreateBusinessPartnersAsync()
		{
			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			var path = String.Format("{0}{1:dd HHmm ss} Test_CreateBusinessPartnersAsync.json", folder, DateTime.Now);

			ServiceLayer.AfterCall(async call => {
				File.AppendAllText(path, $"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}{Environment.NewLine}");
				File.AppendAllText(path, $"Body sent: {call.RequestBody}{Environment.NewLine}");
				File.AppendAllText(path, $"Response: {call.HttpResponseMessage?.StatusCode} ");
				File.AppendAllText(path, await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				File.AppendAllText(path, $"Call duration: {call.Duration.Value.TotalSeconds} seconds{Environment.NewLine}{Environment.NewLine}");
			});

			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);
			var now = DateTime.Now;
			var test = new BusinessPartner {
				CardCode = $"TEST{now:ffff}",
				CardName = $"TEST {now:MMM d, yyyy HH:mm:ss}",
				CardType = "C",
				FederalTaxID = "TEST FederalTaxID",
				Phone1 = $"{now:yyyy-MMdd-HH}",
				Phone2 = $"{now:HHmm-ss-ffff}",
				EmailAddress = "test@email.com",
				Address = $"{now:ffff} Test St.",
				MailAddress = $"{now:ffff} Test St.",
				ZipCode = $"{now:fffff}",
				MailZipCode = $"{now:fffff}",
				City = "Test City",
				MailCity = "Test City",
				Notes = $"TEST {now:MMM d, yyyy HH:mm:ss.fff}",
			};

			var x = await _businessPartnerService.CreateAsync(test);
			Assert.NotNull(x);

			var log = "CardCode,CardName,CardType,Notes\r\n";
			log = String.Format($"{log}{x.CardCode},{x.CardName},{x.CardType}{x.Notes}{Environment.NewLine}");
			File.AppendAllText(path.Replace(".json", ".csv"), log);
		}

		[Fact]
		public void Test_GetBusinessPartnerById()
		{
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);
			Task<BusinessPartner> x;
			x = _businessPartnerService.GetByCardCode("001");
			Assert.NotNull(x);
		}

		[Fact]
		public async Task Test_ListBusinessPartnersAsync()
		{
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);
			var list = await _businessPartnerService.GetAll();
			Assert.True(list.Any());

			var log = "CardCode,CardName,CardType,Notes\r\n";

			foreach (var v in list)
				log = String.Format($"{log}\"{v.CardCode}\",\"{v.CardName}\",\"{v.CardType}\",\"{v.Notes}\"{Environment.NewLine}");

			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}{1:dd HHmm ss} Test_ListBusinessPartnersAsync.csv", folder, DateTime.Now), log);
			Assert.True(true);
		}

		[Fact]
		public async void Test_Logout()
		{
			await ServiceLayer.LogoutAsync();
			Assert.True(true);
		}

		[Fact]
		public async Task Test_UpdateBusinessPartnersAsync()
		{
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);
			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			var path = String.Format("{0}{1:dd HHmm ss} Test_UpdateBusinessPartnersAsync.json", folder, DateTime.Now);

			ServiceLayer.AfterCall(async call => {
				File.AppendAllText(path, $"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}{Environment.NewLine}");
				File.AppendAllText(path, $"Body sent: {call.RequestBody}{Environment.NewLine}");
				File.AppendAllText(path, $"Response: {call.HttpResponseMessage?.StatusCode} ");
				File.AppendAllText(path, await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				File.AppendAllText(path, $"Call duration: {call.Duration.Value.TotalSeconds} seconds{Environment.NewLine}{Environment.NewLine}");
			});

			var log = "CardCode,CardName,CardType,Notes\r\n";
			var test = await _businessPartnerService.GetByCardCode("001");
			Assert.NotNull(test);
			log = String.Format($"{log}{test.CardCode},{test.CardName},{test.CardType}{test.Notes}{Environment.NewLine}");

			test.Notes = $"Test {DateTime.Now:yyyy MMdd HHmm ssff}";
			_businessPartnerService.UpdateAsync(test);
			Thread.Sleep(2200); // sometimes theres a delay in test environments that shouldn't reflect in actual production
			log = String.Format($"{log}{test.CardCode},{test.CardName},{test.CardType}{test.Notes}{Environment.NewLine}");

			File.AppendAllText(path.Replace(".json", ".csv"), log);
		}
	}
}