using System;
using System.Collections.Generic;
using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.JournalEntries
{
	public partial class JournalEntry : BaseEntity
	{
		#region Fields
		public DateTime? DueDate;
		public DateTime? ReferenceDate;
		public DateTime? TaxDate;
		public decimal? WTSum;
		public decimal? WTSumFC;
		public decimal? WTSumSC;
		public IList<JournalEntryLine> JournalEntryLines;
		public IList<object> ElectronicProtocols;
		public IList<object> WithholdingTaxDataCollection;
		public int? JdtNum;
		public int? Number;
		public int? Original;
		public int? Series;
		public string AdjustTransaction;
		public string AllocationNumberIL;
		public string AttachmentEntry;
		public string AutomaticWT;
		public string AutoVAT;
		public string BaseReference;
		public string BlanketAgreementNumber;
		public string BlockDunningLetter;
		public string CertificationNumber;
		public string Cig;
		public string Corisptivi;
		public string Cup;
		public string DeferredTax;
		public string DocumentType;
		public string ECDPostingType;
		public string ExcludeFromTaxReportControlStatementVAT;
		public string ExposedTransNumber;
		public string FolioNumber;
		public string FolioNumberFrom;
		public string FolioNumberTo;
		public string FolioPrefixString;
		public string Indicator;
		public string IsCostCenterTransfer;
		public string Letter;
		public string LocationCode;
		public string Memo;
		public string OperationCode;
		public string OriginalJournal;
		public string PointOfIssueCode;
		public string Printed;
		public string PrivateKeyVersion;
		public string ProjectCode;
		public string Reference;
		public string Reference2;
		public string Reference3;
		public string Report347;
		public string ReportEU;
		public string ReportingSectionControlStatementVAT;
		public string ResidenceNumberType;
		public string SAFTTransactionType;
		public string SAPPassport;
		public string SignatureDigest;
		public string SignatureInputMessage;
		public string StampTax;
		public string StornoDate;
		public string TransactionCode;
		public string UseAutoStorno;
		public string VatDate;
		#endregion

		public JournalEntry()
		{
			JournalEntryLines = new List<JournalEntryLine>();
			ElectronicProtocols = new List<object>();
			WithholdingTaxDataCollection = new List<object>();
		}
}

	public class JournalEntryLine
	{
		#region Fields
		public DateTime? DueDate;
		public DateTime? ReferenceDate1;
		public DateTime? TaxDate;
		public decimal? BaseSum;
		public decimal? Credit;
		public decimal? CreditSys;
		public decimal? Debit;
		public decimal? DebitSys;
		public decimal? EqualizationTaxAmount;
		public decimal? FCCredit;
		public decimal? FCDebit;
		public decimal? GrossValue;
		public decimal? SystemBaseAmount;
		public decimal? SystemEqualizationTaxAmount;
		public decimal? SystemTotalTax;
		public decimal? SystemVatAmount;
		public decimal? TotalTax;
		public decimal? VatAmount;
		public IList<CashFlowAssignment> CashFlowAssignments;
		public int? DocumentArray;
		public int? DocumentLine;
		public int? LineID;
		public string AccountCode;
		public string AdditionalReference;
		public string BlockReason;
		public string BPLID;
		public string BPLName;
		public string CheckAbs;
		public string Cig;
		public string ContraAccount;
		public string ControlAccount;
		public string CostElementCode;
		public string CostingCode;
		public string CostingCode2;
		public string CostingCode3;
		public string CostingCode4;
		public string CostingCode5;
		public string Cup;
		public string ExpensesClassificationCategory;
		public string ExpensesClassificationType;
		public string ExposedTransNumber;
		public string FCCurrency;
		public string FederalTaxID;
		public string IncomeClassificationCategory;
		public string IncomeClassificationType;
		public string LineMemo;
		public string LocationCode;
		public string PaymentBlock;
		public string PaymentOrdered;
		public string ProjectCode;
		public string Reference1;
		public string Reference2;
		public string ReferenceDate2;
		public string ShortName;
		public string TaxCode;
		public string TaxGroup;
		public string TaxPostAccount;
		public string VATClassificationCategory;
		public string VATClassificationType;
		public string VatDate;
		public string VATExemptionCause;
		public string VatLine;
		public string VATRegNum;
		public string WTLiable;
		public string WTRow;
		#endregion

		public JournalEntryLine()
		{
			CashFlowAssignments = new List<CashFlowAssignment>();
		}
	}
}