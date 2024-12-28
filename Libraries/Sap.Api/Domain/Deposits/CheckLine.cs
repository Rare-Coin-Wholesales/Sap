using System;

namespace Sap.Api.Domain.Deposits
{
	public partial class CheckLine
	{
		public int? DepositAbsEntry;
		public int? CheckKey;
		public int? CheckNumber;
		public string Bank;
		public string Branch;
		public string CashCheck;
		public DateTime? CheckDate;
		public string Customer;
		public decimal? CheckAmount;
		public string Deposited;
		public string Transferred;
		public string AccountNumber;
		public string CheckCurrency;
	}
}