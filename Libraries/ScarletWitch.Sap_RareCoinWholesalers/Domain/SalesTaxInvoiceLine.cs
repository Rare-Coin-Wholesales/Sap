namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesTaxInvoiceLine")]
    public partial class SalesTaxInvoiceLine
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string RefEntry1 { get; set; }
    }
}
