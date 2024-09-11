using System;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.Common
{
	/// <summary>
	/// AddressExtension service
	/// </summary>
	public partial class AddressExtensionService : BaseService
	{
		/// <inheritdoc/>
		public virtual void Insert(AddressExtension x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.DocEntry == null)
				throw new Exception("'DocEntry' is required.");
			#endregion

			try {
				_dbContext.AddressExtensions.Add(x);
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
			base.TruncateTable("AddressExtension");
		}
	}
}