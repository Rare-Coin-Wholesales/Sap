using System;
using System.Threading.Tasks;
using Sap.Api.Domain.AccountCategories;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.AccountCategories;

namespace Aabw.Sap
{
	public partial class AccountCategoryUtil
	{
		private readonly AccountCategoryService _accountCategoryService = new AccountCategoryService();

		public async Task GetAllAccountCategorys()
		{
			Program.nLog.Trace("Begin method GetAllAccountCategorys().");
			var list = await Program._serviceLayer.Request(AccountCategoryRequest.ACTION).GetAllAsync<AccountCategory>();
			_accountCategoryService.TruncateTable();

			foreach (var v in list) {
				try {
					_accountCategoryService.Insert(Program._mapper.ToSql(v));
				}

				catch (Exception ex) {
					#region Log
					if (ex.InnerException == null)
						Program.nLog.Warn("{0}{2}Exception thrown running _accountCategoryService.Insert(Program._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
					else
						throw;
					#endregion
				}
			}
		}
	}
}