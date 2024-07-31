using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.ChecksforPayments
{
	public partial class ChecksforPaymentResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<ChecksforPayment> ChecksforPayments;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public ChecksforPaymentResponse()
		{
			ChecksforPayments = new List<ChecksforPayment>();
		}
	}
}