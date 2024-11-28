using System;
using System.Threading.Tasks;
using Sap.Api.Domain.AccountSegmentationCategories;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.AccountSegmentationCategories;

namespace Aabrc.Sap
{
	public partial class AccountSegmentationCategoryUtil
	{
		private readonly AccountSegmentationCategoryService _accountSegmentationCategoryService = new AccountSegmentationCategoryService();

		public async Task GetAllAccountSegmentationCategorys()
		{
			Program.nLog.Trace("Begin method GetAllAccountSegmentationCategorys().");
			var list = await Program._serviceLayer.Request(AccountSegmentationCategoryRequest.ACTION).GetAllAsync<AccountSegmentationCategory>();
			_accountSegmentationCategoryService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountSegmentationCategoryService.Insert(Program._mapper.ToSql(v));
				}

				catch (Exception ex) {
					#region Log
					if (ex.InnerException == null)
						Program.nLog.Warn("{0}{2}Exception thrown running _accountSegmentationCategoryService.Insert(Program._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
					else
						throw;
					#endregion
				}
			}
		}
	}
}