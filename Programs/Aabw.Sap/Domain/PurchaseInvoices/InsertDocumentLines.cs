using System.Collections.Generic;
using Sap.Api.Domain.PurchaseInvoices;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.PurchaseInvoices;

namespace Aabw.Sap
{
	public partial class PurchaseInvoiceUtil
	{
		private readonly IDocumentLineService _documentLineService = new DocumentLineService();

		private void InsertDocumentLines(IList<PurchaseInvoice> list)
		{
			var docLines = new List<PurchaseInvoice_DocumentLine>();

			foreach (var v in list)
				docLines.AddRange(v.DocumentLines);

			var dt = CommonUtil.ToDataTable(docLines);
			_documentLineService.TruncateTable();

			if (!_documentLineService.TryBulkCopy(dt, out var errorMsg))
				Program.nLog.Error(errorMsg);
		}
	}
}