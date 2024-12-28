using System.Data;

namespace Web202209.SAP_ArrowAndBranchWinery.Services.Invoices
{
	public partial class InvoiceService : BaseService, IInvoiceService
	{
		/// <inheritdoc/>
		public virtual void TransferToDbo()
		{
			_dbContext.Database.ExecuteSqlCommand("EXEC [Import].[Invoice_TransferToDbo]");
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "Invoice");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.Invoice", out errorMessage);
		}
	}
}