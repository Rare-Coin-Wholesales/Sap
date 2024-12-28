using System.Data;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services.BusinessPartners
{
	public partial class BPIntrastatExtensionService : BaseService, IBPIntrastatExtensionService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "BPIntrastatExtension");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.BPIntrastatExtension", out errorMessage);
		}
	}
}