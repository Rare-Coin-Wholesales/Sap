using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountCategories;

namespace Sap.Automation
{
	public partial class AccountCategoryUtil
	{
		private readonly AccountCategoryService _accountCategoryService = new AccountCategoryService();

		public void GetAllAccountCategorys()
		{
			Common.logger.Trace("Begin method GetAllAccountCategorys().");
			Common.logger.Trace($"Common.BaseUrl: '{Common.BaseUrl}'");
			Common.logger.Trace($"Common.CompanyDb: '{Common.CompanyDb}'");
			Common.logger.Trace($"Common.Username: '{Common.Username}'");
			Common.logger.Trace($"Common.Password: '{Common.Password}'");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListAccountCategories();
			_accountCategoryService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountCategoryService.Insert(Common._mapper.ToSql(v));
				}

				catch (Exception ex) {
					#region Log
					if (ex.InnerException == null)
						Common.logger.Warn("{0}{2}Exception thrown running _accountCategoryService.Insert(Common._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
					else
						throw;
					#endregion
				}
			}
		}
	}
}