using System;
using System.Threading.Tasks;
using Sap.Api.Domain.HouseBankAccounts;
using ScarletWitch.Sap_RareCoinWholesalers.Services.HouseBankAccounts;

namespace Rcw.Sap
{
	public partial class HouseBankAccountUtil
	{
		private readonly HouseBankAccountService _houseBankAccountService = new HouseBankAccountService();

		public async Task GetAllHouseBankAccounts()
		{
			Program.nLog.Trace("Begin method GetAllHouseBankAccounts().");
			var list = await Program._serviceLayer.Request(HouseBankAccountRequest.ACTION).GetAllAsync<HouseBankAccount>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_houseBankAccountService.TruncateTable();

				foreach (var v in list) {
					try {
						_houseBankAccountService.Insert(Program._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Program.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Program._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
