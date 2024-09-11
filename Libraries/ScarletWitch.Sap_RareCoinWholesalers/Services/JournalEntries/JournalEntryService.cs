using System;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.JournalEntries
{
	/// <summary>
	/// JournalEntry service
	/// </summary>
	public partial class JournalEntryService : BaseService, IJournalEntryService
	{
		/// <inheritdoc/>
		public virtual void Insert(JournalEntry x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.JdtNum == null)
				throw new Exception("'JdtNum' is required.");
			#endregion

			try {
				_dbContext.JournalEntries.Add(x);
				_dbContext.SaveChanges();
			}

			catch (Exception ex) {
				#region Handle Exception
				var msg = GetFullErrorText(ex);

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		/// <inheritdoc/>
		public virtual void InsertJournalEntryLine(JournalEntryLine x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			#endregion

			try {
				_dbContext.JournalEntryLines.Add(x);
				_dbContext.SaveChanges();
			}

			catch (Exception ex) {
				#region Handle Exception
				var msg = GetFullErrorText(ex);

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("JournalEntry");
			base.TruncateTable("JournalEntryLine");
		}
	}
}