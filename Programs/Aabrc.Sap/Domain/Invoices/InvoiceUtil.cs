using System;
using System.Threading.Tasks;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchRareCoins.Services.Invoices;

namespace Aabrc.Sap
{
	public partial class InvoiceUtil
	{
		DateTime EndTimeUtc, StartTimeUtc;
		private readonly InvoiceService _invoiceService = new InvoiceService();

		public async Task GetAllInvoices()
		{
			Program.nLog.Info("Begin method GetAllInvoices().");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetAllInvoicesAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_invoiceService.TruncateTable();

				if (_invoiceService.TryBulkCopy(dt, out var errorMsg)) {
					InsertDocumentLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_invoiceService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetAllInvoices().");
			LogSummary();
		}

		public async Task GetInvoicesByUpdateDate(DateTime minDate)
		{
			Program.nLog.Info("Begin method GetInvoicesByUpdateDate(DateTime minDate).");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetInvoicesByUpdateDateAsync(minDate);

			if (list == null || list.Count == 0) {
				Program.nLog.Info($"No new invoices after {minDate:MMM d, yyyy}{Environment.NewLine}");
				return;
			}
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_invoiceService.TruncateTable();

				if (_invoiceService.TryBulkCopy(dt, out var errorMsg)) {
					InsertDocumentLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_invoiceService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetInvoicesByUpdateDate(DateTime minDate).");
			LogSummary();
		}

		void LogSummary()
		{
			var ts = EndTimeUtc - StartTimeUtc;
			Program.nLog.Info("Invoices Summary:");

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