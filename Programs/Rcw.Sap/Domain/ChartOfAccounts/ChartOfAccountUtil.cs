using System;
using System.Threading.Tasks;
using Sap.Api.Domain.ChartOfAccounts;
using ScarletWitch.Sap_RareCoinWholesalers.Services.ChartOfAccounts;

namespace Rcw.Sap
{
	public partial class ChartOfAccountUtil
	{
		private readonly ChartOfAccountService _chartOfAccountService = new ChartOfAccountService();

		public async Task GetAllChartOfAccounts()
		{
			Program.nLog.Trace("Begin method GetAllChartOfAccounts().");
			var list = await Program._serviceLayer.Request(ChartOfAccountRequest.ACTION).GetAllAsync<ChartOfAccount>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_chartOfAccountService.TruncateTable();

				foreach (var v in list) {
					try {
						_chartOfAccountService.Insert(Program._mapper.ToSql(v));
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
