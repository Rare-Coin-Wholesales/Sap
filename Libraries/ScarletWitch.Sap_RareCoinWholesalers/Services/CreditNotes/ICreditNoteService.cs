using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.CreditNotes
{
	/// <summary>
	/// CreditNote service interface
	/// </summary>
	public interface ICreditNoteService
	{
		/// <summary>
		/// Inserts a <see cref="CreditNote"/>.
		/// </summary>
		/// <param name="x">The <see cref="CreditNote"/>.</param>
		void Insert(CreditNote x);
		/// <summary>
		/// Truncates the <see cref="CreditNote"/> table.
		/// </summary>
		void TruncateTable();
	}
}