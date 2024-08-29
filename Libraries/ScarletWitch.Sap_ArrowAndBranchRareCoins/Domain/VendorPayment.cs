namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendorPayment")]
    public partial class VendorPayment
    {
        public int Id { get; set; }

        [StringLength(4000)]
        public string DocNum { get; set; }

        [StringLength(4000)]
        public string DocType { get; set; }

        [StringLength(4000)]
        public string HandWritten { get; set; }

        [StringLength(4000)]
        public string Printed { get; set; }

        [StringLength(4000)]
        public string DocDate { get; set; }

        [StringLength(4000)]
        public string CardCode { get; set; }

        [StringLength(4000)]
        public string CardName { get; set; }

        [StringLength(4000)]
        public string Address { get; set; }

        [StringLength(4000)]
        public string CashAccount { get; set; }

        [StringLength(4000)]
        public string DocCurrency { get; set; }

        [StringLength(4000)]
        public string CashSum { get; set; }

        [StringLength(4000)]
        public string CheckAccount { get; set; }

        [StringLength(4000)]
        public string TransferAccount { get; set; }

        [StringLength(4000)]
        public string TransferSum { get; set; }

        [StringLength(4000)]
        public string TransferDate { get; set; }

        [StringLength(4000)]
        public string TransferReference { get; set; }

        [StringLength(4000)]
        public string LocalCurrency { get; set; }

        [StringLength(4000)]
        public string DocRate { get; set; }

        [StringLength(4000)]
        public string Reference1 { get; set; }

        [StringLength(4000)]
        public string Reference2 { get; set; }

        [StringLength(4000)]
        public string CounterReference { get; set; }

        [StringLength(4000)]
        public string Remarks { get; set; }

        [StringLength(4000)]
        public string JournalRemarks { get; set; }

        [StringLength(4000)]
        public string SplitTransaction { get; set; }

        [StringLength(4000)]
        public string ContactPersonCode { get; set; }

        [StringLength(4000)]
        public string ApplyVAT { get; set; }

        [StringLength(4000)]
        public string TaxDate { get; set; }

        [StringLength(4000)]
        public string Series { get; set; }

        [StringLength(4000)]
        public string BankCode { get; set; }

        [StringLength(4000)]
        public string BankAccount { get; set; }

        [StringLength(4000)]
        public string DiscountPercent { get; set; }

        [StringLength(4000)]
        public string ProjectCode { get; set; }

        [StringLength(4000)]
        public string CurrencyIsLocal { get; set; }

        [StringLength(4000)]
        public string DeductionPercent { get; set; }

        [StringLength(4000)]
        public string DeductionSum { get; set; }

        [StringLength(4000)]
        public string CashSumFC { get; set; }

        [StringLength(4000)]
        public string CashSumSys { get; set; }

        [StringLength(4000)]
        public string BoeAccount { get; set; }

        [StringLength(4000)]
        public string BillOfExchangeAmount { get; set; }

        [StringLength(4000)]
        public string BillofExchangeStatus { get; set; }

        [StringLength(4000)]
        public string BillOfExchangeAmountFC { get; set; }

        [StringLength(4000)]
        public string BillOfExchangeAmountSC { get; set; }

        [StringLength(4000)]
        public string BillOfExchangeAgent { get; set; }

        [StringLength(4000)]
        public string WTCode { get; set; }

        [StringLength(4000)]
        public string WTAmount { get; set; }

        [StringLength(4000)]
        public string WTAmountFC { get; set; }

        [StringLength(4000)]
        public string WTAmountSC { get; set; }

        [StringLength(4000)]
        public string WTAccount { get; set; }

        [StringLength(4000)]
        public string WTTaxableAmount { get; set; }

        [StringLength(4000)]
        public string Proforma { get; set; }

        [StringLength(4000)]
        public string PayToBankCode { get; set; }

        [StringLength(4000)]
        public string PayToBankBranch { get; set; }

        [StringLength(4000)]
        public string PayToBankAccountNo { get; set; }

        [StringLength(4000)]
        public string PayToCode { get; set; }

        [StringLength(4000)]
        public string PayToBankCountry { get; set; }

        [StringLength(4000)]
        public string IsPayToBank { get; set; }

        [StringLength(4000)]
        public string DocEntry { get; set; }

        [StringLength(4000)]
        public string PaymentPriority { get; set; }

        [StringLength(4000)]
        public string TaxGroup { get; set; }

        [StringLength(4000)]
        public string BankChargeAmount { get; set; }

        [StringLength(4000)]
        public string BankChargeAmountInFC { get; set; }

        [StringLength(4000)]
        public string BankChargeAmountInSC { get; set; }

        [StringLength(4000)]
        public string UnderOverpaymentdifference { get; set; }

        [StringLength(4000)]
        public string UnderOverpaymentdiffSC { get; set; }

        [StringLength(4000)]
        public string WtBaseSum { get; set; }

        [StringLength(4000)]
        public string WtBaseSumFC { get; set; }

        [StringLength(4000)]
        public string WtBaseSumSC { get; set; }

        [StringLength(4000)]
        public string VatDate { get; set; }

        [StringLength(4000)]
        public string TransactionCode { get; set; }

        [StringLength(4000)]
        public string PaymentType { get; set; }

        [StringLength(4000)]
        public string TransferRealAmount { get; set; }

        [StringLength(4000)]
        public string DocObjectCode { get; set; }

        [StringLength(4000)]
        public string DocTypte { get; set; }

        [StringLength(4000)]
        public string DueDate { get; set; }

        [StringLength(4000)]
        public string LocationCode { get; set; }

        [StringLength(4000)]
        public string Cancelled { get; set; }

        [StringLength(4000)]
        public string ControlAccount { get; set; }

        [StringLength(4000)]
        public string UnderOverpaymentdiffFC { get; set; }

        [StringLength(4000)]
        public string AuthorizationStatus { get; set; }

        [StringLength(4000)]
        public string BPLID { get; set; }

        [StringLength(4000)]
        public string BPLName { get; set; }

        [StringLength(4000)]
        public string VATRegNum { get; set; }

        [StringLength(4000)]
        public string BlanketAgreement { get; set; }

        [StringLength(4000)]
        public string PaymentByWTCertif { get; set; }

        [StringLength(4000)]
        public string Cig { get; set; }

        [StringLength(4000)]
        public string Cup { get; set; }

        [StringLength(4000)]
        public string AttachmentEntry { get; set; }

        [StringLength(4000)]
        public string SignatureInputMessage { get; set; }

        [StringLength(4000)]
        public string SignatureDigest { get; set; }

        [StringLength(4000)]
        public string CertificationNumber { get; set; }

        [StringLength(4000)]
        public string PrivateKeyVersion { get; set; }

        [StringLength(4000)]
        public string EDocExportFormat { get; set; }

        [StringLength(4000)]
        public string ElecCommStatus { get; set; }

        [StringLength(4000)]
        public string ElecCommMessage { get; set; }

        [StringLength(4000)]
        public string SplitVendorCreditRow { get; set; }
    }
}
