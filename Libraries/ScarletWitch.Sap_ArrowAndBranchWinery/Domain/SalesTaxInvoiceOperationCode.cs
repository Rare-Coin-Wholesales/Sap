namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SalesTaxInvoiceOperationCode")]
    public partial class SalesTaxInvoiceOperationCode
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string OpCode { get; set; }
    }
}
