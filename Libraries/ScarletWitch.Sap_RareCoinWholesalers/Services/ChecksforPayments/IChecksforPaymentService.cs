using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.ChecksforPayments
{
	/// <summary>
	/// ChecksforPayment service interface
	/// </summary>
	public interface IChecksforPaymentService
	{
		/// <summary>
		/// Inserts a <see cref="ChecksforPayment"/>.
		/// </summary>
		/// <param name="x">The <see cref="ChecksforPayment"/>.</param>
		void Insert(ChecksforPayment x);
		/// <summary>
		/// Inserts a <see cref="ChecksforPaymentLine"/>.
		/// </summary>
		/// <param name="x">The <see cref="ChecksforPaymentLine"/>.</param>
		void Insert(ChecksforPaymentLine x);
		/// <summary>
		/// Truncates the <see cref="ChecksforPayment"/> table.
		/// </summary>
		void TruncateTable();
	}
}