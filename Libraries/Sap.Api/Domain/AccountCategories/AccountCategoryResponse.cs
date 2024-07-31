using System.Collections.Generic;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.AccountCategories
{
	public partial class AccountCategoryResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<AccountCategory> AccountCategories;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public AccountCategoryResponse()
		{
			AccountCategories = new List<AccountCategory>();
		}
	}
}