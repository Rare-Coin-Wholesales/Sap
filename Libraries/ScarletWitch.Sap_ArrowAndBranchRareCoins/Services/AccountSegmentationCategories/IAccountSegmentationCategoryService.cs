using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.AccountSegmentationCategories
{
	/// <summary>
	/// AccountSegmentationCategory service interface
	/// </summary>
	public interface IAccountSegmentationCategoryService
	{
		/// <summary>
		/// Inserts a <see cref="AccountSegmentationCategory"/>.
		/// </summary>
		/// <param name="x">The <see cref="AccountSegmentationCategory"/>.</param>
		void Insert(AccountSegmentationCategory x);
		/// <summary>
		/// Truncates the <see cref="AccountSegmentationCategory"/> table.
		/// </summary>
		void TruncateTable();
	}
}