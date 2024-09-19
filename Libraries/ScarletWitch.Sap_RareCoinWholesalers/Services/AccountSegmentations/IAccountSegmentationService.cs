using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.AccountSegmentations
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