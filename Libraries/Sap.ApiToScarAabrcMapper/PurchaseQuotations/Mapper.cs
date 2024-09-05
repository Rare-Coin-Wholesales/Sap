using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace Sap.ApiToScarAabrcMapper
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