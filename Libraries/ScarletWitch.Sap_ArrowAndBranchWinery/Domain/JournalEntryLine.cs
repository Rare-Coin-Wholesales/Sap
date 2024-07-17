namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("JournalEntryLine")]
    public partial class JournalEntryLine
    {
        public int Id { get; set; }

        public int? DocumentArray { get; set; }

        public int? DocumentLine { get; set; }

        public int? LineID { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? ReferenceDate1 { get; set; }

        public DateTime? TaxDate { get; set; }

        public decimal? BaseSum { get; set; }

        public decimal? Credit { get; set; }

        public decimal? CreditSys { get; set; }

        public decimal? Debit { get; set; }

        public decimal? DebitSys { get; set; }

        public decimal? EqualizationTaxAmount { get; set; }

        public decimal? FCCredit { get; set; }

        public decimal? FCDebit { get; set; }

        public decimal? GrossValue { get; set; }

        public decimal? SystemBaseAmount { get; set; }

        public decimal? SystemEqualizationTaxAmount { get; set; }

        public decimal? SystemTotalTax { get; set; }

        public decimal? SystemVatAmount { get; set; }

        public decimal? TotalTax { get; set; }

        public decimal? VatAmount { get; set; }

        [StringLength(255)]
        public string AccountCode { get; set; }

        [StringLength(255)]
        public string AdditionalReference { get; set; }

        [StringLength(255)]
        public string BlockReason { get; set; }

        [StringLength(255)]
        public string BPLID { get; set; }

        [StringLength(255)]
        public string BPLName { get; set; }

        [StringLength(255)]
        public string CheckAbs { get; set; }

        [StringLength(255)]
        public string Cig { get; set; }

        [StringLength(255)]
        public string ContraAccount { get; set; }

        [StringLength(255)]
        public string ControlAccount { get; set; }

        [StringLength(255)]
        public string CostElementCode { get; set; }

        [StringLength(255)]
        public string CostingCode { get; set; }

        [StringLength(255)]
        public string CostingCode2 { get; set; }

        [StringLength(255)]
        public string CostingCode3 { get; set; }

        [StringLength(255)]
        public string CostingCode4 { get; set; }

        [StringLength(255)]
        public string CostingCode5 { get; set; }

        [StringLength(255)]
        public string Cup { get; set; }

        [StringLength(255)]
        public string ExpensesClassificationCategory { get; set; }

        [StringLength(255)]
        public string ExpensesClassificationType { get; set; }

        [StringLength(255)]
        public string ExposedTransNumber { get; set; }

        [StringLength(255)]
        public string FCCurrency { get; set; }

        [StringLength(255)]
        public string FederalTaxID { get; set; }

        [StringLength(255)]
        public string IncomeClassificationCategory { get; set; }

        [StringLength(255)]
        public string IncomeClassificationType { get; set; }

        [StringLength(255)]
        public string LineMemo { get; set; }

        [StringLength(255)]
        public string LocationCode { get; set; }

        [StringLength(255)]
        public string PaymentBlock { get; set; }

        [StringLength(255)]
        public string PaymentOrdered { get; set; }

        [StringLength(255)]
        public string ProjectCode { get; set; }

        [StringLength(255)]
        public string Reference1 { get; set; }

        [StringLength(255)]
        public string Reference2 { get; set; }

        [StringLength(255)]
        public string ReferenceDate2 { get; set; }

        [StringLength(255)]
        public string ShortName { get; set; }

        [StringLength(255)]
        public string TaxCode { get; set; }

        [StringLength(255)]
        public string TaxGroup { get; set; }

        [StringLength(255)]
        public string TaxPostAccount { get; set; }

        [StringLength(255)]
        public string VATClassificationCategory { get; set; }

        [StringLength(255)]
        public string VATClassificationType { get; set; }

        [StringLength(255)]
        public string VatDate { get; set; }

        [StringLength(255)]
        public string VATExemptionCause { get; set; }

        [StringLength(255)]
        public string VatLine { get; set; }

        [StringLength(255)]
        public string VATRegNum { get; set; }

        [StringLength(255)]
        public string WTLiable { get; set; }

        [StringLength(255)]
        public string WTRow { get; set; }
    }
}
