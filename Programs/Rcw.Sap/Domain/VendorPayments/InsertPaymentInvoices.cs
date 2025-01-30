using System.Collections.Generic;
using Sap.Api.Domain.VendorPayments;
using Sap.Core;
using Web202209.SAP_RareCoinWholesalers.Services.VendorPayments;

namespace Rcw.Sap
{
	public partial class VendorPaymentUtil
	{
		private readonly IPaymentInvoiceService _paymentInvoiceService = new PaymentInvoiceService();

		private void InsertPaymentInvoices(IList<VendorPayment> list)
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