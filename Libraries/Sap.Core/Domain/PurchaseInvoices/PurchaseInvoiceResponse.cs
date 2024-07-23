using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace Sap.Core.Domain.PurchaseInvoices
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