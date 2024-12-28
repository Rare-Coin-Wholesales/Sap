namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SapCode_QbAccountNumber_Mapping
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(400)]
        public string SapCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string QbAccountNumber { get; set; }

        [StringLength(2)]
        public string AccountNumber2 { get; set; }
    }
}
