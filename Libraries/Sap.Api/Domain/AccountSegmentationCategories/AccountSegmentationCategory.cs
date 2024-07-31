using Sap.Core;

namespace Sap.Api.Domain.AccountSegmentationCategories
{
	public partial class AccountSegmentationCategory : BaseEntity
	{
		public int? SegmentID;
		public string Code;
		public string Name;
		public string ShortName;
	}
}