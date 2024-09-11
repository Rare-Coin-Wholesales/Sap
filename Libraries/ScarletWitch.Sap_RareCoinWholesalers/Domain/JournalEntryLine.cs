namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JournalEntryLine")]
    public partial class JournalEntryLine
    {
        public int Id { get; set; }

        [StringLength(2000)]
        public string JdtNum { get; set; }

        [StringLength(2000)]
        public string LineID { get; set; }

        [StringLength(2000)]
        public string AccountCode { get; set; }

        [StringLength(2000)]
        public string Debit { get; set; }

        [StringLength(2000)]
        public string Credit { get; set; }

        [StringLength(2000)]
        public string FCDebit { get; set; }

        [StringLength(2000)]
        public string FCCredit { get; set; }

        [StringLength(2000)]
        public string FCCurrency { get; set; }

        [StringLength(2000)]
        public string DueDate { get; set; }

        [StringLength(2000)]
        public string ShortName { get; set; }

        [StringLength(2000)]
        public string ContraAccount { get; set; }

        [StringLength(2000)]
        public string LineMemo { get; set; }

        [StringLength(2000)]
        public string ReferenceDate1 { get; set; }

        [StringLength(2000)]
        public string ReferenceDate2 { get; set; }

        [StringLength(2000)]
        public string Reference1 { get; set; }

        [StringLength(2000)]
        public string Reference2 { get; set; }

        [StringLength(2000)]
        public string ProjectCode { get; set; }

        [StringLength(2000)]
        public string CostingCode { get; set; }

        [StringLength(2000)]
        public string TaxDate { get; set; }

        [StringLength(2000)]
        public string BaseSum { get; set; }

        [StringLength(2000)]
        public string TaxGroup { get; set; }

        [StringLength(2000)]
        public string DebitSys { get; set; }

        [StringLength(2000)]
        public string CreditSys { get; set; }

        [StringLength(2000)]
        public string VatDate { get; set; }

        [StringLength(2000)]
        public string VatLine { get; set; }

        [StringLength(2000)]
        public string SystemBaseAmount { get; set; }

        [StringLength(2000)]
        public string VatAmount { get; set; }

        [StringLength(2000)]
        public string SystemVatAmount { get; set; }

        [StringLength(2000)]
        public string GrossValue { get; set; }

        [StringLength(2000)]
        public string AdditionalReference { get; set; }

        [StringLength(2000)]
        public string CheckAbs { get; set; }

        [StringLength(2000)]
        public string CostingCode2 { get; set; }

        [StringLength(2000)]
        public string CostingCode3 { get; set; }

        [StringLength(2000)]
        public string CostingCode4 { get; set; }

        [StringLength(2000)]
        public string TaxCode { get; set; }

        [StringLength(2000)]
        public string TaxPostAccount { get; set; }

        [StringLength(2000)]
        public string CostingCode5 { get; set; }

        [StringLength(2000)]
        public string LocationCode { get; set; }

        [StringLength(2000)]
        public string ControlAccount { get; set; }

        [StringLength(2000)]
        public string EqualizationTaxAmount { get; set; }

        [StringLength(2000)]
        public string SystemEqualizationTaxAmount { get; set; }

        [StringLength(2000)]
        public string TotalTax { get; set; }

        [StringLength(2000)]
        public string SystemTotalTax { get; set; }

        [StringLength(2000)]
        public string WTLiable { get; set; }

        [StringLength(2000)]
        public string WTRow { get; set; }

        [StringLength(2000)]
        public string PaymentBlock { get; set; }

        [StringLength(2000)]
        public string BlockReason { get; set; }

        [StringLength(2000)]
        public string FederalTaxID { get; set; }

        [StringLength(2000)]
        public string BPLID { get; set; }

        [StringLength(2000)]
        public string BPLName { get; set; }

        [StringLength(2000)]
        public string VATRegNum { get; set; }

        [StringLength(2000)]
        public string PaymentOrdered { get; set; }

        [StringLength(2000)]
        public string ExposedTransNumber { get; set; }

        [StringLength(2000)]
        public string DocumentArray { get; set; }

        [StringLength(2000)]
        public string DocumentLine { get; set; }

        [StringLength(2000)]
        public string CostElementCode { get; set; }

        [StringLength(2000)]
        public string Cig { get; set; }

        [StringLength(2000)]
        public string Cup { get; set; }

        [StringLength(2000)]
        public string IncomeClassificationCategory { get; set; }

        [StringLength(2000)]
        public string IncomeClassificationType { get; set; }

        [StringLength(2000)]
        public string ExpensesClassificationCategory { get; set; }

        [StringLength(2000)]
        public string ExpensesClassificationType { get; set; }

        [StringLength(2000)]
        public string VATClassificationCategory { get; set; }

        [StringLength(2000)]
        public string VATClassificationType { get; set; }

        [StringLength(2000)]
        public string VATExemptionCause { get; set; }
    }
}
