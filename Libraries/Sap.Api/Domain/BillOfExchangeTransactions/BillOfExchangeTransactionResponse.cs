using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.BillOfExchangeTransactions
{
	public partial class BillOfExchangeTransactionResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<BillOfExchangeTransaction> BillOfExchangeTransactions;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public BillOfExchangeTransactionResponse()
		{
			BillOfExchangeTransactions = new List<BillOfExchangeTransaction>();
		}
	}
}