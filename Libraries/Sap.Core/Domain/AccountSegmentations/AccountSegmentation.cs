using Newtonsoft.Json;
using Sap.Core.Domain.AccountSegmentationCategories;

namespace Sap.Core.Domain.AccountSegmentations
{
	public partial class AccountSegmentation : BaseEntity
	{
		public int? Numerator;
		public string? Name;
		public int? Size;
		public string? Type;
		[JsonProperty("AccountSegmentationsCategories")]
		public IList<AccountSegmentationCategory> AccountSegmentationsCategories;

		public AccountSegmentation() {
			AccountSegmentationsCategories = new List<AccountSegmentationCategory>();
		}
	}
}