using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Sap.Core;

namespace Sap.Api.Domain.CreditNotes
{
	public partial class DocumentLine : BaseEntity
	{
		#region Fields
		[JsonProperty("LineNum")]
		public int? LineNum;

		[JsonProperty("ItemCode")]
		public string ItemCode;

		[JsonProperty("ItemDescription")]
		public string ItemDescription;

		[JsonProperty("Quantity")]
		public decimal? Quantity;

		[JsonProperty("ShipDate")]
		public string ShipDate;

		[JsonProperty("Price")]
		public decimal? Price;

		[JsonProperty("PriceAfterVAT")]
		public decimal? PriceAfterVAT;

		[JsonProperty("Currency")]
		public string Currency;

		[JsonProperty("Rate")]
		public decimal? Rate;

		[JsonProperty("DiscountPercent")]
		public decimal? DiscountPercent;

		[JsonProperty("VendorNum")]
		public string VendorNum;

		[JsonProperty("SerialNum")]
		public string SerialNum;

		[JsonProperty("WarehouseCode")]
		public string WarehouseCode;

		[JsonProperty("SalesPersonCode")]
		public int? SalesPersonCode;

		[JsonProperty("CommisionPercent")]
		public decimal? CommisionPercent;

		[JsonProperty("TreeType")]
		public string TreeType;

		[JsonProperty("AccountCode")]
		public string AccountCode;

		[JsonProperty("UseBaseUnits")]
		public string UseBaseUnits;

		[JsonProperty("SupplierCatNum")]
		public string SupplierCatNum;

		[JsonProperty("CostingCode")]
		public string CostingCode;

		[JsonProperty("ProjectCode")]
		public string ProjectCode;

		[JsonProperty("BarCode")]
		public string BarCode;

		[JsonProperty("VatGroup")]
		public string VatGroup;

		[JsonProperty("Height1")]
		public decimal? Height1;

		[JsonProperty("Hight1Unit")]
		public string Hight1Unit;

		[JsonProperty("Height2")]
		public decimal? Height2;

		[JsonProperty("Height2Unit")]
		public string Height2Unit;

		[JsonProperty("Lengh1")]
		public decimal? Lengh1;

		[JsonProperty("Lengh1Unit")]
		public string Lengh1Unit;

		[JsonProperty("Lengh2")]
		public decimal? Lengh2;

		[JsonProperty("Lengh2Unit")]
		public string Lengh2Unit;

		[JsonProperty("Weight1")]
		public decimal? Weight1;

		[JsonProperty("Weight1Unit")]
		public string Weight1Unit;

		[JsonProperty("Weight2")]
		public decimal? Weight2;

		[JsonProperty("Weight2Unit")]
		public string Weight2Unit;

		[JsonProperty("Factor1")]
		public decimal? Factor1;

		[JsonProperty("Factor2")]
		public decimal? Factor2;

		[JsonProperty("Factor3")]
		public decimal? Factor3;

		[JsonProperty("Factor4")]
		public decimal? Factor4;

		[JsonProperty("BaseType")]
		public int? BaseType;

		[JsonProperty("BaseEntry")]
		public string BaseEntry;

		[JsonProperty("BaseLine")]
		public string BaseLine;

		[JsonProperty("Volume")]
		public decimal? Volume;

		[JsonProperty("VolumeUnit")]
		public string VolumeUnit;

		[JsonProperty("Width1")]
		public decimal? Width1;

		[JsonProperty("Width1Unit")]
		public string Width1Unit;

		[JsonProperty("Width2")]
		public decimal? Width2;

		[JsonProperty("Width2Unit")]
		public string Width2Unit;

		[JsonProperty("Address")]
		public string Address;

		[JsonProperty("TaxCode")]
		public string TaxCode;

		[JsonProperty("TaxType")]
		public string TaxType;

		[JsonProperty("TaxLiable")]
		public string TaxLiable;

		[JsonProperty("PickStatus")]
		public string PickStatus;

		[JsonProperty("PickQuantity")]
		public decimal? PickQuantity;

		[JsonProperty("PickListIdNumber")]
		public string PickListIdNumber;

		[JsonProperty("OriginalItem")]
		public string OriginalItem;

		[JsonProperty("BackOrder")]
		public string BackOrder;

		[JsonProperty("FreeText")]
		public string FreeText;

		[JsonProperty("ShippingMethod")]
		public int? ShippingMethod;

		[JsonProperty("POTargetNum")]
		public string POTargetNum;

		[JsonProperty("POTargetEntry")]
		public string POTargetEntry;

		[JsonProperty("POTargetRowNum")]
		public string POTargetRowNum;

		[JsonProperty("CorrectionInvoiceItem")]
		public string CorrectionInvoiceItem;

		[JsonProperty("CorrInvAmountToStock")]
		public decimal? CorrInvAmountToStock;

		[JsonProperty("CorrInvAmountToDiffAcct")]
		public decimal? CorrInvAmountToDiffAcct;

		[JsonProperty("AppliedTax")]
		public decimal? AppliedTax;

		[JsonProperty("AppliedTaxFC")]
		public decimal? AppliedTaxFC;

		[JsonProperty("AppliedTaxSC")]
		public decimal? AppliedTaxSC;

		[JsonProperty("WTLiable")]
		public string WTLiable;

		[JsonProperty("DeferredTax")]
		public string DeferredTax;

		[JsonProperty("EqualizationTaxPercent")]
		public decimal? EqualizationTaxPercent;

		[JsonProperty("TotalEqualizationTax")]
		public decimal? TotalEqualizationTax;

		[JsonProperty("TotalEqualizationTaxFC")]
		public decimal? TotalEqualizationTaxFC;

		[JsonProperty("TotalEqualizationTaxSC")]
		public decimal? TotalEqualizationTaxSC;

		[JsonProperty("NetTaxAmount")]
		public decimal? NetTaxAmount;

		[JsonProperty("NetTaxAmountFC")]
		public decimal? NetTaxAmountFC;

		[JsonProperty("NetTaxAmountSC")]
		public decimal? NetTaxAmountSC;

		[JsonProperty("MeasureUnit")]
		public string MeasureUnit;

		[JsonProperty("UnitsOfMeasurment")]
		public decimal? UnitsOfMeasurment;

		[JsonProperty("LineTotal")]
		public decimal? LineTotal;

		[JsonProperty("TaxPercentagePerRow")]
		public decimal? TaxPercentagePerRow;

		[JsonProperty("TaxTotal")]
		public decimal? TaxTotal;

		[JsonProperty("ConsumerSalesForecast")]
		public string ConsumerSalesForecast;

		[JsonProperty("ExciseAmount")]
		public decimal? ExciseAmount;

		[JsonProperty("TaxPerUnit")]
		public decimal? TaxPerUnit;

		[JsonProperty("TotalInclTax")]
		public decimal? TotalInclTax;

		[JsonProperty("CountryOrg")]
		public string CountryOrg;

		[JsonProperty("SWW")]
		public string SWW;

		[JsonProperty("TransactionType")]
		public string TransactionType;

		[JsonProperty("DistributeExpense")]
		public string DistributeExpense;

		[JsonProperty("RowTotalFC")]
		public decimal? RowTotalFC;

		[JsonProperty("RowTotalSC")]
		public decimal? RowTotalSC;

		[JsonProperty("LastBuyInmPrice")]
		public decimal? LastBuyInmPrice;

		[JsonProperty("LastBuyDistributeSumFc")]
		public decimal? LastBuyDistributeSumFc;

		[JsonProperty("LastBuyDistributeSumSc")]
		public decimal? LastBuyDistributeSumSc;

		[JsonProperty("LastBuyDistributeSum")]
		public decimal? LastBuyDistributeSum;

		[JsonProperty("StockDistributesumForeign")]
		public decimal? StockDistributesumForeign;

		[JsonProperty("StockDistributesumSystem")]
		public decimal? StockDistributesumSystem;

		[JsonProperty("StockDistributesum")]
		public decimal? StockDistributesum;

		[JsonProperty("StockInmPrice")]
		public decimal? StockInmPrice;

		[JsonProperty("PickStatusEx")]
		public string PickStatusEx;

		[JsonProperty("TaxBeforeDPM")]
		public decimal? TaxBeforeDPM;

		[JsonProperty("TaxBeforeDPMFC")]
		public decimal? TaxBeforeDPMFC;

		[JsonProperty("TaxBeforeDPMSC")]
		public decimal? TaxBeforeDPMSC;

		[JsonProperty("CFOPCode")]
		public string CFOPCode;

		[JsonProperty("CSTCode")]
		public string CSTCode;

		[JsonProperty("Usage")]
		public string Usage;

		[JsonProperty("TaxOnly")]
		public string TaxOnly;

		[JsonProperty("VisualOrder")]
		public int? VisualOrder;

		[JsonProperty("BaseOpenQuantity")]
		public decimal? BaseOpenQuantity;

		[JsonProperty("UnitPrice")]
		public decimal? UnitPrice;

		[JsonProperty("LineStatus")]
		public string LineStatus;

		[JsonProperty("PackageQuantity")]
		public decimal? PackageQuantity;

		[JsonProperty("Text")]
		public string Text;

		[JsonProperty("LineType")]
		public string LineType;

		[JsonProperty("COGSCostingCode")]
		public string COGSCostingCode;

		[JsonProperty("COGSAccountCode")]
		public string COGSAccountCode;

		[JsonProperty("ChangeAssemlyBoMWarehouse")]
		public string ChangeAssemlyBoMWarehouse;

		[JsonProperty("GrossBuyPrice")]
		public decimal? GrossBuyPrice;

		[JsonProperty("GrossBase")]
		public int? GrossBase;

		[JsonProperty("GrossProfitTotalBasePrice")]
		public decimal? GrossProfitTotalBasePrice;

		[JsonProperty("CostingCode2")]
		public string CostingCode2;

		[JsonProperty("CostingCode3")]
		public string CostingCode3;

		[JsonProperty("CostingCode4")]
		public string CostingCode4;

		[JsonProperty("CostingCode5")]
		public string CostingCode5;

		[JsonProperty("ItemDetails")]
		public string ItemDetails;

		[JsonProperty("LocationCode")]
		public string LocationCode;

		[JsonProperty("ActualDeliveryDate")]
		public DateTime? ActualDeliveryDate;

		[JsonProperty("RemainingOpenQuantity")]
		public decimal? RemainingOpenQuantity;

		[JsonProperty("OpenAmount")]
		public decimal? OpenAmount;

		[JsonProperty("OpenAmountFC")]
		public decimal? OpenAmountFC;

		[JsonProperty("OpenAmountSC")]
		public decimal? OpenAmountSC;

		[JsonProperty("ExLineNo")]
		public string ExLineNo;

		[JsonProperty("RequiredDate")]
		public string RequiredDate;

		[JsonProperty("RequiredQuantity")]
		public decimal? RequiredQuantity;

		[JsonProperty("COGSCostingCode2")]
		public string COGSCostingCode2;

		[JsonProperty("COGSCostingCode3")]
		public string COGSCostingCode3;

		[JsonProperty("COGSCostingCode4")]
		public string COGSCostingCode4;

		[JsonProperty("COGSCostingCode5")]
		public string COGSCostingCode5;

		[JsonProperty("CSTforIPI")]
		public string CSTforIPI;

		[JsonProperty("CSTforPIS")]
		public string CSTforPIS;

		[JsonProperty("CSTforCOFINS")]
		public string CSTforCOFINS;

		[JsonProperty("CreditOriginCode")]
		public string CreditOriginCode;

		[JsonProperty("WithoutInventoryMovement")]
		public string WithoutInventoryMovement;

		[JsonProperty("AgreementNo")]
		public string AgreementNo;

		[JsonProperty("AgreementRowNumber")]
		public string AgreementRowNumber;

		[JsonProperty("ActualBaseEntry")]
		public string ActualBaseEntry;

		[JsonProperty("ActualBaseLine")]
		public string ActualBaseLine;

		[JsonProperty("DocEntry")]
		public int? DocEntry;

		[JsonProperty("Surpluses")]
		public decimal? Surpluses;

		[JsonProperty("DefectAndBreakup")]
		public decimal? DefectAndBreakup;

		[JsonProperty("Shortages")]
		public decimal? Shortages;

		[JsonProperty("ConsiderQuantity")]
		public string ConsiderQuantity;

		[JsonProperty("PartialRetirement")]
		public string PartialRetirement;

		[JsonProperty("RetirementQuantity")]
		public decimal? RetirementQuantity;

		[JsonProperty("RetirementAPC")]
		public decimal? RetirementAPC;

		[JsonProperty("ThirdParty")]
		public string ThirdParty;

		[JsonProperty("PoNum")]
		public string PoNum;

		[JsonProperty("PoItmNum")]
		public string PoItmNum;

		[JsonProperty("ExpenseType")]
		public string ExpenseType;

		[JsonProperty("ReceiptNumber")]
		public string ReceiptNumber;

		[JsonProperty("ExpenseOperationType")]
		public string ExpenseOperationType;

		[JsonProperty("FederalTaxID")]
		public string FederalTaxID;

		[JsonProperty("GrossProfit")]
		public decimal? GrossProfit;

		[JsonProperty("GrossProfitFC")]
		public decimal? GrossProfitFC;

		[JsonProperty("GrossProfitSC")]
		public decimal? GrossProfitSC;

		[JsonProperty("PriceSource")]
		public string PriceSource;

		[JsonProperty("EnableReturnCost")]
		public string EnableReturnCost;

		[JsonProperty("ReturnCost")]
		public decimal? ReturnCost;

		[JsonProperty("ReturnAction")]
		public int? ReturnAction;

		[JsonProperty("ReturnReason")]
		public int? ReturnReason;

		[JsonProperty("StgSeqNum")]
		public string StgSeqNum;

		[JsonProperty("StgEntry")]
		public string StgEntry;

		[JsonProperty("StgDesc")]
		public string StgDesc;

		[JsonProperty("UoMEntry")]
		public int? UoMEntry;

		[JsonProperty("UoMCode")]
		public string UoMCode;

		[JsonProperty("InventoryQuantity")]
		public decimal? InventoryQuantity;

		[JsonProperty("RemainingOpenInventoryQuantity")]
		public decimal? RemainingOpenInventoryQuantity;

		[JsonProperty("ParentLineNum")]
		public string ParentLineNum;

		[JsonProperty("Incoterms")]
		public string Incoterms;

		[JsonProperty("TransportMode")]
		public string TransportMode;

		[JsonProperty("NatureOfTransaction")]
		public string NatureOfTransaction;

		[JsonProperty("DestinationCountryForImport")]
		public string DestinationCountryForImport;

		[JsonProperty("DestinationRegionForImport")]
		public string DestinationRegionForImport;

		[JsonProperty("OriginCountryForExport")]
		public string OriginCountryForExport;

		[JsonProperty("OriginRegionForExport")]
		public string OriginRegionForExport;

		[JsonProperty("ItemType")]
		public string ItemType;

		[JsonProperty("ChangeInventoryQuantityIndependently")]
		public string ChangeInventoryQuantityIndependently;

		[JsonProperty("FreeOfChargeBP")]
		public string FreeOfChargeBP;

		[JsonProperty("SACEntry")]
		public string SACEntry;

		[JsonProperty("HSNEntry")]
		public string HSNEntry;

		[JsonProperty("GrossPrice")]
		public decimal? GrossPrice;

		[JsonProperty("GrossTotal")]
		public decimal? GrossTotal;

		[JsonProperty("GrossTotalFC")]
		public decimal? GrossTotalFC;

		[JsonProperty("GrossTotalSC")]
		public decimal? GrossTotalSC;

		[JsonProperty("NCMCode")]
		public int? NCMCode;

		[JsonProperty("NVECode")]
		public string NVECode;

		[JsonProperty("IndEscala")]
		public string IndEscala;

		[JsonProperty("CtrSealQty")]
		public decimal? CtrSealQty;

		[JsonProperty("CNJPMan")]
		public string CNJPMan;

		[JsonProperty("CESTCode")]
		public string CESTCode;

		[JsonProperty("UFFiscalBenefitCode")]
		public string UFFiscalBenefitCode;

		[JsonProperty("ReverseCharge")]
		public string ReverseCharge;

		[JsonProperty("ShipToCode")]
		public string ShipToCode;

		[JsonProperty("ShipToDescription")]
		public string ShipToDescription;

		[JsonProperty("OwnerCode")]
		public string OwnerCode;

		[JsonProperty("ExternalCalcTaxRate")]
		public decimal? ExternalCalcTaxRate;

		[JsonProperty("ExternalCalcTaxAmount")]
		public decimal? ExternalCalcTaxAmount;

		[JsonProperty("ExternalCalcTaxAmountFC")]
		public decimal? ExternalCalcTaxAmountFC;

		[JsonProperty("ExternalCalcTaxAmountSC")]
		public decimal? ExternalCalcTaxAmountSC;

		[JsonProperty("StandardItemIdentification")]
		public string StandardItemIdentification;

		[JsonProperty("CommodityClassification")]
		public string CommodityClassification;

		[JsonProperty("WeightOfRecycledPlastic")]
		public decimal? WeightOfRecycledPlastic;

		[JsonProperty("PlasticPackageExemptionReason")]
		public string PlasticPackageExemptionReason;

		[JsonProperty("LegalText")]
		public string LegalText;

		[JsonProperty("Cig")]
		public string Cig;

		[JsonProperty("Cup")]
		public string Cup;

		[JsonProperty("UnencumberedReason")]
		public string UnencumberedReason;

		[JsonProperty("CUSplit")]
		public string CUSplit;

		[JsonProperty("ListNum")]
		public string ListNum;

		[JsonProperty("RecognizedTaxCode")]
		public string RecognizedTaxCode;

		[JsonProperty("LineTaxJurisdictions")]
		public IList<LineTaxJurisdiction> LineTaxJurisdictions;

		[JsonProperty("ExportProcesses")]
		public IList<object> ExportProcesses;

		[JsonProperty("EBooksDetails")]
		public IList<object> EBooksDetails;

		[JsonProperty("DocumentLineAdditionalExpenses")]
		public IList<object> DocumentLineAdditionalExpenses;

		[JsonProperty("WithholdingTaxLines")]
		public IList<object> WithholdingTaxLines;

		[JsonProperty("SerialNumbers")]
		public IList<object> SerialNumbers;

		[JsonProperty("BatchNumbers")]
		public IList<object> BatchNumbers;

		[JsonProperty("CCDNumbers")]
		public IList<object> CCDNumbers;

		[JsonProperty("DocumentLinesBinAllocations")]
		public IList<object> DocumentLinesBinAllocations;
		#endregion

		public DocumentLine()
		{
			BatchNumbers = new List<object>();
			CCDNumbers = new List<object>();
			DocumentLineAdditionalExpenses = new List<object>();
			DocumentLinesBinAllocations = new List<object>();
			EBooksDetails = new List<object>();
			ExportProcesses = new List<object>();
			LineTaxJurisdictions = new List<LineTaxJurisdiction>();
			SerialNumbers = new List<object>();
			WithholdingTaxLines = new List<object>();
		}
	}
}