using System.Collections.Generic;
using System.Threading.Tasks;
using Sap.Api.Domain.CreditNotes;
using Sap.Automation;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.CreditNotes;

namespace Sap.Aabw.Automation
{
	public partial class CreditNoteUtil
	{
		private readonly ICreditNoteService _creditNoteService = new CreditNoteService();
		private readonly IDocumentLineService _documentLineService = new DocumentLineService();

		public async Task GetAllCreditNotes()
		{
			Common.nLog.Trace("Begin method GetAllCreditNotes().");
			var list = await Common.AabwServiceLayer.GetAllCreditNotesAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				var dt = CommonUtil.ToDataTable(list);
				_creditNoteService.TruncateTable();

				if (_creditNoteService.TryBulkCopy(dt, out var errorMsg))
					InsertDocumentLines(list);
				else
					Common.nLog.Error(errorMsg);
			}

			_creditNoteService.TransferToDbo();
		}

		private void InsertDocumentLines(IList<CreditNote> list)
		{
			var docLines = new List<DocumentLine>();

			foreach (var v in list)
				docLines.AddRange(v.DocumentLines);

			var dt = CommonUtil.ToDataTable(docLines);
			_documentLineService.TruncateTable();

			if (!_documentLineService.TryBulkCopy(dt, out var errorMsg2))
				Common.nLog.Error(errorMsg2);
		}
	}
}