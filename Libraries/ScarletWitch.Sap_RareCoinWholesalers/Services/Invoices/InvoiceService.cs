using System;
using System.Collections.Generic;
using System.Linq;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices
{
	/// <summary>
	/// Invoice service
	/// </summary>
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
		public virtual void Insert(Invoice x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.DocEntry == null)
				throw new Exception("'DocEntry' is required.");
			#endregion

			try {
				_dbContext.Invoices.Add(x);
				_dbContext.SaveChanges();
			}

			catch (Exception ex) {
				#region Handle Exception
				var msg = GetFullErrorText(ex);

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		/// <inheritdoc/>
		public virtual void Insert(Invoice_DocumentLine x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			#endregion

			try {
				_dbContext.Invoice_DocumentLine.Add(x);
				_dbContext.SaveChanges();
			}

			catch (Exception ex) {
				#region Handle Exception
				var msg = GetFullErrorText(ex);

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Invoice");
			base.TruncateTable("Invoice_DocumentLine");
		}
	}
}