using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual PurchaseCreditNote ToSql(Sap.Core.Domain.PurchaseCreditNotes.PurchaseCreditNote x)
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