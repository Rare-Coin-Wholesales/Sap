using System.Collections.Generic;
using Sap.Api.Domain.IncomingPayments;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.IncomingPayments;

namespace Aabw.Sap
{
	public partial class IncomingPaymentUtil
	{
		private readonly IPaymentCheckService _paymentCheckService = new PaymentCheckService();

		private void InsertPaymentChecks(IList<IncomingPayment> list)
		{
			var docLines = new List<PaymentCheck>();

			foreach (var v in list)
				docLines.AddRange(v.PaymentChecks);

			var dt = CommonUtil.ToDataTable(docLines);
			_paymentCheckService.TruncateTable();

			if (!_paymentCheckService.TryBulkCopy(dt, out var errorMsg))
				Program.nLog.Error(errorMsg);
		}
	}
}