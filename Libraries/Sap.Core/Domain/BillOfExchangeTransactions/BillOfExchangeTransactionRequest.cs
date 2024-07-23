namespace Sap.Core.Domain.BillOfExchangeTransactions
{
	public partial class BillOfExchangeTransactionRequest : BaseRequest
	{
		#region Fields
		public const string ACTION = "BillOfExchangeTransactions";
		public string BOETransactionkey;
		public string Code;
		public string IsBoeReconciled;
		public string StatusFrom;
		public string StatusTo;
		public string TransactionDate;
		#endregion

		public BillOfExchangeTransactionRequest() { }

		public BillOfExchangeTransactionRequest(string code)
		{
			Code = code;
		}

		public BillOfExchangeTransactionRequest(BillOfExchangeTransaction x)
		{
			BOETransactionkey = x.BOETransactionkey;
			Code = x.Code;
			IsBoeReconciled = x.IsBoeReconciled;
			StatusFrom = x.StatusFrom;
			StatusTo = x.StatusTo;
			TransactionDate = x.TransactionDate;
		}
	}
}