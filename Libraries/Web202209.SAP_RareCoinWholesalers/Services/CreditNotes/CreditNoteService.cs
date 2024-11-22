using System.Data;

namespace Web202209.SAP_RareCoinWholesalers.Services.CreditNotes
{
	public partial class CreditNoteService : BaseService, ICreditNoteService
	{
		/// <inheritdoc/>
		public virtual void TransferToDbo()
		{
			_dbContext.Database.ExecuteSqlCommand("EXEC [Import].[CreditNote_TransferToDbo]");
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "CreditNote");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.CreditNote", out errorMessage);
		}
	}
}