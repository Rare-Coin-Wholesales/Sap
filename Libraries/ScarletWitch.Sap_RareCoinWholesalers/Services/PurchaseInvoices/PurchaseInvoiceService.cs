using System;
using System.Collections.Generic;
using System.Linq;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseInvoices
{
	/// <summary>
	/// PurchaseInvoice service
	/// </summary>
	public partial class PurchaseInvoiceService : BaseService, IPurchaseInvoiceService
	{
		/// <inheritdoc/>
		public virtual IList<PurchaseInvoice> GetAll()
		{
			return (from x in _dbContext.PurchaseInvoices
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual void Insert(PurchaseInvoice x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.DocEntry == null)
				throw new Exception("'DocEntry' is required.");
			#endregion

			try {
				_dbContext.PurchaseInvoices.Add(x);
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
		public virtual void Insert(PurchaseInvoice_DocumentLine x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.DocEntry == null)
				throw new Exception("'DocEntry' is required.");
			#endregion

			try {
				_dbContext.PurchaseInvoice_DocumentLine.Add(x);
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
			base.TruncateTable("PurchaseInvoice");
			base.TruncateTable("PurchaseInvoice_DocumentLine");
		}
	}
}