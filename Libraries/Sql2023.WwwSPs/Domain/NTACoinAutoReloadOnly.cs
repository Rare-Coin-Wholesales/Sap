namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NTACoinAutoReloadOnly")]
    public partial class NTACoinAutoReloadOnly
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvID { get; set; }

        [StringLength(15)]
        public string Class { get; set; }

        [StringLength(112)]
        public string Grade { get; set; }

        public decimal? Cost { get; set; }

        public decimal? Rock { get; set; }

        public decimal? Wholesale { get; set; }

        [StringLength(50)]
        public string Description1 { get; set; }

        [StringLength(50)]
        public string Description2 { get; set; }

        [StringLength(10)]
        public string Service { get; set; }

        [StringLength(50)]
        public string ConsignmentVendor { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }
    }
}
