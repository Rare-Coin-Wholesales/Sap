namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Invoice_DocumentLine
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DocEntry { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineNum { get; set; }

        [StringLength(400)]
        public string ItemCode { get; set; }

        [StringLength(400)]
        public string ItemDescription { get; set; }

        public decimal? Quantity { get; set; }

        public DateTime? ShipDate { get; set; }

        public decimal? Price { get; set; }

        public decimal? PriceAfterVAT { get; set; }

        [StringLength(400)]
        public string Currency { get; set; }

        public decimal? Rate { get; set; }

        public decimal? DiscountPercent { get; set; }

        [StringLength(400)]
        public string VendorNum { get; set; }

        [StringLength(400)]
        public string SerialNum { get; set; }

        [StringLength(400)]
        public string WarehouseCode { get; set; }

        public int? SalesPersonCode { get; set; }

        public decimal? CommisionPercent { get; set; }

        [StringLength(400)]
        public string TreeType { get; set; }

        [StringLength(400)]
        public string AccountCode { get; set; }

        [StringLength(400)]
        public string UseBaseUnits { get; set; }

        [StringLength(400)]
        public string SupplierCatNum { get; set; }

        [StringLength(400)]
        public string CostingCode { get; set; }

        [StringLength(400)]
        public string ProjectCode { get; set; }

        [StringLength(400)]
        public string BarCode { get; set; }

        [StringLength(400)]
        public string VatGroup { get; set; }

        public decimal? Height1 { get; set; }

        [StringLength(400)]
        public string Hight1Unit { get; set; }

        public decimal? Height2 { get; set; }

        [StringLength(400)]
        public string Height2Unit { get; set; }

        public decimal? Lengh1 { get; set; }

        [StringLength(400)]
        public string Lengh1Unit { get; set; }

        public decimal? Lengh2 { get; set; }

        [StringLength(400)]
        public string Lengh2Unit { get; set; }

        public decimal? Weight1 { get; set; }

        [StringLength(400)]
        public string Weight1Unit { get; set; }

        public decimal? Weight2 { get; set; }

        [StringLength(400)]
        public string Weight2Unit { get; set; }

        public decimal? Factor1 { get; set; }

        public decimal? Factor2 { get; set; }

        public decimal? Factor3 { get; set; }

        public decimal? Factor4 { get; set; }

        public int? BaseType { get; set; }

        [StringLength(400)]
        public string BaseEntry { get; set; }

        [StringLength(400)]
        public string BaseLine { get; set; }

        public decimal? Volume { get; set; }

        [StringLength(400)]
        public string VolumeUnit { get; set; }

        public decimal? Width1 { get; set; }

        [StringLength(400)]
        public string Width1Unit { get; set; }

        public decimal? Width2 { get; set; }

        [StringLength(400)]
        public string Width2Unit { get; set; }

        [StringLength(400)]
        public string Address { get; set; }

        [StringLength(400)]
        public string TaxCode { get; set; }

        [StringLength(400)]
        public string TaxType { get; set; }

        [StringLength(400)]
        public string TaxLiable { get; set; }

        [StringLength(400)]
        public string PickStatus { get; set; }

        public decimal? PickQuantity { get; set; }

        [StringLength(400)]
        public string PickListIdNumber { get; set; }

        [StringLength(400)]
        public string OriginalItem { get; set; }

        [StringLength(400)]
        public string BackOrder { get; set; }

        [StringLength(400)]
        public string FreeText { get; set; }

        public int? ShippingMethod { get; set; }

        [StringLength(400)]
        public string POTargetNum { get; set; }

        [StringLength(400)]
        public string POTargetEntry { get; set; }

        [StringLength(400)]
        public string POTargetRowNum { get; set; }

        [StringLength(400)]
        public string CorrectionInvoiceItem { get; set; }

        public decimal? CorrInvAmountToStock { get; set; }

        public decimal? CorrInvAmountToDiffAcct { get; set; }

        public decimal? AppliedTax { get; set; }

        public decimal? AppliedTaxFC { get; set; }

        public decimal? AppliedTaxSC { get; set; }

        [StringLength(400)]
        public string WTLiable { get; set; }

        [StringLength(400)]
        public string DeferredTax { get; set; }

        public decimal? EqualizationTaxPercent { get; set; }

        public decimal? TotalEqualizationTax { get; set; }

        public decimal? TotalEqualizationTaxFC { get; set; }

        public decimal? TotalEqualizationTaxSC { get; set; }

        public decimal? NetTaxAmount { get; set; }

        public decimal? NetTaxAmountFC { get; set; }

        public decimal? NetTaxAmountSC { get; set; }

        [StringLength(400)]
        public string MeasureUnit { get; set; }

        public decimal? UnitsOfMeasurment { get; set; }

        public decimal? LineTotal { get; set; }

        public decimal? TaxPercentagePerRow { get; set; }

        public decimal? TaxTotal { get; set; }

        [StringLength(400)]
        public string ConsumerSalesForecast { get; set; }

        public decimal? ExciseAmount { get; set; }

        public decimal? TaxPerUnit { get; set; }

        public decimal? TotalInclTax { get; set; }

        [StringLength(400)]
        public string CountryOrg { get; set; }

        [StringLength(400)]
        public string SWW { get; set; }

        [StringLength(400)]
        public string TransactionType { get; set; }

        [StringLength(400)]
        public string DistributeExpense { get; set; }

        public decimal? RowTotalFC { get; set; }

        public decimal? RowTotalSC { get; set; }

        public decimal? LastBuyInmPrice { get; set; }

        public decimal? LastBuyDistributeSumFc { get; set; }

        public decimal? LastBuyDistributeSumSc { get; set; }

        public decimal? LastBuyDistributeSum { get; set; }

        public decimal? StockDistributesumForeign { get; set; }

        public decimal? StockDistributesumSystem { get; set; }

        public decimal? StockDistributesum { get; set; }

        public decimal? StockInmPrice { get; set; }

        [StringLength(400)]
        public string PickStatusEx { get; set; }

        public decimal? TaxBeforeDPM { get; set; }

        public decimal? TaxBeforeDPMFC { get; set; }

        public decimal? TaxBeforeDPMSC { get; set; }

        [StringLength(400)]
        public string CFOPCode { get; set; }

        [StringLength(400)]
        public string CSTCode { get; set; }

        [StringLength(400)]
        public string Usage { get; set; }

        [StringLength(400)]
        public string TaxOnly { get; set; }

        public int? VisualOrder { get; set; }

        public decimal? BaseOpenQuantity { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(400)]
        public string LineStatus { get; set; }

        public decimal? PackageQuantity { get; set; }

        [StringLength(400)]
        public string Text { get; set; }

        [StringLength(400)]
        public string LineType { get; set; }

        [StringLength(400)]
        public string COGSCostingCode { get; set; }

        [StringLength(400)]
        public string COGSAccountCode { get; set; }

        [StringLength(400)]
        public string ChangeAssemlyBoMWarehouse { get; set; }

        public decimal? GrossBuyPrice { get; set; }

        public int? GrossBase { get; set; }

        public decimal? GrossProfitTotalBasePrice { get; set; }

        [StringLength(400)]
        public string CostingCode2 { get; set; }

        [StringLength(400)]
        public string CostingCode3 { get; set; }

        [StringLength(400)]
        public string CostingCode4 { get; set; }

        [StringLength(400)]
        public string CostingCode5 { get; set; }

        [StringLength(400)]
        public string ItemDetails { get; set; }

        [StringLength(400)]
        public string LocationCode { get; set; }

        public DateTime? ActualDeliveryDate { get; set; }

        public decimal? RemainingOpenQuantity { get; set; }

        public decimal? OpenAmount { get; set; }

        public decimal? OpenAmountFC { get; set; }

        public decimal? OpenAmountSC { get; set; }

        [StringLength(400)]
        public string ExLineNo { get; set; }

        public DateTime? RequiredDate { get; set; }

        public decimal? RequiredQuantity { get; set; }

        [StringLength(400)]
        public string COGSCostingCode2 { get; set; }

        [StringLength(400)]
        public string COGSCostingCode3 { get; set; }

        [StringLength(400)]
        public string COGSCostingCode4 { get; set; }

        [StringLength(400)]
        public string COGSCostingCode5 { get; set; }

        [StringLength(400)]
        public string CSTforIPI { get; set; }

        [StringLength(400)]
        public string CSTforPIS { get; set; }

        [StringLength(400)]
        public string CSTforCOFINS { get; set; }

        [StringLength(400)]
        public string CreditOriginCode { get; set; }

        [StringLength(400)]
        public string WithoutInventoryMovement { get; set; }

        [StringLength(400)]
        public string AgreementNo { get; set; }

        [StringLength(400)]
        public string AgreementRowNumber { get; set; }

        [StringLength(400)]
        public string ActualBaseEntry { get; set; }

        [StringLength(400)]
        public string ActualBaseLine { get; set; }

        public decimal? Surpluses { get; set; }

        public decimal? DefectAndBreakup { get; set; }

        public decimal? Shortages { get; set; }

        [StringLength(400)]
        public string ConsiderQuantity { get; set; }

        [StringLength(400)]
        public string PartialRetirement { get; set; }

        public decimal? RetirementQuantity { get; set; }

        public decimal? RetirementAPC { get; set; }

        [StringLength(400)]
        public string ThirdParty { get; set; }

        [StringLength(400)]
        public string PoNum { get; set; }

        [StringLength(400)]
        public string PoItmNum { get; set; }

        [StringLength(400)]
        public string ExpenseType { get; set; }

        [StringLength(400)]
        public string ReceiptNumber { get; set; }

        [StringLength(400)]
        public string ExpenseOperationType { get; set; }

        [StringLength(400)]
        public string FederalTaxID { get; set; }

        public decimal? GrossProfit { get; set; }

        public decimal? GrossProfitFC { get; set; }

        public decimal? GrossProfitSC { get; set; }

        [StringLength(400)]
        public string PriceSource { get; set; }

        [StringLength(400)]
        public string StgSeqNum { get; set; }

        [StringLength(400)]
        public string StgEntry { get; set; }

        [StringLength(400)]
        public string StgDesc { get; set; }

        public int? UoMEntry { get; set; }

        [StringLength(400)]
        public string UoMCode { get; set; }

        public decimal? InventoryQuantity { get; set; }

        public decimal? RemainingOpenInventoryQuantity { get; set; }

        [StringLength(400)]
        public string ParentLineNum { get; set; }

        [StringLength(400)]
        public string Incoterms { get; set; }

        [StringLength(400)]
        public string TransportMode { get; set; }

        [StringLength(400)]
        public string NatureOfTransaction { get; set; }

        [StringLength(400)]
        public string DestinationCountryForImport { get; set; }

        [StringLength(400)]
        public string DestinationRegionForImport { get; set; }

        [StringLength(400)]
        public string OriginCountryForExport { get; set; }

        [StringLength(400)]
        public string OriginRegionForExport { get; set; }

        [StringLength(400)]
        public string ItemType { get; set; }

        [StringLength(400)]
        public string ChangeInventoryQuantityIndependently { get; set; }

        [StringLength(400)]
        public string FreeOfChargeBP { get; set; }

        [StringLength(400)]
        public string SACEntry { get; set; }

        [StringLength(400)]
        public string HSNEntry { get; set; }

        public decimal? GrossPrice { get; set; }

        public decimal? GrossTotal { get; set; }

        public decimal? GrossTotalFC { get; set; }

        public decimal? GrossTotalSC { get; set; }

        public int? NCMCode { get; set; }

        [StringLength(400)]
        public string NVECode { get; set; }

        [StringLength(400)]
        public string IndEscala { get; set; }

        public decimal? CtrSealQty { get; set; }

        [StringLength(400)]
        public string CNJPMan { get; set; }

        [StringLength(400)]
        public string CESTCode { get; set; }

        [StringLength(400)]
        public string UFFiscalBenefitCode { get; set; }

        [StringLength(400)]
        public string ReverseCharge { get; set; }

        [StringLength(400)]
        public string ShipToCode { get; set; }

        [StringLength(400)]
        public string ShipToDescription { get; set; }

        [StringLength(400)]
        public string OwnerCode { get; set; }

        public decimal? ExternalCalcTaxRate { get; set; }

        public decimal? ExternalCalcTaxAmount { get; set; }

        public decimal? ExternalCalcTaxAmountFC { get; set; }

        public decimal? ExternalCalcTaxAmountSC { get; set; }

        [StringLength(400)]
        public string StandardItemIdentification { get; set; }

        [StringLength(400)]
        public string CommodityClassification { get; set; }

        public decimal? WeightOfRecycledPlastic { get; set; }

        [StringLength(400)]
        public string PlasticPackageExemptionReason { get; set; }

        [StringLength(400)]
        public string LegalText { get; set; }

        [StringLength(400)]
        public string Cig { get; set; }

        [StringLength(400)]
        public string Cup { get; set; }

        [StringLength(400)]
        public string UnencumberedReason { get; set; }

        [StringLength(400)]
        public string CUSplit { get; set; }

        [StringLength(400)]
        public string ListNum { get; set; }

        [StringLength(400)]
        public string RecognizedTaxCode { get; set; }
    }
}
