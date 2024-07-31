using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.PurchaseQuotations
{
	public partial class PurchaseQuotationResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<PurchaseQuotation> PurchaseQuotations;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public PurchaseQuotationResponse()
		{
			PurchaseQuotations = new List<PurchaseQuotation>();
		}
	}
}