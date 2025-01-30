using System.Data;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services.VendorPayments
{
	public partial class PaymentInvoiceService : BaseService, IPaymentInvoiceService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "PaymentInvoice");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.PaymentInvoice", out errorMessage);
		}
	}
}