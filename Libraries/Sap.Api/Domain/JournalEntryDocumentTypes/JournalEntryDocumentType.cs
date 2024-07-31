using Sap.Core;

namespace Sap.Api.Domain.JournalEntryDocumentTypes
{
	public partial class JournalEntryDocumentType : BaseEntity
	{
		public string JournalEntryType;
		public string DocTypeDescription;
		public string ShortName;
	}
}