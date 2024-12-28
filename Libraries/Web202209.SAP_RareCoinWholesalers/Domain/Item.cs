namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [StringLength(400)]
        public string OdataEtag { get; set; }

        [Key]
        [StringLength(400)]
        public string ItemCode { get; set; }

        [StringLength(400)]
        public string ItemName { get; set; }

        [StringLength(400)]
        public string ForeignName { get; set; }

        public int? ItemsGroupCode { get; set; }

        public int? CustomsGroupCode { get; set; }

        [StringLength(400)]
        public string SalesVATGroup { get; set; }

        [StringLength(400)]
        public string BarCode { get; set; }

        [StringLength(400)]
        public string VatLiable { get; set; }

        [StringLength(400)]
        public string PurchaseItem { get; set; }

        [StringLength(400)]
        public string SalesItem { get; set; }

        [StringLength(400)]
        public string InventoryItem { get; set; }

        [StringLength(400)]
        public string IncomeAccount { get; set; }

        [StringLength(400)]
        public string ExemptIncomeAccount { get; set; }

        [StringLength(400)]
        public string ExpanseAccount { get; set; }

        [StringLength(400)]
        public string Mainsupplier { get; set; }

        [StringLength(400)]
        public string SupplierCatalogNo { get; set; }

        public decimal? DesiredInventory { get; set; }

        public decimal? MinInventory { get; set; }

        [StringLength(400)]
        public string Picture { get; set; }

        [StringLength(400)]
        public string UserText { get; set; }

        [StringLength(400)]
        public string SerialNum { get; set; }

        public decimal? CommissionPercent { get; set; }

        public decimal? CommissionSum { get; set; }

        public int? CommissionGroup { get; set; }

        [StringLength(400)]
        public string TreeType { get; set; }

        [StringLength(400)]
        public string AssetItem { get; set; }

        [StringLength(400)]
        public string DataExportCode { get; set; }

        public int? Manufacturer { get; set; }

        public decimal? QuantityOnStock { get; set; }

        public decimal? QuantityOrderedFromVendors { get; set; }

        public decimal? QuantityOrderedByCustomers { get; set; }

        [StringLength(400)]
        public string ManageSerialNumbers { get; set; }

        [StringLength(400)]
        public string ManageBatchNumbers { get; set; }

        [StringLength(400)]
        public string Valid { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        [StringLength(400)]
        public string ValidRemarks { get; set; }

        [StringLength(400)]
        public string Frozen { get; set; }

        public DateTime? FrozenFrom { get; set; }

        public DateTime? FrozenTo { get; set; }

        [StringLength(400)]
        public string FrozenRemarks { get; set; }

        [StringLength(400)]
        public string SalesUnit { get; set; }

        public decimal? SalesItemsPerUnit { get; set; }

        [StringLength(400)]
        public string SalesPackagingUnit { get; set; }

        public decimal? SalesQtyPerPackUnit { get; set; }

        [StringLength(400)]
        public string SalesUnitLength { get; set; }

        [StringLength(400)]
        public string SalesLengthUnit { get; set; }

        [StringLength(400)]
        public string SalesUnitWidth { get; set; }

        [StringLength(400)]
        public string SalesWidthUnit { get; set; }

        [StringLength(400)]
        public string SalesUnitHeight { get; set; }

        [StringLength(400)]
        public string SalesHeightUnit { get; set; }

        public decimal? SalesUnitVolume { get; set; }

        public int? SalesVolumeUnit { get; set; }

        [StringLength(400)]
        public string SalesUnitWeight { get; set; }

        [StringLength(400)]
        public string SalesWeightUnit { get; set; }

        [StringLength(400)]
        public string PurchaseUnit { get; set; }

        public decimal? PurchaseItemsPerUnit { get; set; }

        [StringLength(400)]
        public string PurchasePackagingUnit { get; set; }

        public decimal? PurchaseQtyPerPackUnit { get; set; }

        [StringLength(400)]
        public string PurchaseUnitLength { get; set; }

        [StringLength(400)]
        public string PurchaseLengthUnit { get; set; }

        [StringLength(400)]
        public string PurchaseUnitWidth { get; set; }

        [StringLength(400)]
        public string PurchaseWidthUnit { get; set; }

        [StringLength(400)]
        public string PurchaseUnitHeight { get; set; }

        [StringLength(400)]
        public string PurchaseHeightUnit { get; set; }

        public decimal? PurchaseUnitVolume { get; set; }

        public int? PurchaseVolumeUnit { get; set; }

        [StringLength(400)]
        public string PurchaseUnitWeight { get; set; }

        [StringLength(400)]
        public string PurchaseWeightUnit { get; set; }

        [StringLength(400)]
        public string PurchaseVATGroup { get; set; }

        public decimal? SalesFactor1 { get; set; }

        public decimal? SalesFactor2 { get; set; }

        public decimal? SalesFactor3 { get; set; }

        public decimal? SalesFactor4 { get; set; }

        public decimal? PurchaseFactor1 { get; set; }

        public decimal? PurchaseFactor2 { get; set; }

        public decimal? PurchaseFactor3 { get; set; }

        public decimal? PurchaseFactor4 { get; set; }

        public decimal? MovingAveragePrice { get; set; }

        [StringLength(400)]
        public string ForeignRevenuesAccount { get; set; }

        [StringLength(400)]
        public string ECRevenuesAccount { get; set; }

        [StringLength(400)]
        public string ForeignExpensesAccount { get; set; }

        [StringLength(400)]
        public string ECExpensesAccount { get; set; }

        public decimal? AvgStdPrice { get; set; }

        [StringLength(400)]
        public string DefaultWarehouse { get; set; }

        [StringLength(400)]
        public string ShipType { get; set; }

        [StringLength(400)]
        public string GLMethod { get; set; }

        [StringLength(400)]
        public string TaxType { get; set; }

        public decimal? MaxInventory { get; set; }

        [StringLength(400)]
        public string ManageStockByWarehouse { get; set; }

        [StringLength(400)]
        public string PurchaseHeightUnit1 { get; set; }

        [StringLength(400)]
        public string PurchaseUnitHeight1 { get; set; }

        [StringLength(400)]
        public string PurchaseLengthUnit1 { get; set; }

        [StringLength(400)]
        public string PurchaseUnitLength1 { get; set; }

        [StringLength(400)]
        public string PurchaseWeightUnit1 { get; set; }

        [StringLength(400)]
        public string PurchaseUnitWeight1 { get; set; }

        [StringLength(400)]
        public string PurchaseWidthUnit1 { get; set; }

        [StringLength(400)]
        public string PurchaseUnitWidth1 { get; set; }

        [StringLength(400)]
        public string SalesHeightUnit1 { get; set; }

        [StringLength(400)]
        public string SalesUnitHeight1 { get; set; }

        [StringLength(400)]
        public string SalesLengthUnit1 { get; set; }

        [StringLength(400)]
        public string SalesUnitLength1 { get; set; }

        [StringLength(400)]
        public string SalesWeightUnit1 { get; set; }

        [StringLength(400)]
        public string SalesUnitWeight1 { get; set; }

        [StringLength(400)]
        public string SalesWidthUnit1 { get; set; }

        [StringLength(400)]
        public string SalesUnitWidth1 { get; set; }

        [StringLength(400)]
        public string ForceSelectionOfSerialNumber { get; set; }

        [StringLength(400)]
        public string ManageSerialNumbersOnReleaseOnly { get; set; }

        [StringLength(400)]
        public string WTLiable { get; set; }

        [StringLength(400)]
        public string CostAccountingMethod { get; set; }

        [StringLength(400)]
        public string SWW { get; set; }

        [StringLength(400)]
        public string WarrantyTemplate { get; set; }

        [StringLength(400)]
        public string IndirectTax { get; set; }

        [StringLength(400)]
        public string ArTaxCode { get; set; }

        [StringLength(400)]
        public string ApTaxCode { get; set; }

        [StringLength(400)]
        public string BaseUnitName { get; set; }

        [StringLength(400)]
        public string ItemCountryOrg { get; set; }

        [StringLength(400)]
        public string IssueMethod { get; set; }

        [StringLength(400)]
        public string SRIAndBatchManageMethod { get; set; }

        [StringLength(400)]
        public string IsPhantom { get; set; }

        [StringLength(400)]
        public string InventoryUOM { get; set; }

        [StringLength(400)]
        public string PlanningSystem { get; set; }

        [StringLength(400)]
        public string ProcurementMethod { get; set; }

        [StringLength(400)]
        public string ComponentWarehouse { get; set; }

        [StringLength(400)]
        public string OrderIntervals { get; set; }

        public decimal? OrderMultiple { get; set; }

        [StringLength(400)]
        public string LeadTime { get; set; }

        public decimal? MinOrderQuantity { get; set; }

        [StringLength(400)]
        public string ItemType { get; set; }

        [StringLength(400)]
        public string ItemClass { get; set; }

        public int? OutgoingServiceCode { get; set; }

        public int? IncomingServiceCode { get; set; }

        public int? ServiceGroup { get; set; }

        public int? NCMCode { get; set; }

        [StringLength(400)]
        public string MaterialType { get; set; }

        public int? MaterialGroup { get; set; }

        [StringLength(400)]
        public string ProductSource { get; set; }

        [StringLength(400)]
        public string Properties1 { get; set; }

        [StringLength(400)]
        public string Properties2 { get; set; }

        [StringLength(400)]
        public string Properties3 { get; set; }

        [StringLength(400)]
        public string Properties4 { get; set; }

        [StringLength(400)]
        public string Properties5 { get; set; }

        [StringLength(400)]
        public string Properties6 { get; set; }

        [StringLength(400)]
        public string Properties7 { get; set; }

        [StringLength(400)]
        public string Properties8 { get; set; }

        [StringLength(400)]
        public string Properties9 { get; set; }

        [StringLength(400)]
        public string Properties10 { get; set; }

        [StringLength(400)]
        public string Properties11 { get; set; }

        [StringLength(400)]
        public string Properties12 { get; set; }

        [StringLength(400)]
        public string Properties13 { get; set; }

        [StringLength(400)]
        public string Properties14 { get; set; }

        [StringLength(400)]
        public string Properties15 { get; set; }

        [StringLength(400)]
        public string Properties16 { get; set; }

        [StringLength(400)]
        public string Properties17 { get; set; }

        [StringLength(400)]
        public string Properties18 { get; set; }

        [StringLength(400)]
        public string Properties19 { get; set; }

        [StringLength(400)]
        public string Properties20 { get; set; }

        [StringLength(400)]
        public string Properties21 { get; set; }

        [StringLength(400)]
        public string Properties22 { get; set; }

        [StringLength(400)]
        public string Properties23 { get; set; }

        [StringLength(400)]
        public string Properties24 { get; set; }

        [StringLength(400)]
        public string Properties25 { get; set; }

        [StringLength(400)]
        public string Properties26 { get; set; }

        [StringLength(400)]
        public string Properties27 { get; set; }

        [StringLength(400)]
        public string Properties28 { get; set; }

        [StringLength(400)]
        public string Properties29 { get; set; }

        [StringLength(400)]
        public string Properties30 { get; set; }

        [StringLength(400)]
        public string Properties31 { get; set; }

        [StringLength(400)]
        public string Properties32 { get; set; }

        [StringLength(400)]
        public string Properties33 { get; set; }

        [StringLength(400)]
        public string Properties34 { get; set; }

        [StringLength(400)]
        public string Properties35 { get; set; }

        [StringLength(400)]
        public string Properties36 { get; set; }

        [StringLength(400)]
        public string Properties37 { get; set; }

        [StringLength(400)]
        public string Properties38 { get; set; }

        [StringLength(400)]
        public string Properties39 { get; set; }

        [StringLength(400)]
        public string Properties40 { get; set; }

        [StringLength(400)]
        public string Properties41 { get; set; }

        [StringLength(400)]
        public string Properties42 { get; set; }

        [StringLength(400)]
        public string Properties43 { get; set; }

        [StringLength(400)]
        public string Properties44 { get; set; }

        [StringLength(400)]
        public string Properties45 { get; set; }

        [StringLength(400)]
        public string Properties46 { get; set; }

        [StringLength(400)]
        public string Properties47 { get; set; }

        [StringLength(400)]
        public string Properties48 { get; set; }

        [StringLength(400)]
        public string Properties49 { get; set; }

        [StringLength(400)]
        public string Properties50 { get; set; }

        [StringLength(400)]
        public string Properties51 { get; set; }

        [StringLength(400)]
        public string Properties52 { get; set; }

        [StringLength(400)]
        public string Properties53 { get; set; }

        [StringLength(400)]
        public string Properties54 { get; set; }

        [StringLength(400)]
        public string Properties55 { get; set; }

        [StringLength(400)]
        public string Properties56 { get; set; }

        [StringLength(400)]
        public string Properties57 { get; set; }

        [StringLength(400)]
        public string Properties58 { get; set; }

        [StringLength(400)]
        public string Properties59 { get; set; }

        [StringLength(400)]
        public string Properties60 { get; set; }

        [StringLength(400)]
        public string Properties61 { get; set; }

        [StringLength(400)]
        public string Properties62 { get; set; }

        [StringLength(400)]
        public string Properties63 { get; set; }

        [StringLength(400)]
        public string Properties64 { get; set; }

        [StringLength(400)]
        public string AutoCreateSerialNumbersOnRelease { get; set; }

        public int? DNFEntry { get; set; }

        [StringLength(400)]
        public string GTSItemSpec { get; set; }

        [StringLength(400)]
        public string GTSItemTaxCategory { get; set; }

        [StringLength(400)]
        public string FuelID { get; set; }

        [StringLength(400)]
        public string BeverageTableCode { get; set; }

        [StringLength(400)]
        public string BeverageGroupCode { get; set; }

        [StringLength(400)]
        public string BeverageCommercialBrandCode { get; set; }

        public int? Series { get; set; }

        [StringLength(400)]
        public string ToleranceDays { get; set; }

        [StringLength(400)]
        public string TypeOfAdvancedRules { get; set; }

        [StringLength(400)]
        public string IssuePrimarilyBy { get; set; }

        [StringLength(400)]
        public string NoDiscounts { get; set; }

        [StringLength(400)]
        public string AssetClass { get; set; }

        [StringLength(400)]
        public string AssetGroup { get; set; }

        [StringLength(400)]
        public string InventoryNumber { get; set; }

        [StringLength(400)]
        public string Technician { get; set; }

        [StringLength(400)]
        public string Employee { get; set; }

        [StringLength(400)]
        public string Location { get; set; }

        [StringLength(400)]
        public string AssetStatus { get; set; }

        public DateTime? CapitalizationDate { get; set; }

        [StringLength(400)]
        public string StatisticalAsset { get; set; }

        [StringLength(400)]
        public string Cession { get; set; }

        [StringLength(400)]
        public string DeactivateAfterUsefulLife { get; set; }

        [StringLength(400)]
        public string ManageByQuantity { get; set; }

        public int? UoMGroupEntry { get; set; }

        public int? InventoryUoMEntry { get; set; }

        [StringLength(400)]
        public string DefaultSalesUoMEntry { get; set; }

        [StringLength(400)]
        public string DefaultPurchasingUoMEntry { get; set; }

        [StringLength(400)]
        public string DepreciationGroup { get; set; }

        [StringLength(400)]
        public string AssetSerialNumber { get; set; }

        [StringLength(400)]
        public string InventoryWeight { get; set; }

        [StringLength(400)]
        public string InventoryWeightUnit { get; set; }

        [StringLength(400)]
        public string InventoryWeight1 { get; set; }

        [StringLength(400)]
        public string InventoryWeightUnit1 { get; set; }

        [StringLength(400)]
        public string DefaultCountingUnit { get; set; }

        public decimal? CountingItemsPerUnit { get; set; }

        [StringLength(400)]
        public string DefaultCountingUoMEntry { get; set; }

        [StringLength(400)]
        public string Excisable { get; set; }

        public int? ChapterID { get; set; }

        [StringLength(400)]
        public string ScsCode { get; set; }

        [StringLength(400)]
        public string SpProdType { get; set; }

        public decimal? ProdStdCost { get; set; }

        [StringLength(400)]
        public string InCostRollup { get; set; }

        [StringLength(400)]
        public string VirtualAssetItem { get; set; }

        [StringLength(400)]
        public string EnforceAssetSerialNumbers { get; set; }

        [StringLength(400)]
        public string AttachmentEntry { get; set; }

        [StringLength(400)]
        public string LinkedResource { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(400)]
        public string UpdateTime { get; set; }

        [StringLength(400)]
        public string GSTRelevnt { get; set; }

        public int? SACEntry { get; set; }

        [StringLength(400)]
        public string GSTTaxCategory { get; set; }

        public int? ServiceCategoryEntry { get; set; }

        public decimal? CapitalGoodsOnHoldPercent { get; set; }

        public decimal? CapitalGoodsOnHoldLimit { get; set; }

        public decimal? AssessableValue { get; set; }

        public decimal? AssVal4WTR { get; set; }

        [StringLength(400)]
        public string SOIExcisable { get; set; }

        [StringLength(400)]
        public string TNVED { get; set; }

        [StringLength(400)]
        public string ImportedItem { get; set; }

        public int? PricingUnit { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(400)]
        public string CreateTime { get; set; }

        [StringLength(400)]
        public string NVECode { get; set; }

        public decimal? CtrSealQty { get; set; }

        public int? CESTCode { get; set; }

        [StringLength(400)]
        public string LegalText { get; set; }

        public int? DataVersion { get; set; }

        [StringLength(400)]
        public string CreateQRCodeFrom { get; set; }

        [StringLength(400)]
        public string TraceableItem { get; set; }

        public int? CommodityClassification { get; set; }

        public decimal? WeightOfRecycledPlastic { get; set; }

        [StringLength(400)]
        public string PlasticPackageTaxCategory { get; set; }

        [StringLength(400)]
        public string PlasticPackageExemptionReasonForPurchase { get; set; }

        [StringLength(400)]
        public string PlasticPackageExemptionReasonForProduction { get; set; }

        [StringLength(400)]
        public string SAFTProductType { get; set; }
    }
}
