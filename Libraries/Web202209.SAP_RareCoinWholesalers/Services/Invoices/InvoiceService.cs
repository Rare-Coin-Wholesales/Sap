using System.Collections.Generic;
using System.Data;
using System.Linq;
using Web202209.SAP_RareCoinWholesalers.Domain;

namespace Web202209.SAP_RareCoinWholesalers.Services.Invoices
{
	public partial class InvoiceService : BaseService, IInvoiceService
	{
		/// <inheritdoc/>
		public virtual IList<Invoice> GetAll()
		{
			return (from x in _dbContext.Invoices
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<Invoice> GetAllValid()
		{
			var query = (from x in _dbContext.Invoices
						 where x.CancelStatus == CANCEL_STATUS_NO &&
							   x.CardCode != null && x.CardCode.Trim() != "" &&
							   x.NumAtCard != null && x.NumAtCard.Trim() != ""
						 select x).ToList();

			return query.Where(x => decimal.TryParse(x.NumAtCard, out _)).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<Invoice> GetForPdsjs()
		{
			var query = (from x in _dbContext.Invoices
						 where x.NumAtCard != null && x.NumAtCard.Trim() != ""
						 select x).ToList();

			return query;
		}

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