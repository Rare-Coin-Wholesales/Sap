using System.Data;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services.BusinessPartners
{
	public partial class ContactEmployeeService : BaseService, IContactEmployeeService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "ContactEmployee");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.ContactEmployee", out errorMessage);
		}
	}
}