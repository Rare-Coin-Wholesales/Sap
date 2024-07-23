namespace Sap.Core.Domain.AccountCategories
{
	public partial class AccountCategoryRequest : BaseRequest
	{
		public const string ACTION = "AccountCategory";
		public int? CategoryCode;
		public string CategoryName;
		public string CategorySource;

		public AccountCategoryRequest() { }

		public AccountCategoryRequest(int id)
		{
			CategoryCode = id;
		}

		public AccountCategoryRequest(int? categoryCode, string categoryName, string categorySource)
		{
			CategoryCode = categoryCode;
			CategoryName = categoryName;
			CategorySource = categorySource;
		}
	}
}