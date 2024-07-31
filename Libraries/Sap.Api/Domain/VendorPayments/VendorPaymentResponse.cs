using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.VendorPayments
{
	public partial class VendorPaymentResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<VendorPayment> VendorPayments;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public VendorPaymentResponse()
		{
			VendorPayments = new List<VendorPayment>();
		}
	}
}