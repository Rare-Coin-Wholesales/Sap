namespace Sql2023.Intranet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UnixCustomer
    {
        [Key]
        public int UnixCustID { get; set; }

        [Required]
        [StringLength(15)]
        public string CustID { get; set; }

        [StringLength(100)]
        public string CustName { get; set; }

        [StringLength(50)]
        public string CustContact { get; set; }

        [StringLength(50)]
        public string CustAddress1 { get; set; }

        [StringLength(50)]
        public string CustAddress2 { get; set; }

        [StringLength(50)]
        public string CustCity { get; set; }

        [StringLength(10)]
        public string CustState { get; set; }

        [StringLength(20)]
        public string CustZip { get; set; }

        [StringLength(1)]
        public string CustTaxCode { get; set; }

        [StringLength(30)]
        public string CustPhone1 { get; set; }

        [StringLength(30)]
        public string CustPhone2 { get; set; }

        [StringLength(50)]
        public string CustReseller { get; set; }

        [StringLength(255)]
        public string CustTerms { get; set; }

        [StringLength(100)]
        public string GM_AccountNo { get; set; }
    }
}
