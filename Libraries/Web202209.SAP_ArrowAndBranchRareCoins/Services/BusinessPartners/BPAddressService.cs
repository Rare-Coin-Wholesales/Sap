using System.Data;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services.BusinessPartners
{
	public partial class BPAddressService : BaseService, IBPAddressService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "BPAddress");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.BPAddress", out errorMessage);
		}
	}
}