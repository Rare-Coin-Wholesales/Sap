namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        public int Id { get; set; }

        [StringLength(1000)]
        public string OdataEtag { get; set; }

        [StringLength(1000)]
        public string ItemCode { get; set; }

        [StringLength(1000)]
        public string ItemName { get; set; }

        [StringLength(1000)]
        public string ForeignName { get; set; }

        [StringLength(1000)]
        public string ItemsGroupCode { get; set; }

        [StringLength(1000)]
        public string CustomsGroupCode { get; set; }

        [StringLength(1000)]
        public string SalesVATGroup { get; set; }

        [StringLength(1000)]
        public string BarCode { get; set; }

        [StringLength(1000)]
        public string VatLiable { get; set; }

        [StringLength(1000)]
        public string PurchaseItem { get; set; }

        [StringLength(1000)]
        public string SalesItem { get; set; }

        [StringLength(1000)]
        public string InventoryItem { get; set; }

        [StringLength(1000)]
        public string IncomeAccount { get; set; }

        [StringLength(1000)]
        public string ExemptIncomeAccount { get; set; }

        [StringLength(1000)]
        public string ExpanseAccount { get; set; }

        [StringLength(1000)]
        public string Mainsupplier { get; set; }

        [StringLength(1000)]
        public string SupplierCatalogNo { get; set; }

        [StringLength(1000)]
        public string DesiredInventory { get; set; }

        [StringLength(1000)]
        public string MinInventory { get; set; }

        [StringLength(1000)]
        public string Picture { get; set; }

        [StringLength(1000)]
        public string UserText { get; set; }

        [StringLength(1000)]
        public string SerialNum { get; set; }

        [StringLength(1000)]
        public string CommissionPercent { get; set; }

        [StringLength(1000)]
        public string CommissionSum { get; set; }

        [StringLength(1000)]
        public string CommissionGroup { get; set; }

        [StringLength(1000)]
        public string TreeType { get; set; }

        [StringLength(1000)]
        public string AssetItem { get; set; }

        [StringLength(1000)]
        public string DataExportCode { get; set; }

        [StringLength(1000)]
        public string Manufacturer { get; set; }

        [StringLength(1000)]
        public string QuantityOnStock { get; set; }

        [StringLength(1000)]
        public string QuantityOrderedFromVendors { get; set; }

        [StringLength(1000)]
        public string QuantityOrderedByCustomers { get; set; }

        [StringLength(1000)]
        public string ManageSerialNumbers { get; set; }

        [StringLength(1000)]
        public string ManageBatchNumbers { get; set; }

        [StringLength(1000)]
        public string Valid { get; set; }

        [StringLength(1000)]
        public string ValidFrom { get; set; }

        [StringLength(1000)]
        public string ValidTo { get; set; }

        [StringLength(1000)]
        public string ValidRemarks { get; set; }

        [StringLength(1000)]
        public string Frozen { get; set; }

        [StringLength(1000)]
        public string FrozenFrom { get; set; }

        [StringLength(1000)]
        public string FrozenTo { get; set; }

        [StringLength(1000)]
        public string FrozenRemarks { get; set; }

        [StringLength(1000)]
        public string SalesUnit { get; set; }

        [StringLength(1000)]
        public string SalesItemsPerUnit { get; set; }

        [StringLength(1000)]
        public string SalesPackagingUnit { get; set; }

        [StringLength(1000)]
        public string SalesQtyPerPackUnit { get; set; }

        [StringLength(1000)]
        public string SalesUnitLength { get; set; }

        [StringLength(1000)]
        public string SalesLengthUnit { get; set; }

        [StringLength(1000)]
        public string SalesUnitWidth { get; set; }

        [StringLength(1000)]
        public string SalesWidthUnit { get; set; }

        [StringLength(1000)]
        public string SalesUnitHeight { get; set; }

        [StringLength(1000)]
        public string SalesHeightUnit { get; set; }

        [StringLength(1000)]
        public string SalesUnitVolume { get; set; }

        [StringLength(1000)]
        public string SalesVolumeUnit { get; set; }

        [StringLength(1000)]
        public string SalesUnitWeight { get; set; }

        [StringLength(1000)]
        public string SalesWeightUnit { get; set; }

        [StringLength(1000)]
        public string PurchaseUnit { get; set; }

        [StringLength(1000)]
        public string PurchaseItemsPerUnit { get; set; }

        [StringLength(1000)]
        public string PurchasePackagingUnit { get; set; }

        [StringLength(1000)]
        public string PurchaseQtyPerPackUnit { get; set; }

        [StringLength(1000)]
        public string PurchaseUnitLength { get; set; }

        [StringLength(1000)]
        public string PurchaseLengthUnit { get; set; }

        [StringLength(1000)]
        public string PurchaseUnitWidth { get; set; }

        [StringLength(1000)]
        public string PurchaseWidthUnit { get; set; }

        [StringLength(1000)]
        public string PurchaseUnitHeight { get; set; }

        [StringLength(1000)]
        public string PurchaseHeightUnit { get; set; }

        [StringLength(1000)]
        public string PurchaseUnitVolume { get; set; }

        [StringLength(1000)]
        public string PurchaseVolumeUnit { get; set; }

        [StringLength(1000)]
        public string PurchaseUnitWeight { get; set; }

        [StringLength(1000)]
        public string PurchaseWeightUnit { get; set; }

        [StringLength(1000)]
        public string PurchaseVATGroup { get; set; }

        [StringLength(1000)]
        public string SalesFactor1 { get; set; }

        [StringLength(1000)]
        public string SalesFactor2 { get; set; }

        [StringLength(1000)]
        public string SalesFactor3 { get; set; }

        [StringLength(1000)]
        public string SalesFactor4 { get; set; }

        [StringLength(1000)]
        public string PurchaseFactor1 { get; set; }

        [StringLength(1000)]
        public string PurchaseFactor2 { get; set; }

        [StringLength(1000)]
        public string PurchaseFactor3 { get; set; }

        [StringLength(1000)]
        public string PurchaseFactor4 { get; set; }

        [StringLength(1000)]
        public string MovingAveragePrice { get; set; }

        [StringLength(1000)]
        public string ForeignRevenuesAccount { get; set; }

        [StringLength(1000)]
        public string ECRevenuesAccount { get; set; }

        [StringLength(1000)]
        public string ForeignExpensesAccount { get; set; }

        [StringLength(1000)]
        public string ECExpensesAccount { get; set; }

        [StringLength(1000)]
        public string AvgStdPrice { get; set; }

        [StringLength(1000)]
        public string DefaultWarehouse { get; set; }

        [StringLength(1000)]
        public string ShipType { get; set; }

        [StringLength(1000)]
        public string GLMethod { get; set; }

        [StringLength(1000)]
        public string TaxType { get; set; }

        [StringLength(1000)]
        public string MaxInventory { get; set; }

        [StringLength(1000)]
        public string ManageStockByWarehouse { get; set; }

        [StringLength(1000)]
        public string PurchaseHeightUnit1 { get; set; }

        [StringLength(1000)]
        public string PurchaseUnitHeight1 { get; set; }

        [StringLength(1000)]
        public string PurchaseLengthUnit1 { get; set; }

        [StringLength(1000)]
        public string PurchaseUnitLength1 { get; set; }

        [StringLength(1000)]
        public string PurchaseWeightUnit1 { get; set; }

        [StringLength(1000)]
        public string PurchaseUnitWeight1 { get; set; }

        [StringLength(1000)]
        public string PurchaseWidthUnit1 { get; set; }

        [StringLength(1000)]
        public string PurchaseUnitWidth1 { get; set; }

        [StringLength(1000)]
        public string SalesHeightUnit1 { get; set; }

        [StringLength(1000)]
        public string SalesUnitHeight1 { get; set; }

        [StringLength(1000)]
        public string SalesLengthUnit1 { get; set; }

        [StringLength(1000)]
        public string SalesUnitLength1 { get; set; }

        [StringLength(1000)]
        public string SalesWeightUnit1 { get; set; }

        [StringLength(1000)]
        public string SalesUnitWeight1 { get; set; }

        [StringLength(1000)]
        public string SalesWidthUnit1 { get; set; }

        [StringLength(1000)]
        public string SalesUnitWidth1 { get; set; }

        [StringLength(1000)]
        public string ForceSelectionOfSerialNumber { get; set; }

        [StringLength(1000)]
        public string ManageSerialNumbersOnReleaseOnly { get; set; }

        [StringLength(1000)]
        public string WTLiable { get; set; }

        [StringLength(1000)]
        public string CostAccountingMethod { get; set; }

        [StringLength(1000)]
        public string SWW { get; set; }

        [StringLength(1000)]
        public string WarrantyTemplate { get; set; }

        [StringLength(1000)]
        public string IndirectTax { get; set; }

        [StringLength(1000)]
        public string ArTaxCode { get; set; }

        [StringLength(1000)]
        public string ApTaxCode { get; set; }

        [StringLength(1000)]
        public string BaseUnitName { get; set; }

        [StringLength(1000)]
        public string ItemCountryOrg { get; set; }

        [StringLength(1000)]
        public string IssueMethod { get; set; }

        [StringLength(1000)]
        public string SRIAndBatchManageMethod { get; set; }

        [StringLength(1000)]
        public string IsPhantom { get; set; }

        [StringLength(1000)]
        public string InventoryUOM { get; set; }

        [StringLength(1000)]
        public string PlanningSystem { get; set; }

        [StringLength(1000)]
        public string ProcurementMethod { get; set; }

        [StringLength(1000)]
        public string ComponentWarehouse { get; set; }

        [StringLength(1000)]
        public string OrderIntervals { get; set; }

        [StringLength(1000)]
        public string OrderMultiple { get; set; }

        [StringLength(1000)]
        public string LeadTime { get; set; }

        [StringLength(1000)]
        public string MinOrderQuantity { get; set; }

        [StringLength(1000)]
        public string ItemType { get; set; }

        [StringLength(1000)]
        public string ItemClass { get; set; }

        [StringLength(1000)]
        public string OutgoingServiceCode { get; set; }

        [StringLength(1000)]
        public string IncomingServiceCode { get; set; }

        [StringLength(1000)]
        public string ServiceGroup { get; set; }

        [StringLength(1000)]
        public string NCMCode { get; set; }

        [StringLength(1000)]
        public string MaterialType { get; set; }

        [StringLength(1000)]
        public string MaterialGroup { get; set; }

        [StringLength(1000)]
        public string ProductSource { get; set; }

        [StringLength(1000)]
        public string Properties1 { get; set; }

        [StringLength(1000)]
        public string Properties2 { get; set; }

        [StringLength(1000)]
        public string Properties3 { get; set; }

        [StringLength(1000)]
        public string Properties4 { get; set; }

        [StringLength(1000)]
        public string Properties5 { get; set; }

        [StringLength(1000)]
        public string Properties6 { get; set; }

        [StringLength(1000)]
        public string Properties7 { get; set; }

        [StringLength(1000)]
        public string Properties8 { get; set; }

        [StringLength(1000)]
        public string Properties9 { get; set; }

        [StringLength(1000)]
        public string Properties10 { get; set; }

        [StringLength(1000)]
        public string Properties11 { get; set; }

        [StringLength(1000)]
        public string Properties12 { get; set; }

        [StringLength(1000)]
        public string Properties13 { get; set; }

        [StringLength(1000)]
        public string Properties14 { get; set; }

        [StringLength(1000)]
        public string Properties15 { get; set; }

        [StringLength(1000)]
        public string Properties16 { get; set; }

        [StringLength(1000)]
        public string Properties17 { get; set; }

        [StringLength(1000)]
        public string Properties18 { get; set; }

        [StringLength(1000)]
        public string Properties19 { get; set; }

        [StringLength(1000)]
        public string Properties20 { get; set; }

        [StringLength(1000)]
        public string Properties21 { get; set; }

        [StringLength(1000)]
        public string Properties22 { get; set; }

        [StringLength(1000)]
        public string Properties23 { get; set; }

        [StringLength(1000)]
        public string Properties24 { get; set; }

        [StringLength(1000)]
        public string Properties25 { get; set; }

        [StringLength(1000)]
        public string Properties26 { get; set; }

        [StringLength(1000)]
        public string Properties27 { get; set; }

        [StringLength(1000)]
        public string Properties28 { get; set; }

        [StringLength(1000)]
        public string Properties29 { get; set; }

        [StringLength(1000)]
        public string Properties30 { get; set; }

        [StringLength(1000)]
        public string Properties31 { get; set; }

        [StringLength(1000)]
        public string Properties32 { get; set; }

        [StringLength(1000)]
        public string Properties33 { get; set; }

        [StringLength(1000)]
        public string Properties34 { get; set; }

        [StringLength(1000)]
        public string Properties35 { get; set; }

        [StringLength(1000)]
        public string Properties36 { get; set; }

        [StringLength(1000)]
        public string Properties37 { get; set; }

        [StringLength(1000)]
        public string Properties38 { get; set; }

        [StringLength(1000)]
        public string Properties39 { get; set; }

        [StringLength(1000)]
        public string Properties40 { get; set; }

        [StringLength(1000)]
        public string Properties41 { get; set; }

        [StringLength(1000)]
        public string Properties42 { get; set; }

        [StringLength(1000)]
        public string Properties43 { get; set; }

        [StringLength(1000)]
        public string Properties44 { get; set; }

        [StringLength(1000)]
        public string Properties45 { get; set; }

        [StringLength(1000)]
        public string Properties46 { get; set; }

        [StringLength(1000)]
        public string Properties47 { get; set; }

        [StringLength(1000)]
        public string Properties48 { get; set; }

        [StringLength(1000)]
        public string Properties49 { get; set; }

        [StringLength(1000)]
        public string Properties50 { get; set; }

        [StringLength(1000)]
        public string Properties51 { get; set; }

        [StringLength(1000)]
        public string Properties52 { get; set; }

        [StringLength(1000)]
        public string Properties53 { get; set; }

        [StringLength(1000)]
        public string Properties54 { get; set; }

        [StringLength(1000)]
        public string Properties55 { get; set; }

        [StringLength(1000)]
        public string Properties56 { get; set; }

        [StringLength(1000)]
        public string Properties57 { get; set; }

        [StringLength(1000)]
        public string Properties58 { get; set; }

        [StringLength(1000)]
        public string Properties59 { get; set; }

        [StringLength(1000)]
        public string Properties60 { get; set; }

        [StringLength(1000)]
        public string Properties61 { get; set; }

        [StringLength(1000)]
        public string Properties62 { get; set; }

        [StringLength(1000)]
        public string Properties63 { get; set; }

        [StringLength(1000)]
        public string Properties64 { get; set; }

        [StringLength(1000)]
        public string AutoCreateSerialNumbersOnRelease { get; set; }

        [StringLength(1000)]
        public string DNFEntry { get; set; }

        [StringLength(1000)]
        public string GTSItemSpec { get; set; }

        [StringLength(1000)]
        public string GTSItemTaxCategory { get; set; }

        [StringLength(1000)]
        public string FuelID { get; set; }

        [StringLength(1000)]
        public string BeverageTableCode { get; set; }

        [StringLength(1000)]
        public string BeverageGroupCode { get; set; }

        [StringLength(1000)]
        public string BeverageCommercialBrandCode { get; set; }

        [StringLength(1000)]
        public string Series { get; set; }

        [StringLength(1000)]
        public string ToleranceDays { get; set; }

        [StringLength(1000)]
        public string TypeOfAdvancedRules { get; set; }

        [StringLength(1000)]
        public string IssuePrimarilyBy { get; set; }

        [StringLength(1000)]
        public string NoDiscounts { get; set; }

        [StringLength(1000)]
        public string AssetClass { get; set; }

        [StringLength(1000)]
        public string AssetGroup { get; set; }

        [StringLength(1000)]
        public string InventoryNumber { get; set; }

        [StringLength(1000)]
        public string Technician { get; set; }

        [StringLength(1000)]
        public string Employee { get; set; }

        [StringLength(1000)]
        public string Location { get; set; }

        [StringLength(1000)]
        public string AssetStatus { get; set; }

        [StringLength(1000)]
        public string CapitalizationDate { get; set; }

        [StringLength(1000)]
        public string StatisticalAsset { get; set; }

        [StringLength(1000)]
        public string Cession { get; set; }

        [StringLength(1000)]
        public string DeactivateAfterUsefulLife { get; set; }

        [StringLength(1000)]
        public string ManageByQuantity { get; set; }

        [StringLength(1000)]
        public string UoMGroupEntry { get; set; }

        [StringLength(1000)]
        public string InventoryUoMEntry { get; set; }

        [StringLength(1000)]
        public string DefaultSalesUoMEntry { get; set; }

        [StringLength(1000)]
        public string DefaultPurchasingUoMEntry { get; set; }

        [StringLength(1000)]
        public string DepreciationGroup { get; set; }

        [StringLength(1000)]
        public string AssetSerialNumber { get; set; }

        [StringLength(1000)]
        public string InventoryWeight { get; set; }

        [StringLength(1000)]
        public string InventoryWeightUnit { get; set; }

        [StringLength(1000)]
        public string InventoryWeight1 { get; set; }

        [StringLength(1000)]
        public string InventoryWeightUnit1 { get; set; }

        [StringLength(1000)]
        public string DefaultCountingUnit { get; set; }

        [StringLength(1000)]
        public string CountingItemsPerUnit { get; set; }

        [StringLength(1000)]
        public string DefaultCountingUoMEntry { get; set; }

        [StringLength(1000)]
        public string Excisable { get; set; }

        [StringLength(1000)]
        public string ChapterID { get; set; }

        [StringLength(1000)]
        public string ScsCode { get; set; }

        [StringLength(1000)]
        public string SpProdType { get; set; }

        [StringLength(1000)]
        public string ProdStdCost { get; set; }

        [StringLength(1000)]
        public string InCostRollup { get; set; }

        [StringLength(1000)]
        public string VirtualAssetItem { get; set; }

        [StringLength(1000)]
        public string EnforceAssetSerialNumbers { get; set; }

        [StringLength(1000)]
        public string AttachmentEntry { get; set; }

        [StringLength(1000)]
        public string LinkedResource { get; set; }

        [StringLength(1000)]
        public string UpdateDate { get; set; }

        [StringLength(1000)]
        public string UpdateTime { get; set; }

        [StringLength(1000)]
        public string GSTRelevnt { get; set; }

        [StringLength(1000)]
        public string SACEntry { get; set; }

        [StringLength(1000)]
        public string GSTTaxCategory { get; set; }

        [StringLength(1000)]
        public string ServiceCategoryEntry { get; set; }

        [StringLength(1000)]
        public string CapitalGoodsOnHoldPercent { get; set; }

        [StringLength(1000)]
        public string CapitalGoodsOnHoldLimit { get; set; }

        [StringLength(1000)]
        public string AssessableValue { get; set; }

        [StringLength(1000)]
        public string AssVal4WTR { get; set; }

        [StringLength(1000)]
        public string SOIExcisable { get; set; }

        [StringLength(1000)]
        public string TNVED { get; set; }

        [StringLength(1000)]
        public string ImportedItem { get; set; }

        [StringLength(1000)]
        public string PricingUnit { get; set; }

        [StringLength(1000)]
        public string CreateDate { get; set; }

        [StringLength(1000)]
        public string CreateTime { get; set; }

        [StringLength(1000)]
        public string NVECode { get; set; }

        [StringLength(1000)]
        public string CtrSealQty { get; set; }

        [StringLength(1000)]
        public string CESTCode { get; set; }

        [StringLength(1000)]
        public string LegalText { get; set; }

        [StringLength(1000)]
        public string DataVersion { get; set; }

        [StringLength(1000)]
        public string CreateQRCodeFrom { get; set; }

        [StringLength(1000)]
        public string TraceableItem { get; set; }

        [StringLength(1000)]
        public string CommodityClassification { get; set; }

        [StringLength(1000)]
        public string WeightOfRecycledPlastic { get; set; }

        [StringLength(1000)]
        public string PlasticPackageTaxCategory { get; set; }

        [StringLength(1000)]
        public string PlasticPackageExemptionReasonForPurchase { get; set; }

        [StringLength(1000)]
        public string PlasticPackageExemptionReasonForProduction { get; set; }

        [StringLength(1000)]
        public string SAFTProductType { get; set; }
    }
}
