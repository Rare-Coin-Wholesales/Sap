using System.Data;

namespace Web202209.SAP_ArrowAndBranchWinery.Services.PurchaseCreditNotes
{
	public partial class PurchaseCreditNoteService : BaseService, IPurchaseCreditNoteService
	{
		/// <inheritdoc/>
		public virtual void TransferToDbo()
		{
			_dbContext.Database.ExecuteSqlCommand("EXEC [Import].[PurchaseCreditNote_TransferToDbo]");
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "PurchaseCreditNote");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.PurchaseCreditNote", out errorMessage);
		}
	}
}