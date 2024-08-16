using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.HouseBankAccounts;

namespace Sap.Automation
{
	public partial class HouseBankAccountUtil
	{
		private readonly HouseBankAccountService _houseBankAccountService = new HouseBankAccountService();

		public void GetAllHouseBankAccounts()
		{
			Common.logger.Trace("Begin method GetAllHouseBankAccounts().");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListHouseBankAccounts();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_houseBankAccountService.TruncateTable();

				foreach (var v in list) {
					try {
						_houseBankAccountService.Insert(Common._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.logger.Warn("{0}{2}Exception thrown running _service.Insert(Common._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
