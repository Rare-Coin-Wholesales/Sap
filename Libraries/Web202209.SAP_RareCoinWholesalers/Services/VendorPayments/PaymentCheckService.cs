using System.Data;

namespace Web202209.SAP_RareCoinWholesalers.Services.VendorPayments
{
	public partial class PaymentCheckService : BaseService, IPaymentCheckService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "PaymentCheck");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.PaymentCheck", out errorMessage);
		}
	}
}