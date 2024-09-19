using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.Deposits;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Deposits;

namespace Sap.Rcw.Automation
{
	public partial class DepositUtil
	{
		private readonly DepositService _depositService = new DepositService();

		public async Task GetAllDeposits(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllDeposits().");
			var list = await serviceLayer.Request(DepositRequest.ACTION).GetAllAsync<Deposit>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_depositService.TruncateTable();

				foreach (var v in list) {
					try {
						_depositService.Insert(Common._rcwMapper.ToSql(v));
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
