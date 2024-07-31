using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.Deposits
{
	public partial class DepositResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<Deposit> Deposits;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public DepositResponse()
		{
			Deposits = new List<Deposit>();
		}
	}
}