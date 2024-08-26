using B1SLayer;
using Sap.Api.Domain.PurchaseInvoices;
using Sap.Core;
using Sap.Services.Security;

namespace Sap.UnitTests
{
	public partial class PurchaseInvoiceUnitTests
	{
		private static readonly EncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string CompanyDb = "A21384_ABW_T02"; // CommonUtil.GetEnvironmentVariable("SAP_CompanyDb");
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Password"));
		// make sure to keep this *after* setting the 4 variables
		private static SLConnection ServiceLayer = new SLConnection(BaseUrl, CompanyDb, Username, Password);

		[Fact]
		public async Task Test_CancelPurchaseInvoicesAsync()
		{
			var _purchaseInvoiceService = new Api.Services.PurchaseInvoiceService(ServiceLayer);
			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			var path = String.Format("{0}{1:dd HH mmss} Test_CancelPurchaseInvoicesAsync.json", folder, DateTime.Now);

			ServiceLayer.AfterCall(async call => {
				File.AppendAllText(path, $"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}{Environment.NewLine}");
				File.AppendAllText(path, $"Body sent: {call.RequestBody}{Environment.NewLine}");
				File.AppendAllText(path, $"Response: {call.HttpResponseMessage?.StatusCode} ");
				File.AppendAllText(path, await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				File.AppendAllText(path, $"Call duration: {call.Duration.Value.TotalSeconds} seconds{Environment.NewLine}{Environment.NewLine}");
			});

			var log = "DocEntry,DocNum,DocType,CardCode,Comments,ItemCode,TaxCode,CancelDate,Cancelled,CancelStatus\r\n";
			var test = await _purchaseInvoiceService.GetByDocEntry(62);
			Assert.NotNull(test);
			log = String.Format($"{log}{test.DocEntry},{test.DocNum},{test.DocType},{test.CardCode},{test.Comments},{test.DocumentLines[0].ItemCode},{test.DocumentLines[0].TaxCode},{test.CancelDate},{test.Cancelled},{test.CancelStatus}{Environment.NewLine}");

			test.Comments = $"Test {DateTime.Now:yyyy MMdd HHmm ssff}";
			_purchaseInvoiceService.CancelAsync(test);
			Thread.Sleep(2200); // sometimes theres a delay in test environments that shouldn't reflect in actual production
			log = String.Format($"{log}{test.DocEntry},{test.DocNum},{test.DocType},{test.CardCode},{test.Comments},{test.DocumentLines[0].ItemCode},{test.DocumentLines[0].TaxCode},{test.CancelDate},{test.Cancelled},{test.CancelStatus}{Environment.NewLine}");

			File.AppendAllText(path.Replace(".json", ".csv"), log);
		}

		[Fact]
		public async Task Test_CreatePurchaseInvoicesAsync()
		{
			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			var path = String.Format("{0}{1:dd HH mmss} Test_CreatePurchaseInvoicesAsync.json", folder, DateTime.Now);

			ServiceLayer.AfterCall(async call => {
				File.AppendAllText(path, $"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}{Environment.NewLine}");
				File.AppendAllText(path, $"Body sent: {call.RequestBody}{Environment.NewLine}");
				File.AppendAllText(path, $"Response: {call.HttpResponseMessage?.StatusCode} ");
				File.AppendAllText(path, await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				File.AppendAllText(path, $"Call duration: {call.Duration.Value.TotalSeconds} seconds{Environment.NewLine}{Environment.NewLine}");
			});

			var _purchaseInvoiceService = new Api.Services.PurchaseInvoiceService(ServiceLayer);
			var test = new PurchaseInvoice {
				CardCode = "V1120",
				DocumentLines = new List<PurchaseInvoice_DocumentLine> {
					new PurchaseInvoice_DocumentLine {
						ItemCode = "Office",
						Quantity = 1,
						TaxCode = "EX",
						UnitPrice = 20,
					}
				}
			};

			var x = await _purchaseInvoiceService.CreateAsync(test);
			Assert.NotNull(x);

			var log = "DocEntry,DocNum,DocType,CardCode,Comments,ItemCode,TaxCode\r\n";
			log = String.Format($"{log}{x.DocEntry},{x.DocNum},{x.DocType},{x.CardCode},{x.Comments},{x.DocumentLines[0].ItemCode},{x.DocumentLines[0].TaxCode}{Environment.NewLine}");
			File.AppendAllText(path.Replace(".json", ".csv"), log);
		}

		[Fact]
		public async Task Test_ListPurchaseInvoicesAsync()
		{
			var _purchaseInvoiceService = new Api.Services.PurchaseInvoiceService(ServiceLayer);
			var list = await _purchaseInvoiceService.GetAll();
			Assert.True(list.Any());

			var log = "DocEntry,DocNum,DocType,CardCode,Comments,ItemCode,TaxCode\r\n";

			foreach (var v in list)
				log = String.Format($"{log}{v.DocEntry},{v.DocNum},{v.DocType},{v.CardCode},{v.Comments},{v.DocumentLines[0].ItemCode},{v.DocumentLines[0].TaxCode}{Environment.NewLine}");

			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}{1:dd HH mmss} Test_ListPurchaseInvoicesAsync.csv", folder, DateTime.Now), log);
		}

		[Fact]
		public async Task Test_UpdatePurchaseInvoicesAsync()
		{
			var _purchaseInvoiceService = new Api.Services.PurchaseInvoiceService(ServiceLayer);
			var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			var path = String.Format("{0}{1:dd HH mmss} Test_UpdatePurchaseInvoicesAsync.json", folder, DateTime.Now);

			ServiceLayer.AfterCall(async call => {
				File.AppendAllText(path, $"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}{Environment.NewLine}");
				File.AppendAllText(path, $"Body sent: {call.RequestBody}{Environment.NewLine}");
				File.AppendAllText(path, $"Response: {call.HttpResponseMessage?.StatusCode} ");
				File.AppendAllText(path, await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				File.AppendAllText(path, $"Call duration: {call.Duration.Value.TotalSeconds} seconds{Environment.NewLine}{Environment.NewLine}");
			});

			var log = "DocEntry,DocNum,DocType,CardCode,Comments,ItemCode,TaxCode\r\n";
			var test = await _purchaseInvoiceService.GetByDocEntry(62);
			Assert.NotNull(test);
			log = String.Format($"{log}{test.DocEntry},{test.DocNum},{test.DocType},{test.CardCode},{test.Comments},{test.DocumentLines[0].ItemCode},{test.DocumentLines[0].TaxCode}{Environment.NewLine}");

			test.Comments = $"Test {DateTime.Now:yyyy MMdd HHmm ssff}";
			_purchaseInvoiceService.UpdateAsync(test);
			Thread.Sleep(2200); // sometimes theres a delay in test environments that shouldn't reflect in actual production
			log = String.Format($"{log}{test.DocEntry},{test.DocNum},{test.DocType},{test.CardCode},{test.Comments},{test.DocumentLines[0].ItemCode},{test.DocumentLines[0].TaxCode}{Environment.NewLine}");

			File.AppendAllText(path.Replace(".json", ".csv"), log);
		}

		[Fact]
		public void Test_GetPurchaseInvoiceById()
		{
			var _purchaseInvoiceService = new Api.Services.PurchaseInvoiceService(ServiceLayer);
			Task<PurchaseInvoice> x;
			x = _purchaseInvoiceService.GetByDocEntry(8);
			Assert.NotNull(x);
		}
	}
}