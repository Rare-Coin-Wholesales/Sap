namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TradingAccount")]
    public partial class TradingAccount
    {
        public int Id { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string InsightCustomerId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? AutoReload { get; set; }

        public bool? Closed { get; set; }

        [StringLength(100)]
        public string ReloadStatus { get; set; }
    }
}
