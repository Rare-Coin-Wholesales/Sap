using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace Sap.Core.Domain.TransactionCodes
{
	public partial class TransactionCodeResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<TransactionCode> TransactionCodes;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public TransactionCodeResponse()
		{
			TransactionCodes = new List<TransactionCode>();
		}
	}
}