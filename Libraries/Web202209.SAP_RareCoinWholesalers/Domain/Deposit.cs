namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deposit")]
    public partial class Deposit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepositNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AbsEntry { get; set; }

        [StringLength(2000)]
        public string DepositType { get; set; }

        public DateTime? DepositDate { get; set; }

        [StringLength(2000)]
        public string DepositCurrency { get; set; }

        [StringLength(2000)]
        public string DepositAccount { get; set; }

        [StringLength(2000)]
        public string DepositorName { get; set; }

        [StringLength(2000)]
        public string Bank { get; set; }

        [StringLength(2000)]
        public string BankAccountNum { get; set; }

        [StringLength(2000)]
        public string BankBranch { get; set; }

        [StringLength(2000)]
        public string BankReference { get; set; }

        [StringLength(2000)]
        public string JournalRemarks { get; set; }

        public decimal? TotalLC { get; set; }

        public decimal? TotalFC { get; set; }

        public decimal? TotalSC { get; set; }

        [StringLength(2000)]
        public string AllocationAccount { get; set; }

        public decimal? DocRate { get; set; }

        [StringLength(2000)]
        public string TaxAccount { get; set; }

        public decimal? TaxAmount { get; set; }

        [StringLength(2000)]
        public string CommissionAccount { get; set; }

        public decimal? Commission { get; set; }

        [StringLength(2000)]
        public string CommissionDate { get; set; }

        [StringLength(2000)]
        public string TaxCode { get; set; }

        [StringLength(2000)]
        public string DepositAccountType { get; set; }

        [StringLength(2000)]
        public string ReconcileAfterDeposit { get; set; }

        [StringLength(2000)]
        public string VoucherAccount { get; set; }

        public int? Series { get; set; }

        [StringLength(2000)]
        public string Project { get; set; }

        [StringLength(2000)]
        public string DistributionRule { get; set; }

        [StringLength(2000)]
        public string DistributionRule2 { get; set; }

        [StringLength(2000)]
        public string DistributionRule3 { get; set; }

        [StringLength(2000)]
        public string DistributionRule4 { get; set; }

        [StringLength(2000)]
        public string DistributionRule5 { get; set; }

        [StringLength(2000)]
        public string CommissionCurrency { get; set; }

        public decimal? CommissionSC { get; set; }

        public decimal? CommissionFC { get; set; }

        public decimal? TaxAmountSC { get; set; }

        public decimal? TaxAmountFC { get; set; }

        [StringLength(2000)]
        public string BPLID { get; set; }

        [StringLength(2000)]
        public string CheckDepositType { get; set; }

        [StringLength(2000)]
        public string AttachmentEntry { get; set; }

        [StringLength(2000)]
        public string IncomeTaxAccount { get; set; }

        public decimal? IncomeTaxAmount { get; set; }

        public decimal? IncomeTaxAmountSC { get; set; }

        public decimal? IncomeTaxAmountFC { get; set; }
    }
}
