namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TradingAccountTransactionHide")]
    public partial class TradingAccountTransactionHide
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string InsightCustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(21)]
        public string DocumentId { get; set; }
    }
}
