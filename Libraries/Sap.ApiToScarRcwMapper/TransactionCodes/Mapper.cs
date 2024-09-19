using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
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