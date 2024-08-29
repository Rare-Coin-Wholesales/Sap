namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        public int Id { get; set; }

        public int? BaseType { get; set; }

        public int? CashDiscountDateOffset { get; set; }

        public int? ContactPersonCode { get; set; }

        public int? DataVersion { get; set; }

        public int? DocEntry { get; set; }

        public int? DocNum { get; set; }

        public int? ExtraDays { get; set; }

        public int? ExtraMonth { get; set; }

        public int? FinancialPeriod { get; set; }

        public int? IssuingReason { get; set; }

        public int? LanguageCode { get; set; }

        public int? NumberOfInstallments { get; set; }

        public int? PaymentGroupCode { get; set; }

        public int? RelatedType { get; set; }

        public int? SalesPersonCode { get; set; }

        public int? Segment { get; set; }

        public int? Series { get; set; }

        public int? TransNum { get; set; }

        public int? TransportationCode { get; set; }

        public int? UserSign { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? DocDate { get; set; }

        public DateTime? DocDueDate { get; set; }

        public DateTime? TaxDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public decimal? BaseAmount { get; set; }

        public decimal? BaseAmountFC { get; set; }

        public decimal? BaseAmountSC { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal? DocRate { get; set; }

        public decimal? DocTotal { get; set; }

        public decimal? DocTotalFc { get; set; }

        public decimal? DocTotalSys { get; set; }

        public decimal? DownPayment { get; set; }

        public decimal? DownPaymentAmount { get; set; }

        public decimal? DownPaymentAmountFC { get; set; }

        public decimal? DownPaymentAmountSC { get; set; }

        public decimal? DownPaymentPercentage { get; set; }

        public decimal? PaidToDate { get; set; }

        public decimal? PaidToDateFC { get; set; }

        public decimal? PaidToDateSys { get; set; }

        public decimal? RoundingDiffAmount { get; set; }

        public decimal? RoundingDiffAmountFC { get; set; }

        public decimal? RoundingDiffAmountSC { get; set; }

        public decimal? TotalDiscount { get; set; }

        public decimal? TotalDiscountFC { get; set; }

        public decimal? TotalDiscountSC { get; set; }

        public decimal? TotalEqualizationTax { get; set; }

        public decimal? TotalEqualizationTaxFC { get; set; }

        public decimal? TotalEqualizationTaxSC { get; set; }

        public decimal? VatPercent { get; set; }

        public decimal? VatSum { get; set; }

        public decimal? VatSumFc { get; set; }

        public decimal? VatSumSys { get; set; }

        public decimal? WTAmount { get; set; }

        public decimal? WTAmountFC { get; set; }

        public decimal? WTAmountSC { get; set; }

        public decimal? WTApplied { get; set; }

        public decimal? WTAppliedFC { get; set; }

        public decimal? WTAppliedSC { get; set; }

        public decimal? WTExemptedAmount { get; set; }

        public decimal? WTExemptedAmountFC { get; set; }

        public decimal? WTExemptedAmountSC { get; set; }

        public decimal? WTNonSubjectAmount { get; set; }

        public decimal? WTNonSubjectAmountFC { get; set; }

        public decimal? WTNonSubjectAmountSC { get; set; }

        [StringLength(255)]
        public string AddLegIn { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string Address2 { get; set; }

        [StringLength(255)]
        public string AgentCode { get; set; }

        [StringLength(255)]
        public string AllocationNumberIL { get; set; }

        [StringLength(255)]
        public string AnnualInvoiceDeclarationReference { get; set; }

        [StringLength(255)]
        public string ApplyCurrentVATRatesForDownPaymentsToDraw { get; set; }

        [StringLength(255)]
        public string ApplyTaxOnFirstInstallment { get; set; }

        [StringLength(255)]
        public string ArchiveNonremovableSalesQuotation { get; set; }

        [StringLength(255)]
        public string AssetValueDate { get; set; }

        [StringLength(255)]
        public string ATDocumentType { get; set; }

        [StringLength(255)]
        public string AttachmentEntry { get; set; }

        [StringLength(255)]
        public string AuthorizationCode { get; set; }

        [StringLength(255)]
        public string AuthorizationStatus { get; set; }

        [StringLength(255)]
        public string BaseEntry { get; set; }

        [StringLength(255)]
        public string BillOfExchangeReserved { get; set; }

        [StringLength(255)]
        public string BlanketAgreementNumber { get; set; }

        [StringLength(255)]
        public string BlockDunning { get; set; }

        [StringLength(255)]
        public string Box1099 { get; set; }

        [StringLength(255)]
        public string BPChannelCode { get; set; }

        [StringLength(255)]
        public string BPChannelContact { get; set; }

        [StringLength(255)]
        public string BPLIDAssignedToInvoice { get; set; }

        [StringLength(255)]
        public string BPLName { get; set; }

        [StringLength(255)]
        public string CancelDate { get; set; }

        [StringLength(255)]
        public string Cancelled { get; set; }

        [StringLength(255)]
        public string CancelStatus { get; set; }

        [StringLength(255)]
        public string CardCode { get; set; }

        [StringLength(255)]
        public string CardName { get; set; }

        [StringLength(255)]
        public string CentralBankIndicator { get; set; }

        [StringLength(255)]
        public string CertificationNumber { get; set; }

        [StringLength(255)]
        public string Cig { get; set; }

        [StringLength(255)]
        public string ClosingDate { get; set; }

        [StringLength(255)]
        public string ClosingOption { get; set; }

        [StringLength(255)]
        public string ClosingRemarks { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [StringLength(255)]
        public string CommissionTrade { get; set; }

        [StringLength(255)]
        public string CommissionTradeReturn { get; set; }

        [StringLength(255)]
        public string Confirmed { get; set; }

        [StringLength(255)]
        public string ControlAccount { get; set; }

        [StringLength(255)]
        public string CreateOnlineQuotation { get; set; }

        [StringLength(255)]
        public string CreateQRCodeFrom { get; set; }

        [StringLength(255)]
        public string Cup { get; set; }

        [StringLength(255)]
        public string CustOffice { get; set; }

        [StringLength(255)]
        public string DANFELgTxt { get; set; }

        [StringLength(255)]
        public string DateOfReportingControlStatementVAT { get; set; }

        [StringLength(255)]
        public string DeferredTax { get; set; }

        [StringLength(255)]
        public string DocCurrency { get; set; }

        [StringLength(255)]
        public string DocObjectCode { get; set; }

        [StringLength(255)]
        public string DocTime { get; set; }

        [StringLength(255)]
        public string DocType { get; set; }

        [StringLength(255)]
        public string DocumentDelivery { get; set; }

        [StringLength(255)]
        public string DocumentsOwner { get; set; }

        [StringLength(255)]
        public string DocumentStatus { get; set; }

        [StringLength(255)]
        public string DocumentSubType { get; set; }

        [StringLength(255)]
        public string DocumentTaxID { get; set; }

        [StringLength(255)]
        public string DownPaymentStatus { get; set; }

        [StringLength(255)]
        public string DownPaymentType { get; set; }

        [StringLength(255)]
        public string ECommerceGSTIN { get; set; }

        [StringLength(255)]
        public string ECommerceOperator { get; set; }

        [StringLength(255)]
        public string EDocErrorCode { get; set; }

        [StringLength(255)]
        public string EDocErrorMessage { get; set; }

        [StringLength(255)]
        public string EDocExportFormat { get; set; }

        [StringLength(255)]
        public string EDocGenerationType { get; set; }

        [StringLength(255)]
        public string EDocNum { get; set; }

        [StringLength(255)]
        public string EDocSeries { get; set; }

        [StringLength(255)]
        public string EDocStatus { get; set; }

        [StringLength(255)]
        public string EDocType { get; set; }

        [StringLength(255)]
        public string ElecCommMessage { get; set; }

        [StringLength(255)]
        public string ElecCommStatus { get; set; }

        [StringLength(255)]
        public string EndDeliveryDate { get; set; }

        [StringLength(255)]
        public string EndDeliveryTime { get; set; }

        [StringLength(255)]
        public string ETaxNumber { get; set; }

        [StringLength(255)]
        public string ETaxWebSite { get; set; }

        [StringLength(255)]
        public string ExcludeFromTaxReportControlStatementVAT { get; set; }

        [StringLength(255)]
        public string ExemptionValidityDateFrom { get; set; }

        [StringLength(255)]
        public string ExemptionValidityDateTo { get; set; }

        [StringLength(255)]
        public string ExternalCorrectedDocNum { get; set; }

        [StringLength(255)]
        public string FatherCard { get; set; }

        [StringLength(255)]
        public string FatherType { get; set; }

        [StringLength(255)]
        public string FCEAsPaymentMeans { get; set; }

        [StringLength(255)]
        public string FCI { get; set; }

        [StringLength(255)]
        public string FederalTaxID { get; set; }

        [StringLength(255)]
        public string FiscalDocNum { get; set; }

        [StringLength(255)]
        public string FolioNumber { get; set; }

        [StringLength(255)]
        public string FolioNumberFrom { get; set; }

        [StringLength(255)]
        public string FolioNumberTo { get; set; }

        [StringLength(255)]
        public string FolioPrefixString { get; set; }

        [StringLength(255)]
        public string Form1099 { get; set; }

        [StringLength(255)]
        public string GroupHandWritten { get; set; }

        [StringLength(255)]
        public string GroupNumber { get; set; }

        [StringLength(255)]
        public string GroupSeries { get; set; }

        [StringLength(255)]
        public string GSTTransactionType { get; set; }

        [StringLength(255)]
        public string GTSChecker { get; set; }

        [StringLength(255)]
        public string GTSPayee { get; set; }

        [StringLength(255)]
        public string HandWritten { get; set; }

        [StringLength(255)]
        public string ImportFileNum { get; set; }

        [StringLength(255)]
        public string IndFinal { get; set; }

        [StringLength(255)]
        public string Indicator { get; set; }

        [StringLength(255)]
        public string InsuranceOperation347 { get; set; }

        [StringLength(255)]
        public string InterimType { get; set; }

        [StringLength(255)]
        public string InternalCorrectedDocNum { get; set; }

        [StringLength(255)]
        public string InventoryStatus { get; set; }

        [StringLength(255)]
        public string InvoicePayment { get; set; }

        [StringLength(255)]
        public string IsAlteration { get; set; }

        [StringLength(255)]
        public string IsPayToBank { get; set; }

        [StringLength(255)]
        public string JournalMemo { get; set; }

        [StringLength(255)]
        public string LastPageFolioNumber { get; set; }

        [StringLength(255)]
        public string LegTextF { get; set; }

        [StringLength(255)]
        public string Letter { get; set; }

        [StringLength(255)]
        public string ManualNumber { get; set; }

        [StringLength(255)]
        public string MaximumCashDiscount { get; set; }

        [StringLength(255)]
        public string NetProcedure { get; set; }

        [StringLength(255)]
        public string NextCorrectingDocument { get; set; }

        [StringLength(255)]
        public string NotRelevantForMonthlyInvoice { get; set; }

        [StringLength(255)]
        public string NTSApproved { get; set; }

        [StringLength(255)]
        public string NTSApprovedNumber { get; set; }

        [StringLength(255)]
        public string NumAtCard { get; set; }

        [StringLength(255)]
        public string OdataEtag { get; set; }

        [StringLength(255)]
        public string OpenForLandedCosts { get; set; }

        [StringLength(255)]
        public string OpeningRemarks { get; set; }

        [StringLength(255)]
        public string OriginalCreditOrDebitDate { get; set; }

        [StringLength(255)]
        public string OriginalCreditOrDebitNo { get; set; }

        [StringLength(255)]
        public string OriginalRefDate { get; set; }

        [StringLength(255)]
        public string OriginalRefNo { get; set; }

        [StringLength(255)]
        public string PartialSupply { get; set; }

        [StringLength(255)]
        public string PaymentBlock { get; set; }

        [StringLength(255)]
        public string PaymentBlockEntry { get; set; }

        [StringLength(255)]
        public string PaymentMethod { get; set; }

        [StringLength(255)]
        public string PaymentReference { get; set; }

        [StringLength(255)]
        public string PayToBankAccountNo { get; set; }

        [StringLength(255)]
        public string PayToBankBranch { get; set; }

        [StringLength(255)]
        public string PayToBankCode { get; set; }

        [StringLength(255)]
        public string PayToBankCountry { get; set; }

        [StringLength(255)]
        public string PayToCode { get; set; }

        [StringLength(255)]
        public string PeriodIndicator { get; set; }

        [StringLength(255)]
        public string Pick { get; set; }

        [StringLength(255)]
        public string PickRemark { get; set; }

        [StringLength(255)]
        public string PickStatus { get; set; }

        [StringLength(255)]
        public string PlasticPackagingTaxRelevant { get; set; }

        [StringLength(255)]
        public string PointOfIssueCode { get; set; }

        [StringLength(255)]
        public string POSCashierNumber { get; set; }

        [StringLength(255)]
        public string POSCashRegister { get; set; }

        [StringLength(255)]
        public string POSDailySummaryNo { get; set; }

        [StringLength(255)]
        public string POSEquipmentNumber { get; set; }

        [StringLength(255)]
        public string POSManufacturerSerialNumber { get; set; }

        [StringLength(255)]
        public string POSReceiptNo { get; set; }

        [StringLength(255)]
        public string PriceMode { get; set; }

        [StringLength(255)]
        public string Printed { get; set; }

        [StringLength(255)]
        public string PrintSEPADirect { get; set; }

        [StringLength(255)]
        public string PrivateKeyVersion { get; set; }

        [StringLength(255)]
        public string Project { get; set; }

        [StringLength(255)]
        public string Receiver { get; set; }

        [StringLength(255)]
        public string Reference1 { get; set; }

        [StringLength(255)]
        public string Reference2 { get; set; }

        [StringLength(255)]
        public string RelatedEntry { get; set; }

        [StringLength(255)]
        public string Releaser { get; set; }

        [StringLength(255)]
        public string RelevantToGTS { get; set; }

        [StringLength(255)]
        public string ReopenManuallyClosedOrCanceledDocument { get; set; }

        [StringLength(255)]
        public string ReopenOriginalDocument { get; set; }

        [StringLength(255)]
        public string ReportingSectionControlStatementVAT { get; set; }

        [StringLength(255)]
        public string RequriedDate { get; set; }

        [StringLength(255)]
        public string Reserve { get; set; }

        [StringLength(255)]
        public string ReserveInvoice { get; set; }

        [StringLength(255)]
        public string ReuseDocumentNum { get; set; }

        [StringLength(255)]
        public string ReuseNotaFiscalNum { get; set; }

        [StringLength(255)]
        public string Revision { get; set; }

        [StringLength(255)]
        public string RevisionPo { get; set; }

        [StringLength(255)]
        public string Rounding { get; set; }

        [StringLength(255)]
        public string SAPPassport { get; set; }

        [StringLength(255)]
        public string SequenceCode { get; set; }

        [StringLength(255)]
        public string SequenceModel { get; set; }

        [StringLength(255)]
        public string SequenceSerial { get; set; }

        [StringLength(255)]
        public string SeriesString { get; set; }

        [StringLength(255)]
        public string ServiceGrossProfitPercent { get; set; }

        [StringLength(255)]
        public string ShipFrom { get; set; }

        [StringLength(255)]
        public string ShipPlace { get; set; }

        [StringLength(255)]
        public string ShipState { get; set; }

        [StringLength(255)]
        public string ShipToCode { get; set; }

        [StringLength(255)]
        public string ShowSCN { get; set; }

        [StringLength(255)]
        public string SignatureDigest { get; set; }

        [StringLength(255)]
        public string SignatureInputMessage { get; set; }

        [StringLength(255)]
        public string SpecifiedClosingDate { get; set; }

        [StringLength(255)]
        public string StartDeliveryDate { get; set; }

        [StringLength(255)]
        public string StartDeliveryTime { get; set; }

        [StringLength(255)]
        public string StartFrom { get; set; }

        [StringLength(255)]
        public string Submitted { get; set; }

        [StringLength(255)]
        public string SubSeriesString { get; set; }

        [StringLength(255)]
        public string SummeryType { get; set; }

        [StringLength(255)]
        public string Supplier { get; set; }

        [StringLength(255)]
        public string TaxExemptionLetterNum { get; set; }

        [StringLength(255)]
        public string TaxOnInstallments { get; set; }

        [StringLength(255)]
        public string TrackingNumber { get; set; }

        [StringLength(255)]
        public string UpdateTime { get; set; }

        [StringLength(255)]
        public string UseBillToAddrToDetermineTax { get; set; }

        [StringLength(255)]
        public string UseCorrectionVATGroup { get; set; }

        [StringLength(255)]
        public string UseShpdGoodsAct { get; set; }

        [StringLength(255)]
        public string VatDate { get; set; }

        [StringLength(255)]
        public string VATRegNum { get; set; }

        [StringLength(255)]
        public string VehiclePlate { get; set; }

        [StringLength(255)]
        public string WareHouseUpdateType { get; set; }
    }
}
