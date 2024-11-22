using System.Data;

namespace Web202209.SAP_ArrowAndBranchWinery.Services.PurchaseCreditNotes
{
	public partial class DocumentLineService : BaseService, IDocumentLineService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "PurchaseCreditNote_DocumentLine");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.PurchaseCreditNote_DocumentLine", out errorMessage);
		}
	}
}