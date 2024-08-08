namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JournalEntry")]
    public partial class JournalEntry
    {
        public int Id { get; set; }

        [StringLength(2000)]
        public string ReferenceDate { get; set; }

        [StringLength(2000)]
        public string Memo { get; set; }

        [StringLength(2000)]
        public string Reference { get; set; }

        [StringLength(2000)]
        public string Reference2 { get; set; }

        [StringLength(2000)]
        public string TransactionCode { get; set; }

        [StringLength(2000)]
        public string ProjectCode { get; set; }

        [StringLength(2000)]
        public string TaxDate { get; set; }

        [StringLength(2000)]
        public string JdtNum { get; set; }

        [StringLength(2000)]
        public string Indicator { get; set; }

        [StringLength(2000)]
        public string UseAutoStorno { get; set; }

        [StringLength(2000)]
        public string StornoDate { get; set; }

        [StringLength(2000)]
        public string VatDate { get; set; }

        [StringLength(2000)]
        public string Series { get; set; }

        [StringLength(2000)]
        public string StampTax { get; set; }

        [StringLength(2000)]
        public string DueDate { get; set; }

        [StringLength(2000)]
        public string AutoVAT { get; set; }

        [StringLength(2000)]
        public string Number { get; set; }

        [StringLength(2000)]
        public string FolioNumber { get; set; }

        [StringLength(2000)]
        public string FolioPrefixString { get; set; }

        [StringLength(2000)]
        public string ReportEU { get; set; }

        [StringLength(2000)]
        public string Report347 { get; set; }

        [StringLength(2000)]
        public string Printed { get; set; }

        [StringLength(2000)]
        public string LocationCode { get; set; }

        [StringLength(2000)]
        public string OriginalJournal { get; set; }

        [StringLength(2000)]
        public string Original { get; set; }

        [StringLength(2000)]
        public string BaseReference { get; set; }

        [StringLength(2000)]
        public string BlockDunningLetter { get; set; }

        [StringLength(2000)]
        public string AutomaticWT { get; set; }

        [StringLength(2000)]
        public string WTSum { get; set; }

        [StringLength(2000)]
        public string WTSumSC { get; set; }

        [StringLength(2000)]
        public string WTSumFC { get; set; }

        [StringLength(2000)]
        public string SignatureInputMessage { get; set; }

        [StringLength(2000)]
        public string SignatureDigest { get; set; }

        [StringLength(2000)]
        public string CertificationNumber { get; set; }

        [StringLength(2000)]
        public string PrivateKeyVersion { get; set; }

        [StringLength(2000)]
        public string Corisptivi { get; set; }

        [StringLength(2000)]
        public string Reference3 { get; set; }

        [StringLength(2000)]
        public string DocumentType { get; set; }

        [StringLength(2000)]
        public string DeferredTax { get; set; }

        [StringLength(2000)]
        public string BlanketAgreementNumber { get; set; }

        [StringLength(2000)]
        public string OperationCode { get; set; }

        [StringLength(2000)]
        public string ResidenceNumberType { get; set; }

        [StringLength(2000)]
        public string ECDPostingType { get; set; }

        [StringLength(2000)]
        public string ExposedTransNumber { get; set; }

        [StringLength(2000)]
        public string PointOfIssueCode { get; set; }

        [StringLength(2000)]
        public string Letter { get; set; }

        [StringLength(2000)]
        public string FolioNumberFrom { get; set; }

        [StringLength(2000)]
        public string FolioNumberTo { get; set; }

        [StringLength(2000)]
        public string IsCostCenterTransfer { get; set; }

        [StringLength(2000)]
        public string ReportingSectionControlStatementVAT { get; set; }

        [StringLength(2000)]
        public string ExcludeFromTaxReportControlStatementVAT { get; set; }

        [StringLength(2000)]
        public string SAPPassport { get; set; }

        [StringLength(2000)]
        public string Cig { get; set; }

        [StringLength(2000)]
        public string Cup { get; set; }

        [StringLength(2000)]
        public string AdjustTransaction { get; set; }

        [StringLength(2000)]
        public string AttachmentEntry { get; set; }

        [StringLength(2000)]
        public string SAFTTransactionType { get; set; }

        [StringLength(2000)]
        public string AllocationNumberIL { get; set; }
    }
}
