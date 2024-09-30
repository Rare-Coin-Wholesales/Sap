using B1SLayer;
using Sap.Api.Domain.BusinessPartners;
using Sap.Core;
using Sap.Services.Security;

namespace Sap.Aabw.UnitTests
{
	public partial class BusinessPartnerUnitTests
	{
		private static readonly EncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly string Aabw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabw_CompanyDb");
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Password"));
		private static readonly string Test_CompanyDb = "A21384_ABW_T02";
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		// make sure to keep this *after* setting the 4 variables
		private static SLConnection ServiceLayer = new SLConnection(BaseUrl, Test_CompanyDb, Username, Password);

		[Fact]
		public async Task Test_CreateBusinessPartnersAsync()
		{
			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			var path = String.Format("{0}{1:dd HH mmss} Test_CreateBusinessPartnersAsync.json", folder, DateTime.Now);

			ServiceLayer.AfterCall(async call => {
				File.AppendAllText(path, $"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}{Environment.NewLine}");
				File.AppendAllText(path, $"Body sent: {call.RequestBody}{Environment.NewLine}");
				File.AppendAllText(path, $"Response: {call.HttpResponseMessage?.StatusCode} ");
				File.AppendAllText(path, await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				File.AppendAllText(path, $"Call duration: {call.Duration.Value.TotalSeconds} seconds{Environment.NewLine}{Environment.NewLine}");
			});

			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);
			var test = new BusinessPartner {
				CardCode = "001",
				CardName = "CERTIFIED COIN CONSULTANTS",
				CardType = "C",
			};

			var x = await _businessPartnerService.CreateAsync(test);
			Assert.NotNull(x);

			var log = "CardCode,CardName,CardType,Notes\r\n";
			log = String.Format($"{log}{x.CardCode},{x.CardName},{x.CardType}{x.Notes}{Environment.NewLine}");
			File.AppendAllText(path.Replace(".json", ".csv"), log);
		}

		[Fact]
		public async Task Test_ListBusinessPartnersAsync()
		{
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);
			var list = await _businessPartnerService.GetAll();
			Assert.True(list.Any());

			var log = "CardCode,CardName,CardType,Notes\r\n";

			foreach (var v in list)
				log = String.Format($"{log}{v.CardCode},{v.CardName},{v.CardType}{v.Notes}{Environment.NewLine}");

			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}{1:dd HH mmss} Test_ListBusinessPartnersAsync.csv", folder, DateTime.Now), log);
		}

		[Fact]
		public async Task Test_UpdateBusinessPartnersAsync()
		{
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);
			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			var path = String.Format("{0}{1:dd HH mmss} Test_UpdateBusinessPartnersAsync.json", folder, DateTime.Now);

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

		[Fact]
		public void Test_GetBusinessPartnerById()
		{
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);
			Task<BusinessPartner> x;
			x = _businessPartnerService.GetByCardCode("001");
			Assert.NotNull(x);
		}
	}
}