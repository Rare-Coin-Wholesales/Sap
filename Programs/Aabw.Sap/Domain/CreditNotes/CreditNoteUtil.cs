using System.Collections.Generic;
using System.Threading.Tasks;
using Sap.Api.Domain.CreditNotes;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.CreditNotes;

namespace Aabw.Sap
{
	public partial class CreditNoteUtil
	{
		private readonly ICreditNoteService _creditNoteService = new CreditNoteService();
		private readonly IDocumentLineService _documentLineService = new DocumentLineService();

		public async Task GetAllCreditNotes()
		{
			Program.nLog.Trace("Begin method GetAllCreditNotes().");
			var list = await Program._serviceLayer.GetAllCreditNotesAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				var dt = CommonUtil.ToDataTable(list);
				_creditNoteService.TruncateTable();

				if (_creditNoteService.TryBulkCopy(dt, out var errorMsg))
					InsertDocumentLines(list);
				else
					Program.nLog.Error(errorMsg);
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
				Program.nLog.Error(errorMsg2);
		}
	}
}