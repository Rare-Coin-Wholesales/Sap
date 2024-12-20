using System.Data;

namespace Web202209.SAP_ArrowAndBranchWinery.Services.IncomingPayments
{
	public partial class IncomingPaymentService : BaseService, IIncomingPaymentService
	{
		/// <inheritdoc/>
		public virtual void TransferToDbo()
		{
			_dbContext.Database.ExecuteSqlCommand("EXEC [Import].[IncomingPayment_TransferToDbo]");
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "IncomingPayment");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.IncomingPayment", out errorMessage);
		}
	}
}