using System;
using System.Threading.Tasks;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchRareCoins.Services.Deposits;

namespace Aabrc.Sap
{
	public partial class DepositUtil
	{
		DateTime EndTimeUtc, StartTimeUtc;
		private readonly IDepositService _depositService = new DepositService();

		public async Task GetAllDeposits()
		{
			Program.nLog.Info("Begin method GetAllDeposits().");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetAllDepositsAsync();

			if (list == null || list.Count == 0) {
				Program.nLog.Info($"Aabrc doesn't have any Deposits yet.{Environment.NewLine}");
				return;
			}
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_depositService.TruncateTable();

				if (_depositService.TryBulkCopy(dt, out var errorMsg)) {
					InsertCheckLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_depositService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetAllDeposits().");
			LogSummary();
		}

		public async Task GetDepositsByDepositDateAsync(DateTime minDate, int pageSize)
		{
			Program.nLog.Info("Begin method GetDepositsByDepositDateAsync(DateTime minDate, int pageSize).");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetDepositsByDepositDateAsync(minDate, pageSize);

			if (list == null || list.Count == 0) {
				Program.nLog.Info($"No new Deposits after {minDate:MMM d, yyyy}{Environment.NewLine}");
				return;
			}
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_depositService.TruncateTable();

				if (_depositService.TryBulkCopy(dt, out var errorMsg)) {
					InsertCheckLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_depositService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetDepositsByDepositDateAsync(DateTime minDate, int pageSize).");
			LogSummary();
		}

		void LogSummary()
		{
			var ts = EndTimeUtc - StartTimeUtc;
			Program.nLog.Info("Deposits Summary:");

			if (ts.TotalSeconds < 61)
				Program.nLog.Info("It took {0} sec to complete{1}", ts.ToString(@"s\.fff"), Environment.NewLine);
			else if (ts.TotalMinutes < 61)
				Program.nLog.Info("It took {0}m {1}s to complete{2}", ts.Minutes, ts.Seconds, Environment.NewLine);
			else
				Program.nLog.Info("It took {0}h {1}m to complete{2}", ts.Hours, ts.Minutes, Environment.NewLine);
		}
	}
}