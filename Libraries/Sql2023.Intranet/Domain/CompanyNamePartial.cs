namespace Sql2023.Intranet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyNamePartial")]
    public partial class CompanyNamePartial
    {
        [Key]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
