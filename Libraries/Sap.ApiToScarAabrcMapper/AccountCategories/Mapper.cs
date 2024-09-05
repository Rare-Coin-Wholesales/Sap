using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace Sap.ApiToScarAabrcMapper
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