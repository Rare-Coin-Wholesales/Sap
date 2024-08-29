using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.AccountSegmentations
{
	/// <summary>
	/// AccountSegmentation service interface
	/// </summary>
	public interface IAccountSegmentationService
	{
		/// <summary>
		/// Inserts a <see cref="AccountSegmentation"/>.
		/// </summary>
		/// <param name="x">The <see cref="AccountSegmentation"/>.</param>
		void Insert(AccountSegmentation x);
		/// <summary>
		/// Truncates the <see cref="AccountSegmentation"/> table.
		/// </summary>
		void TruncateTable();
	}
}