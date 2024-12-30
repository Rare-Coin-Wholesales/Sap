namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BPPaymentMethod")]
    public partial class BPPaymentMethod
    {
        [StringLength(400)]
        public string PaymentMethodCode { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(400)]
        public string BPCode { get; set; }
    }
}
