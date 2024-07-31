using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.HouseBankAccounts
{
	public partial class HouseBankAccountResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<HouseBankAccount> HouseBankAccounts;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public HouseBankAccountResponse()
		{
			HouseBankAccounts = new List<HouseBankAccount>();
		}
	}
}