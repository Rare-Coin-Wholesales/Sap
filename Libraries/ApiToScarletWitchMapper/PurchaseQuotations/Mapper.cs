using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual PurchaseQuotation ToSql(Sap.Core.Domain.PurchaseQuotations.PurchaseQuotation x)
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