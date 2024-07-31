using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual ChecksforPayment ToSql(Sap.Api.Domain.ChecksforPayments.ChecksforPayment x)
		{
			return new ChecksforPayment {
				CheckKey = x.CheckKey,
				AccountNumber = x.AccountNumber,
				BankCode = x.BankCode,
				Branch = x.Branch,
				CardOrAccount = x.CardOrAccount,
				CheckNumber = x.CheckNumber,
				CountryCode = x.CountryCode,
				CustomerAccountCode = x.CustomerAccountCode,
				Details = x.Details,
				VendorCode = x.VendorCode,
			};
		}
	}
}