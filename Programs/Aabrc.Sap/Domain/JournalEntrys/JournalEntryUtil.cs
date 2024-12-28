using System;
using System.Threading.Tasks;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchRareCoins.Services.JournalEntries;

namespace Aabrc.Sap
{
	public partial class JournalEntryUtil
	{
		DateTime EndTimeUtc, StartTimeUtc;
		private readonly IJournalEntryService _journalEntryService = new JournalEntryService();

		public async Task GetAllJournalEntries()
		{
			Program.nLog.Info("Begin method GetAllJournalEntries().");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetAllJournalEntriesAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_journalEntryService.TruncateTable();

				if (_journalEntryService.TryBulkCopy(dt, out var errorMsg)) {
					InsertDocumentLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_journalEntryService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetAllJournalEntries().");
			LogSummary();
		}

		public async Task GetJournalEntriesByReferenceDate(DateTime minDate)
		{
			Program.nLog.Info("Begin method GetJournalEntriesByReferenceDate(DateTime minDate).");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetJournalEntriesByReferenceDateAsync(minDate);

			if (list == null || list.Count == 0)
				return;
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_journalEntryService.TruncateTable();

				if (_journalEntryService.TryBulkCopy(dt, out var errorMsg)) {
					InsertDocumentLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_journalEntryService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetJournalEntriesByReferenceDate(DateTime minDate).");
			LogSummary();
		}

		void LogSummary()
		{
			var ts = EndTimeUtc - StartTimeUtc;
			Program.nLog.Info("JournalEntries Summary:");

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