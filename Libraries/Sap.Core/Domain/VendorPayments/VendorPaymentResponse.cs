using Newtonsoft.Json;

namespace Sap.Core.Domain.VendorPayments
{
	public partial class VendorPaymentResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<VendorPayment> VendorPayments;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public VendorPaymentResponse()
		{
			VendorPayments = new List<VendorPayment>();
		}
	}
}