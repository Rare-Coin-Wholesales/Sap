using Newtonsoft.Json;

namespace Sap.Core.Domain.PurchaseOrders
{
	public partial class PurchaseOrderResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<PurchaseOrder> PurchaseOrders;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public PurchaseOrderResponse()
		{
			PurchaseOrders = new List<PurchaseOrder>();
		}
	}
}