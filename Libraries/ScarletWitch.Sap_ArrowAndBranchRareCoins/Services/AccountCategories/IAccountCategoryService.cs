using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.AccountCategories
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