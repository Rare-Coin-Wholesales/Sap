using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sap.Api.Domain.CreditNotes
{
	public partial class CreditNoteResponse : BaseResponse
	{
		[JsonProperty("value")]
		public IList<CreditNote> CreditNotes;

		public CreditNoteResponse()
		{
			CreditNotes = new List<CreditNote>();
		}
	}
}