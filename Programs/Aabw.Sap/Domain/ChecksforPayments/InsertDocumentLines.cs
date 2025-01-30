using System.Collections.Generic;
using Sap.Api.Domain.ChecksforPayments;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.ChecksforPayments;

namespace Aabw.Sap
{
	public partial class ChecksforPaymentUtil
	{
		private readonly IChecksforPaymentLineService _checksforPaymentLineService = new ChecksforPaymentLineService();

		private void InsertDocumentLines(IList<ChecksforPayment> list)
		{
			var docLines = new List<ChecksforPaymentLine>();

			foreach (var v in list)
				docLines.AddRange(v.ChecksforPaymentLines);

			var dt = CommonUtil.ToDataTable(docLines);
			_checksforPaymentLineService.TruncateTable();

			if (!_checksforPaymentLineService.TryBulkCopy(dt, out var errorMsg))
				Program.nLog.Error(errorMsg);
		}
	}
}