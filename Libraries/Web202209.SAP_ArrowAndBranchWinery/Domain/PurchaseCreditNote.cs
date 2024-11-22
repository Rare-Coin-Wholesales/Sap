namespace Web202209.SAP_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Import.PurchaseCreditNote")]
    public partial class PurchaseCreditNote
    {
        public int Id { get; set; }

        [StringLength(4000)]
        public string odataetag { get; set; }

        public int? DocEntry { get; set; }

        public int? DocNum { get; set; }

        [StringLength(4000)]
        public string DocType { get; set; }

        [StringLength(4000)]
        public string HandWritten { get; set; }

        [StringLength(4000)]
        public string Printed { get; set; }

        public DateTime? DocDate { get; set; }

        public DateTime? DocDueDate { get; set; }

        [StringLength(4000)]
        public string CardCode { get; set; }

        [StringLength(4000)]
        public string CardName { get; set; }

        [StringLength(4000)]
        public string Address { get; set; }

        [StringLength(4000)]
        public string NumAtCard { get; set; }

        public decimal? DocTotal { get; set; }

        public int? AttachmentEntry { get; set; }

        [StringLength(4000)]
        public string DocCurrency { get; set; }

        public decimal? DocRate { get; set; }

        [StringLength(4000)]
        public string Reference1 { get; set; }

        [StringLength(4000)]
        public string Reference2 { get; set; }

        [StringLength(4000)]
        public string Comments { get; set; }

        [StringLength(4000)]
        public string JournalMemo { get; set; }

        public int? PaymentGroupCode { get; set; }

        [StringLength(4000)]
        public string DocTime { get; set; }

        public int? SalesPersonCode { get; set; }

        public int? TransportationCode { get; set; }

        [StringLength(4000)]
        public string Confirmed { get; set; }

        [StringLength(4000)]
        public string ImportFileNum { get; set; }

        [StringLength(4000)]
        public string SummeryType { get; set; }

        public int? ContactPersonCode { get; set; }

        [StringLength(4000)]
        public string ShowSCN { get; set; }

        public int? Series { get; set; }

        public DateTime? TaxDate { get; set; }

        [StringLength(4000)]
        public string PartialSupply { get; set; }

        [StringLength(4000)]
        public string DocObjectCode { get; set; }

        [StringLength(4000)]
        public string ShipToCode { get; set; }

        [StringLength(4000)]
        public string Indicator { get; set; }

        [StringLength(4000)]
        public string FederalTaxID { get; set; }

        public decimal? DiscountPercent { get; set; }

        [StringLength(4000)]
        public string PaymentReference { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? FinancialPeriod { get; set; }

        public int? UserSign { get; set; }

        public int? TransNum { get; set; }

        public decimal? VatSum { get; set; }

        public decimal? VatSumSys { get; set; }

        public decimal? VatSumFc { get; set; }

        [StringLength(4000)]
        public string NetProcedure { get; set; }

        public decimal? DocTotalFc { get; set; }

        public decimal? DocTotalSys { get; set; }

        [StringLength(4000)]
        public string Form1099 { get; set; }

        [StringLength(4000)]
        public string Box1099 { get; set; }

        [StringLength(4000)]
        public string RevisionPo { get; set; }

        [StringLength(4000)]
        public string RequriedDate { get; set; }

        [StringLength(4000)]
        public string CancelDate { get; set; }

        [StringLength(4000)]
        public string BlockDunning { get; set; }

        [StringLength(4000)]
        public string Submitted { get; set; }

        public int? Segment { get; set; }

        [StringLength(4000)]
        public string PickStatus { get; set; }

        [StringLength(4000)]
        public string Pick { get; set; }

        [StringLength(4000)]
        public string PaymentMethod { get; set; }

        [StringLength(4000)]
        public string PaymentBlock { get; set; }

        [StringLength(4000)]
        public string PaymentBlockEntry { get; set; }

        [StringLength(4000)]
        public string CentralBankIndicator { get; set; }

        [StringLength(4000)]
        public string MaximumCashDiscount { get; set; }

        [StringLength(4000)]
        public string Reserve { get; set; }

        [StringLength(4000)]
        public string Project { get; set; }

        [StringLength(4000)]
        public string ExemptionValidityDateFrom { get; set; }

        [StringLength(4000)]
        public string ExemptionValidityDateTo { get; set; }

        [StringLength(4000)]
        public string WareHouseUpdateType { get; set; }

        [StringLength(4000)]
        public string Rounding { get; set; }

        [StringLength(4000)]
        public string ExternalCorrectedDocNum { get; set; }

        [StringLength(4000)]
        public string InternalCorrectedDocNum { get; set; }

        [StringLength(4000)]
        public string NextCorrectingDocument { get; set; }

        [StringLength(4000)]
        public string DeferredTax { get; set; }

        [StringLength(4000)]
        public string TaxExemptionLetterNum { get; set; }

        public decimal? WTApplied { get; set; }

        public decimal? WTAppliedFC { get; set; }

        [StringLength(4000)]
        public string BillOfExchangeReserved { get; set; }

        [StringLength(4000)]
        public string AgentCode { get; set; }

        public decimal? WTAppliedSC { get; set; }

        public decimal? TotalEqualizationTax { get; set; }

        public decimal? TotalEqualizationTaxFC { get; set; }

        public decimal? TotalEqualizationTaxSC { get; set; }

        public int? NumberOfInstallments { get; set; }

        [StringLength(4000)]
        public string ApplyTaxOnFirstInstallment { get; set; }

        [StringLength(4000)]
        public string TaxOnInstallments { get; set; }

        public decimal? WTNonSubjectAmount { get; set; }

        public decimal? WTNonSubjectAmountSC { get; set; }

        public decimal? WTNonSubjectAmountFC { get; set; }

        public decimal? WTExemptedAmount { get; set; }

        public decimal? WTExemptedAmountSC { get; set; }

        public decimal? WTExemptedAmountFC { get; set; }

        public decimal? BaseAmount { get; set; }

        public decimal? BaseAmountSC { get; set; }

        public decimal? BaseAmountFC { get; set; }

        public decimal? WTAmount { get; set; }

        public decimal? WTAmountSC { get; set; }

        public decimal? WTAmountFC { get; set; }

        [StringLength(4000)]
        public string VatDate { get; set; }

        [StringLength(4000)]
        public string DocumentsOwner { get; set; }

        [StringLength(4000)]
        public string FolioPrefixString { get; set; }

        [StringLength(4000)]
        public string FolioNumber { get; set; }

        [StringLength(4000)]
        public string DocumentSubType { get; set; }

        [StringLength(4000)]
        public string BPChannelCode { get; set; }

        [StringLength(4000)]
        public string BPChannelContact { get; set; }

        [StringLength(4000)]
        public string Address2 { get; set; }

        [StringLength(4000)]
        public string DocumentStatus { get; set; }

        [StringLength(4000)]
        public string PeriodIndicator { get; set; }

        [StringLength(4000)]
        public string PayToCode { get; set; }

        [StringLength(4000)]
        public string ManualNumber { get; set; }

        [StringLength(4000)]
        public string UseShpdGoodsAct { get; set; }

        [StringLength(4000)]
        public string IsPayToBank { get; set; }

        [StringLength(4000)]
        public string PayToBankCountry { get; set; }

        [StringLength(4000)]
        public string PayToBankCode { get; set; }

        [StringLength(4000)]
        public string PayToBankAccountNo { get; set; }

        [StringLength(4000)]
        public string PayToBankBranch { get; set; }

        [StringLength(4000)]
        public string BPL_IDAssignedToInvoice { get; set; }

        public decimal? DownPayment { get; set; }

        [StringLength(4000)]
        public string ReserveInvoice { get; set; }

        public int? LanguageCode { get; set; }

        [StringLength(4000)]
        public string TrackingNumber { get; set; }

        [StringLength(4000)]
        public string PickRemark { get; set; }

        [StringLength(4000)]
        public string ClosingDate { get; set; }

        [StringLength(4000)]
        public string SequenceCode { get; set; }

        [StringLength(4000)]
        public string SequenceSerial { get; set; }

        [StringLength(4000)]
        public string SeriesString { get; set; }

        [StringLength(4000)]
        public string SubSeriesString { get; set; }

        [StringLength(4000)]
        public string SequenceModel { get; set; }

        [StringLength(4000)]
        public string UseCorrectionVATGroup { get; set; }

        public decimal? TotalDiscount { get; set; }

        public decimal? DownPaymentAmount { get; set; }

        public decimal? DownPaymentPercentage { get; set; }

        [StringLength(4000)]
        public string DownPaymentType { get; set; }

        public decimal? DownPaymentAmountSC { get; set; }

        public decimal? DownPaymentAmountFC { get; set; }

        public decimal? VatPercent { get; set; }

        public decimal? ServiceGrossProfitPercent { get; set; }

        [StringLength(4000)]
        public string OpeningRemarks { get; set; }

        [StringLength(4000)]
        public string ClosingRemarks { get; set; }

        public decimal? RoundingDiffAmount { get; set; }

        public decimal? RoundingDiffAmountFC { get; set; }

        public decimal? RoundingDiffAmountSC { get; set; }

        [StringLength(4000)]
        public string Cancelled { get; set; }

        [StringLength(4000)]
        public string SignatureInputMessage { get; set; }

        [StringLength(4000)]
        public string SignatureDigest { get; set; }

        [StringLength(4000)]
        public string CertificationNumber { get; set; }

        [StringLength(4000)]
        public string PrivateKeyVersion { get; set; }

        [StringLength(4000)]
        public string ControlAccount { get; set; }

        [StringLength(4000)]
        public string InsuranceOperation347 { get; set; }

        [StringLength(4000)]
        public string ArchiveNonremovableSalesQuotation { get; set; }

        [StringLength(4000)]
        public string GTSChecker { get; set; }

        [StringLength(4000)]
        public string GTSPayee { get; set; }

        public int? ExtraMonth { get; set; }

        public int? ExtraDays { get; set; }

        public int? CashDiscountDateOffset { get; set; }

        [StringLength(4000)]
        public string StartFrom { get; set; }

        [StringLength(4000)]
        public string NTSApproved { get; set; }

        [StringLength(4000)]
        public string ETaxWebSite { get; set; }

        [StringLength(4000)]
        public string ETaxNumber { get; set; }

        [StringLength(4000)]
        public string NTSApprovedNumber { get; set; }

        [StringLength(4000)]
        public string EDocGenerationType { get; set; }

        [StringLength(4000)]
        public string EDocSeries { get; set; }

        [StringLength(4000)]
        public string EDocNum { get; set; }

        [StringLength(4000)]
        public string EDocExportFormat { get; set; }

        [StringLength(4000)]
        public string EDocStatus { get; set; }

        [StringLength(4000)]
        public string EDocErrorCode { get; set; }

        [StringLength(4000)]
        public string EDocErrorMessage { get; set; }

        [StringLength(4000)]
        public string DownPaymentStatus { get; set; }

        [StringLength(4000)]
        public string GroupSeries { get; set; }

        [StringLength(4000)]
        public string GroupNumber { get; set; }

        [StringLength(4000)]
        public string GroupHandWritten { get; set; }

        [StringLength(4000)]
        public string ReopenOriginalDocument { get; set; }

        [StringLength(4000)]
        public string ReopenManuallyClosedOrCanceledDocument { get; set; }

        [StringLength(4000)]
        public string CreateOnlineQuotation { get; set; }

        [StringLength(4000)]
        public string POSEquipmentNumber { get; set; }

        [StringLength(4000)]
        public string POSManufacturerSerialNumber { get; set; }

        [StringLength(4000)]
        public string POSCashierNumber { get; set; }

        [StringLength(4000)]
        public string ApplyCurrentVATRatesForDownPaymentsToDraw { get; set; }

        [StringLength(4000)]
        public string ClosingOption { get; set; }

        [StringLength(4000)]
        public string SpecifiedClosingDate { get; set; }

        [StringLength(4000)]
        public string OpenForLandedCosts { get; set; }

        [StringLength(4000)]
        public string AuthorizationStatus { get; set; }

        public decimal? TotalDiscountFC { get; set; }

        public decimal? TotalDiscountSC { get; set; }

        [StringLength(4000)]
        public string RelevantToGTS { get; set; }

        [StringLength(4000)]
        public string BPLName { get; set; }

        [StringLength(4000)]
        public string VATRegNum { get; set; }

        [StringLength(4000)]
        public string AnnualInvoiceDeclarationReference { get; set; }

        [StringLength(4000)]
        public string Supplier { get; set; }

        [StringLength(4000)]
        public string Releaser { get; set; }

        [StringLength(4000)]
        public string Receiver { get; set; }

        [StringLength(4000)]
        public string BlanketAgreementNumber { get; set; }

        [StringLength(4000)]
        public string IsAlteration { get; set; }

        [StringLength(4000)]
        public string CancelStatus { get; set; }

        [StringLength(4000)]
        public string AssetValueDate { get; set; }

        [StringLength(4000)]
        public string DocumentDelivery { get; set; }

        [StringLength(4000)]
        public string AuthorizationCode { get; set; }

        [StringLength(4000)]
        public string StartDeliveryDate { get; set; }

        [StringLength(4000)]
        public string StartDeliveryTime { get; set; }

        [StringLength(4000)]
        public string EndDeliveryDate { get; set; }

        [StringLength(4000)]
        public string EndDeliveryTime { get; set; }

        [StringLength(4000)]
        public string VehiclePlate { get; set; }

        [StringLength(4000)]
        public string ATDocumentType { get; set; }

        [StringLength(4000)]
        public string ElecCommStatus { get; set; }

        [StringLength(4000)]
        public string ElecCommMessage { get; set; }

        [StringLength(4000)]
        public string ReuseDocumentNum { get; set; }

        [StringLength(4000)]
        public string ReuseNotaFiscalNum { get; set; }

        [StringLength(4000)]
        public string PrintSEPADirect { get; set; }

        [StringLength(4000)]
        public string FiscalDocNum { get; set; }

        [StringLength(4000)]
        public string POSDailySummaryNo { get; set; }

        [StringLength(4000)]
        public string POSReceiptNo { get; set; }

        [StringLength(4000)]
        public string PointOfIssueCode { get; set; }

        [StringLength(4000)]
        public string Letter { get; set; }

        [StringLength(4000)]
        public string FolioNumberFrom { get; set; }

        [StringLength(4000)]
        public string FolioNumberTo { get; set; }

        [StringLength(4000)]
        public string InterimType { get; set; }

        public int? RelatedType { get; set; }

        [StringLength(4000)]
        public string RelatedEntry { get; set; }

        [StringLength(4000)]
        public string SAPPassport { get; set; }

        [StringLength(4000)]
        public string DocumentTaxID { get; set; }

        [StringLength(4000)]
        public string DateOfReportingControlStatementVAT { get; set; }

        [StringLength(4000)]
        public string ReportingSectionControlStatementVAT { get; set; }

        [StringLength(4000)]
        public string ExcludeFromTaxReportControlStatementVAT { get; set; }

        [StringLength(4000)]
        public string POS_CashRegister { get; set; }

        [StringLength(4000)]
        public string UpdateTime { get; set; }

        [StringLength(4000)]
        public string CreateQRCodeFrom { get; set; }

        [StringLength(4000)]
        public string PriceMode { get; set; }

        [StringLength(4000)]
        public string OriginalRefNo { get; set; }

        [StringLength(4000)]
        public string OriginalRefDate { get; set; }

        [StringLength(4000)]
        public string Revision { get; set; }

        [StringLength(4000)]
        public string GSTTransactionType { get; set; }

        [StringLength(4000)]
        public string OriginalCreditOrDebitNo { get; set; }

        [StringLength(4000)]
        public string OriginalCreditOrDebitDate { get; set; }

        [StringLength(4000)]
        public string TaxInvoiceNo { get; set; }

        [StringLength(4000)]
        public string TaxInvoiceDate { get; set; }

        [StringLength(4000)]
        public string ShipFrom { get; set; }

        [StringLength(4000)]
        public string CommissionTrade { get; set; }

        [StringLength(4000)]
        public string CommissionTradeReturn { get; set; }

        [StringLength(4000)]
        public string UseBillToAddrToDetermineTax { get; set; }

        public int? IssuingReason { get; set; }

        [StringLength(4000)]
        public string Cig { get; set; }

        [StringLength(4000)]
        public string Cup { get; set; }

        public decimal? PaidToDate { get; set; }

        public decimal? PaidToDateFC { get; set; }

        public decimal? PaidToDateSys { get; set; }

        [StringLength(4000)]
        public string FatherCard { get; set; }

        [StringLength(4000)]
        public string FatherType { get; set; }

        [StringLength(4000)]
        public string ShipState { get; set; }

        [StringLength(4000)]
        public string ShipPlace { get; set; }

        [StringLength(4000)]
        public string CustOffice { get; set; }

        [StringLength(4000)]
        public string FCI { get; set; }

        [StringLength(4000)]
        public string AddLegIn { get; set; }

        [StringLength(4000)]
        public string LegTextF { get; set; }

        [StringLength(4000)]
        public string DANFELgTxt { get; set; }

        public int? DataVersion { get; set; }

        [StringLength(4000)]
        public string LastPageFolioNumber { get; set; }

        [StringLength(4000)]
        public string InventoryStatus { get; set; }

        [StringLength(4000)]
        public string PlasticPackagingTaxRelevant { get; set; }

        [StringLength(4000)]
        public string NotRelevantForMonthlyInvoice { get; set; }
    }
}
