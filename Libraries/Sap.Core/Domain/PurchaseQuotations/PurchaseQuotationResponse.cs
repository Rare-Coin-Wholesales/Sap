using Newtonsoft.Json;

namespace Sap.Core.Domain.PurchaseQuotations
{
	public partial class PurchaseQuotationResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<PurchaseQuotation> PurchaseQuotations;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public PurchaseQuotationResponse()
		{
			PurchaseQuotations = new List<PurchaseQuotation>();
		}
	}
}