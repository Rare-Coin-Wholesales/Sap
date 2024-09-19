using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.JournalEntryDocumentTypes
{
	/// <summary>
	/// JournalEntryDocumentType service interface
	/// </summary>
	public interface IJournalEntryDocumentTypeService
	{
		/// <summary>
		/// Inserts a <see cref="JournalEntryDocumentType"/>.
		/// </summary>
		/// <param name="x">The <see cref="JournalEntryDocumentType"/>.</param>
		void Insert(JournalEntryDocumentType x);
		/// <summary>
		/// Truncates the <see cref="JournalEntryDocumentType"/> table.
		/// </summary>
		void TruncateTable();
	}
}