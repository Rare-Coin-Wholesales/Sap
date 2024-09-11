using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.Deposits
{
	/// <summary>
	/// Deposit service interface
	/// </summary>
	public interface IDepositService
	{
		/// <summary>
		/// Inserts a <see cref="Deposit"/>.
		/// </summary>
		/// <param name="x">The <see cref="Deposit"/>.</param>
		void Insert(Deposit x);
		/// <summary>
		/// Truncates the <see cref="Deposit"/> table.
		/// </summary>
		void TruncateTable();
	}
}