namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChecksforPayment")]
    public partial class ChecksforPayment
    {
        public int Id { get; set; }

        public int? CheckKey { get; set; }

        [StringLength(255)]
        public string AccountNumber { get; set; }

        [StringLength(255)]
        public string BankCode { get; set; }

        [StringLength(255)]
        public string Branch { get; set; }

        [StringLength(255)]
        public string CardOrAccount { get; set; }

        [StringLength(255)]
        public string CheckNumber { get; set; }

        [StringLength(255)]
        public string CountryCode { get; set; }

        [StringLength(255)]
        public string CustomerAccountCode { get; set; }

        [StringLength(255)]
        public string Details { get; set; }

        [StringLength(255)]
        public string VendorCode { get; set; }
    }
}
