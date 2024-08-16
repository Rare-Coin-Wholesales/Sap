using Newtonsoft.Json;
using Sap.Core;

namespace Sap.Api.Domain.BusinessPartners
{
	public partial class BPPaymentMethod : BaseEntity
	{
		[JsonProperty("PaymentMethodCode")]
		public string PaymentMethodCode;

		[JsonProperty("RowNumber")]
		public string RowNumber;

		[JsonProperty("BPCode")]
		public string BPCode;
	}
}