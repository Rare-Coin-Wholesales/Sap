using System;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.VendorPayments
{
	/// <summary>
	/// VendorPayment service
	/// </summary>
	public partial class VendorPaymentService : BaseService, IVendorPaymentService
	{
		/// <inheritdoc/>
		public virtual void Insert(PaymentCheck x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			#endregion

			try {
				_dbContext.PaymentChecks.Add(x);
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
		public virtual void Insert(PaymentInvoice x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			#endregion

			try {
				_dbContext.PaymentInvoices.Add(x);
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
		public virtual void Insert(VendorPayment x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.DocEntry == null)
				throw new Exception("'DocEntry' is required.");
			#endregion

			try {
				_dbContext.VendorPayments.Add(x);
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
			base.TruncateTable("PaymentCheck");
			base.TruncateTable("PaymentInvoice");
			base.TruncateTable("VendorPayment");
		}
	}
}