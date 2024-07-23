using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace Sap.Core.Domain.PurchaseTaxInvoices
{
	public partial class PurchaseTaxInvoiceResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<PurchaseTaxInvoice> PurchaseTaxInvoices;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public PurchaseTaxInvoiceResponse()
		{
			PurchaseTaxInvoices = new List<PurchaseTaxInvoice>();
		}
	}
}