using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.HouseBankAccounts;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.HouseBankAccounts;

namespace Sap.Automation
{
	public partial class HouseBankAccountUtil
	{
		private readonly HouseBankAccountService _houseBankAccountService = new HouseBankAccountService();

		public async Task GetAllHouseBankAccounts(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllHouseBankAccounts().");
			var list = await serviceLayer.Request(HouseBankAccountRequest.ACTION).GetAllAsync<HouseBankAccount>();

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
