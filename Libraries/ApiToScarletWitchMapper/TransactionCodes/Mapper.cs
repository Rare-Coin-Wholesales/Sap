using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual TransactionCode ToSql(Sap.Core.Domain.TransactionCodes.TransactionCode x)
		{
			return new TransactionCode {
				Code = x.Code,
				Description = x.Description,
			};
		}
	}
}