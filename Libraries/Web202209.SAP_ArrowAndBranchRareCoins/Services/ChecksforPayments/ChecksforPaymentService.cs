using System.Data;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services.ChecksforPayments
{
	public partial class ChecksforPaymentService : BaseService, IChecksforPaymentService
	{
		/// <inheritdoc/>
		public virtual void TransferToDbo()
		{
			_dbContext.Database.ExecuteSqlCommand("EXEC [Import].[ChecksforPayment_TransferToDbo]");
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "ChecksforPayment");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.ChecksforPayment", out errorMessage);
		}
	}
}