namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChartOfAccount")]
    public partial class ChartOfAccount
    {
        public int Id { get; set; }

        [StringLength(4000)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Balance { get; set; }

        [StringLength(4000)]
        public string CashAccount { get; set; }

        [StringLength(4000)]
        public string BudgetAccount { get; set; }

        [StringLength(4000)]
        public string ActiveAccount { get; set; }

        [StringLength(4000)]
        public string PrimaryAccount { get; set; }

        [StringLength(4000)]
        public string AccountLevel { get; set; }

        [StringLength(4000)]
        public string DataExportCode { get; set; }

        [StringLength(4000)]
        public string FatherAccountKey { get; set; }

        [StringLength(4000)]
        public string ExternalCode { get; set; }

        [StringLength(4000)]
        public string RateConversion { get; set; }

        [StringLength(4000)]
        public string TaxLiableAccount { get; set; }

        [StringLength(4000)]
        public string TaxExemptAccount { get; set; }

        [StringLength(4000)]
        public string ExternalReconNo { get; set; }

        [StringLength(4000)]
        public string InternalReconNo { get; set; }

        [StringLength(4000)]
        public string AccountType { get; set; }

        [StringLength(4000)]
        public string AcctCurrency { get; set; }

        [StringLength(4000)]
        public string BalanceSyscurr { get; set; }

        [StringLength(4000)]
        public string BalanceFrgnCurr { get; set; }

        [StringLength(4000)]
        public string Protected { get; set; }

        [StringLength(4000)]
        public string ReconciledAccount { get; set; }

        [StringLength(4000)]
        public string LiableForAdvances { get; set; }

        [StringLength(4000)]
        public string ForeignName { get; set; }

        [StringLength(4000)]
        public string Details { get; set; }

        [StringLength(4000)]
        public string ProjectCode { get; set; }

        [StringLength(4000)]
        public string RevaluationCoordinated { get; set; }

        [StringLength(4000)]
        public string LockManualTransaction { get; set; }

        [StringLength(4000)]
        public string FormatCode { get; set; }

        [StringLength(4000)]
        public string AllowChangeVatGroup { get; set; }

        [StringLength(4000)]
        public string DefaultVatGroup { get; set; }

        [StringLength(4000)]
        public string Category { get; set; }

        [StringLength(4000)]
        public string TransactionCode { get; set; }

        [StringLength(4000)]
        public string LoadingType { get; set; }

        [StringLength(4000)]
        public string LoadingFactorCode { get; set; }

        [StringLength(4000)]
        public string LoadingFactorCode2 { get; set; }

        [StringLength(4000)]
        public string LoadingFactorCode3 { get; set; }

        [StringLength(4000)]
        public string LoadingFactorCode4 { get; set; }

        [StringLength(4000)]
        public string LoadingFactorCode5 { get; set; }

        [StringLength(4000)]
        public string PlanningLevel { get; set; }

        [StringLength(4000)]
        public string DatevAccount { get; set; }

        [StringLength(4000)]
        public string DatevAutoAccount { get; set; }

        [StringLength(4000)]
        public string DatevFirstDataEntry { get; set; }

        [StringLength(4000)]
        public string AllowMultipleLinking { get; set; }

        [StringLength(4000)]
        public string ProjectRelevant { get; set; }

        [StringLength(4000)]
        public string DistributionRuleRelevant { get; set; }

        [StringLength(4000)]
        public string DistributionRule2Relevant { get; set; }

        [StringLength(4000)]
        public string DistributionRule3Relevant { get; set; }

        [StringLength(4000)]
        public string DistributionRule4Relevant { get; set; }

        [StringLength(4000)]
        public string DistributionRule5Relevant { get; set; }

        [StringLength(4000)]
        public string BPLID { get; set; }

        [StringLength(4000)]
        public string BPLName { get; set; }

        [StringLength(4000)]
        public string VATRegNum { get; set; }

        [StringLength(4000)]
        public string AccountPurposeCode { get; set; }

        [StringLength(4000)]
        public string ReferentialAccountCode { get; set; }

        [StringLength(4000)]
        public string ValidFor { get; set; }

        [StringLength(4000)]
        public string ValidFrom { get; set; }

        [StringLength(4000)]
        public string ValidTo { get; set; }

        [StringLength(4000)]
        public string ValidRemarks { get; set; }

        [StringLength(4000)]
        public string FrozenFor { get; set; }

        [StringLength(4000)]
        public string FrozenFrom { get; set; }

        [StringLength(4000)]
        public string FrozenTo { get; set; }

        [StringLength(4000)]
        public string FrozenRemarks { get; set; }

        [StringLength(4000)]
        public string BlockManualPosting { get; set; }

        [StringLength(4000)]
        public string CashFlowRelevant { get; set; }

        [StringLength(4000)]
        public string PCN874ReportRelevant { get; set; }

        [StringLength(4000)]
        public string PrimaryClosingAccount { get; set; }

        [StringLength(4000)]
        public string CostAccountingOnly { get; set; }

        [StringLength(4000)]
        public string CostElementRelevant { get; set; }

        [StringLength(4000)]
        public string CostElementCode { get; set; }

        [StringLength(4000)]
        public string StandardAccountCode { get; set; }

        [StringLength(4000)]
        public string TaxonomyCode { get; set; }

        [StringLength(4000)]
        public string IncomeClassificationCategory { get; set; }

        [StringLength(4000)]
        public string IncomeClassificationType { get; set; }

        [StringLength(4000)]
        public string ExpenseClassificationCategory { get; set; }

        [StringLength(4000)]
        public string ExpenseClassificationType { get; set; }

        [StringLength(4000)]
        public string OfficialAccountCode { get; set; }

        [StringLength(4000)]
        public string UINV { get; set; }
    }
}
