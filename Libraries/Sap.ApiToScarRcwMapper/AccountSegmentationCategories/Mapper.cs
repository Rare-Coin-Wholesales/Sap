using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
{
	public partial class Mapper
	{
		public virtual AccountSegmentationCategory ToSql(Api.Domain.AccountSegmentationCategories.AccountSegmentationCategory x)
		{
			return new AccountSegmentationCategory {
				Code = x.Code,
				Name = x.Name,
				SegmentID = x.SegmentID,
				ShortName = x.ShortName,
			};
		}
	}
}