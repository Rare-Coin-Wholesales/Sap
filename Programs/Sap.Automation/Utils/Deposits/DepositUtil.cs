using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.Deposits;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.Deposits;

namespace Sap.Automation
{
	public partial class DepositUtil
	{
		private readonly DepositService _depositService = new DepositService();

		public async Task GetAllDeposits(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllDeposits().");
			var list = await serviceLayer.Request(DepositRequest.ACTION).GetAllAsync<Deposit>();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_depositService.TruncateTable();

				foreach (var v in list) {
					try {
						_depositService.Insert(Common._mapper.ToSql(v));
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
