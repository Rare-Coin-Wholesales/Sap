using System.Collections.Generic;
using Sap.Api.Domain.Invoices;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.Invoices;

namespace Aabw.Sap
{
	public partial class InvoiceUtil
	{
		private readonly IDocumentLineService _documentLineService = new DocumentLineService();

		private void InsertDocumentLines(IList<Invoice> list)
		{
			var docLines = new List<Invoice_DocumentLine>();

			foreach (var v in list)
				docLines.AddRange(v.DocumentLines);

			var dt = CommonUtil.ToDataTable(docLines);
			_documentLineService.TruncateTable();

			if (!_documentLineService.TryBulkCopy(dt, out var errorMsg))
				Program.nLog.Error(errorMsg);
		}
	}
}