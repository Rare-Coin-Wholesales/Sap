using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual AccountSegmentationCategory ToSql(Sap.Api.Domain.AccountSegmentationCategories.AccountSegmentationCategory x)
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