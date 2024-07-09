using Newtonsoft.Json;

namespace Sap.Core.Domain.PurchaseCreditNotes
{
	public partial class PurchaseCreditNoteResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<PurchaseCreditNote> PurchaseCreditNotes;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public PurchaseCreditNoteResponse()
		{
			PurchaseCreditNotes = new List<PurchaseCreditNote>();
		}
	}
}