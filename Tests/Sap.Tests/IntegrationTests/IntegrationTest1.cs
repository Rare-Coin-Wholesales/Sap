using ApiToScarletWitchMapper;
using Sap.Core;
using Sap.Core.Http;
using Sap.Core.Services.Security;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountCategories;

namespace Sap.Tests.IntegrationTests
{
	public class IntegrationTest1
	{
		private static readonly EncryptionUtil _encryptionUtil = new();
		private static readonly Mapper _mapper = new ();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_CompanyDb");
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Password"));

		#region AccountCategory
		private readonly AccountCategoryService _accountCategoryService = new();

		[Fact]
		public void Test_AccountCategoryIntegration()
		{
			var client = new SapClient(BaseUrl);
			var response = client.Login(CompanyDb, Username, Password);
			Console.WriteLine($"Result: {response.Result}");

			var list = client.ListAccountCategories();
			Assert.True(list.Any());

			_accountCategoryService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountCategoryService.Insert(_mapper.ToSql(v));
					Assert.True(true);
				}

				catch {
					Assert.True(false);
				}
			}
		}
		#endregion
	}
}