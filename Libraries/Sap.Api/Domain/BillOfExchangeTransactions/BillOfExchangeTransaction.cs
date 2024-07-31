using System.Collections.Generic;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.BillOfExchangeTransactions
{
	public partial class BillOfExchangeTransaction : BaseEntity
	{
		public IList<BillOfExchangeTransactionLine> BillOfExchangeTransactionLines;
		public string BOETransactionkey;
		public string Code;
		public string IsBoeReconciled;
		public string StatusFrom;
		public string StatusTo;
		public string TransactionDate;

		public BillOfExchangeTransaction() {
			BillOfExchangeTransactionLines = new List<BillOfExchangeTransactionLine>();
		}
	}

	public class BillOfExchangeTransactionLine
	{
		public int? BillOfExchangeNo;
		public string BillOfExchangeDueDate;
		public string BillOfExchangeType;
	}
}