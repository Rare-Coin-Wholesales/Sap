using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.AccountSegmentationCategories;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.AccountSegmentationCategories;

namespace Sap.Aabrc.Automation
{
	public partial class AccountSegmentationCategoryUtil
	{
		private readonly AccountSegmentationCategoryService _accountSegmentationCategoryService = new AccountSegmentationCategoryService();

		public async Task GetAllAccountSegmentationCategorys(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllAccountSegmentationCategorys().");
			var list = await serviceLayer.Request(AccountSegmentationCategoryRequest.ACTION).GetAllAsync<AccountSegmentationCategory>();
			_accountSegmentationCategoryService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountSegmentationCategoryService.Insert(Common._aabrcMapper.ToSql(v));
				}

				catch (Exception ex) {
					#region Log
					if (ex.InnerException == null)
						Common.nLog.Warn("{0}{2}Exception thrown running _accountSegmentationCategoryService.Insert(Common._aabrcMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
					else
						throw;
					#endregion
				}
			}
		}
	}
}