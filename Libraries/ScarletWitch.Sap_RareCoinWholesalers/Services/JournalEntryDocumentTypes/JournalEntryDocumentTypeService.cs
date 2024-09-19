using System;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.JournalEntryDocumentTypes
{
	/// <summary>
	/// JournalEntryDocumentType service
	/// </summary>
	public partial class JournalEntryDocumentTypeService : BaseService, IJournalEntryDocumentTypeService
	{
		/// <inheritdoc/>
		public virtual void Insert(JournalEntryDocumentType x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			if (x.JournalEntryType == null)
				throw new Exception("'JournalEntryType' is required.");
			#endregion

			try {
				_dbContext.JournalEntryDocumentTypes.Add(x);
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
			base.TruncateTable("JournalEntryDocumentType");
		}
	}
}