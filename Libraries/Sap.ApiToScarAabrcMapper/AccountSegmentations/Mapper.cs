using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace Sap.ApiToScarAabrcMapper
{
	public partial class Mapper
	{
		public virtual AccountSegmentation ToSql(Api.Domain.AccountSegmentations.AccountSegmentation x)
		{
			return new AccountSegmentation {
				Name = x.Name,
				Numerator = x.Numerator,
				Size = x.Size,
				Type = x.Type,
			};
		}
	}
}