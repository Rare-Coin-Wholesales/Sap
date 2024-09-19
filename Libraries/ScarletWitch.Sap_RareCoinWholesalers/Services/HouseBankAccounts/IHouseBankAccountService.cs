using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.HouseBankAccounts
{
	/// <summary>
	/// HouseBankAccount service interface
	/// </summary>
	public interface IHouseBankAccountService
	{
		/// <summary>
		/// Inserts a <see cref="HouseBankAccount"/>.
		/// </summary>
		/// <param name="x">The <see cref="HouseBankAccount"/>.</param>
		void Insert(HouseBankAccount x);
		/// <summary>
		/// Truncates the <see cref="HouseBankAccount"/> table.
		/// </summary>
		void TruncateTable();
	}
}