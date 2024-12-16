using System;
using Sap.Core;

namespace Sap.Api.Domain.IncomingPayments
{
	public partial class PaymentCheck : BaseEntity
	{
		#region Fields
		public int? LineNum;
		public DateTime? DueDate;
		public int? CheckNumber;
		public string BankCode;
		public string Branch;
		public string AccounttNum;
		public string Details;
		public string Trnsfrable;
		public decimal? CheckSum;
		public string Currency;
		public string CountryCode;
		public int? CheckAbsEntry;
		public string CheckAccount;
		public string ManualCheck;
		public string FiscalID;
		public string OriginallyIssuedBy;
		public string Endorse;
		public string EndorsableCheckNo;
		public string ECheck;
		#endregion
	}
}