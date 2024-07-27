using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual Deposit ToSql(Sap.Core.Domain.Deposits.Deposit x)
		{
			return new Deposit {
				AbsEntry = x.AbsEntry,
				DepositAccount = x.DepositAccount,
				DepositNumber = x.DepositNumber,
				DepositType = x.DepositType,
				JournalRemarks = x.JournalRemarks,
				VoucherAccount = x.VoucherAccount,
			};
		}
	}
}