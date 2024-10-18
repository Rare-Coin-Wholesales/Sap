namespace Sql2023.WwwSPs.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NtaCoin")]
    public partial class NtaCoin
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string InsightCustomerId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CertNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string GradingService { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Grade { get; set; }

        [StringLength(50)]
        public string PurchaseDocumentId { get; set; }

        public int? ConsignmentDocumentId { get; set; }

        [StringLength(50)]
        public string SoldDocumentId { get; set; }

        public DateTime? PurchasedOn { get; set; }

        public DateTime? ConsignedOn { get; set; }

        public DateTime? SoldOn { get; set; }

        public decimal? PurchasePrice { get; set; }

        public decimal? ProRataSoldPrice { get; set; }

        public decimal? SoldPrice { get; set; }

        public decimal? WholesalePrice { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Designation { get; set; }
    }
}
