using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace Sap.ApiToScarAabrcMapper
{
	public partial class Mapper
	{
		public virtual CreditNote ToSql(Api.Domain.CreditNotes.CreditNote x)
		{
			return new CreditNote {
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