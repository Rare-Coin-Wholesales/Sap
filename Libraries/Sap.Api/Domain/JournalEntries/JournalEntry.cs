using System.Collections.Generic;
using Sap.Core;

namespace Sap.Api.Domain.JournalEntries
{
	public partial class JournalEntry : BaseEntity
	{
		#region Fields
		public string ReferenceDate;
		public string Memo;
		public string Reference;
		public string Reference2;
		public string TransactionCode;
		public string ProjectCode;
		public string TaxDate;
		public string JdtNum;
		public string Indicator;
		public string UseAutoStorno;
		public string StornoDate;
		public string VatDate;
		public string Series;
		public string StampTax;
		public string DueDate;
		public string AutoVAT;
		public string Number;
		public string FolioNumber;
		public string FolioPrefixString;
		public string ReportEU;
		public string Report347;
		public string Printed;
		public string LocationCode;
		public string OriginalJournal;
		public string Original;
		public string BaseReference;
		public string BlockDunningLetter;
		public string AutomaticWT;
		public string WTSum;
		public string WTSumSC;
		public string WTSumFC;
		public string SignatureInputMessage;
		public string SignatureDigest;
		public string CertificationNumber;
		public string PrivateKeyVersion;
		public string Corisptivi;
		public string Reference3;
		public string DocumentType;
		public string DeferredTax;
		public string BlanketAgreementNumber;
		public string OperationCode;
		public string ResidenceNumberType;
		public string ECDPostingType;
		public string ExposedTransNumber;
		public string PointOfIssueCode;
		public string Letter;
		public string FolioNumberFrom;
		public string FolioNumberTo;
		public string IsCostCenterTransfer;
		public string ReportingSectionControlStatementVAT;
		public string ExcludeFromTaxReportControlStatementVAT;
		public string SAPPassport;
		public string Cig;
		public string Cup;
		public string AdjustTransaction;
		public string AttachmentEntry;
		public string SAFTTransactionType;
		public string AllocationNumberIL;
		public IList<JournalEntryLine> JournalEntryLines;
		public IList<object> WithholdingTaxDataCollection;
		public IList<object> ElectronicProtocols;
		#endregion

		public JournalEntry()
		{
			JournalEntryLines = new List<JournalEntryLine>();
			ElectronicProtocols = new List<object>();
			WithholdingTaxDataCollection = new List<object>();
		}
	}
}