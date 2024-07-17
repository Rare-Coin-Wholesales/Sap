namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PaymentInvoice")]
    public partial class PaymentInvoice
    {
        public int Id { get; set; }

        public int? DocEntry { get; set; }

        public int? DocLine { get; set; }

        public int? DocNum { get; set; }

        public int? InstallmentId { get; set; }

        public int? LineNum { get; set; }

        public decimal? AppliedFC { get; set; }

        public decimal? AppliedSys { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal? DocRate { get; set; }

        public decimal? PaidSum { get; set; }

        public decimal? SumApplied { get; set; }

        public decimal? TotalDiscount { get; set; }

        public decimal? TotalDiscountFC { get; set; }

        public decimal? TotalDiscountSC { get; set; }

        public decimal? WitholdingTaxApplied { get; set; }

        public decimal? WitholdingTaxAppliedFC { get; set; }

        public decimal? WitholdingTaxAppliedSC { get; set; }

        [StringLength(255)]
        public string DistributionRule { get; set; }

        [StringLength(255)]
        public string DistributionRule2 { get; set; }

        [StringLength(255)]
        public string DistributionRule3 { get; set; }

        [StringLength(255)]
        public string DistributionRule4 { get; set; }

        [StringLength(255)]
        public string DistributionRule5 { get; set; }

        [StringLength(255)]
        public string InvoiceType { get; set; }

        [StringLength(255)]
        public string LinkDate { get; set; }
    }
}
