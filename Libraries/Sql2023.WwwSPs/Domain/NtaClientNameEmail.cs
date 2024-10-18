namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NtaClientNameEmail")]
    public partial class NtaClientNameEmail
    {
        [Key]
        [StringLength(15)]
        public string InsightCustomerId { get; set; }

        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string ReloadStatus { get; set; }
    }
}
