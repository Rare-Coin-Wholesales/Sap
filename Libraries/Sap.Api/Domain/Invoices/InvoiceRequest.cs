using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sap.Api.Domain.Invoices
{
	public partial class InvoiceRequest : BaseRequest
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
		public IList<Invoice_DocumentLine> DocumentLines;

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

		public InvoiceRequest()
		{
			AddressExtension = new AddressExtension();
			DocumentAdditionalExpenses = new List<object>();
			DocumentApprovalRequests = new List<object>();
			DocumentInstallments = new List<DocumentInstallment>();
			DocumentLines = new List<Invoice_DocumentLine>();
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

		public InvoiceRequest(int docEntry)
		{
			DocEntry = docEntry;
			AddressExtension = new AddressExtension();
			DocumentAdditionalExpenses = new List<object>();
			DocumentApprovalRequests = new List<object>();
			DocumentInstallments = new List<DocumentInstallment>();
			DocumentLines = new List<Invoice_DocumentLine>();
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

		public InvoiceRequest(Invoice x)
		{
			OdataEtag = x.OdataEtag;
			DocEntry = x.DocEntry;
			DocNum = x.DocNum;
			DocType = x.DocType;
			HandWritten = x.HandWritten;
			Printed = x.Printed;
			DocDate = x.DocDate;
			DocDueDate = x.DocDueDate;
			CardCode = x.CardCode;
			CardName = x.CardName;
			Address = x.Address;
			NumAtCard = x.NumAtCard;
			DocTotal = x.DocTotal;
			AttachmentEntry = x.AttachmentEntry;
			DocCurrency = x.DocCurrency;
			DocRate = x.DocRate;
			Reference1 = x.Reference1;
			Reference2 = x.Reference2;
			Comments = x.Comments;
			JournalMemo = x.JournalMemo;
			PaymentGroupCode = x.PaymentGroupCode;
			DocTime = x.DocTime;
			SalesPersonCode = x.SalesPersonCode;
			TransportationCode = x.TransportationCode;
			Confirmed = x.Confirmed;
			ImportFileNum = x.ImportFileNum;
			SummeryType = x.SummeryType;
			ContactPersonCode = x.ContactPersonCode;
			ShowSCN = x.ShowSCN;
			Series = x.Series;
			TaxDate = x.TaxDate;
			PartialSupply = x.PartialSupply;
			DocObjectCode = x.DocObjectCode;
			ShipToCode = x.ShipToCode;
			Indicator = x.Indicator;
			FederalTaxID = x.FederalTaxID;
			DiscountPercent = x.DiscountPercent;
			PaymentReference = x.PaymentReference;
			CreationDate = x.CreationDate;
			UpdateDate = x.UpdateDate;
			FinancialPeriod = x.FinancialPeriod;
			UserSign = x.UserSign;
			TransNum = x.TransNum;
			VatSum = x.VatSum;
			VatSumSys = x.VatSumSys;
			VatSumFc = x.VatSumFc;
			NetProcedure = x.NetProcedure;
			DocTotalFc = x.DocTotalFc;
			DocTotalSys = x.DocTotalSys;
			Form1099 = x.Form1099;
			Box1099 = x.Box1099;
			RevisionPo = x.RevisionPo;
			RequriedDate = x.RequriedDate;
			CancelDate = x.CancelDate;
			BlockDunning = x.BlockDunning;
			Submitted = x.Submitted;
			Segment = x.Segment;
			PickStatus = x.PickStatus;
			Pick = x.Pick;
			PaymentMethod = x.PaymentMethod;
			PaymentBlock = x.PaymentBlock;
			PaymentBlockEntry = x.PaymentBlockEntry;
			CentralBankIndicator = x.CentralBankIndicator;
			MaximumCashDiscount = x.MaximumCashDiscount;
			Reserve = x.Reserve;
			Project = x.Project;
			ExemptionValidityDateFrom = x.ExemptionValidityDateFrom;
			ExemptionValidityDateTo = x.ExemptionValidityDateTo;
			WareHouseUpdateType = x.WareHouseUpdateType;
			Rounding = x.Rounding;
			ExternalCorrectedDocNum = x.ExternalCorrectedDocNum;
			InternalCorrectedDocNum = x.InternalCorrectedDocNum;
			NextCorrectingDocument = x.NextCorrectingDocument;
			DeferredTax = x.DeferredTax;
			TaxExemptionLetterNum = x.TaxExemptionLetterNum;
			WTApplied = x.WTApplied;
			WTAppliedFC = x.WTAppliedFC;
			BillOfExchangeReserved = x.BillOfExchangeReserved;
			AgentCode = x.AgentCode;
			WTAppliedSC = x.WTAppliedSC;
			TotalEqualizationTax = x.TotalEqualizationTax;
			TotalEqualizationTaxFC = x.TotalEqualizationTaxFC;
			TotalEqualizationTaxSC = x.TotalEqualizationTaxSC;
			NumberOfInstallments = x.NumberOfInstallments;
			ApplyTaxOnFirstInstallment = x.ApplyTaxOnFirstInstallment;
			TaxOnInstallments = x.TaxOnInstallments;
			WTNonSubjectAmount = x.WTNonSubjectAmount;
			WTNonSubjectAmountSC = x.WTNonSubjectAmountSC;
			WTNonSubjectAmountFC = x.WTNonSubjectAmountFC;
			WTExemptedAmount = x.WTExemptedAmount;
			WTExemptedAmountSC = x.WTExemptedAmountSC;
			WTExemptedAmountFC = x.WTExemptedAmountFC;
			BaseAmount = x.BaseAmount;
			BaseAmountSC = x.BaseAmountSC;
			BaseAmountFC = x.BaseAmountFC;
			WTAmount = x.WTAmount;
			WTAmountSC = x.WTAmountSC;
			WTAmountFC = x.WTAmountFC;
			VatDate = x.VatDate;
			DocumentsOwner = x.DocumentsOwner;
			FolioPrefixString = x.FolioPrefixString;
			FolioNumber = x.FolioNumber;
			DocumentSubType = x.DocumentSubType;
			BPChannelCode = x.BPChannelCode;
			BPChannelContact = x.BPChannelContact;
			Address2 = x.Address2;
			DocumentStatus = x.DocumentStatus;
			PeriodIndicator = x.PeriodIndicator;
			PayToCode = x.PayToCode;
			ManualNumber = x.ManualNumber;
			UseShpdGoodsAct = x.UseShpdGoodsAct;
			IsPayToBank = x.IsPayToBank;
			PayToBankCountry = x.PayToBankCountry;
			PayToBankCode = x.PayToBankCode;
			PayToBankAccountNo = x.PayToBankAccountNo;
			PayToBankBranch = x.PayToBankBranch;
			BPLIDAssignedToInvoice = x.BPLIDAssignedToInvoice;
			DownPayment = x.DownPayment;
			ReserveInvoice = x.ReserveInvoice;
			LanguageCode = x.LanguageCode;
			TrackingNumber = x.TrackingNumber;
			PickRemark = x.PickRemark;
			ClosingDate = x.ClosingDate;
			SequenceCode = x.SequenceCode;
			SequenceSerial = x.SequenceSerial;
			SeriesString = x.SeriesString;
			SubSeriesString = x.SubSeriesString;
			SequenceModel = x.SequenceModel;
			UseCorrectionVATGroup = x.UseCorrectionVATGroup;
			TotalDiscount = x.TotalDiscount;
			DownPaymentAmount = x.DownPaymentAmount;
			DownPaymentPercentage = x.DownPaymentPercentage;
			DownPaymentType = x.DownPaymentType;
			DownPaymentAmountSC = x.DownPaymentAmountSC;
			DownPaymentAmountFC = x.DownPaymentAmountFC;
			VatPercent = x.VatPercent;
			ServiceGrossProfitPercent = x.ServiceGrossProfitPercent;
			OpeningRemarks = x.OpeningRemarks;
			ClosingRemarks = x.ClosingRemarks;
			RoundingDiffAmount = x.RoundingDiffAmount;
			RoundingDiffAmountFC = x.RoundingDiffAmountFC;
			RoundingDiffAmountSC = x.RoundingDiffAmountSC;
			Cancelled = x.Cancelled;
			SignatureInputMessage = x.SignatureInputMessage;
			SignatureDigest = x.SignatureDigest;
			CertificationNumber = x.CertificationNumber;
			PrivateKeyVersion = x.PrivateKeyVersion;
			ControlAccount = x.ControlAccount;
			InsuranceOperation347 = x.InsuranceOperation347;
			ArchiveNonremovableSalesQuotation = x.ArchiveNonremovableSalesQuotation;
			GTSChecker = x.GTSChecker;
			GTSPayee = x.GTSPayee;
			ExtraMonth = x.ExtraMonth;
			ExtraDays = x.ExtraDays;
			CashDiscountDateOffset = x.CashDiscountDateOffset;
			StartFrom = x.StartFrom;
			NTSApproved = x.NTSApproved;
			ETaxWebSite = x.ETaxWebSite;
			ETaxNumber = x.ETaxNumber;
			NTSApprovedNumber = x.NTSApprovedNumber;
			EDocGenerationType = x.EDocGenerationType;
			EDocSeries = x.EDocSeries;
			EDocNum = x.EDocNum;
			EDocExportFormat = x.EDocExportFormat;
			EDocStatus = x.EDocStatus;
			EDocErrorCode = x.EDocErrorCode;
			EDocErrorMessage = x.EDocErrorMessage;
			DownPaymentStatus = x.DownPaymentStatus;
			GroupSeries = x.GroupSeries;
			GroupNumber = x.GroupNumber;
			GroupHandWritten = x.GroupHandWritten;
			ReopenOriginalDocument = x.ReopenOriginalDocument;
			ReopenManuallyClosedOrCanceledDocument = x.ReopenManuallyClosedOrCanceledDocument;
			CreateOnlineQuotation = x.CreateOnlineQuotation;
			POSEquipmentNumber = x.POSEquipmentNumber;
			POSManufacturerSerialNumber = x.POSManufacturerSerialNumber;
			POSCashierNumber = x.POSCashierNumber;
			ApplyCurrentVATRatesForDownPaymentsToDraw = x.ApplyCurrentVATRatesForDownPaymentsToDraw;
			ClosingOption = x.ClosingOption;
			SpecifiedClosingDate = x.SpecifiedClosingDate;
			OpenForLandedCosts = x.OpenForLandedCosts;
			AuthorizationStatus = x.AuthorizationStatus;
			TotalDiscountFC = x.TotalDiscountFC;
			TotalDiscountSC = x.TotalDiscountSC;
			RelevantToGTS = x.RelevantToGTS;
			BPLName = x.BPLName;
			VATRegNum = x.VATRegNum;
			AnnualInvoiceDeclarationReference = x.AnnualInvoiceDeclarationReference;
			Supplier = x.Supplier;
			Releaser = x.Releaser;
			Receiver = x.Receiver;
			BlanketAgreementNumber = x.BlanketAgreementNumber;
			IsAlteration = x.IsAlteration;
			CancelStatus = x.CancelStatus;
			AssetValueDate = x.AssetValueDate;
			InvoicePayment = x.InvoicePayment;
			DocumentDelivery = x.DocumentDelivery;
			AuthorizationCode = x.AuthorizationCode;
			StartDeliveryDate = x.StartDeliveryDate;
			StartDeliveryTime = x.StartDeliveryTime;
			EndDeliveryDate = x.EndDeliveryDate;
			EndDeliveryTime = x.EndDeliveryTime;
			VehiclePlate = x.VehiclePlate;
			ATDocumentType = x.ATDocumentType;
			ElecCommStatus = x.ElecCommStatus;
			ElecCommMessage = x.ElecCommMessage;
			ReuseDocumentNum = x.ReuseDocumentNum;
			ReuseNotaFiscalNum = x.ReuseNotaFiscalNum;
			PrintSEPADirect = x.PrintSEPADirect;
			FiscalDocNum = x.FiscalDocNum;
			POSDailySummaryNo = x.POSDailySummaryNo;
			POSReceiptNo = x.POSReceiptNo;
			PointOfIssueCode = x.PointOfIssueCode;
			Letter = x.Letter;
			FolioNumberFrom = x.FolioNumberFrom;
			FolioNumberTo = x.FolioNumberTo;
			InterimType = x.InterimType;
			RelatedType = x.RelatedType;
			RelatedEntry = x.RelatedEntry;
			SAPPassport = x.SAPPassport;
			DocumentTaxID = x.DocumentTaxID;
			DateOfReportingControlStatementVAT = x.DateOfReportingControlStatementVAT;
			ReportingSectionControlStatementVAT = x.ReportingSectionControlStatementVAT;
			ExcludeFromTaxReportControlStatementVAT = x.ExcludeFromTaxReportControlStatementVAT;
			POSCashRegister = x.POSCashRegister;
			UpdateTime = x.UpdateTime;
			CreateQRCodeFrom = x.CreateQRCodeFrom;
			PriceMode = x.PriceMode;
			OriginalRefNo = x.OriginalRefNo;
			OriginalRefDate = x.OriginalRefDate;
			Revision = x.Revision;
			GSTTransactionType = x.GSTTransactionType;
			OriginalCreditOrDebitNo = x.OriginalCreditOrDebitNo;
			OriginalCreditOrDebitDate = x.OriginalCreditOrDebitDate;
			ECommerceOperator = x.ECommerceOperator;
			ECommerceGSTIN = x.ECommerceGSTIN;
			ShipFrom = x.ShipFrom;
			CommissionTrade = x.CommissionTrade;
			CommissionTradeReturn = x.CommissionTradeReturn;
			UseBillToAddrToDetermineTax = x.UseBillToAddrToDetermineTax;
			IssuingReason = x.IssuingReason;
			Cig = x.Cig;
			Cup = x.Cup;
			EDocType = x.EDocType;
			FCEAsPaymentMeans = x.FCEAsPaymentMeans;
			PaidToDate = x.PaidToDate;
			PaidToDateFC = x.PaidToDateFC;
			PaidToDateSys = x.PaidToDateSys;
			BaseType = x.BaseType;
			BaseEntry = x.BaseEntry;
			FatherCard = x.FatherCard;
			FatherType = x.FatherType;
			ShipState = x.ShipState;
			ShipPlace = x.ShipPlace;
			CustOffice = x.CustOffice;
			FCI = x.FCI;
			AddLegIn = x.AddLegIn;
			LegTextF = x.LegTextF;
			DANFELgTxt = x.DANFELgTxt;
			IndFinal = x.IndFinal;
			DataVersion = x.DataVersion;
			LastPageFolioNumber = x.LastPageFolioNumber;
			InventoryStatus = x.InventoryStatus;
			PlasticPackagingTaxRelevant = x.PlasticPackagingTaxRelevant;
			NotRelevantForMonthlyInvoice = x.NotRelevantForMonthlyInvoice;
			AllocationNumberIL = x.AllocationNumberIL;
			DocumentApprovalRequests = x.DocumentApprovalRequests;
			DocumentLines = x.DocumentLines;
			EWayBillDetails = x.EWayBillDetails;
			ElectronicProtocols = x.ElectronicProtocols;
			DocumentAdditionalExpenses = x.DocumentAdditionalExpenses;
			WithholdingTaxDataWTXCollection = x.WithholdingTaxDataWTXCollection;
			WithholdingTaxDataCollection = x.WithholdingTaxDataCollection;
			DocumentPackages = x.DocumentPackages;
			DocumentSpecialLines = x.DocumentSpecialLines;
			DocumentInstallments = x.DocumentInstallments;
			DownPaymentsToDraw = x.DownPaymentsToDraw;
			TaxExtension = x.TaxExtension;
			AddressExtension = x.AddressExtension;
			DocumentReferences = x.DocumentReferences;
		}
	}
}