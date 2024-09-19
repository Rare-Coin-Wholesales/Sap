using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.AccountCategories
{
	/// <summary>
	/// AccountCategory service interface
	/// </summary>
	public interface IAccountCategoryService
	{
		/// <summary>
		/// Inserts a <see cref="AccountCategory"/>.
		/// </summary>
		/// <param name="x">The <see cref="AccountCategory"/>.</param>
		void Insert(AccountCategory x);
		/// <summary>
		/// Truncates the <see cref="AccountCategory"/> table.
		/// </summary>
		void TruncateTable();
	}
}