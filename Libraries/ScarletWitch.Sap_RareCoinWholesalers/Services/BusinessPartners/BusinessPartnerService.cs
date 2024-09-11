using System;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.BusinessPartners
{
	/// <summary>
	/// BusinessPartner service
	/// </summary>
	public partial class BusinessPartnerService : BaseService, IBusinessPartnerService
	{
		/// <inheritdoc/>
		public virtual void Insert(BPAddress x)
		{
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");

			try {
				_dbContext.BPAddresses.Add(x);
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
		public virtual void Insert(BPIntrastatExtension x)
		{
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");

			try {
				_dbContext.BPIntrastatExtensions.Add(x);
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
		public virtual void Insert(BPPaymentMethod x)
		{
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");

			try {
				_dbContext.BPPaymentMethods.Add(x);
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
		public virtual void Insert(BusinessPartner x)
		{
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");

			try {
				_dbContext.BusinessPartners.Add(x);
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
		public virtual void Insert(ContactEmployee x)
		{
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");

			try {
				_dbContext.ContactEmployees.Add(x);
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
			base.TruncateTable("BPAddress");
			base.TruncateTable("BPIntrastatExtension");
			base.TruncateTable("BPPaymentMethod");
			base.TruncateTable("BusinessPartner");
			base.TruncateTable("ContactEmployee");
		}
	}
}