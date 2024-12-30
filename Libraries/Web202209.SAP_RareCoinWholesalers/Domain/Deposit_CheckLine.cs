namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Deposit_CheckLine
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepositAbsEntry { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CheckKey { get; set; }

        public int? CheckNumber { get; set; }

        [StringLength(2000)]
        public string Bank { get; set; }

        [StringLength(2000)]
        public string Branch { get; set; }

        [StringLength(2000)]
        public string CashCheck { get; set; }

        public DateTime? CheckDate { get; set; }

        [StringLength(2000)]
        public string Customer { get; set; }

        public decimal? CheckAmount { get; set; }

        [StringLength(2000)]
        public string Deposited { get; set; }

        [StringLength(2000)]
        public string Transferred { get; set; }

        [StringLength(2000)]
        public string AccountNumber { get; set; }

        [StringLength(2000)]
        public string CheckCurrency { get; set; }
    }
}
