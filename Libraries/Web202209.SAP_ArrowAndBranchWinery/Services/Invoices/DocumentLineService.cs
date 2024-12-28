using System.Data;

namespace Web202209.SAP_ArrowAndBranchWinery.Services.Invoices
{
	public partial class DocumentLineService : BaseService, IDocumentLineService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "Invoice_DocumentLine");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.Invoice_DocumentLine", out errorMessage);
		}
	}
}