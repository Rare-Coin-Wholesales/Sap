using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.ChartOfAccounts;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.ChartOfAccounts;

namespace Sap.Rcw.Automation
{
	public partial class ChartOfAccountUtil
	{
		private readonly ChartOfAccountService _chartOfAccountService = new ChartOfAccountService();

		public async Task GetAllChartOfAccounts(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllChartOfAccounts().");
			var list = await serviceLayer.Request(ChartOfAccountRequest.ACTION).GetAllAsync<ChartOfAccount>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_chartOfAccountService.TruncateTable();

				foreach (var v in list) {
					try {
						_chartOfAccountService.Insert(Common._rcwMapper.ToSql(v));
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
