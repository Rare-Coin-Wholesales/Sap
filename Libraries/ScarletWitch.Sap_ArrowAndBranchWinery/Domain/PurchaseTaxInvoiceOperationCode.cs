namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PurchaseTaxInvoiceOperationCode")]
    public partial class PurchaseTaxInvoiceOperationCode
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string OpCode { get; set; }
    }
}
