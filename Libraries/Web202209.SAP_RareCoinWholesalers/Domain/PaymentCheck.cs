namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentCheck")]
    public partial class PaymentCheck
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DocEntry { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineNum { get; set; }

        public DateTime? DueDate { get; set; }

        public int? CheckNumber { get; set; }

        [StringLength(400)]
        public string BankCode { get; set; }

        [StringLength(400)]
        public string Branch { get; set; }

        [StringLength(400)]
        public string AccounttNum { get; set; }

        [StringLength(400)]
        public string Details { get; set; }

        [StringLength(400)]
        public string Trnsfrable { get; set; }

        public decimal? CheckSum { get; set; }

        [StringLength(400)]
        public string Currency { get; set; }

        [StringLength(400)]
        public string CountryCode { get; set; }

        public int? CheckAbsEntry { get; set; }

        [StringLength(400)]
        public string CheckAccount { get; set; }

        [StringLength(400)]
        public string ManualCheck { get; set; }

        [StringLength(400)]
        public string FiscalID { get; set; }

        [StringLength(400)]
        public string OriginallyIssuedBy { get; set; }

        [StringLength(400)]
        public string Endorse { get; set; }

        [StringLength(400)]
        public string EndorsableCheckNo { get; set; }

        [StringLength(400)]
        public string ECheck { get; set; }

        [StringLength(50)]
        public string Canceled { get; set; }

        [StringLength(50)]
        public string VendorCode { get; set; }

        [StringLength(400)]
        public string VendorName { get; set; }
    }
}
