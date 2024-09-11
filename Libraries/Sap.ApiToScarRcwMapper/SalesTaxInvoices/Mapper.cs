using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
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