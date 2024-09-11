namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LineTaxJurisdiction")]
    public partial class LineTaxJurisdiction
    {
        public int Id { get; set; }

        public int? DocEntry { get; set; }

        public int? JurisdictionType { get; set; }

        public int? LineNumber { get; set; }

        public int? RowSequence { get; set; }

        public decimal? BaseSum { get; set; }

        public decimal? ExternalCalcTaxAmount { get; set; }

        public decimal? ExternalCalcTaxAmountFC { get; set; }

        public decimal? ExternalCalcTaxAmountSC { get; set; }

        public decimal? ExternalCalcTaxRate { get; set; }

        public decimal? NonDeductiblePercent { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? TaxAmountFC { get; set; }

        public decimal? TaxAmountSC { get; set; }

        public decimal? TaxRate { get; set; }

        [StringLength(255)]
        public string Exempt { get; set; }

        [StringLength(255)]
        public string JurisdictionCode { get; set; }

        [StringLength(255)]
        public string TaxInPrice { get; set; }

        [StringLength(255)]
        public string TaxOnReserveInvoice { get; set; }

        [StringLength(255)]
        public string Unencumbered { get; set; }
    }
}
