namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CashFlowAssignment")]
    public partial class CashFlowAssignment
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string AmountLC { get; set; }

        [StringLength(255)]
        public string PaymentMeans { get; set; }
    }
}
