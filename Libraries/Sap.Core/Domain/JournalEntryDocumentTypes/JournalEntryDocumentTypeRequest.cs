namespace Sap.Core.Domain.JournalEntryDocumentTypes
{
	public partial class JournalEntryDocumentTypeRequest : BaseRequest
	{
		public const string ACTION = "JournalEntryDocumentTypes";
		public string? JournalEntryType;
		public string? DocTypeDescription;
		public string? ShortName;

		public JournalEntryDocumentTypeRequest() { }

		public JournalEntryDocumentTypeRequest(string journalEntryType)
		{
			JournalEntryType = journalEntryType;
		}

		public JournalEntryDocumentTypeRequest(JournalEntryDocumentType x)
		{
			JournalEntryType = x.JournalEntryType;
			DocTypeDescription = x.DocTypeDescription;
			ShortName = x.ShortName;
		}
	}
}