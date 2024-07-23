using System.Collections.Generic;

namespace Sap.Core.Domain.Deposits
{
	public partial class Deposit : BaseEntity
	{
		public int? AbsEntry;
		public IList<CreditLine> CreditLines;
		public string DepositAccount;
		public string DepositNumber;
		public string DepositType;
		public string JournalRemarks;
		public string VoucherAccount;

		public Deposit()
		{
			CreditLines = new List<CreditLine>();
		}
	}

	public class CreditLine
	{
		public int? AbsId;
	}
}