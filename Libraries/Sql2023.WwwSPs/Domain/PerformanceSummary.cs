namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PerformanceSummary")]
    public partial class PerformanceSummary
    {
        [Key]
        [Column(Order = 0)]
        public DateTime CreatedOnUtc { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountId { get; set; }

        public decimal StartingBalance { get; set; }

        public decimal? Deposits { get; set; }

        public decimal? Withdrawals { get; set; }

        public decimal? MarketChanges { get; set; }

        public decimal? Profit { get; set; }

        public decimal? ManagementFees { get; set; }

        public decimal? TotalNetDeposits { get; set; }

        public int? NumDeposits { get; set; }

        public int? NumWithdrawals { get; set; }

        public decimal? TimeWeightedReturn { get; set; }

        public int? UpdatedById { get; set; }

        public DateTime? UpdatedOnUtc { get; set; }
    }
}
