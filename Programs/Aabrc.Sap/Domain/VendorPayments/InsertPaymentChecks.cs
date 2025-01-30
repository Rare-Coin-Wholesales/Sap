using System.Collections.Generic;
using Sap.Api.Domain.VendorPayments;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchRareCoins.Services.VendorPayments;

namespace Aabrc.Sap
{
	public partial class VendorPaymentUtil
	{
		private readonly IPaymentCheckService _paymentCheckService = new PaymentCheckService();

		private void InsertPaymentChecks(IList<VendorPayment> list)
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