using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.IncomingPayments
{
	public partial class IncomingPaymentResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<IncomingPayment> IncomingPayments;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public IncomingPaymentResponse()
		{
			IncomingPayments = new List<IncomingPayment>();
		}
	}
}