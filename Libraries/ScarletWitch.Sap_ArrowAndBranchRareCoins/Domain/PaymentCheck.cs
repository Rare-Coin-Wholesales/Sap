namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentCheck")]
    public partial class PaymentCheck
    {
        public int Id { get; set; }

        [StringLength(4000)]
        public string DocEntry { get; set; }

        [StringLength(4000)]
        public string LineNum { get; set; }

        [StringLength(4000)]
        public string DueDate { get; set; }

        [StringLength(4000)]
        public string CheckNumber { get; set; }

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

        [StringLength(4000)]
        public string CheckSum { get; set; }

        [StringLength(4000)]
        public string Currency { get; set; }

        [StringLength(4000)]
        public string CountryCode { get; set; }

        [StringLength(4000)]
        public string CheckAbsEntry { get; set; }

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
