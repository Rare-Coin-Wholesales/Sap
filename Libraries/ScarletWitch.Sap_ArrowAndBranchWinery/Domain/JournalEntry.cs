namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("JournalEntry")]
    public partial class JournalEntry
    {
        public int Id { get; set; }

        public int? JdtNum { get; set; }

        public int? Number { get; set; }

        public int? Original { get; set; }

        public int? Series { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? ReferenceDate { get; set; }

        public DateTime? TaxDate { get; set; }

        public decimal? WTSum { get; set; }

        public decimal? WTSumFC { get; set; }

        public decimal? WTSumSC { get; set; }

        [StringLength(255)]
        public string AdjustTransaction { get; set; }

        [StringLength(255)]
        public string AllocationNumberIL { get; set; }

        [StringLength(255)]
        public string AttachmentEntry { get; set; }

        [StringLength(255)]
        public string AutomaticWT { get; set; }

        [StringLength(255)]
        public string AutoVAT { get; set; }

        [StringLength(255)]
        public string BaseReference { get; set; }

        [StringLength(255)]
        public string BlanketAgreementNumber { get; set; }

        [StringLength(255)]
        public string BlockDunningLetter { get; set; }

        [StringLength(255)]
        public string CertificationNumber { get; set; }

        [StringLength(255)]
        public string Cig { get; set; }

        [StringLength(255)]
        public string Corisptivi { get; set; }

        [StringLength(255)]
        public string Cup { get; set; }

        [StringLength(255)]
        public string DeferredTax { get; set; }

        [StringLength(255)]
        public string DocumentType { get; set; }

        [StringLength(255)]
        public string ECDPostingType { get; set; }

        [StringLength(255)]
        public string ExcludeFromTaxReportControlStatementVAT { get; set; }

        [StringLength(255)]
        public string ExposedTransNumber { get; set; }

        [StringLength(255)]
        public string FolioNumber { get; set; }

        [StringLength(255)]
        public string FolioNumberFrom { get; set; }

        [StringLength(255)]
        public string FolioNumberTo { get; set; }

        [StringLength(255)]
        public string FolioPrefixString { get; set; }

        [StringLength(255)]
        public string Indicator { get; set; }

        [StringLength(255)]
        public string IsCostCenterTransfer { get; set; }

        [StringLength(255)]
        public string Letter { get; set; }

        [StringLength(255)]
        public string LocationCode { get; set; }

        [StringLength(255)]
        public string Memo { get; set; }

        [StringLength(255)]
        public string OperationCode { get; set; }

        [StringLength(255)]
        public string OriginalJournal { get; set; }

        [StringLength(255)]
        public string PointOfIssueCode { get; set; }

        [StringLength(255)]
        public string Printed { get; set; }

        [StringLength(255)]
        public string PrivateKeyVersion { get; set; }

        [StringLength(255)]
        public string ProjectCode { get; set; }

        [StringLength(255)]
        public string Reference { get; set; }

        [StringLength(255)]
        public string Reference2 { get; set; }

        [StringLength(255)]
        public string Reference3 { get; set; }

        [StringLength(255)]
        public string Report347 { get; set; }

        [StringLength(255)]
        public string ReportEU { get; set; }

        [StringLength(255)]
        public string ReportingSectionControlStatementVAT { get; set; }

        [StringLength(255)]
        public string ResidenceNumberType { get; set; }

        [StringLength(255)]
        public string SAFTTransactionType { get; set; }

        [StringLength(255)]
        public string SAPPassport { get; set; }

        [StringLength(255)]
        public string SignatureDigest { get; set; }

        [StringLength(255)]
        public string SignatureInputMessage { get; set; }

        [StringLength(255)]
        public string StampTax { get; set; }

        [StringLength(255)]
        public string StornoDate { get; set; }

        [StringLength(255)]
        public string TransactionCode { get; set; }

        [StringLength(255)]
        public string UseAutoStorno { get; set; }

        [StringLength(255)]
        public string VatDate { get; set; }
    }
}
