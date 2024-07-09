using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.VendorPayments
{
	public partial class VendorPaymentRequest : BaseRequest
	{
		public const string ACTION = "VendorPayments";
		public IList<CashFlowAssignment> CashFlowAssignments;
		public int? DocEntry;
		public string? CardCode;
		public string? DocNum;
		public string? DocType;
		public string? HandWritten;
		public string? Remarks;
		public string? TransferAccount;
		public string? TransferDate;
		public string? TransferSum;

		public VendorPaymentRequest()
		{
			CashFlowAssignments = new List<CashFlowAssignment>();
		}

		public VendorPaymentRequest(int docEntry)
		{
			DocEntry = docEntry;
			CashFlowAssignments = new List<CashFlowAssignment>();
		}

		public VendorPaymentRequest(VendorPayment x)
		{
			CashFlowAssignments = x.CashFlowAssignments;
			DocEntry = x.DocEntry;
			CardCode = x.CardCode;
			DocNum = x.DocNum;
			DocType = x.DocType;
			HandWritten = x.HandWritten;
			Remarks = x.Remarks;
			TransferAccount = x.TransferAccount;
			TransferDate = x.TransferDate;
			TransferSum = x.TransferSum;
		}
	}
}