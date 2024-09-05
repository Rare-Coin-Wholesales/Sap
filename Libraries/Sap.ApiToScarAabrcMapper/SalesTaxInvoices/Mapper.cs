using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace Sap.ApiToScarAabrcMapper
{
	public partial class Mapper
	{
		public virtual SalesTaxInvoice ToSql(Api.Domain.SalesTaxInvoices.SalesTaxInvoice x)
		{
			return new SalesTaxInvoice {
				DocEntry = x.DocEntry,
				CardCode = x.CardCode,
				Comments = x.Comments,
				DocNum = x.DocNum,
				DocType = x.DocType,
			};
		}
	}
}