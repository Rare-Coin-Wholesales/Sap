using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.ChartOfAccounts;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.ChartOfAccounts;

namespace Sap.Automation
{
	public partial class ChartOfAccountUtil
	{
		private readonly ChartOfAccountService _chartOfAccountService = new ChartOfAccountService();

		public async Task GetAllChartOfAccounts(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllChartOfAccounts().");
			var list = await serviceLayer.Request(ChartOfAccountRequest.ACTION).GetAllAsync<ChartOfAccount>();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_chartOfAccountService.TruncateTable();

				foreach (var v in list) {
					try {
						_chartOfAccountService.Insert(Common._mapper.ToSql(v));
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
