namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Invoice_DocumentLine
    {
        public int Id { get; set; }

        [StringLength(1000)]
        public string LineNum { get; set; }

        [StringLength(1000)]
        public string ItemCode { get; set; }

        [StringLength(1000)]
        public string ItemDescription { get; set; }

        [StringLength(1000)]
        public string Quantity { get; set; }

        [StringLength(1000)]
        public string ShipDate { get; set; }

        [StringLength(1000)]
        public string Price { get; set; }

        [StringLength(1000)]
        public string PriceAfterVAT { get; set; }

        [StringLength(1000)]
        public string Currency { get; set; }

        [StringLength(1000)]
        public string Rate { get; set; }

        [StringLength(1000)]
        public string DiscountPercent { get; set; }

        [StringLength(1000)]
        public string VendorNum { get; set; }

        [StringLength(1000)]
        public string SerialNum { get; set; }

        [StringLength(1000)]
        public string WarehouseCode { get; set; }

        [StringLength(1000)]
        public string SalesPersonCode { get; set; }

        [StringLength(1000)]
        public string CommisionPercent { get; set; }

        [StringLength(1000)]
        public string TreeType { get; set; }

        [StringLength(1000)]
        public string AccountCode { get; set; }

        [StringLength(1000)]
        public string UseBaseUnits { get; set; }

        [StringLength(1000)]
        public string SupplierCatNum { get; set; }

        [StringLength(1000)]
        public string CostingCode { get; set; }

        [StringLength(1000)]
        public string ProjectCode { get; set; }

        [StringLength(1000)]
        public string BarCode { get; set; }

        [StringLength(1000)]
        public string VatGroup { get; set; }

        [StringLength(1000)]
        public string Height1 { get; set; }

        [StringLength(1000)]
        public string Hight1Unit { get; set; }

        [StringLength(1000)]
        public string Height2 { get; set; }

        [StringLength(1000)]
        public string Height2Unit { get; set; }

        [StringLength(1000)]
        public string Lengh1 { get; set; }

        [StringLength(1000)]
        public string Lengh1Unit { get; set; }

        [StringLength(1000)]
        public string Lengh2 { get; set; }

        [StringLength(1000)]
        public string Lengh2Unit { get; set; }

        [StringLength(1000)]
        public string Weight1 { get; set; }

        [StringLength(1000)]
        public string Weight1Unit { get; set; }

        [StringLength(1000)]
        public string Weight2 { get; set; }

        [StringLength(1000)]
        public string Weight2Unit { get; set; }

        [StringLength(1000)]
        public string Factor1 { get; set; }

        [StringLength(1000)]
        public string Factor2 { get; set; }

        [StringLength(1000)]
        public string Factor3 { get; set; }

        [StringLength(1000)]
        public string Factor4 { get; set; }

        [StringLength(1000)]
        public string BaseType { get; set; }

        [StringLength(1000)]
        public string BaseEntry { get; set; }

        [StringLength(1000)]
        public string BaseLine { get; set; }

        [StringLength(1000)]
        public string Volume { get; set; }

        [StringLength(1000)]
        public string VolumeUnit { get; set; }

        [StringLength(1000)]
        public string Width1 { get; set; }

        [StringLength(1000)]
        public string Width1Unit { get; set; }

        [StringLength(1000)]
        public string Width2 { get; set; }

        [StringLength(1000)]
        public string Width2Unit { get; set; }

        [StringLength(1000)]
        public string Address { get; set; }

        [StringLength(1000)]
        public string TaxCode { get; set; }

        [StringLength(1000)]
        public string TaxType { get; set; }

        [StringLength(1000)]
        public string TaxLiable { get; set; }

        [StringLength(1000)]
        public string PickStatus { get; set; }

        [StringLength(1000)]
        public string PickQuantity { get; set; }

        [StringLength(1000)]
        public string PickListIdNumber { get; set; }

        [StringLength(1000)]
        public string OriginalItem { get; set; }

        [StringLength(1000)]
        public string BackOrder { get; set; }

        [StringLength(1000)]
        public string FreeText { get; set; }

        [StringLength(1000)]
        public string ShippingMethod { get; set; }

        [StringLength(1000)]
        public string POTargetNum { get; set; }

        [StringLength(1000)]
        public string POTargetEntry { get; set; }

        [StringLength(1000)]
        public string POTargetRowNum { get; set; }

        [StringLength(1000)]
        public string CorrectionInvoiceItem { get; set; }

        [StringLength(1000)]
        public string CorrInvAmountToStock { get; set; }

        [StringLength(1000)]
        public string CorrInvAmountToDiffAcct { get; set; }

        [StringLength(1000)]
        public string AppliedTax { get; set; }

        [StringLength(1000)]
        public string AppliedTaxFC { get; set; }

        [StringLength(1000)]
        public string AppliedTaxSC { get; set; }

        [StringLength(1000)]
        public string WTLiable { get; set; }

        [StringLength(1000)]
        public string DeferredTax { get; set; }

        [StringLength(1000)]
        public string EqualizationTaxPercent { get; set; }

        [StringLength(1000)]
        public string TotalEqualizationTax { get; set; }

        [StringLength(1000)]
        public string TotalEqualizationTaxFC { get; set; }

        [StringLength(1000)]
        public string TotalEqualizationTaxSC { get; set; }

        [StringLength(1000)]
        public string NetTaxAmount { get; set; }

        [StringLength(1000)]
        public string NetTaxAmountFC { get; set; }

        [StringLength(1000)]
        public string NetTaxAmountSC { get; set; }

        [StringLength(1000)]
        public string MeasureUnit { get; set; }

        [StringLength(1000)]
        public string UnitsOfMeasurment { get; set; }

        [StringLength(1000)]
        public string LineTotal { get; set; }

        [StringLength(1000)]
        public string TaxPercentagePerRow { get; set; }

        [StringLength(1000)]
        public string TaxTotal { get; set; }

        [StringLength(1000)]
        public string ConsumerSalesForecast { get; set; }

        [StringLength(1000)]
        public string ExciseAmount { get; set; }

        [StringLength(1000)]
        public string TaxPerUnit { get; set; }

        [StringLength(1000)]
        public string TotalInclTax { get; set; }

        [StringLength(1000)]
        public string CountryOrg { get; set; }

        [StringLength(1000)]
        public string SWW { get; set; }

        [StringLength(1000)]
        public string TransactionType { get; set; }

        [StringLength(1000)]
        public string DistributeExpense { get; set; }

        [StringLength(1000)]
        public string RowTotalFC { get; set; }

        [StringLength(1000)]
        public string RowTotalSC { get; set; }

        [StringLength(1000)]
        public string LastBuyInmPrice { get; set; }

        [StringLength(1000)]
        public string LastBuyDistributeSumFc { get; set; }

        [StringLength(1000)]
        public string LastBuyDistributeSumSc { get; set; }

        [StringLength(1000)]
        public string LastBuyDistributeSum { get; set; }

        [StringLength(1000)]
        public string StockDistributesumForeign { get; set; }

        [StringLength(1000)]
        public string StockDistributesumSystem { get; set; }

        [StringLength(1000)]
        public string StockDistributesum { get; set; }

        [StringLength(1000)]
        public string StockInmPrice { get; set; }

        [StringLength(1000)]
        public string PickStatusEx { get; set; }

        [StringLength(1000)]
        public string TaxBeforeDPM { get; set; }

        [StringLength(1000)]
        public string TaxBeforeDPMFC { get; set; }

        [StringLength(1000)]
        public string TaxBeforeDPMSC { get; set; }

        [StringLength(1000)]
        public string CFOPCode { get; set; }

        [StringLength(1000)]
        public string CSTCode { get; set; }

        [StringLength(1000)]
        public string Usage { get; set; }

        [StringLength(1000)]
        public string TaxOnly { get; set; }

        [StringLength(1000)]
        public string VisualOrder { get; set; }

        [StringLength(1000)]
        public string BaseOpenQuantity { get; set; }

        [StringLength(1000)]
        public string UnitPrice { get; set; }

        [StringLength(1000)]
        public string LineStatus { get; set; }

        [StringLength(1000)]
        public string PackageQuantity { get; set; }

        [StringLength(1000)]
        public string Text { get; set; }

        [StringLength(1000)]
        public string LineType { get; set; }

        [StringLength(1000)]
        public string COGSCostingCode { get; set; }

        [StringLength(1000)]
        public string COGSAccountCode { get; set; }

        [StringLength(1000)]
        public string ChangeAssemlyBoMWarehouse { get; set; }

        [StringLength(1000)]
        public string GrossBuyPrice { get; set; }

        [StringLength(1000)]
        public string GrossBase { get; set; }

        [StringLength(1000)]
        public string GrossProfitTotalBasePrice { get; set; }

        [StringLength(1000)]
        public string CostingCode2 { get; set; }

        [StringLength(1000)]
        public string CostingCode3 { get; set; }

        [StringLength(1000)]
        public string CostingCode4 { get; set; }

        [StringLength(1000)]
        public string CostingCode5 { get; set; }

        [StringLength(1000)]
        public string ItemDetails { get; set; }

        [StringLength(1000)]
        public string LocationCode { get; set; }

        [StringLength(1000)]
        public string ActualDeliveryDate { get; set; }

        [StringLength(1000)]
        public string RemainingOpenQuantity { get; set; }

        [StringLength(1000)]
        public string OpenAmount { get; set; }

        [StringLength(1000)]
        public string OpenAmountFC { get; set; }

        [StringLength(1000)]
        public string OpenAmountSC { get; set; }

        [StringLength(1000)]
        public string ExLineNo { get; set; }

        [StringLength(1000)]
        public string RequiredDate { get; set; }

        [StringLength(1000)]
        public string RequiredQuantity { get; set; }

        [StringLength(1000)]
        public string COGSCostingCode2 { get; set; }

        [StringLength(1000)]
        public string COGSCostingCode3 { get; set; }

        [StringLength(1000)]
        public string COGSCostingCode4 { get; set; }

        [StringLength(1000)]
        public string COGSCostingCode5 { get; set; }

        [StringLength(1000)]
        public string CSTforIPI { get; set; }

        [StringLength(1000)]
        public string CSTforPIS { get; set; }

        [StringLength(1000)]
        public string CSTforCOFINS { get; set; }

        [StringLength(1000)]
        public string CreditOriginCode { get; set; }

        [StringLength(1000)]
        public string WithoutInventoryMovement { get; set; }

        [StringLength(1000)]
        public string AgreementNo { get; set; }

        [StringLength(1000)]
        public string AgreementRowNumber { get; set; }

        [StringLength(1000)]
        public string ActualBaseEntry { get; set; }

        [StringLength(1000)]
        public string ActualBaseLine { get; set; }

        [StringLength(1000)]
        public string DocEntry { get; set; }

        [StringLength(1000)]
        public string Surpluses { get; set; }

        [StringLength(1000)]
        public string DefectAndBreakup { get; set; }

        [StringLength(1000)]
        public string Shortages { get; set; }

        [StringLength(1000)]
        public string ConsiderQuantity { get; set; }

        [StringLength(1000)]
        public string PartialRetirement { get; set; }

        [StringLength(1000)]
        public string RetirementQuantity { get; set; }

        [StringLength(1000)]
        public string RetirementAPC { get; set; }

        [StringLength(1000)]
        public string ThirdParty { get; set; }

        [StringLength(1000)]
        public string PoNum { get; set; }

        [StringLength(1000)]
        public string PoItmNum { get; set; }

        [StringLength(1000)]
        public string ExpenseType { get; set; }

        [StringLength(1000)]
        public string ReceiptNumber { get; set; }

        [StringLength(1000)]
        public string ExpenseOperationType { get; set; }

        [StringLength(1000)]
        public string FederalTaxID { get; set; }

        [StringLength(1000)]
        public string GrossProfit { get; set; }

        [StringLength(1000)]
        public string GrossProfitFC { get; set; }

        [StringLength(1000)]
        public string GrossProfitSC { get; set; }

        [StringLength(1000)]
        public string PriceSource { get; set; }

        [StringLength(1000)]
        public string StgSeqNum { get; set; }

        [StringLength(1000)]
        public string StgEntry { get; set; }

        [StringLength(1000)]
        public string StgDesc { get; set; }

        [StringLength(1000)]
        public string UoMEntry { get; set; }

        [StringLength(1000)]
        public string UoMCode { get; set; }

        [StringLength(1000)]
        public string InventoryQuantity { get; set; }

        [StringLength(1000)]
        public string RemainingOpenInventoryQuantity { get; set; }

        [StringLength(1000)]
        public string ParentLineNum { get; set; }

        [StringLength(1000)]
        public string Incoterms { get; set; }

        [StringLength(1000)]
        public string TransportMode { get; set; }

        [StringLength(1000)]
        public string NatureOfTransaction { get; set; }

        [StringLength(1000)]
        public string DestinationCountryForImport { get; set; }

        [StringLength(1000)]
        public string DestinationRegionForImport { get; set; }

        [StringLength(1000)]
        public string OriginCountryForExport { get; set; }

        [StringLength(1000)]
        public string OriginRegionForExport { get; set; }

        [StringLength(1000)]
        public string ItemType { get; set; }

        [StringLength(1000)]
        public string ChangeInventoryQuantityIndependently { get; set; }

        [StringLength(1000)]
        public string FreeOfChargeBP { get; set; }

        [StringLength(1000)]
        public string SACEntry { get; set; }

        [StringLength(1000)]
        public string HSNEntry { get; set; }

        [StringLength(1000)]
        public string GrossPrice { get; set; }

        [StringLength(1000)]
        public string GrossTotal { get; set; }

        [StringLength(1000)]
        public string GrossTotalFC { get; set; }

        [StringLength(1000)]
        public string GrossTotalSC { get; set; }

        [StringLength(1000)]
        public string NCMCode { get; set; }

        [StringLength(1000)]
        public string NVECode { get; set; }

        [StringLength(1000)]
        public string IndEscala { get; set; }

        [StringLength(1000)]
        public string CtrSealQty { get; set; }

        [StringLength(1000)]
        public string CNJPMan { get; set; }

        [StringLength(1000)]
        public string CESTCode { get; set; }

        [StringLength(1000)]
        public string UFFiscalBenefitCode { get; set; }

        [StringLength(1000)]
        public string ReverseCharge { get; set; }

        [StringLength(1000)]
        public string ShipToCode { get; set; }

        [StringLength(1000)]
        public string ShipToDescription { get; set; }

        [StringLength(1000)]
        public string OwnerCode { get; set; }

        [StringLength(1000)]
        public string ExternalCalcTaxRate { get; set; }

        [StringLength(1000)]
        public string ExternalCalcTaxAmount { get; set; }

        [StringLength(1000)]
        public string ExternalCalcTaxAmountFC { get; set; }

        [StringLength(1000)]
        public string ExternalCalcTaxAmountSC { get; set; }

        [StringLength(1000)]
        public string StandardItemIdentification { get; set; }

        [StringLength(1000)]
        public string CommodityClassification { get; set; }

        [StringLength(1000)]
        public string WeightOfRecycledPlastic { get; set; }

        [StringLength(1000)]
        public string PlasticPackageExemptionReason { get; set; }

        [StringLength(1000)]
        public string LegalText { get; set; }

        [StringLength(1000)]
        public string Cig { get; set; }

        [StringLength(1000)]
        public string Cup { get; set; }

        [StringLength(1000)]
        public string UnencumberedReason { get; set; }

        [StringLength(1000)]
        public string CUSplit { get; set; }

        [StringLength(1000)]
        public string ListNum { get; set; }

        [StringLength(1000)]
        public string RecognizedTaxCode { get; set; }
    }
}
