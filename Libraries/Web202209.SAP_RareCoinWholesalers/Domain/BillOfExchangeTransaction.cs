namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillOfExchangeTransaction")]
    public partial class BillOfExchangeTransaction
    {
        [Key]
        [StringLength(255)]
        public string BOETransactionkey { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(255)]
        public string IsBoeReconciled { get; set; }

        [StringLength(255)]
        public string StatusFrom { get; set; }

        [StringLength(255)]
        public string StatusTo { get; set; }

        [StringLength(255)]
        public string TransactionDate { get; set; }
    }
}
