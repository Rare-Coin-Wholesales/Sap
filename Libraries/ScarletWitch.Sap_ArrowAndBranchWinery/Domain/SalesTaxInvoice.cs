namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesTaxInvoice")]
    public partial class SalesTaxInvoice
    {
        public int Id { get; set; }

        public int? DocEntry { get; set; }

        [StringLength(255)]
        public string CardCode { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [StringLength(255)]
        public string DocNum { get; set; }

        [StringLength(255)]
        public string DocType { get; set; }
    }
}
