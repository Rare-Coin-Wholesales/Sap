using B1SLayer;
using Sap.ApiToScarRcwMapper;
using Sap.Core;
using Sap.Services.Security;

namespace Sap.Rcw.IntegrationTests
{
	public partial class BusinessPartnerIntegrationTests
	{
		private static readonly EncryptionUtil _encryptionUtil = new();
		private static readonly Mapper _mapper = new();
		private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Test_CompanyDb = "A21384_RCW_T01";
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");

		private static SLConnection ServiceLayer = new SLConnection(BaseUrl, Rcw_CompanyDb, Username, Password);
		private readonly ScarletWitch.Sap_RareCoinWholesalers.Services.BusinessPartners.BusinessPartnerService _businessPartnerService = new();

		[Fact]
		public async Task Test_GetAllBusinessPartnersAsync()
		{
			var _businessPartnerServiceNew = new Api.Services.BusinessPartnerService(ServiceLayer);
			var list = await _businessPartnerServiceNew.GetAll();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_businessPartnerService.TruncateTable();

				foreach (var v in list) {
					try {
						_businessPartnerService.Insert(_mapper.ToSql(v));
						Assert.True(true);

						#region Insert BPAddress
						foreach (var line in v.BPAddresses) {
							try {
								_businessPartnerService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
						#endregion

						#region Insert BPPaymentMethod
						foreach (var line in v.BPPaymentMethods) {
							try {
								_businessPartnerService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
						#endregion

						#region Insert ContactEmployee
						foreach (var line in v.ContactEmployees) {
							try {
								_businessPartnerService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
						#endregion
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
			//File.WriteAllText(String.Format("{0}{1:dd HH mmss} Test_GetAllBusinessPartnersAsync.csv", folder, DateTime.Now), log);
		}
	}
}