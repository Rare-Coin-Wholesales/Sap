using System.Data;

namespace Web202209.SAP_ArrowAndBranchWinery.Services.BusinessPartners
{
	public partial class BPPaymentMethodService : BaseService, IBPPaymentMethodService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "BPPaymentMethod");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.BPPaymentMethod", out errorMessage);
		}
	}
}