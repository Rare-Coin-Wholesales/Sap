using System.Collections.Generic;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.AccountSegmentationCategories
{
	public partial class AccountSegmentationCategoryResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<AccountSegmentationCategory> AccountSegmentationCategories;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public AccountSegmentationCategoryResponse()
		{
			AccountSegmentationCategories = new List<AccountSegmentationCategory>();
		}
	}
}