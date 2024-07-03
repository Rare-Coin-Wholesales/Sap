using Newtonsoft.Json;

namespace Sap.Core.Domain.IncomingPayments
{
	public partial class IncomingPaymentResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<IncomingPayment> IncomingPayments;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public IncomingPaymentResponse()
		{
			IncomingPayments = new List<IncomingPayment>();
		}
	}
}