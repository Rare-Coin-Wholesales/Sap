using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.CreditNotes
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