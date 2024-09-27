namespace Sql2023.Intranet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesXRef")]
    public partial class SalesXRef
    {
        [Key]
        public int XREFID { get; set; }

        [StringLength(50)]
        public string InsightSalesRep { get; set; }

        [StringLength(50)]
        public string SalesRep { get; set; }
    }
}
