namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseTaxInvoiceOperationCode")]
    public partial class PurchaseTaxInvoiceOperationCode
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string OpCode { get; set; }
    }
}
