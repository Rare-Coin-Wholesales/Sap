namespace Sap.Core.Domain.IncomingPayments
{
	public partial class IncomingPaymentRequest : BaseRequest
	{
		public const string ACTION = "IncomingPayments";
		public int? DocEntry;
		public string? CardCode;
		public string? CashAccount;
		public string? CashSum;
		public string? DocNum;
		public string? DocType;
		public string? HandWritten;
		public string? Remarks;

		public IncomingPaymentRequest() { }

		public IncomingPaymentRequest(int docEntry)
		{
			DocEntry = docEntry;
		}

		public IncomingPaymentRequest(IncomingPayment x)
		{
			DocEntry = x.DocEntry;
			CardCode = x.CardCode;
			CashAccount = x.CashAccount;
			CashSum = x.CashSum;
			DocNum = x.DocNum;
			DocType = x.DocType;
			HandWritten = x.HandWritten;
			Remarks = x.Remarks;
		}
	}
}