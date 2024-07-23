using System;
using System.Collections.Generic;
using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.VendorPayments
{
	public partial class VendorPayment : BaseEntity
	{
		public IList<CashFlowAssignment> CashFlowAssignments;
		public int? DocEntry;
		public string CardCode;
		public string DocNum;
		public string DocType;
		public string HandWritten;
		public string Remarks;
		public string TransferAccount;
		public string TransferDate;
		public string TransferSum;

		public VendorPayment()
		{
			CashFlowAssignments = new List<CashFlowAssignment>();
		}
	}
}