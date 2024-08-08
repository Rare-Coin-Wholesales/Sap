using System.Collections.Generic;
using Newtonsoft.Json;

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