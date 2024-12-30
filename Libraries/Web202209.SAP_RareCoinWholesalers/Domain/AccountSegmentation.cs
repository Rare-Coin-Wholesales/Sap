namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountSegmentation")]
    public partial class AccountSegmentation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numerator { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? Size { get; set; }

        [StringLength(255)]
        public string Type { get; set; }
    }
}
