using System.Data;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services.Deposits
{
	public partial class CheckLineService : BaseService, ICheckLineService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "Deposit_CheckLine");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.Deposit_CheckLine", out errorMessage);
		}
	}
}