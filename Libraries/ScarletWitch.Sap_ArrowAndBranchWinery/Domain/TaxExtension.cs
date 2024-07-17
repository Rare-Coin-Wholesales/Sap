namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TaxExtension")]
    public partial class TaxExtension
    {
        public int Id { get; set; }

        public int? DocEntry { get; set; }

        public decimal? BoEValue { get; set; }

        public decimal? GrossWeight { get; set; }

        public decimal? NetWeight { get; set; }

        [StringLength(255)]
        public string BillOfEntryDate { get; set; }

        [StringLength(255)]
        public string BillOfEntryNo { get; set; }

        [StringLength(255)]
        public string BlockB { get; set; }

        [StringLength(255)]
        public string BlockS { get; set; }

        [StringLength(255)]
        public string Brand { get; set; }

        [StringLength(255)]
        public string BuildingB { get; set; }

        [StringLength(255)]
        public string BuildingS { get; set; }

        [StringLength(255)]
        public string Carrier { get; set; }

        [StringLength(255)]
        public string CityB { get; set; }

        [StringLength(255)]
        public string CityS { get; set; }

        [StringLength(255)]
        public string ClaimRefund { get; set; }

        [StringLength(255)]
        public string CountryB { get; set; }

        [StringLength(255)]
        public string CountryS { get; set; }

        [StringLength(255)]
        public string County { get; set; }

        [StringLength(255)]
        public string CountyB { get; set; }

        [StringLength(255)]
        public string CountyS { get; set; }

        [StringLength(255)]
        public string DifferentialOfTaxRate { get; set; }

        [StringLength(255)]
        public string GlobalLocationNumberB { get; set; }

        [StringLength(255)]
        public string GlobalLocationNumberS { get; set; }

        [StringLength(255)]
        public string ImportOrExport { get; set; }

        [StringLength(255)]
        public string ImportOrExportType { get; set; }

        [StringLength(255)]
        public string Incoterms { get; set; }

        [StringLength(255)]
        public string IsIGSTAccount { get; set; }

        [StringLength(255)]
        public string MainUsage { get; set; }

        [StringLength(255)]
        public string NFRef { get; set; }

        [StringLength(255)]
        public string OriginalBillOfEntryDate { get; set; }

        [StringLength(255)]
        public string OriginalBillOfEntryNo { get; set; }

        [StringLength(255)]
        public string PackDescription { get; set; }

        [StringLength(255)]
        public string PackQuantity { get; set; }

        [StringLength(255)]
        public string PortCode { get; set; }

        [StringLength(255)]
        public string ShipUnitNo { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string StateB { get; set; }

        [StringLength(255)]
        public string StateS { get; set; }

        [StringLength(255)]
        public string StreetB { get; set; }

        [StringLength(255)]
        public string StreetS { get; set; }

        [StringLength(255)]
        public string TaxId0 { get; set; }

        [StringLength(255)]
        public string TaxId1 { get; set; }

        [StringLength(255)]
        public string TaxId12 { get; set; }

        [StringLength(255)]
        public string TaxId13 { get; set; }

        [StringLength(255)]
        public string TaxId14 { get; set; }

        [StringLength(255)]
        public string TaxId2 { get; set; }

        [StringLength(255)]
        public string TaxId3 { get; set; }

        [StringLength(255)]
        public string TaxId4 { get; set; }

        [StringLength(255)]
        public string TaxId5 { get; set; }

        [StringLength(255)]
        public string TaxId6 { get; set; }

        [StringLength(255)]
        public string TaxId7 { get; set; }

        [StringLength(255)]
        public string TaxId8 { get; set; }

        [StringLength(255)]
        public string TaxId9 { get; set; }

        [StringLength(255)]
        public string Vehicle { get; set; }

        [StringLength(255)]
        public string VehicleState { get; set; }

        [StringLength(255)]
        public string ZipCodeB { get; set; }

        [StringLength(255)]
        public string ZipCodeS { get; set; }
    }
}
