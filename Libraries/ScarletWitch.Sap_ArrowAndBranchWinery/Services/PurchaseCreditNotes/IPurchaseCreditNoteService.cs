using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseCreditNotes
{
	/// <summary>
	/// PurchaseCreditNote service interface
	/// </summary>
	public interface IPurchaseCreditNoteService
	{
		/// <summary>
		/// Inserts a <see cref="PurchaseCreditNote"/>.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseCreditNote"/>.</param>
		void Insert(PurchaseCreditNote x);
		/// <summary>
		/// Truncates the <see cref="PurchaseCreditNote"/> table.
		/// </summary>
		void TruncateTable();
	}
}