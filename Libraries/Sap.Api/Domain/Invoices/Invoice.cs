using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Sap.Api.Domain.Common;
using Sap.Core;

namespace Sap.Api.Domain.Invoices
{
	public partial class Invoice : BaseEntity
	{
		#region Fields
		[JsonProperty("odata.etag")]
		public string OdataEtag;

		[JsonProperty("DocEntry")]
		public int? DocEntry;

		[JsonProperty("DocNum")]
		public int? DocNum;

		[JsonProperty("DocType")]
		public string DocType;

		[JsonProperty("HandWritten")]
		public string HandWritten;

		[JsonProperty("Printed")]
		public string Printed;

		[JsonProperty("DocDate")]
		public DateTime? DocDate;

		[JsonProperty("DocDueDate")]
		public DateTime? DocDueDate;

		[JsonProperty("CardCode")]
		public string CardCode;

		[JsonProperty("CardName")]
		public string CardName;

		[JsonProperty("Address")]
		public string Address;

		[JsonProperty("NumAtCard")]
		public string NumAtCard;

		[JsonProperty("DocTotal")]
		public decimal? DocTotal;

		[JsonProperty("AttachmentEntry")]
		public string AttachmentEntry;

		[JsonProperty("DocCurrency")]
		public string DocCurrency;

		[JsonProperty("DocRate")]
		public decimal? DocRate;

		[JsonProperty("Reference1")]
		public string Reference1;

		[JsonProperty("Reference2")]
		public string Reference2;

		[JsonProperty("Comments")]
		public string Comments;

		[JsonProperty("JournalMemo")]
		public string JournalMemo;

		[JsonProperty("PaymentGroupCode")]
		public int? PaymentGroupCode;

		[JsonProperty("DocTime")]
		public string DocTime;

		[JsonProperty("SalesPersonCode")]
		public int? SalesPersonCode;

		[JsonProperty("TransportationCode")]
		public int? TransportationCode;

		[JsonProperty("Confirmed")]
		public string Confirmed;

		[JsonProperty("ImportFileNum")]
		public string ImportFileNum;

		[JsonProperty("SummeryType")]
		public string SummeryType;

		[JsonProperty("ContactPersonCode")]
		public int? ContactPersonCode;

		[JsonProperty("ShowSCN")]
		public string ShowSCN;

		[JsonProperty("Series")]
		public int? Series;

		[JsonProperty("TaxDate")]
		public DateTime? TaxDate;

		[JsonProperty("PartialSupply")]
		public string PartialSupply;

		[JsonProperty("DocObjectCode")]
		public string DocObjectCode;

		[JsonProperty("ShipToCode")]
		public string ShipToCode;

		[JsonProperty("Indicator")]
		public string Indicator;

		[JsonProperty("FederalTaxID")]
		public string FederalTaxID;

		[JsonProperty("DiscountPercent")]
		public decimal? DiscountPercent;

		[JsonProperty("PaymentReference")]
		public string PaymentReference;

		[JsonProperty("CreationDate")]
		public DateTime? CreationDate;

		[JsonProperty("UpdateDate")]
		public DateTime? UpdateDate;

		[JsonProperty("FinancialPeriod")]
		public int? FinancialPeriod;

		[JsonProperty("UserSign")]
		public int? UserSign;

		[JsonProperty("TransNum")]
		public int? TransNum;

		[JsonProperty("VatSum")]
		public decimal? VatSum;

		[JsonProperty("VatSumSys")]
		public decimal? VatSumSys;

		[JsonProperty("VatSumFc")]
		public decimal? VatSumFc;

		[JsonProperty("NetProcedure")]
		public string NetProcedure;

		[JsonProperty("DocTotalFc")]
		public decimal? DocTotalFc;

		[JsonProperty("DocTotalSys")]
		public decimal? DocTotalSys;

		[JsonProperty("Form1099")]
		public string Form1099;

		[JsonProperty("Box1099")]
		public string Box1099;

		[JsonProperty("RevisionPo")]
		public string RevisionPo;

		[JsonProperty("RequriedDate")]
		public DateTime? RequriedDate;

		[JsonProperty("CancelDate")]
		public DateTime? CancelDate;

		[JsonProperty("BlockDunning")]
		public string BlockDunning;

		[JsonProperty("Submitted")]
		public string Submitted;

		[JsonProperty("Segment")]
		public int? Segment;

		[JsonProperty("PickStatus")]
		public string PickStatus;

		[JsonProperty("Pick")]
		public string Pick;

		[JsonProperty("PaymentMethod")]
		public string PaymentMethod;

		[JsonProperty("PaymentBlock")]
		public string PaymentBlock;

		[JsonProperty("PaymentBlockEntry")]
		public string PaymentBlockEntry;

		[JsonProperty("CentralBankIndicator")]
		public string CentralBankIndicator;

		[JsonProperty("MaximumCashDiscount")]
		public string MaximumCashDiscount;

		[JsonProperty("Reserve")]
		public string Reserve;

		[JsonProperty("Project")]
		public string Project;

		[JsonProperty("ExemptionValidityDateFrom")]
		public DateTime? ExemptionValidityDateFrom;

		[JsonProperty("ExemptionValidityDateTo")]
		public DateTime? ExemptionValidityDateTo;

		[JsonProperty("WareHouseUpdateType")]
		public string WareHouseUpdateType;

		[JsonProperty("Rounding")]
		public string Rounding;

		[JsonProperty("ExternalCorrectedDocNum")]
		public string ExternalCorrectedDocNum;

		[JsonProperty("InternalCorrectedDocNum")]
		public string InternalCorrectedDocNum;

		[JsonProperty("NextCorrectingDocument")]
		public string NextCorrectingDocument;

		[JsonProperty("DeferredTax")]
		public string DeferredTax;

		[JsonProperty("TaxExemptionLetterNum")]
		public string TaxExemptionLetterNum;

		[JsonProperty("WTApplied")]
		public decimal? WTApplied;

		[JsonProperty("WTAppliedFC")]
		public decimal? WTAppliedFC;

		[JsonProperty("BillOfExchangeReserved")]
		public string BillOfExchangeReserved;

		[JsonProperty("AgentCode")]
		public string AgentCode;

		[JsonProperty("WTAppliedSC")]
		public decimal? WTAppliedSC;

		[JsonProperty("TotalEqualizationTax")]
		public decimal? TotalEqualizationTax;

		[JsonProperty("TotalEqualizationTaxFC")]
		public decimal? TotalEqualizationTaxFC;

		[JsonProperty("TotalEqualizationTaxSC")]
		public decimal? TotalEqualizationTaxSC;

		[JsonProperty("NumberOfInstallments")]
		public int? NumberOfInstallments;

		[JsonProperty("ApplyTaxOnFirstInstallment")]
		public string ApplyTaxOnFirstInstallment;

		[JsonProperty("TaxOnInstallments")]
		public string TaxOnInstallments;

		[JsonProperty("WTNonSubjectAmount")]
		public decimal? WTNonSubjectAmount;

		[JsonProperty("WTNonSubjectAmountSC")]
		public decimal? WTNonSubjectAmountSC;

		[JsonProperty("WTNonSubjectAmountFC")]
		public decimal? WTNonSubjectAmountFC;

		[JsonProperty("WTExemptedAmount")]
		public decimal? WTExemptedAmount;

		[JsonProperty("WTExemptedAmountSC")]
		public decimal? WTExemptedAmountSC;

		[JsonProperty("WTExemptedAmountFC")]
		public decimal? WTExemptedAmountFC;

		[JsonProperty("BaseAmount")]
		public decimal? BaseAmount;

		[JsonProperty("BaseAmountSC")]
		public decimal? BaseAmountSC;

		[JsonProperty("BaseAmountFC")]
		public decimal? BaseAmountFC;

		[JsonProperty("WTAmount")]
		public decimal? WTAmount;

		[JsonProperty("WTAmountSC")]
		public decimal? WTAmountSC;

		[JsonProperty("WTAmountFC")]
		public decimal? WTAmountFC;

		[JsonProperty("VatDate")]
		public DateTime? VatDate;

		[JsonProperty("DocumentsOwner")]
		public string DocumentsOwner;

		[JsonProperty("FolioPrefixString")]
		public string FolioPrefixString;

		[JsonProperty("FolioNumber")]
		public string FolioNumber;

		[JsonProperty("DocumentSubType")]
		public string DocumentSubType;

		[JsonProperty("BPChannelCode")]
		public string BPChannelCode;

		[JsonProperty("BPChannelContact")]
		public string BPChannelContact;

		[JsonProperty("Address2")]
		public string Address2;

		[JsonProperty("DocumentStatus")]
		public string DocumentStatus;

		[JsonProperty("PeriodIndicator")]
		public string PeriodIndicator;

		[JsonProperty("PayToCode")]
		public string PayToCode;

		[JsonProperty("ManualNumber")]
		public string ManualNumber;

		[JsonProperty("UseShpdGoodsAct")]
		public string UseShpdGoodsAct;

		[JsonProperty("IsPayToBank")]
		public string IsPayToBank;

		[JsonProperty("PayToBankCountry")]
		public string PayToBankCountry;

		[JsonProperty("PayToBankCode")]
		public string PayToBankCode;

		[JsonProperty("PayToBankAccountNo")]
		public string PayToBankAccountNo;

		[JsonProperty("PayToBankBranch")]
		public string PayToBankBranch;

		[JsonProperty("BPL_IDAssignedToInvoice")]
		public string BPLIDAssignedToInvoice;

		[JsonProperty("DownPayment")]
		public decimal? DownPayment;

		[JsonProperty("ReserveInvoice")]
		public string ReserveInvoice;

		[JsonProperty("LanguageCode")]
		public int? LanguageCode;

		[JsonProperty("TrackingNumber")]
		public string TrackingNumber;

		[JsonProperty("PickRemark")]
		public string PickRemark;

		[JsonProperty("ClosingDate")]
		public DateTime? ClosingDate;

		[JsonProperty("SequenceCode")]
		public string SequenceCode;

		[JsonProperty("SequenceSerial")]
		public string SequenceSerial;

		[JsonProperty("SeriesString")]
		public string SeriesString;

		[JsonProperty("SubSeriesString")]
		public string SubSeriesString;

		[JsonProperty("SequenceModel")]
		public string SequenceModel;

		[JsonProperty("UseCorrectionVATGroup")]
		public string UseCorrectionVATGroup;

		[JsonProperty("TotalDiscount")]
		public decimal? TotalDiscount;

		[JsonProperty("DownPaymentAmount")]
		public decimal? DownPaymentAmount;

		[JsonProperty("DownPaymentPercentage")]
		public decimal? DownPaymentPercentage;

		[JsonProperty("DownPaymentType")]
		public string DownPaymentType;

		[JsonProperty("DownPaymentAmountSC")]
		public decimal? DownPaymentAmountSC;

		[JsonProperty("DownPaymentAmountFC")]
		public decimal? DownPaymentAmountFC;

		[JsonProperty("VatPercent")]
		public decimal? VatPercent;

		[JsonProperty("ServiceGrossProfitPercent")]
		public decimal? ServiceGrossProfitPercent;

		[JsonProperty("OpeningRemarks")]
		public string OpeningRemarks;

		[JsonProperty("ClosingRemarks")]
		public string ClosingRemarks;

		[JsonProperty("RoundingDiffAmount")]
		public decimal? RoundingDiffAmount;

		[JsonProperty("RoundingDiffAmountFC")]
		public decimal? RoundingDiffAmountFC;

		[JsonProperty("RoundingDiffAmountSC")]
		public decimal? RoundingDiffAmountSC;

		[JsonProperty("Cancelled")]
		public string Cancelled;

		[JsonProperty("SignatureInputMessage")]
		public string SignatureInputMessage;

		[JsonProperty("SignatureDigest")]
		public string SignatureDigest;

		[JsonProperty("CertificationNumber")]
		public string CertificationNumber;

		[JsonProperty("PrivateKeyVersion")]
		public string PrivateKeyVersion;

		[JsonProperty("ControlAccount")]
		public string ControlAccount;

		[JsonProperty("InsuranceOperation347")]
		public string InsuranceOperation347;

		[JsonProperty("ArchiveNonremovableSalesQuotation")]
		public string ArchiveNonremovableSalesQuotation;

		[JsonProperty("GTSChecker")]
		public string GTSChecker;

		[JsonProperty("GTSPayee")]
		public string GTSPayee;

		[JsonProperty("ExtraMonth")]
		public int? ExtraMonth;

		[JsonProperty("ExtraDays")]
		public int? ExtraDays;

		[JsonProperty("CashDiscountDateOffset")]
		public int? CashDiscountDateOffset;

		[JsonProperty("StartFrom")]
		public string StartFrom;

		[JsonProperty("NTSApproved")]
		public string NTSApproved;

		[JsonProperty("ETaxWebSite")]
		public string ETaxWebSite;

		[JsonProperty("ETaxNumber")]
		public string ETaxNumber;

		[JsonProperty("NTSApprovedNumber")]
		public string NTSApprovedNumber;

		[JsonProperty("EDocGenerationType")]
		public string EDocGenerationType;

		[JsonProperty("EDocSeries")]
		public string EDocSeries;

		[JsonProperty("EDocNum")]
		public string EDocNum;

		[JsonProperty("EDocExportFormat")]
		public string EDocExportFormat;

		[JsonProperty("EDocStatus")]
		public string EDocStatus;

		[JsonProperty("EDocErrorCode")]
		public string EDocErrorCode;

		[JsonProperty("EDocErrorMessage")]
		public string EDocErrorMessage;

		[JsonProperty("DownPaymentStatus")]
		public string DownPaymentStatus;

		[JsonProperty("GroupSeries")]
		public string GroupSeries;

		[JsonProperty("GroupNumber")]
		public string GroupNumber;

		[JsonProperty("GroupHandWritten")]
		public string GroupHandWritten;

		[JsonProperty("ReopenOriginalDocument")]
		public string ReopenOriginalDocument;

		[JsonProperty("ReopenManuallyClosedOrCanceledDocument")]
		public string ReopenManuallyClosedOrCanceledDocument;

		[JsonProperty("CreateOnlineQuotation")]
		public string CreateOnlineQuotation;

		[JsonProperty("POSEquipmentNumber")]
		public string POSEquipmentNumber;

		[JsonProperty("POSManufacturerSerialNumber")]
		public string POSManufacturerSerialNumber;

		[JsonProperty("POSCashierNumber")]
		public string POSCashierNumber;

		[JsonProperty("ApplyCurrentVATRatesForDownPaymentsToDraw")]
		public string ApplyCurrentVATRatesForDownPaymentsToDraw;

		[JsonProperty("ClosingOption")]
		public string ClosingOption;

		[JsonProperty("SpecifiedClosingDate")]
		public DateTime? SpecifiedClosingDate;

		[JsonProperty("OpenForLandedCosts")]
		public string OpenForLandedCosts;

		[JsonProperty("AuthorizationStatus")]
		public string AuthorizationStatus;

		[JsonProperty("TotalDiscountFC")]
		public decimal? TotalDiscountFC;

		[JsonProperty("TotalDiscountSC")]
		public decimal? TotalDiscountSC;

		[JsonProperty("RelevantToGTS")]
		public string RelevantToGTS;

		[JsonProperty("BPLName")]
		public string BPLName;

		[JsonProperty("VATRegNum")]
		public string VATRegNum;

		[JsonProperty("AnnualInvoiceDeclarationReference")]
		public string AnnualInvoiceDeclarationReference;

		[JsonProperty("Supplier")]
		public string Supplier;

		[JsonProperty("Releaser")]
		public string Releaser;

		[JsonProperty("Receiver")]
		public string Receiver;

		[JsonProperty("BlanketAgreementNumber")]
		public string BlanketAgreementNumber;

		[JsonProperty("IsAlteration")]
		public string IsAlteration;

		[JsonProperty("CancelStatus")]
		public string CancelStatus;

		[JsonProperty("AssetValueDate")]
		public DateTime? AssetValueDate;

		[JsonProperty("InvoicePayment")]
		public string InvoicePayment;

		[JsonProperty("DocumentDelivery")]
		public string DocumentDelivery;

		[JsonProperty("AuthorizationCode")]
		public string AuthorizationCode;

		[JsonProperty("StartDeliveryDate")]
		public DateTime? StartDeliveryDate;

		[JsonProperty("StartDeliveryTime")]
		public string StartDeliveryTime;

		[JsonProperty("EndDeliveryDate")]
		public DateTime? EndDeliveryDate;

		[JsonProperty("EndDeliveryTime")]
		public string EndDeliveryTime;

		[JsonProperty("VehiclePlate")]
		public string VehiclePlate;

		[JsonProperty("ATDocumentType")]
		public string ATDocumentType;

		[JsonProperty("ElecCommStatus")]
		public string ElecCommStatus;

		[JsonProperty("ElecCommMessage")]
		public string ElecCommMessage;

		[JsonProperty("ReuseDocumentNum")]
		public string ReuseDocumentNum;

		[JsonProperty("ReuseNotaFiscalNum")]
		public string ReuseNotaFiscalNum;

		[JsonProperty("PrintSEPADirect")]
		public string PrintSEPADirect;

		[JsonProperty("FiscalDocNum")]
		public string FiscalDocNum;

		[JsonProperty("POSDailySummaryNo")]
		public string POSDailySummaryNo;

		[JsonProperty("POSReceiptNo")]
		public string POSReceiptNo;

		[JsonProperty("PointOfIssueCode")]
		public string PointOfIssueCode;

		[JsonProperty("Letter")]
		public string Letter;

		[JsonProperty("FolioNumberFrom")]
		public string FolioNumberFrom;

		[JsonProperty("FolioNumberTo")]
		public string FolioNumberTo;

		[JsonProperty("InterimType")]
		public string InterimType;

		[JsonProperty("RelatedType")]
		public int? RelatedType;

		[JsonProperty("RelatedEntry")]
		public string RelatedEntry;

		[JsonProperty("SAPPassport")]
		public string SAPPassport;

		[JsonProperty("DocumentTaxID")]
		public string DocumentTaxID;

		[JsonProperty("DateOfReportingControlStatementVAT")]
		public DateTime? DateOfReportingControlStatementVAT;

		[JsonProperty("ReportingSectionControlStatementVAT")]
		public string ReportingSectionControlStatementVAT;

		[JsonProperty("ExcludeFromTaxReportControlStatementVAT")]
		public string ExcludeFromTaxReportControlStatementVAT;

		[JsonProperty("POS_CashRegister")]
		public string POSCashRegister;

		[JsonProperty("UpdateTime")]
		public string UpdateTime;

		[JsonProperty("CreateQRCodeFrom")]
		public string CreateQRCodeFrom;

		[JsonProperty("PriceMode")]
		public string PriceMode;

		[JsonProperty("OriginalRefNo")]
		public string OriginalRefNo;

		[JsonProperty("OriginalRefDate")]
		public DateTime? OriginalRefDate;

		[JsonProperty("Revision")]
		public string Revision;

		[JsonProperty("GSTTransactionType")]
		public string GSTTransactionType;

		[JsonProperty("OriginalCreditOrDebitNo")]
		public string OriginalCreditOrDebitNo;

		[JsonProperty("OriginalCreditOrDebitDate")]
		public DateTime? OriginalCreditOrDebitDate;

		[JsonProperty("ECommerceOperator")]
		public string ECommerceOperator;

		[JsonProperty("ECommerceGSTIN")]
		public string ECommerceGSTIN;

		[JsonProperty("ShipFrom")]
		public string ShipFrom;

		[JsonProperty("CommissionTrade")]
		public string CommissionTrade;

		[JsonProperty("CommissionTradeReturn")]
		public string CommissionTradeReturn;

		[JsonProperty("UseBillToAddrToDetermineTax")]
		public string UseBillToAddrToDetermineTax;

		[JsonProperty("IssuingReason")]
		public int? IssuingReason;

		[JsonProperty("Cig")]
		public string Cig;

		[JsonProperty("Cup")]
		public string Cup;

		[JsonProperty("EDocType")]
		public string EDocType;

		[JsonProperty("FCEAsPaymentMeans")]
		public string FCEAsPaymentMeans;

		[JsonProperty("PaidToDate")]
		public decimal? PaidToDate;

		[JsonProperty("PaidToDateFC")]
		public decimal? PaidToDateFC;

		[JsonProperty("PaidToDateSys")]
		public decimal? PaidToDateSys;

		[JsonProperty("BaseType")]
		public int? BaseType;

		[JsonProperty("BaseEntry")]
		public string BaseEntry;

		[JsonProperty("FatherCard")]
		public string FatherCard;

		[JsonProperty("FatherType")]
		public string FatherType;

		[JsonProperty("ShipState")]
		public string ShipState;

		[JsonProperty("ShipPlace")]
		public string ShipPlace;

		[JsonProperty("CustOffice")]
		public string CustOffice;

		[JsonProperty("FCI")]
		public string FCI;

		[JsonProperty("AddLegIn")]
		public string AddLegIn;

		[JsonProperty("LegTextF")]
		public string LegTextF;

		[JsonProperty("DANFELgTxt")]
		public string DANFELgTxt;

		[JsonProperty("IndFinal")]
		public string IndFinal;

		[JsonProperty("DataVersion")]
		public int? DataVersion;

		[JsonProperty("LastPageFolioNumber")]
		public string LastPageFolioNumber;

		[JsonProperty("InventoryStatus")]
		public string InventoryStatus;

		[JsonProperty("PlasticPackagingTaxRelevant")]
		public string PlasticPackagingTaxRelevant;

		[JsonProperty("NotRelevantForMonthlyInvoice")]
		public string NotRelevantForMonthlyInvoice;

		[JsonProperty("AllocationNumberIL")]
		public string AllocationNumberIL;

		[JsonProperty("Document_ApprovalRequests")]
		public IList<object> DocumentApprovalRequests;

		[JsonProperty("DocumentLines")]
		public IList<DocumentLine> DocumentLines;

		[JsonProperty("EWayBillDetails")]
		public EWayBillDetails EWayBillDetails;

		[JsonProperty("ElectronicProtocols")]
		public IList<object> ElectronicProtocols;

		[JsonProperty("DocumentAdditionalExpenses")]
		public IList<object> DocumentAdditionalExpenses;

		[JsonProperty("WithholdingTaxDataWTXCollection")]
		public IList<object> WithholdingTaxDataWTXCollection;

		[JsonProperty("WithholdingTaxDataCollection")]
		public IList<object> WithholdingTaxDataCollection;

		[JsonProperty("DocumentPackages")]
		public IList<object> DocumentPackages;

		[JsonProperty("DocumentSpecialLines")]
		public IList<object> DocumentSpecialLines;

		[JsonProperty("DocumentInstallments")]
		public IList<DocumentInstallment> DocumentInstallments;

		[JsonProperty("DownPaymentsToDraw")]
		public IList<object> DownPaymentsToDraw;

		[JsonProperty("TaxExtension")]
		public TaxExtension TaxExtension;

		[JsonProperty("AddressExtension")]
		public AddressExtension AddressExtension;

		[JsonProperty("DocumentReferences")]
		public IList<object> DocumentReferences;
		#endregion

		public Invoice()
		{
			AddressExtension = new AddressExtension();
			DocumentAdditionalExpenses = new List<object>();
			DocumentApprovalRequests = new List<object>();
			DocumentInstallments = new List<DocumentInstallment>();
			DocumentLines = new List<DocumentLine>();
			DocumentPackages = new List<object>();
			DocumentReferences = new List<object>();
			DocumentSpecialLines = new List<object>();
			DownPaymentsToDraw = new List<object>();
			ElectronicProtocols = new List<object>();
			EWayBillDetails = new EWayBillDetails();
			TaxExtension = new TaxExtension();
			WithholdingTaxDataCollection = new List<object>();
			WithholdingTaxDataWTXCollection = new List<object>();
		}
	}
}