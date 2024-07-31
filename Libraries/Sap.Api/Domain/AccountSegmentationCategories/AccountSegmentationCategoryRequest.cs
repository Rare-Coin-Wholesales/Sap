using Sap.Core;

namespace Sap.Api.Domain.AccountSegmentationCategories
{
	public partial class AccountSegmentationCategoryRequest : BaseRequest
	{
		public const string ACTION = "AccountSegmentationCategories";
		public int? SegmentID;
		public string Code;
		public string Name;
		public string ShortName;

		public AccountSegmentationCategoryRequest() { }

		public AccountSegmentationCategoryRequest(int? segmentID, string code)
		{
			SegmentID = segmentID;
			Code = code;
		}

		public AccountSegmentationCategoryRequest(AccountSegmentationCategory x)
		{
			SegmentID = x.SegmentID;
			Code = x.Code;
			Name = x.Name;
			ShortName = x.ShortName;
		}
	}
}