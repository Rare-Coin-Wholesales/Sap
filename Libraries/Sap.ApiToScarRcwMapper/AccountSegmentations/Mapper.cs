using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
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