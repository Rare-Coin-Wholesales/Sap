using System.Data;

namespace Web202209.SAP_RareCoinWholesalers.Services.JournalEntries
{
	public partial class JournalEntryLineService : BaseService, IJournalEntryLineService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "JournalEntryLine");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.JournalEntryLine", out errorMessage);
		}
	}
}