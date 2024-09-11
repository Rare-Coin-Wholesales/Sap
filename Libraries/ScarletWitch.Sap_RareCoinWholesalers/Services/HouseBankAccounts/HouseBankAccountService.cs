using System;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.HouseBankAccounts
{
	/// <summary>
	/// HouseBankAccount service
	/// </summary>
	public partial class HouseBankAccountService : BaseService, IHouseBankAccountService
	{
		/// <inheritdoc/>
		public virtual void Insert(HouseBankAccount x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.AbsoluteEntry == null)
				throw new Exception("'AbsoluteEntry' is required.");
			#endregion

			try {
				_dbContext.HouseBankAccounts.Add(x);
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
			base.TruncateTable("HouseBankAccount");
		}
	}
}