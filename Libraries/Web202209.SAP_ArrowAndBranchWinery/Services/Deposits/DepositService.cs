using System.Data;

namespace Web202209.SAP_ArrowAndBranchWinery.Services.Deposits
{
	public partial class DepositService : BaseService, IDepositService
	{
		/// <inheritdoc/>
		public virtual void TransferToDbo()
		{
			_dbContext.Database.ExecuteSqlCommand("EXEC [Import].[Deposit_TransferToDbo]");
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "Deposit");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.Deposit", out errorMessage);
		}
	}
}