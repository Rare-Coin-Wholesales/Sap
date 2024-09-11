using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.HouseBankAccounts;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.HouseBankAccounts;

namespace Sap.Rcw.Automation
{
	public partial class HouseBankAccountUtil
	{
		private readonly HouseBankAccountService _houseBankAccountService = new HouseBankAccountService();

		public async Task GetAllHouseBankAccounts(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllHouseBankAccounts().");
			var list = await serviceLayer.Request(HouseBankAccountRequest.ACTION).GetAllAsync<HouseBankAccount>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_houseBankAccountService.TruncateTable();

				foreach (var v in list) {
					try {
						_houseBankAccountService.Insert(Common._rcwMapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._rcwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
