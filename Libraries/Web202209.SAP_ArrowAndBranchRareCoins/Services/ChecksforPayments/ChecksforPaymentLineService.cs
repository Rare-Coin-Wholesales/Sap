using System.Data;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services.ChecksforPayments
{
	public partial class ChecksforPaymentLineService : BaseService, IChecksforPaymentLineService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "ChecksforPaymentLine");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.ChecksforPaymentLine", out errorMessage);
		}
	}
}