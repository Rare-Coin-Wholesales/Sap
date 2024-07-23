namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseTaxInvoiceLine")]
    public partial class PurchaseTaxInvoiceLine
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string RefEntry1 { get; set; }
    }
}
