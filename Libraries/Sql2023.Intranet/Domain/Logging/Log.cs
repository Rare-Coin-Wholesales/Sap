namespace Sql2023.Intranet.Domain.Logging
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        [Key]
        [Column(Order = 0)]
        public DateTime CreatedOnUtc { get; set; }

        public int? LogLevelId { get; set; }

        public int? CustomerId { get; set; }

        [StringLength(200)]
        public string IpAddress { get; set; }

        [StringLength(4000)]
        public string PageUrl { get; set; }

        [StringLength(4000)]
        public string ReferrerUrl { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(400)]
        public string ShortMessage { get; set; }

        [StringLength(4000)]
        public string FullMessage { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
