using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace Sap.Core.Domain.CreditNotes
{
	public partial class CreditNoteResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<CreditNote> CreditNotes;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public CreditNoteResponse()
		{
			CreditNotes = new List<CreditNote>();
		}
	}
}