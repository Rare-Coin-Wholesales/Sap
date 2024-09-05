using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace Sap.ApiToScarAabrcMapper
{
	public partial class Mapper
	{
		public virtual TransactionCode ToSql(Api.Domain.TransactionCodes.TransactionCode x)
		{
			return new TransactionCode {
				Code = x.Code,
				Description = x.Description,
			};
		}
	}
}