using System.Data;

namespace Web202209.SAP_RareCoinWholesalers.Services.PurchaseInvoices
{
	public partial class DocumentLineService : BaseService, IDocumentLineService
	{
		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "PurchaseInvoice_DocumentLine");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.PurchaseInvoice_DocumentLine", out errorMessage);
		}
	}
}