namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChecksforPaymentLine")]
    public partial class ChecksforPaymentLine
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CheckKey { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowNumber { get; set; }

        [StringLength(400)]
        public string RowDetails { get; set; }

        public decimal? RowTotal { get; set; }

        [StringLength(400)]
        public string RowCurrency { get; set; }

        [StringLength(400)]
        public string TaxDefinition { get; set; }

        public decimal? TaxPercent { get; set; }

        [StringLength(400)]
        public string CreditedAccount { get; set; }

        public decimal? LineTotal { get; set; }
    }
}
