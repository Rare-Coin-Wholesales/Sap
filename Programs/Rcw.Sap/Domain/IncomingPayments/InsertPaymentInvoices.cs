using System.Collections.Generic;
using Sap.Api.Domain.IncomingPayments;
using Sap.Core;
using Web202209.SAP_RareCoinWholesalers.Services.IncomingPayments;

namespace Rcw.Sap
{
	public partial class IncomingPaymentUtil
	{
		private readonly IPaymentInvoiceService _paymentInvoiceService = new PaymentInvoiceService();

		private void InsertPaymentInvoices(IList<IncomingPayment> list)
		{
			var docLines = new List<PaymentInvoice>();

			foreach (var v in list)
				docLines.AddRange(v.PaymentInvoices);

			var dt = CommonUtil.ToDataTable(docLines);
			_paymentInvoiceService.TruncateTable();

			if (!_paymentInvoiceService.TryBulkCopy(dt, out var errorMsg))
				Program.nLog.Error(errorMsg);
		}
	}
}