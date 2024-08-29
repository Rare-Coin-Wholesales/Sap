namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DownPaymentsToDrawDetail")]
    public partial class DownPaymentsToDrawDetail
    {
        public int Id { get; set; }

        public int? DocEntry { get; set; }

        public int? DocInternalID { get; set; }

        public int? RowNum { get; set; }

        public int? SeqNum { get; set; }

        public decimal? AmountToDraw { get; set; }

        public decimal? AmountToDrawSC { get; set; }

        public decimal? GrossAmountToDraw { get; set; }

        public decimal? GrossAmountToDrawFC { get; set; }

        public decimal? GrossAmountToDrawSC { get; set; }

        public decimal? Tax { get; set; }

        public decimal? TaxSC { get; set; }

        public decimal? VatPercent { get; set; }

        [StringLength(255)]
        public string AmountToDrawFC { get; set; }

        [StringLength(255)]
        public string IsGrossLine { get; set; }

        [StringLength(255)]
        public string LineType { get; set; }

        [StringLength(255)]
        public string TaxAdjust { get; set; }

        [StringLength(255)]
        public string TaxFC { get; set; }

        [StringLength(255)]
        public string VatGroupCode { get; set; }
    }
}
