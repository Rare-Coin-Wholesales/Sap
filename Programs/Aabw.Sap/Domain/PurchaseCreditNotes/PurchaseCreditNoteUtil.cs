using System.Collections.Generic;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseCreditNotes;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.PurchaseCreditNotes;

namespace Aabw.Sap
{
	public partial class PurchaseCreditNoteUtil
	{
		private readonly IPurchaseCreditNoteService _purchaseCreditNoteService = new PurchaseCreditNoteService();
		private readonly IDocumentLineService _documentLineService = new DocumentLineService();

		public async Task GetAllPurchaseCreditNotes()
		{
			Program.nLog.Trace("Begin method GetAllPurchaseCreditNotes().");
			var list = await Program._serviceLayer.GetAllPurchaseCreditNotesAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				var dt = CommonUtil.ToDataTable(list);
				_purchaseCreditNoteService.TruncateTable();

				if (_purchaseCreditNoteService.TryBulkCopy(dt, out var errorMsg))
					InsertDocumentLines(list);
				else
					Program.nLog.Error(errorMsg);
			}

			_purchaseCreditNoteService.TransferToDbo();
		}

		private void InsertDocumentLines(IList<PurchaseCreditNote> list)
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