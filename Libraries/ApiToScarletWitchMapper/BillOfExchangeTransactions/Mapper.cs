using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ApiToScarletWitchMapper
{
	public partial class Mapper
	{
		public virtual BillOfExchangeTransaction ToSql(Sap.Core.Domain.BillOfExchangeTransactions.BillOfExchangeTransaction x)
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