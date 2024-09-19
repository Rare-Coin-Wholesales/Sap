namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountCategory")]
    public partial class AccountCategory
    {
        public int Id { get; set; }

        public int? CategoryCode { get; set; }

        [StringLength(255)]
        public string CategoryName { get; set; }

        [StringLength(255)]
        public string CategorySource { get; set; }
    }
}
