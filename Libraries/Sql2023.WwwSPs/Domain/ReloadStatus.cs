namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReloadStatuses")]
    public partial class ReloadStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusID { get; set; }

        [Column("ReloadStatus")]
        [StringLength(100)]
        public string ReloadStatus1 { get; set; }
    }
}
