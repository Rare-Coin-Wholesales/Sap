using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.JournalEntries
{
	/// <summary>
	/// JournalEntry service interface
	/// </summary>
	public interface IJournalEntryService
	{
		/// <summary>
		/// Inserts a <see cref="JournalEntry"/>.
		/// </summary>
		/// <param name="x">The <see cref="JournalEntry"/>.</param>
		void Insert(JournalEntry x);
		/// <summary>
		/// Inserts a <see cref="JournalEntryLine"/>.
		/// </summary>
		/// <param name="x">The <see cref="JournalEntryLine"/>.</param>
		void InsertJournalEntryLine(JournalEntryLine x);
		/// <summary>
		/// Truncates the <see cref="JournalEntry"/> table.
		/// </summary>
		void TruncateTable();
	}
}