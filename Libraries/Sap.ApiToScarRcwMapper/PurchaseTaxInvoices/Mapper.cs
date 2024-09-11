using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace Sap.ApiToScarRcwMapper
{
	public partial class Mapper
	{
		public virtual PurchaseTaxInvoice ToSql(Api.Domain.PurchaseTaxInvoices.PurchaseTaxInvoice x)
		{
			return new PurchaseTaxInvoice {
				DocEntry = x.DocEntry,
				CardCode = x.CardCode,
				Comments = x.Comments,
				DocNum = x.DocNum,
				DocType = x.DocType,
			};
		}
	}
}