using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountCategories;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Tests
{
	public class UnitTest1
	{
		#region AccountCategory
		private readonly IAccountCategoryService _accountCategoryService = new AccountCategoryService();

		[Fact]
		public void Test_AccountCategoryService_Insert()
		{
			if (int.TryParse(String.Format("{0:fffffff}", DateTime.Now), out var id)) {
				var dateString = String.Format("{0:yyyy MMdd HHmm ssff}", DateTime.Now);
				var test1 = new AccountCategory {
					CategoryCode = id,
					CategoryName = String.Format($"Test{dateString}"),
					CategorySource = "Test",
				};

				_accountCategoryService.Insert(test1);
				Assert.True(true);
			}
		}
		#endregion
	}
}