using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.ChartOfAccounts
{
	public partial class ChartOfAccountResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<ChartOfAccount> ChartOfAccounts;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public ChartOfAccountResponse()
		{
			ChartOfAccounts = new List<ChartOfAccount>();
		}
	}
}