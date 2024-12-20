using System.Data;

namespace Web202209.SAP_RareCoinWholesalers.Services.IncomingPayments
{
	public partial class PaymentCheckService : BaseService, IPaymentCheckService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "IncomingPayment_PaymentCheck");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.IncomingPayment_PaymentCheck", out errorMessage);
		}
	}
}