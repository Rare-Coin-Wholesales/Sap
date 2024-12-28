namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentInvoice")]
    public partial class PaymentInvoice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorPaymentDocEntry { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineNum { get; set; }

        public int? DocEntry { get; set; }

        public int? DocNum { get; set; }

        public decimal? SumApplied { get; set; }

        public decimal? AppliedFC { get; set; }

        public decimal? AppliedSys { get; set; }

        public decimal? DocRate { get; set; }

        public int? DocLine { get; set; }

        [StringLength(400)]
        public string InvoiceType { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal? PaidSum { get; set; }

        public int? InstallmentId { get; set; }

        public decimal? WitholdingTaxApplied { get; set; }

        public decimal? WitholdingTaxAppliedFC { get; set; }

        public decimal? WitholdingTaxAppliedSC { get; set; }

        public DateTime? LinkDate { get; set; }

        [StringLength(400)]
        public string DistributionRule { get; set; }

        [StringLength(400)]
        public string DistributionRule2 { get; set; }

        [StringLength(400)]
        public string DistributionRule3 { get; set; }

        [StringLength(400)]
        public string DistributionRule4 { get; set; }

        [StringLength(400)]
        public string DistributionRule5 { get; set; }

        public decimal? TotalDiscount { get; set; }

        public decimal? TotalDiscountFC { get; set; }

        public decimal? TotalDiscountSC { get; set; }
    }
}
