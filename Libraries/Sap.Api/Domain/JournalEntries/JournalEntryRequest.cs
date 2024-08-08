using System.Collections.Generic;

namespace Sap.Api.Domain.JournalEntries
{
	public partial class JournalEntryRequest : BaseRequest
	{
		public const string ACTION = "JournalEntries";
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

		public JournalEntryRequest()
		{
			JournalEntryLines = new List<JournalEntryLine>();
			ElectronicProtocols = new List<object>();
			WithholdingTaxDataCollection = new List<object>();
		}

		public JournalEntryRequest(string jdtNum)
		{
			JdtNum = jdtNum;
			JournalEntryLines = new List<JournalEntryLine>();
			ElectronicProtocols = new List<object>();
			WithholdingTaxDataCollection = new List<object>();
		}

		public JournalEntryRequest(JournalEntry x)
		{
			DueDate = x.DueDate;
			ReferenceDate = x.ReferenceDate;
			TaxDate = x.TaxDate;
			WTSum = x.WTSum;
			WTSumFC = x.WTSumFC;
			WTSumSC = x.WTSumSC;
			JournalEntryLines = x.JournalEntryLines;
			ElectronicProtocols = x.ElectronicProtocols;
			WithholdingTaxDataCollection = x.WithholdingTaxDataCollection;
			JdtNum = x.JdtNum;
			Number = x.Number;
			Original = x.Original;
			Series = x.Series;
			AdjustTransaction = x.AdjustTransaction;
			AllocationNumberIL = x.AllocationNumberIL;
			AttachmentEntry = x.AttachmentEntry;
			AutomaticWT = x.AutomaticWT;
			AutoVAT = x.AutoVAT;
			BaseReference = x.BaseReference;
			BlanketAgreementNumber = x.BlanketAgreementNumber;
			BlockDunningLetter = x.BlockDunningLetter;
			CertificationNumber = x.CertificationNumber;
			Cig = x.Cig;
			Corisptivi = x.Corisptivi;
			Cup = x.Cup;
			DeferredTax = x.DeferredTax;
			DocumentType = x.DocumentType;
			ECDPostingType = x.ECDPostingType;
			ExcludeFromTaxReportControlStatementVAT = x.ExcludeFromTaxReportControlStatementVAT;
			ExposedTransNumber = x.ExposedTransNumber;
			FolioNumber = x.FolioNumber;
			FolioNumberFrom = x.FolioNumberFrom;
			FolioNumberTo = x.FolioNumberTo;
			FolioPrefixString = x.FolioPrefixString;
			Indicator = x.Indicator;
			IsCostCenterTransfer = x.IsCostCenterTransfer;
			Letter = x.Letter;
			LocationCode = x.LocationCode;
			Memo = x.Memo;
			OperationCode = x.OperationCode;
			OriginalJournal = x.OriginalJournal;
			PointOfIssueCode = x.PointOfIssueCode;
			Printed = x.Printed;
			PrivateKeyVersion = x.PrivateKeyVersion;
			ProjectCode = x.ProjectCode;
			Reference = x.Reference;
			Reference2 = x.Reference2;
			Reference3 = x.Reference3;
			Report347 = x.Report347;
			ReportEU = x.ReportEU;
			ReportingSectionControlStatementVAT = x.ReportingSectionControlStatementVAT;
			ResidenceNumberType = x.ResidenceNumberType;
			SAFTTransactionType = x.SAFTTransactionType;
			SAPPassport = x.SAPPassport;
			SignatureDigest = x.SignatureDigest;
			SignatureInputMessage = x.SignatureInputMessage;
			StampTax = x.StampTax;
			StornoDate = x.StornoDate;
			TransactionCode = x.TransactionCode;
			UseAutoStorno = x.UseAutoStorno;
			VatDate = x.VatDate;
		}
	}
}