namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DownPaymentsToDraw")]
    public partial class DownPaymentsToDraw
    {
        public int Id { get; set; }

        public int? DocEntry { get; set; }

        public int? DocInternalID { get; set; }

        public int? DocNumber { get; set; }

        public int? RowNum { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? PostingDate { get; set; }

        public decimal? AmountToDraw { get; set; }

        public decimal? AmountToDrawSC { get; set; }

        public decimal? GrossAmountToDraw { get; set; }

        public decimal? GrossAmountToDrawFC { get; set; }

        public decimal? GrossAmountToDrawSC { get; set; }

        public decimal? Tax { get; set; }

        public decimal? TaxFC { get; set; }

        public decimal? TaxSC { get; set; }

        [StringLength(255)]
        public string AmountToDrawFC { get; set; }

        [StringLength(255)]
        public string Details { get; set; }

        [StringLength(255)]
        public string DownPaymentType { get; set; }

        [StringLength(255)]
        public string IsGrossLine { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
    }
}
