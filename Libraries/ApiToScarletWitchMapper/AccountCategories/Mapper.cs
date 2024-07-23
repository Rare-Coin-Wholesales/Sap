using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual AccountCategory ToSql(Sap.Core.Domain.AccountCategories.AccountCategory x)
		{
			return new AccountCategory {
				CategoryCode = x.CategoryCode,
				CategoryName = x.CategoryName,
				CategorySource = x.CategorySource,
			};
		}
	}
}