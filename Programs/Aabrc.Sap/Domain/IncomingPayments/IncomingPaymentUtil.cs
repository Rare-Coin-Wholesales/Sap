using System;
using System.Threading.Tasks;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchRareCoins.Services.IncomingPayments;

namespace Aabrc.Sap
{
	public partial class IncomingPaymentUtil
	{
		DateTime EndTimeUtc, StartTimeUtc;
		private readonly IIncomingPaymentService _incomingPaymentService = new IncomingPaymentService();

		public async Task GetAllIncomingPayments()
		{
			Program.nLog.Info("Begin method GetAllIncomingPayments().");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetAllIncomingPaymentsAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_incomingPaymentService.TruncateTable();

				if (_incomingPaymentService.TryBulkCopy(dt, out var errorMsg)) {
					InsertPaymentChecks(list);
					InsertPaymentInvoices(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_incomingPaymentService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetAllIncomingPayments().");
			LogSummary();
		}

		public async Task GetIncomingPaymentsByDocDate(DateTime minDate)
		{
			Program.nLog.Info("Begin method GetIncomingPaymentsByDocDate(DateTime minDate).");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetIncomingPaymentsByDocDateAsync(minDate);

			if (list == null || list.Count == 0)
				return;
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_incomingPaymentService.TruncateTable();

				if (_incomingPaymentService.TryBulkCopy(dt, out var errorMsg)) {
					InsertPaymentChecks(list);
					InsertPaymentInvoices(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_incomingPaymentService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetIncomingPaymentsByDocDate(DateTime minDate).");
			LogSummary();
		}

		void LogSummary()
		{
			var ts = EndTimeUtc - StartTimeUtc;
			Program.nLog.Info("IncomingPayments Summary:");

			if (ts.TotalSeconds < 61)
				Program.nLog.Info("It took {0} sec to complete", ts.ToString(@"s\.fff"));
			else if (ts.TotalMinutes < 61)
				Program.nLog.Info("It took {0}m {1}s to complete", ts.Minutes, ts.Seconds);
			else
				Program.nLog.Info("It took {0}h {1}m to complete", ts.Hours, ts.Minutes);

			Program.nLog.Info("");
		}
	}
}