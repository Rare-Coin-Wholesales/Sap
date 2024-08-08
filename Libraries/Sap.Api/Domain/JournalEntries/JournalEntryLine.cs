using System.Collections.Generic;
using Newtonsoft.Json;
using Sap.Api.Domain.Common;

namespace Sap.Api.Domain.JournalEntries
{
	public partial class JournalEntryLine
	{
		#region Fields
		public string JdtNum;
		[JsonProperty("Line_ID")]
		public string LineID;
		public string AccountCode;
		public string Debit;
		public string Credit;
		public string FCDebit;
		public string FCCredit;
		public string FCCurrency;
		public string DueDate;
		public string ShortName;
		public string ContraAccount;
		public string LineMemo;
		public string ReferenceDate1;
		public string ReferenceDate2;
		public string Reference1;
		public string Reference2;
		public string ProjectCode;
		public string CostingCode;
		public string TaxDate;
		public string BaseSum;
		public string TaxGroup;
		public string DebitSys;
		public string CreditSys;
		public string VatDate;
		public string VatLine;
		public string SystemBaseAmount;
		public string VatAmount;
		public string SystemVatAmount;
		public string GrossValue;
		public string AdditionalReference;
		public string CheckAbs;
		public string CostingCode2;
		public string CostingCode3;
		public string CostingCode4;
		public string TaxCode;
		public string TaxPostAccount;
		public string CostingCode5;
		public string LocationCode;
		public string ControlAccount;
		public string EqualizationTaxAmount;
		public string SystemEqualizationTaxAmount;
		public string TotalTax;
		public string SystemTotalTax;
		public string WTLiable;
		public string WTRow;
		public string PaymentBlock;
		public string BlockReason;
		public string FederalTaxID;
		public string BPLID;
		public string BPLName;
		public string VATRegNum;
		public string PaymentOrdered;
		public string ExposedTransNumber;
		public string DocumentArray;
		public string DocumentLine;
		public string CostElementCode;
		public string Cig;
		public string Cup;
		public string IncomeClassificationCategory;
		public string IncomeClassificationType;
		public string ExpensesClassificationCategory;
		public string ExpensesClassificationType;
		public string VATClassificationCategory;
		public string VATClassificationType;
		public string VATExemptionCause;
		public IList<CashFlowAssignment> CashFlowAssignments;
		#endregion

		public JournalEntryLine()
		{
			CashFlowAssignments = new List<CashFlowAssignment>();
		}
	}
}