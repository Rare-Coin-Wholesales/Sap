using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
{
	public partial class Mapper
	{
		public virtual AccountCategory ToSql(Api.Domain.AccountCategories.AccountCategory x)
		{
			return new AccountCategory {
				CategoryCode = x.CategoryCode,
				CategoryName = x.CategoryName,
				CategorySource = x.CategorySource,
			};
		}
	}
}