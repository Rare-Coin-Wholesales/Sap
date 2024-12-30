namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JournalEntry")]
    public partial class JournalEntry
    {
        public DateTime? ReferenceDate { get; set; }

        [StringLength(400)]
        public string Memo { get; set; }

        [StringLength(400)]
        public string Reference { get; set; }

        [StringLength(400)]
        public string Reference2 { get; set; }

        [StringLength(400)]
        public string TransactionCode { get; set; }

        [StringLength(400)]
        public string ProjectCode { get; set; }

        public DateTime? TaxDate { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JdtNum { get; set; }

        [StringLength(400)]
        public string Indicator { get; set; }

        [StringLength(400)]
        public string UseAutoStorno { get; set; }

        [StringLength(400)]
        public string StornoDate { get; set; }

        [StringLength(400)]
        public string VatDate { get; set; }

        public int? Series { get; set; }

        [StringLength(400)]
        public string StampTax { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(400)]
        public string AutoVAT { get; set; }

        public int? Number { get; set; }

        [StringLength(400)]
        public string FolioNumber { get; set; }

        [StringLength(400)]
        public string FolioPrefixString { get; set; }

        [StringLength(400)]
        public string ReportEU { get; set; }

        [StringLength(400)]
        public string Report347 { get; set; }

        [StringLength(400)]
        public string Printed { get; set; }

        [StringLength(400)]
        public string LocationCode { get; set; }

        [StringLength(400)]
        public string OriginalJournal { get; set; }

        public int? Original { get; set; }

        [StringLength(400)]
        public string BaseReference { get; set; }

        [StringLength(400)]
        public string BlockDunningLetter { get; set; }

        [StringLength(400)]
        public string AutomaticWT { get; set; }

        public decimal? WTSum { get; set; }

        public decimal? WTSumSC { get; set; }

        public decimal? WTSumFC { get; set; }

        [StringLength(400)]
        public string SignatureInputMessage { get; set; }

        [StringLength(400)]
        public string SignatureDigest { get; set; }

        [StringLength(400)]
        public string CertificationNumber { get; set; }

        [StringLength(400)]
        public string PrivateKeyVersion { get; set; }

        [StringLength(400)]
        public string Corisptivi { get; set; }

        [StringLength(400)]
        public string Reference3 { get; set; }

        [StringLength(400)]
        public string DocumentType { get; set; }

        [StringLength(400)]
        public string DeferredTax { get; set; }

        [StringLength(400)]
        public string BlanketAgreementNumber { get; set; }

        [StringLength(400)]
        public string OperationCode { get; set; }

        [StringLength(400)]
        public string ResidenceNumberType { get; set; }

        [StringLength(400)]
        public string ECDPostingType { get; set; }

        [StringLength(400)]
        public string ExposedTransNumber { get; set; }

        [StringLength(400)]
        public string PointOfIssueCode { get; set; }

        [StringLength(400)]
        public string Letter { get; set; }

        [StringLength(400)]
        public string FolioNumberFrom { get; set; }

        [StringLength(400)]
        public string FolioNumberTo { get; set; }

        [StringLength(400)]
        public string IsCostCenterTransfer { get; set; }

        [StringLength(400)]
        public string ReportingSectionControlStatementVAT { get; set; }

        [StringLength(400)]
        public string ExcludeFromTaxReportControlStatementVAT { get; set; }

        [StringLength(400)]
        public string SAPPassport { get; set; }

        [StringLength(400)]
        public string Cig { get; set; }

        [StringLength(400)]
        public string Cup { get; set; }

        [StringLength(400)]
        public string AdjustTransaction { get; set; }

        [StringLength(400)]
        public string AttachmentEntry { get; set; }

        [StringLength(400)]
        public string SAFTTransactionType { get; set; }

        [StringLength(400)]
        public string AllocationNumberIL { get; set; }
    }
}
