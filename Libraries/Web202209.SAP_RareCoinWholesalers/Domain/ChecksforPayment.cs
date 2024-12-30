namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChecksforPayment")]
    public partial class ChecksforPayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CheckKey { get; set; }

        public int? CheckNumber { get; set; }

        [StringLength(400)]
        public string BankCode { get; set; }

        [StringLength(400)]
        public string Branch { get; set; }

        [StringLength(400)]
        public string BankName { get; set; }

        public DateTime? CheckDate { get; set; }

        [StringLength(400)]
        public string AccountNumber { get; set; }

        [StringLength(400)]
        public string Details { get; set; }

        [StringLength(400)]
        public string JournalEntryReference { get; set; }

        public DateTime? PaymentDate { get; set; }

        public int? PaymentNo { get; set; }

        public decimal? CheckAmount { get; set; }

        [StringLength(400)]
        public string Transferable { get; set; }

        [StringLength(400)]
        public string VendorCode { get; set; }

        [StringLength(400)]
        public string CheckCurrency { get; set; }

        [StringLength(400)]
        public string Canceled { get; set; }

        [StringLength(400)]
        public string CardOrAccount { get; set; }

        [StringLength(400)]
        public string Printed { get; set; }

        [StringLength(400)]
        public string VendorName { get; set; }

        [StringLength(400)]
        public string Signature { get; set; }

        [StringLength(400)]
        public string CustomerAccountCode { get; set; }

        public int? TransactionNumber { get; set; }

        [StringLength(400)]
        public string Address { get; set; }

        [StringLength(400)]
        public string CreateJournalEntry { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? CreationDate { get; set; }

        public decimal? TaxTotal { get; set; }

        public DateTime? TaxDate { get; set; }

        public decimal? DeductionRefundAmount { get; set; }

        public int? PrintedBy { get; set; }

        [StringLength(400)]
        public string CountryCode { get; set; }

        [StringLength(400)]
        public string TotalinWords { get; set; }

        [StringLength(400)]
        public string AddressName { get; set; }

        [StringLength(400)]
        public string ManualCheck { get; set; }

        [StringLength(400)]
        public string AttachmentEntry { get; set; }

        [StringLength(400)]
        public string ECheck { get; set; }

        [StringLength(400)]
        public string PrintConfirm { get; set; }
    }
}
