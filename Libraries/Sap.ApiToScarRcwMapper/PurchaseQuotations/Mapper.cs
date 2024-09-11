using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
{
	public partial class Mapper
	{
		public virtual PurchaseQuotation ToSql(Api.Domain.PurchaseQuotations.PurchaseQuotation x)
		{
			return new PurchaseQuotation {
				DocEntry = x.DocEntry,
				RequriedDate = x.RequriedDate,
				CardCode = x.CardCode,
				Code = x.Code,
				Comments = x.Comments,
				Description = x.Description,
				DocNum = x.DocNum,
				DocType = x.DocType,
			};
		}
	}
}