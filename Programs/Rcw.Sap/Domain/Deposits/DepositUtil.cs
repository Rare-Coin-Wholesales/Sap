using System;
using System.Threading.Tasks;
using Sap.Api.Domain.Deposits;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Deposits;

namespace Rcw.Sap
{
	public partial class DepositUtil
	{
		private readonly DepositService _depositService = new DepositService();

		public async Task GetAllDeposits()
		{
			Program.nLog.Trace("Begin method GetAllDeposits().");
			var list = await Program._serviceLayer.Request(DepositRequest.ACTION).GetAllAsync<Deposit>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_depositService.TruncateTable();

				foreach (var v in list) {
					try {
						_depositService.Insert(Program._mapper.ToSql(v));
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
