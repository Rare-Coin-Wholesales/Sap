namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TradingAccountSummary
    {
        [Key]
        public int TADID { get; set; }

        [StringLength(50)]
        public string InsightCustomerID { get; set; }

        public DateTime? OpenDate { get; set; }

        public decimal? InitialBasis { get; set; }

        public decimal? CurrentBasis { get; set; }

        public decimal? TotalProfit { get; set; }

        public decimal? TotalDistribution { get; set; }

        public decimal? RateOfReturn { get; set; }

        public decimal? AnnualizedRateOfReturn { get; set; }

        public decimal? BasisInCoins { get; set; }

        public decimal? UninvestedCashOnAccount { get; set; }

        public decimal? TotalAccountBalance { get; set; }
    }
}
