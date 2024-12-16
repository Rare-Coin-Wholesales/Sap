namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Import.IncomingPayment_PaymentCheck")]
    public partial class IncomingPayment_PaymentCheck
    {
        public int Id { get; set; }

        public int? IncomingPaymentDocEntry { get; set; }

        public int? LineNum { get; set; }

        public DateTime? DueDate { get; set; }

        public int? CheckNumber { get; set; }

        [StringLength(4000)]
        public string BankCode { get; set; }

        [StringLength(4000)]
        public string Branch { get; set; }

        [StringLength(4000)]
        public string AccounttNum { get; set; }

        [StringLength(4000)]
        public string Details { get; set; }

        [StringLength(4000)]
        public string Trnsfrable { get; set; }

        public decimal? CheckSum { get; set; }

        [StringLength(4000)]
        public string Currency { get; set; }

        [StringLength(4000)]
        public string CountryCode { get; set; }

        public int? CheckAbsEntry { get; set; }

        [StringLength(4000)]
        public string CheckAccount { get; set; }

        [StringLength(4000)]
        public string ManualCheck { get; set; }

        [StringLength(4000)]
        public string FiscalID { get; set; }

        [StringLength(4000)]
        public string OriginallyIssuedBy { get; set; }

        [StringLength(4000)]
        public string Endorse { get; set; }

        [StringLength(4000)]
        public string EndorsableCheckNo { get; set; }

        [StringLength(4000)]
        public string ECheck { get; set; }
    }
}
