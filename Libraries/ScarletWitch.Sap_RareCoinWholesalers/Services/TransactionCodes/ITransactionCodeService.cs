using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.TransactionCodes
{
	/// <summary>
	/// TransactionCode service interface
	/// </summary>
	public interface ITransactionCodeService
	{
		/// <summary>
		/// Inserts a <see cref="TransactionCode"/>.
		/// </summary>
		/// <param name="x">The <see cref="TransactionCode"/>.</param>
		void Insert(TransactionCode x);
		/// <summary>
		/// Truncates the <see cref="TransactionCode"/> table.
		/// </summary>
		void TruncateTable();
	}
}