using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
{
	public partial class Mapper
	{
		public virtual PurchaseCreditNote ToSql(Api.Domain.PurchaseCreditNotes.PurchaseCreditNote x)
		{
			return new PurchaseCreditNote {
				DocEntry = x.DocEntry,
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