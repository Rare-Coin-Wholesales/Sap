using System.Collections.Generic;
using Sap.Api.Domain.JournalEntries;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.JournalEntries;

namespace Aabw.Sap
{
	public partial class JournalEntryUtil
	{
		private readonly IJournalEntryLineService _documentLineService = new JournalEntryLineService();

		private void InsertDocumentLines(IList<JournalEntry> list)
		{
			var docLines = new List<JournalEntryLine>();

			foreach (var v in list)
				docLines.AddRange(v.JournalEntryLines);

			var dt = CommonUtil.ToDataTable(docLines);
			_documentLineService.TruncateTable();

			if (!_documentLineService.TryBulkCopy(dt, out var errorMsg))
				Program.nLog.Error(errorMsg);
		}
	}
}