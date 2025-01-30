using System.Data;

namespace Web202209.SAP_RareCoinWholesalers.Services.VendorPayments
{
	public partial class VendorPaymentService : BaseService, IVendorPaymentService
	{
		/// <inheritdoc/>
		public virtual void TransferToDbo()
		{
			_dbContext.Database.ExecuteSqlCommand("EXEC [Import].[VendorPayment_TransferToDbo]");
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "VendorPayment");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.VendorPayment", out errorMessage);
		}
	}
}