namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("VendorPayment")]
    public partial class VendorPayment
    {
        public int Id { get; set; }

        public int? DocEntry { get; set; }

        [StringLength(255)]
        public string CardCode { get; set; }

        [StringLength(255)]
        public string DocNum { get; set; }

        [StringLength(255)]
        public string DocType { get; set; }

        [StringLength(255)]
        public string HandWritten { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        [StringLength(255)]
        public string TransferAccount { get; set; }

        [StringLength(255)]
        public string TransferDate { get; set; }

        [StringLength(255)]
        public string TransferSum { get; set; }
    }
}
