using Newtonsoft.Json;

namespace Sap.Core.Domain.AccountSegmentationCategories
{
	public partial class AccountSegmentationCategoryResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<AccountSegmentationCategory> AccountSegmentationCategories;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public AccountSegmentationCategoryResponse()
		{
			AccountSegmentationCategories = new List<AccountSegmentationCategory>();
		}
	}
}