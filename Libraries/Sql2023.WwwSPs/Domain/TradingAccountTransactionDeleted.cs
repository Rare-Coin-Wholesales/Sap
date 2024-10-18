namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TradingAccountTransactionDeleted")]
    public partial class TradingAccountTransactionDeleted
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(41)]
        public string Id { get; set; }

        [StringLength(15)]
        public string InsightCustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(21)]
        public string DocumentId { get; set; }

        [StringLength(21)]
        public string CheckVoucherId { get; set; }

        public short? DocumentType { get; set; }

        public DateTime? DocumentDate { get; set; }

        public DateTime? PostedDate { get; set; }

        public DateTime? GeneralLedgerPostedDate { get; set; }

        [StringLength(21)]
        public string PaymentTerms { get; set; }

        public decimal? UnappliedFunds { get; set; }

        public decimal? AppliedFunds { get; set; }

        public short? RMDocumentType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string TransactionType { get; set; }

        public bool? IsBasis { get; set; }

        public bool? IsDistribution { get; set; }

        public bool? IsCoinDistribution { get; set; }

        public bool? IsNonNta { get; set; }

        public bool? Void { get; set; }

        [StringLength(50)]
        public string TransactionSubtype { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
