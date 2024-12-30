namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JournalEntryLine")]
    public partial class JournalEntryLine
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JdtNum { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineID { get; set; }

        [StringLength(400)]
        public string AccountCode { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }

        public decimal? FCDebit { get; set; }

        public decimal? FCCredit { get; set; }

        [StringLength(400)]
        public string FCCurrency { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(400)]
        public string ShortName { get; set; }

        [StringLength(400)]
        public string ContraAccount { get; set; }

        [StringLength(400)]
        public string LineMemo { get; set; }

        public DateTime? ReferenceDate1 { get; set; }

        [StringLength(400)]
        public string ReferenceDate2 { get; set; }

        [StringLength(400)]
        public string Reference1 { get; set; }

        [StringLength(400)]
        public string Reference2 { get; set; }

        [StringLength(400)]
        public string ProjectCode { get; set; }

        [StringLength(400)]
        public string CostingCode { get; set; }

        public DateTime? TaxDate { get; set; }

        public decimal? BaseSum { get; set; }

        [StringLength(400)]
        public string TaxGroup { get; set; }

        public decimal? DebitSys { get; set; }

        public decimal? CreditSys { get; set; }

        [StringLength(400)]
        public string VatDate { get; set; }

        [StringLength(400)]
        public string VatLine { get; set; }

        public decimal? SystemBaseAmount { get; set; }

        public decimal? VatAmount { get; set; }

        public decimal? SystemVatAmount { get; set; }

        public decimal? GrossValue { get; set; }

        [StringLength(400)]
        public string AdditionalReference { get; set; }

        public int? CheckAbs { get; set; }

        [StringLength(400)]
        public string CostingCode2 { get; set; }

        [StringLength(400)]
        public string CostingCode3 { get; set; }

        [StringLength(400)]
        public string CostingCode4 { get; set; }

        [StringLength(400)]
        public string TaxCode { get; set; }

        [StringLength(400)]
        public string TaxPostAccount { get; set; }

        [StringLength(400)]
        public string CostingCode5 { get; set; }

        [StringLength(400)]
        public string LocationCode { get; set; }

        [StringLength(400)]
        public string ControlAccount { get; set; }

        public decimal? EqualizationTaxAmount { get; set; }

        public decimal? SystemEqualizationTaxAmount { get; set; }

        public decimal? TotalTax { get; set; }

        public decimal? SystemTotalTax { get; set; }

        [StringLength(400)]
        public string WTLiable { get; set; }

        [StringLength(400)]
        public string WTRow { get; set; }

        [StringLength(400)]
        public string PaymentBlock { get; set; }

        [StringLength(400)]
        public string BlockReason { get; set; }

        [StringLength(400)]
        public string FederalTaxID { get; set; }

        [StringLength(400)]
        public string BPLID { get; set; }

        [StringLength(400)]
        public string BPLName { get; set; }

        [StringLength(400)]
        public string VATRegNum { get; set; }

        [StringLength(400)]
        public string PaymentOrdered { get; set; }

        [StringLength(400)]
        public string ExposedTransNumber { get; set; }

        public int? DocumentArray { get; set; }

        public int? DocumentLine { get; set; }

        [StringLength(400)]
        public string CostElementCode { get; set; }

        [StringLength(400)]
        public string Cig { get; set; }

        [StringLength(400)]
        public string Cup { get; set; }

        [StringLength(400)]
        public string IncomeClassificationCategory { get; set; }

        [StringLength(400)]
        public string IncomeClassificationType { get; set; }

        [StringLength(400)]
        public string ExpensesClassificationCategory { get; set; }

        [StringLength(400)]
        public string ExpensesClassificationType { get; set; }

        [StringLength(400)]
        public string VATClassificationCategory { get; set; }

        [StringLength(400)]
        public string VATClassificationType { get; set; }

        [StringLength(400)]
        public string VATExemptionCause { get; set; }
    }
}
