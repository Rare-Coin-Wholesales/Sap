using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.SalesTaxInvoices
{
	public partial class SalesTaxInvoiceResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<SalesTaxInvoice> SalesTaxInvoices;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public SalesTaxInvoiceResponse()
		{
			SalesTaxInvoices = new List<SalesTaxInvoice>();
		}
	}
}