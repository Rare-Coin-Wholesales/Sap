using Newtonsoft.Json;

namespace Sap.Core.Domain.Quotations
{
	public partial class QuotationResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<Quotation> Quotations;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public QuotationResponse()
		{
			Quotations = new List<Quotation>();
		}
	}
}