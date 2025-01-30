using System;
using System.Threading.Tasks;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.ChecksforPayments;

namespace Aabw.Sap
{
	public partial class ChecksforPaymentUtil
	{
		DateTime EndTimeUtc, StartTimeUtc;
		private readonly IChecksforPaymentService _checksforPaymentService = new ChecksforPaymentService();

		public async Task GetAllChecksforPayments()
		{
			Program.nLog.Info("Begin method GetAllChecksforPayments().");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetAllChecksforPaymentAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_checksforPaymentService.TruncateTable();

				if (_checksforPaymentService.TryBulkCopy(dt, out var errorMsg)) {
					InsertDocumentLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_checksforPaymentService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetAllChecksforPayments().");
			LogSummary();
		}

		public async Task GetChecksforPaymentsByUpdateDate(DateTime minDate, int pageSize)
		{
			Program.nLog.Info($"Begin method GetChecksforPaymentsByUpdateDate(DateTime minDate='{minDate}', int pageSize='{pageSize}').");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetChecksforPaymentByUpdateDateAsync(minDate, pageSize);

			if (list == null || list.Count == 0) {
				Program.nLog.Info($"No new ChecksforPayments after {minDate:MMM d, yyyy}{Environment.NewLine}");
				return;
			}
			else {
				Program.nLog.Info($"{list.Count} ChecksforPayments found.");
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_checksforPaymentService.TruncateTable();

				if (_checksforPaymentService.TryBulkCopy(dt, out var errorMsg)) {
					InsertDocumentLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_checksforPaymentService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetChecksforPaymentsByUpdateDate(DateTime minDate, int pageSize).");
			LogSummary();
		}

		void LogSummary()
		{
			var ts = EndTimeUtc - StartTimeUtc;
			Program.nLog.Info("ChecksforPayments Summary:");

			if (ts.TotalSeconds < 61)
				Program.nLog.Info("It took {0} sec to complete{1}", ts.ToString(@"s\.fff"), Environment.NewLine);
			else if (ts.TotalMinutes < 61)
				Program.nLog.Info("It took {0}m {1}s to complete{2}", ts.Minutes, ts.Seconds, Environment.NewLine);
			else
				Program.nLog.Info("It took {0}h {1}m to complete{2}", ts.Hours, ts.Minutes, Environment.NewLine);
		}
	}
}