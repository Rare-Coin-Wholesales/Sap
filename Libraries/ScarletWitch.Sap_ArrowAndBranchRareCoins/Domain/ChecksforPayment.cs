namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChecksforPayment")]
    public partial class ChecksforPayment
    {
        public int Id { get; set; }

        [StringLength(2000)]
        public string CheckKey { get; set; }

        [StringLength(2000)]
        public string CheckNumber { get; set; }

        [StringLength(2000)]
        public string BankCode { get; set; }

        [StringLength(2000)]
        public string Branch { get; set; }

        [StringLength(2000)]
        public string BankName { get; set; }

        [StringLength(2000)]
        public string CheckDate { get; set; }

        [StringLength(2000)]
        public string AccountNumber { get; set; }

        [StringLength(2000)]
        public string Details { get; set; }

        [StringLength(2000)]
        public string JournalEntryReference { get; set; }

        [StringLength(2000)]
        public string PaymentDate { get; set; }

        [StringLength(2000)]
        public string PaymentNo { get; set; }

        [StringLength(2000)]
        public string CheckAmount { get; set; }

        [StringLength(2000)]
        public string Transferable { get; set; }

        [StringLength(2000)]
        public string VendorCode { get; set; }

        [StringLength(2000)]
        public string CheckCurrency { get; set; }

        [StringLength(2000)]
        public string Canceled { get; set; }

        [StringLength(2000)]
        public string CardOrAccount { get; set; }

        [StringLength(2000)]
        public string Printed { get; set; }

        [StringLength(2000)]
        public string VendorName { get; set; }

        [StringLength(2000)]
        public string Signature { get; set; }

        [StringLength(2000)]
        public string CustomerAccountCode { get; set; }

        [StringLength(2000)]
        public string TransactionNumber { get; set; }

        [StringLength(2000)]
        public string Address { get; set; }

        [StringLength(2000)]
        public string CreateJournalEntry { get; set; }

        [StringLength(2000)]
        public string UpdateDate { get; set; }

        [StringLength(2000)]
        public string CreationDate { get; set; }

        [StringLength(2000)]
        public string TaxTotal { get; set; }

        [StringLength(2000)]
        public string TaxDate { get; set; }

        [StringLength(2000)]
        public string DeductionRefundAmount { get; set; }

        [StringLength(2000)]
        public string PrintedBy { get; set; }

        [StringLength(2000)]
        public string CountryCode { get; set; }

        [StringLength(2000)]
        public string TotalinWords { get; set; }

        [StringLength(2000)]
        public string AddressName { get; set; }

        [StringLength(2000)]
        public string ManualCheck { get; set; }

        [StringLength(2000)]
        public string AttachmentEntry { get; set; }

        [StringLength(2000)]
        public string ECheck { get; set; }

        [StringLength(2000)]
        public string PrintConfirm { get; set; }
    }
}
