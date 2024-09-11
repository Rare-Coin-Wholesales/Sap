using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.AccountCategories;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.AccountCategories;

namespace Sap.Rcw.Automation
{
	public partial class AccountCategoryUtil
	{
		private readonly AccountCategoryService _accountCategoryService = new AccountCategoryService();

		public async Task GetAllAccountCategorys(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllAccountCategorys().");
			var list = await serviceLayer.Request(AccountCategoryRequest.ACTION).GetAllAsync<AccountCategory>();
			_accountCategoryService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountCategoryService.Insert(Common._rcwMapper.ToSql(v));
				}

				catch (Exception ex) {
					#region Log
					if (ex.InnerException == null)
						Common.nLog.Warn("{0}{2}Exception thrown running _accountCategoryService.Insert(Common._rcwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
					else
						throw;
					#endregion
				}
			}
		}
	}
}