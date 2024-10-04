using B1SLayer;
using Sap.Api.Domain.Common;
using Sap.Api.Domain.PurchaseInvoices;
using Sap.Api.Services;
using Sap.ApiToScarRcwMapper;
using Sap.Core;
using Sap.Services.Security;
using Sap.Tests;

namespace Sap.Rcw.IntegrationTests
{
	public partial class PurchaseInvoiceIntegrationTests
	{
		private const string RESOURCE = "PurchaseInvoices";
		private static readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		private static readonly string Test_CompanyDb = "A21384_RCW_T01";
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly SLConnection ServiceLayer = new SLConnection(BaseUrl, Test_CompanyDb, Username, Password);

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
		public async Task Test_CreateAsync()
		{
			AddErrorLogs();
			var now = DateTime.Now;
			var data = new PurchaseInvoice {
				DocEntry = 51957,
				DocNum = 51957,
				CardCode = "V17810",
				ShipState = "MA",
				CreationDate = DateTime.Parse("2024-07-09 00:00:00.000"),
				DocDate = DateTime.Parse("2024-07-09 00:00:00.000"),
				UpdateDate = DateTime.Parse("2024-09-09 00:00:00.000"),
				DocumentLines = new List<PurchaseInvoice_DocumentLine>(),
			};

			data.DocumentLines.Add(new PurchaseInvoice_DocumentLine {
				LineNum = 1,
				VisualOrder = 1,
				ItemCode = "143932",
				Quantity = 1,
				UnitPrice = 25500.00m,
				LineTotal = 25500.00m,
			});

			var _purchaseInvoiceService = new PurchaseInvoiceService(ServiceLayer);
			var created = await _purchaseInvoiceService.CreateAsync(data);
			created.ShouldNotBeNull();
		}

		[Fact]
		public async Task Test_CreatePurchaseInvoicesAsync()
		{
			var all = await ServiceLayer.Request(RESOURCE).GetAllAsync<PurchaseInvoice>();
			all.ShouldNotBeNull();
		}

		[Fact]
		public async Task Test_GetAllAsync()
		{
			var _purchaseInvoiceService = new PurchaseInvoiceService(ServiceLayer);
			var all = await _purchaseInvoiceService.GetAll();
			all.ShouldNotBeNull();
		}

		[Fact]
		public async Task Test_GetAllPurchaseInvoicesAsync()
		{
			var _mapper = new Mapper();
			var _purchaseInvoiceService = new ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseInvoices.PurchaseInvoiceService();
			var _purchaseInvoiceServiceNew = new Api.Services.PurchaseInvoiceService(ServiceLayer);
			var list = await _purchaseInvoiceServiceNew.GetAll();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_purchaseInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseInvoiceService.Insert(_mapper.ToSql(v));
						Assert.True(true);

						foreach (var line in v.DocumentLines) {
							try {
								_purchaseInvoiceService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
					}

					catch {
						Assert.True(false);
					}
				}
			}

			//var log = "DocEntry,DocNum,DocType,CardCode,Comments\r\n";

			//foreach (var v in list)
			//	log = String.Format($"{log}{v.DocEntry},{v.DocNum},{v.DocType},{v.CardCode},{v.Comments}{Environment.NewLine}");

			//var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			//Directory.CreateDirectory(folder);
			//File.WriteAllText(String.Format("{0}{1:dd HH mmss} Test_GetAllPurchaseInvoicesAsync.csv", folder, DateTime.Now), log);
		}
	}
}