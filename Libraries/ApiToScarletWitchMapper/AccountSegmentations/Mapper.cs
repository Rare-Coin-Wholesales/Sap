using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual AccountSegmentation ToSql(Sap.Api.Domain.AccountSegmentations.AccountSegmentation x)
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