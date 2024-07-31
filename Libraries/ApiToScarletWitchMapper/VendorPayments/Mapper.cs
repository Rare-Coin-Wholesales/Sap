using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual VendorPayment ToSql(Sap.Api.Domain.VendorPayments.VendorPayment x)
		{
			return new VendorPayment {
				DocEntry = x.DocEntry,
				CardCode = x.CardCode,
				DocNum = x.DocNum,
				DocType = x.DocType,
				HandWritten = x.HandWritten,
				Remarks = x.Remarks,
				TransferAccount = x.TransferAccount,
				TransferDate = x.TransferDate,
				TransferSum = x.TransferSum,
			};
		}
	}
}