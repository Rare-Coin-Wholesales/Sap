namespace Sap.Core.Domain.ChecksforPayments
{
	public partial class ChecksforPaymentRequest : BaseRequest
	{
		public const string ACTION = "ChecksforPayment";
		public int? CheckKey;
		public string AccountNumber;
		public string BankCode;
		public string Branch;
		public string CardOrAccount;
		public string CheckNumber;
		public string CountryCode;
		public string CustomerAccountCode;
		public string Details;
		public string VendorCode;

		public ChecksforPaymentRequest() { }

		public ChecksforPaymentRequest(int checkKey)
		{
			CheckKey = checkKey;
		}

		public ChecksforPaymentRequest(ChecksforPayment x)
		{
			AccountNumber = x.AccountNumber;
			BankCode = x.BankCode;
			Branch = x.Branch;
			CardOrAccount = x.CardOrAccount;
			CheckKey = x.CheckKey;
			CheckNumber = x.CheckNumber;
			CountryCode = x.CountryCode;
			CustomerAccountCode = x.CustomerAccountCode;
			Details = x.Details;
			VendorCode = x.VendorCode;
		}
	}
}