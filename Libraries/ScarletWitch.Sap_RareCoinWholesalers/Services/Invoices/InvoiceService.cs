using System;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices
{
	/// <summary>
	/// Invoice service
	/// </summary>
	public partial class InvoiceService : BaseService, IInvoiceService
	{
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
		public virtual void InsertDocumentLine(Invoice_DocumentLine x)
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