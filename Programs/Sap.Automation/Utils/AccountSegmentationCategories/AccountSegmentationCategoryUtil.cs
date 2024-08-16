using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountSegmentationCategories;

namespace Sap.Automation
{
	public partial class AccountSegmentationCategoryUtil
	{
		private readonly AccountSegmentationCategoryService _accountSegmentationCategoryService = new AccountSegmentationCategoryService();

		public void GetAllAccountSegmentationCategorys()
		{
			Common.logger.Trace("Begin method GetAllAccountSegmentationCategorys().");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListAccountSegmentationCategories();
			_accountSegmentationCategoryService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountSegmentationCategoryService.Insert(Common._mapper.ToSql(v));
				}

				catch (Exception ex) {
					#region Log
					if (ex.InnerException == null)
						Common.logger.Warn("{0}{2}Exception thrown running _accountSegmentationCategoryService.Insert(Common._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
					else
						throw;
					#endregion
				}
			}
		}
	}
}