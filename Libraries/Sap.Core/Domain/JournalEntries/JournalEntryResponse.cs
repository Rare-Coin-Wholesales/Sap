using Newtonsoft.Json;

namespace Sap.Core.Domain.JournalEntries
{
	public partial class JournalEntryResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<JournalEntry> JournalEntries;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public JournalEntryResponse()
		{
			JournalEntries = new List<JournalEntry>();
		}
	}
}