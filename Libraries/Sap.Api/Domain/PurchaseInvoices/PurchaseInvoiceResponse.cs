using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sap.Api.Domain.PurchaseInvoices
{
	public partial class PurchaseInvoiceResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<PurchaseInvoice> PurchaseInvoices;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public PurchaseInvoiceResponse()
		{
			PurchaseInvoices = new List<PurchaseInvoice>();
		}
	}
}