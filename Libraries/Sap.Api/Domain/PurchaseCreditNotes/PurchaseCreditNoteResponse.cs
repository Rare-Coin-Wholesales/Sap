using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sap.Api.Domain.PurchaseCreditNotes
{
	public partial class PurchaseCreditNoteResponse : BaseResponse
	{
		[JsonProperty("value")]
		public IList<PurchaseCreditNote> PurchaseCreditNotes;

		public PurchaseCreditNoteResponse()
		{
			PurchaseCreditNotes = new List<PurchaseCreditNote>();
		}
	}
}