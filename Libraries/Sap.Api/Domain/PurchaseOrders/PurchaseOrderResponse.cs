using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.PurchaseOrders
{
	public partial class PurchaseOrderResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<PurchaseOrder> PurchaseOrders;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public PurchaseOrderResponse()
		{
			PurchaseOrders = new List<PurchaseOrder>();
		}
	}
}