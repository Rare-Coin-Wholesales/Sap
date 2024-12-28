namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditLine")]
    public partial class CreditLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AbsId { get; set; }
    }
}
