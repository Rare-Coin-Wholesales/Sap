using System;
using System.Collections.Generic;

namespace Sap.Core.Domain.JournalEntries
{
	public partial class JournalEntryRequest : BaseRequest
	{
		#region Fields
		public const string ACTION = "JournalEntries";
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

		public JournalEntryRequest()
		{
			JournalEntryLines = new List<JournalEntryLine>();
			ElectronicProtocols = new List<object>();
			WithholdingTaxDataCollection = new List<object>();
		}

		public JournalEntryRequest(int jdtNum)
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