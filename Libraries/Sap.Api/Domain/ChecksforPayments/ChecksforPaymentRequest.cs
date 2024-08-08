namespace Sap.Api.Domain.ChecksforPayments
{
	public partial class ChecksforPaymentRequest : BaseRequest
	{
		public const string ACTION = "ChecksforPayment";
		#region Fields
		public string CheckKey;
		public string CheckNumber;
		public string BankCode;
		public string Branch;
		public string BankName;
		public string CheckDate;
		public string AccountNumber;
		public string Details;
		public string JournalEntryReference;
		public string PaymentDate;
		public string PaymentNo;
		public string CheckAmount;
		public string Transferable;
		public string VendorCode;
		public string CheckCurrency;
		public string Canceled;
		public string CardOrAccount;
		public string Printed;
		public string VendorName;
		public string Signature;
		public string CustomerAccountCode;
		public string TransactionNumber;
		public string Address;
		public string CreateJournalEntry;
		public string UpdateDate;
		public string CreationDate;
		public string TaxTotal;
		public string TaxDate;
		public string DeductionRefundAmount;
		public string PrintedBy;
		public string CountryCode;
		public string TotalinWords;
		public string AddressName;
		public string ManualCheck;
		public string AttachmentEntry;
		public string ECheck;
		public string PrintConfirm;
		#endregion

		#region Constructors
		public ChecksforPaymentRequest() { }

		public ChecksforPaymentRequest(string checkKey)
		{
			CheckKey = checkKey;
		}

		public ChecksforPaymentRequest(ChecksforPayment x)
		{
			CheckKey = x.CheckKey;
			CheckNumber = x.CheckNumber;
			BankCode = x.BankCode;
			Branch = x.Branch;
			BankName = x.BankName;
			CheckDate = x.CheckDate;
			AccountNumber = x.AccountNumber;
			Details = x.Details;
			JournalEntryReference = x.JournalEntryReference;
			PaymentDate = x.PaymentDate;
			PaymentNo = x.PaymentNo;
			CheckAmount = x.CheckAmount;
			Transferable = x.Transferable;
			VendorCode = x.VendorCode;
			CheckCurrency = x.CheckCurrency;
			Canceled = x.Canceled;
			CardOrAccount = x.CardOrAccount;
			Printed = x.Printed;
			VendorName = x.VendorName;
			Signature = x.Signature;
			CustomerAccountCode = x.CustomerAccountCode;
			TransactionNumber = x.TransactionNumber;
			Address = x.Address;
			CreateJournalEntry = x.CreateJournalEntry;
			UpdateDate = x.UpdateDate;
			CreationDate = x.CreationDate;
			TaxTotal = x.TaxTotal;
			TaxDate = x.TaxDate;
			DeductionRefundAmount = x.DeductionRefundAmount;
			PrintedBy = x.PrintedBy;
			CountryCode = x.CountryCode;
			TotalinWords = x.TotalinWords;
			AddressName = x.AddressName;
			ManualCheck = x.ManualCheck;
			AttachmentEntry = x.AttachmentEntry;
			ECheck = x.ECheck;
			PrintConfirm = x.PrintConfirm;
		}
		#endregion
	}
}