using Newtonsoft.Json;

namespace Sap.Core.Domain.ChecksforPayments
{
	public partial class ChecksforPaymentResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<ChecksforPayment> ChecksforPayments;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public ChecksforPaymentResponse()
		{
			ChecksforPayments = new List<ChecksforPayment>();
		}
	}
}