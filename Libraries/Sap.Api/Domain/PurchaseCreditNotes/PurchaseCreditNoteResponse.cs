using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.PurchaseCreditNotes
{
	public partial class PurchaseCreditNoteResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<PurchaseCreditNote> PurchaseCreditNotes;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public PurchaseCreditNoteResponse()
		{
			PurchaseCreditNotes = new List<PurchaseCreditNote>();
		}
	}
}