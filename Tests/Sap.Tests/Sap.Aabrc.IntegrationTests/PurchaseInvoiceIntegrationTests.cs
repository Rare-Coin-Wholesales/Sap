using B1SLayer;
using Sap.ApiToScarAabrcMapper;
using Sap.Core;
using Sap.Services.Security;

namespace Sap.Aabrc.IntegrationTests
{
	public partial class PurchaseInvoiceIntegrationTests
	{
		private static readonly EncryptionUtil _encryptionUtil = new();
		private static readonly Mapper _mapper = new();
		private static readonly string Aabrc_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabrc_CompanyDb");
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Password"));
		private static readonly string Test_CompanyDb = "A21384_ABW_T02";
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");

		private static SLConnection ServiceLayer = new SLConnection(BaseUrl, Aabrc_CompanyDb, Username, Password);
		private readonly ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.PurchaseInvoices.PurchaseInvoiceService _purchaseInvoiceService = new();

		[Fact]
		public async Task Test_GetAllPurchaseInvoicesAsync()
		{
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