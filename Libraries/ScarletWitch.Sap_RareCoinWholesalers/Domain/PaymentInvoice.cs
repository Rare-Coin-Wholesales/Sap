namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentInvoice")]
    public partial class PaymentInvoice
    {
        public int Id { get; set; }

        [StringLength(4000)]
        public string VendorPaymentDocEntry { get; set; }

        [StringLength(4000)]
        public string LineNum { get; set; }

        [StringLength(4000)]
        public string DocEntry { get; set; }

        [StringLength(4000)]
        public string DocNum { get; set; }

        [StringLength(4000)]
        public string SumApplied { get; set; }

        [StringLength(4000)]
        public string AppliedFC { get; set; }

        [StringLength(4000)]
        public string AppliedSys { get; set; }

        [StringLength(4000)]
        public string DocRate { get; set; }

        [StringLength(4000)]
        public string DocLine { get; set; }

        [StringLength(4000)]
        public string InvoiceType { get; set; }

        [StringLength(4000)]
        public string DiscountPercent { get; set; }

        [StringLength(4000)]
        public string PaidSum { get; set; }

        [StringLength(4000)]
        public string InstallmentId { get; set; }

        [StringLength(4000)]
        public string WitholdingTaxApplied { get; set; }

        [StringLength(4000)]
        public string WitholdingTaxAppliedFC { get; set; }

        [StringLength(4000)]
        public string WitholdingTaxAppliedSC { get; set; }

        [StringLength(4000)]
        public string LinkDate { get; set; }

        [StringLength(4000)]
        public string DistributionRule { get; set; }

        [StringLength(4000)]
        public string DistributionRule2 { get; set; }

        [StringLength(4000)]
        public string DistributionRule3 { get; set; }

        [StringLength(4000)]
        public string DistributionRule4 { get; set; }

        [StringLength(4000)]
        public string DistributionRule5 { get; set; }

        [StringLength(4000)]
        public string TotalDiscount { get; set; }

        [StringLength(4000)]
        public string TotalDiscountFC { get; set; }

        [StringLength(4000)]
        public string TotalDiscountSC { get; set; }
    }
}
