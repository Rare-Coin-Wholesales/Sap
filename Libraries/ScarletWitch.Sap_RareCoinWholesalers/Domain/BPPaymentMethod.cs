namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BPPaymentMethod")]
    public partial class BPPaymentMethod
    {
        public int Id { get; set; }

        [StringLength(4000)]
        public string PaymentMethodCode { get; set; }

        [StringLength(4000)]
        public string RowNumber { get; set; }

        [StringLength(4000)]
        public string BPCode { get; set; }
    }
}
