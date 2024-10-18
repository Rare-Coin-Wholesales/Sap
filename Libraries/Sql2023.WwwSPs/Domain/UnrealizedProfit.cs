namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UnrealizedProfit")]
    public partial class UnrealizedProfit
    {
        [Key]
        [Column(Order = 0)]
        public DateTime InsertedOnUtc { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string AccountId { get; set; }

        public decimal? SumCost { get; set; }

        public decimal? SumRock { get; set; }

        public decimal? SumWholesale { get; set; }

        public decimal? SumSoldPrice { get; set; }

        public decimal? SumConsignmentBase { get; set; }

        public decimal? CurrentMarketValueOfAssets { get; set; }

        public decimal? UnrealizedProfitPercent { get; set; }

        public DateTime UpdatedOnUtc { get; set; }
    }
}
