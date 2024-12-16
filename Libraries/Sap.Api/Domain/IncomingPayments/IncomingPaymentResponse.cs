using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sap.Api.Domain.IncomingPayments
{
	public partial class IncomingPaymentResponse : BaseResponse
	{
		[JsonProperty("value")]
		public IList<IncomingPayment> IncomingPayments;

		public IncomingPaymentResponse()
		{
			IncomingPayments = new List<IncomingPayment>();
		}
	}
}