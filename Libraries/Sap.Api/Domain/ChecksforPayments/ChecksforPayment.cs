using System.Collections.Generic;
using Sap.Core;

namespace Sap.Api.Domain.ChecksforPayments
{
	public partial class ChecksforPayment : BaseEntity
	{
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
		public IList<ChecksforPaymentLine> ChecksforPaymentLines;
		public IList<ChecksforPaymentPrintStatus> ChecksforPaymentPrintStatus;
		public IList<object> ChecksforPaymentDocumentReferences;
		#endregion

		public ChecksforPayment()
		{
			ChecksforPaymentLines = new List<ChecksforPaymentLine>();
			ChecksforPaymentPrintStatus = new List<ChecksforPaymentPrintStatus>();
			ChecksforPaymentDocumentReferences = new List<object>();
		}
	}
}