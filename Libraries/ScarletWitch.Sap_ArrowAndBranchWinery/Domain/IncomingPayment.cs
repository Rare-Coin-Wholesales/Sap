namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IncomingPayment")]
    public partial class IncomingPayment
    {
        public int Id { get; set; }

        public int? DocEntry { get; set; }

        public int? DocNum { get; set; }

        public int? Series { get; set; }

        public DateTime? DocDate { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? TaxDate { get; set; }

        public DateTime? TransferDate { get; set; }

        public DateTime? VatDate { get; set; }

        public decimal? BankChargeAmount { get; set; }

        public decimal? BankChargeAmountInFC { get; set; }

        public decimal? BankChargeAmountInSC { get; set; }

        public decimal? BillOfExchangeAmount { get; set; }

        public decimal? BillOfExchangeAmountFC { get; set; }

        public decimal? BillOfExchangeAmountSC { get; set; }

        public decimal? CashSum { get; set; }

        public decimal? CashSumFC { get; set; }

        public decimal? CashSumSys { get; set; }

        public decimal? DeductionPercent { get; set; }

        public decimal? DeductionSum { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal? DocRate { get; set; }

        public decimal? TransferRealAmount { get; set; }

        public decimal? TransferSum { get; set; }

        public decimal? UnderOverpaymentdifference { get; set; }

        public decimal? UnderOverpaymentdiffFC { get; set; }

        public decimal? UnderOverpaymentdiffSC { get; set; }

        public decimal? WTAmount { get; set; }

        public decimal? WTAmountFC { get; set; }

        public decimal? WTAmountSC { get; set; }

        public decimal? WtBaseSum { get; set; }

        public decimal? WtBaseSumFC { get; set; }

        public decimal? WtBaseSumSC { get; set; }

        public decimal? WTTaxableAmount { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string ApplyVAT { get; set; }

        [StringLength(255)]
        public string AttachmentEntry { get; set; }

        [StringLength(255)]
        public string AuthorizationStatus { get; set; }

        [StringLength(255)]
        public string BankAccount { get; set; }

        [StringLength(255)]
        public string BankCode { get; set; }

        [StringLength(255)]
        public string BillOfExchangeAgent { get; set; }

        [StringLength(255)]
        public string BillofExchangeStatus { get; set; }

        [StringLength(255)]
        public string BlanketAgreement { get; set; }

        [StringLength(255)]
        public string BoeAccount { get; set; }

        [StringLength(255)]
        public string BPLID { get; set; }

        [StringLength(255)]
        public string BPLName { get; set; }

        [StringLength(255)]
        public string Cancelled { get; set; }

        [StringLength(255)]
        public string CardCode { get; set; }

        [StringLength(255)]
        public string CardName { get; set; }

        [StringLength(255)]
        public string CashAccount { get; set; }

        [StringLength(255)]
        public string CertificationNumber { get; set; }

        [StringLength(255)]
        public string CheckAccount { get; set; }

        [StringLength(255)]
        public string Cig { get; set; }

        [StringLength(255)]
        public string ContactPersonCode { get; set; }

        [StringLength(255)]
        public string ControlAccount { get; set; }

        [StringLength(255)]
        public string CounterReference { get; set; }

        [StringLength(255)]
        public string Cup { get; set; }

        [StringLength(255)]
        public string CurrencyIsLocal { get; set; }

        [StringLength(255)]
        public string DocCurrency { get; set; }

        [StringLength(255)]
        public string DocObjectCode { get; set; }

        [StringLength(255)]
        public string DocType { get; set; }

        [StringLength(255)]
        public string DocTypte { get; set; }

        [StringLength(255)]
        public string EDocExportFormat { get; set; }

        [StringLength(255)]
        public string ElecCommMessage { get; set; }

        [StringLength(255)]
        public string ElecCommStatus { get; set; }

        [StringLength(255)]
        public string HandWritten { get; set; }

        [StringLength(255)]
        public string IsPayToBank { get; set; }

        [StringLength(255)]
        public string JournalRemarks { get; set; }

        [StringLength(255)]
        public string LocalCurrency { get; set; }

        [StringLength(255)]
        public string LocationCode { get; set; }

        [StringLength(255)]
        public string PaymentByWTCertif { get; set; }

        [StringLength(255)]
        public string PaymentPriority { get; set; }

        [StringLength(255)]
        public string PaymentType { get; set; }

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
        public string Printed { get; set; }

        [StringLength(255)]
        public string PrivateKeyVersion { get; set; }

        [StringLength(255)]
        public string Proforma { get; set; }

        [StringLength(255)]
        public string ProjectCode { get; set; }

        [StringLength(255)]
        public string Reference1 { get; set; }

        [StringLength(255)]
        public string Reference2 { get; set; }

        [StringLength(255)]
        public string Remarks { get; set; }

        [StringLength(255)]
        public string SignatureDigest { get; set; }

        [StringLength(255)]
        public string SignatureInputMessage { get; set; }

        [StringLength(255)]
        public string SplitTransaction { get; set; }

        [StringLength(255)]
        public string SplitVendorCreditRow { get; set; }

        [StringLength(255)]
        public string TaxGroup { get; set; }

        [StringLength(255)]
        public string TransactionCode { get; set; }

        [StringLength(255)]
        public string TransferAccount { get; set; }

        [StringLength(255)]
        public string TransferReference { get; set; }

        [StringLength(255)]
        public string VATRegNum { get; set; }

        [StringLength(255)]
        public string WTAccount { get; set; }

        [StringLength(255)]
        public string WTCode { get; set; }
    }
}
