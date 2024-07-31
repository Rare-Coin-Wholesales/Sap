using Sap.Core;

namespace Sap.Api.Domain.AccountCategories
{
	public partial class AccountCategory : BaseEntity
	{
		public int? CategoryCode;
		public string CategoryName;
		public string CategorySource;
	}
}