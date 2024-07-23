namespace Sap.Core.Domain.Deposits
{
	public partial class DepositRequest : BaseRequest
	{
		public const string ACTION = "Deposits";
		public int? AbsEntry;
		public string DepositAccount;
		public string DepositNumber;
		public string DepositType;
		public string JournalRemarks;
		public string VoucherAccount;

		public DepositRequest() { }

		public DepositRequest(int absEntry)
		{
			AbsEntry = absEntry;
		}

		public DepositRequest(Deposit x)
		{
			AbsEntry = x.AbsEntry;
			DepositAccount = x.DepositAccount;
			DepositNumber = x.DepositNumber;
			DepositType = x.DepositType;
			JournalRemarks = x.JournalRemarks;
			VoucherAccount = x.VoucherAccount;
		}
	}
}