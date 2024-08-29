using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace Sap.ApiToScarAabwMapper
{
	public partial class Mapper
	{
		public virtual BillOfExchangeTransaction ToSql(Api.Domain.BillOfExchangeTransactions.BillOfExchangeTransaction x)
		{
			return new BillOfExchangeTransaction {
				BOETransactionkey = x.BOETransactionkey,
				Code = x.Code,
				IsBoeReconciled = x.IsBoeReconciled,
				StatusFrom = x.StatusFrom,
				StatusTo = x.StatusTo,
				TransactionDate = x.TransactionDate,
			};
		}
	}
}