using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace Sap.ApiToScarAabrcMapper
{
	public partial class Mapper
	{
		public virtual Deposit ToSql(Api.Domain.Deposits.Deposit x)
		{
			return new Deposit {
				AbsEntry = x.AbsEntry,
				DepositAccount = x.DepositAccount,
				DepositType = x.DepositType,
				JournalRemarks = x.JournalRemarks,
				VoucherAccount = x.VoucherAccount,
			};
		}
	}
}