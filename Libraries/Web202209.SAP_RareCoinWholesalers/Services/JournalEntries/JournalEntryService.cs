using System.Data;

namespace Web202209.SAP_RareCoinWholesalers.Services.JournalEntries
{
	public partial class JournalEntryService : BaseService, IJournalEntryService
	{
		/// <inheritdoc/>
		public virtual void TransferToDbo()
		{
			_dbContext.Database.ExecuteSqlCommand("EXEC [Import].[JournalEntry_TransferToDbo]");
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "JournalEntry");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.JournalEntry", out errorMessage);
		}
	}
}