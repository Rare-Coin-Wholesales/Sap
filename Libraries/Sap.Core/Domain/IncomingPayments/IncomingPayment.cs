namespace Sap.Core.Domain.IncomingPayments
{
	public partial class IncomingPayment : BaseEntity
	{
		public int? DocEntry;
		public IList<CashFlowAssignment> CashFlowAssignments;
		public string? CardCode;
		public string? CashAccount;
		public string? CashSum;
		public string? DocNum;
		public string? DocType;
		public string? HandWritten;
		public string? Remarks;

		public IncomingPayment() {
			CashFlowAssignments = new List<CashFlowAssignment>();
		}
	}

	public class CashFlowAssignment
	{
		public string? AmountLC;
		public string? PaymentMeans;
	}
}