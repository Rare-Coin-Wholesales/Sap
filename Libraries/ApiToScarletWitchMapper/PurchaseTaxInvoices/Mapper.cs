using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual PurchaseTaxInvoice ToSql(Sap.Core.Domain.PurchaseTaxInvoices.PurchaseTaxInvoice x)
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