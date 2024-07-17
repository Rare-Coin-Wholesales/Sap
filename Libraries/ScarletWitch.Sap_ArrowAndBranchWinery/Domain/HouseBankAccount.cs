namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("HouseBankAccount")]
    public partial class HouseBankAccount
    {
        public int Id { get; set; }

        public int? AbsoluteEntry { get; set; }

        public int? BankKey { get; set; }

        public int? IncomingPaymentSeries { get; set; }

        public int? ISRType { get; set; }

        public int? JournalEntrySeries { get; set; }

        public int? OutgoingPaymentSeries { get; set; }

        public decimal? DiscountLimit { get; set; }

        public decimal? MaxAmountofBillofExchan { get; set; }

        public decimal? MinAmountofBillofExchang { get; set; }

        [StringLength(255)]
        public string AccNo { get; set; }

        [StringLength(255)]
        public string AccountCheckDigit { get; set; }

        [StringLength(255)]
        public string AccountName { get; set; }

        [StringLength(255)]
        public string AddressType { get; set; }

        [StringLength(255)]
        public string AgreementNumber { get; set; }

        [StringLength(255)]
        public string BankCode { get; set; }

        [StringLength(255)]
        public string BankonCollection { get; set; }

        [StringLength(255)]
        public string BankonDiscounted { get; set; }

        [StringLength(255)]
        public string BICSwiftCode { get; set; }

        [StringLength(255)]
        public string BISR { get; set; }

        [StringLength(255)]
        public string Block { get; set; }

        [StringLength(255)]
        public string Branch { get; set; }

        [StringLength(255)]
        public string BranchCheckDigit { get; set; }

        [StringLength(255)]
        public string Building { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(255)]
        public string CollectionCode { get; set; }

        [StringLength(255)]
        public string ControlKey { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        [StringLength(255)]
        public string County { get; set; }

        [StringLength(255)]
        public string CustomerIdNumber { get; set; }

        [StringLength(255)]
        public string DaysInAdvance { get; set; }

        [StringLength(255)]
        public string DebtofDiscountedBillofExc { get; set; }

        [StringLength(255)]
        public string DiscountAccount { get; set; }

        [StringLength(255)]
        public string DSC1STREETALIAS { get; set; }

        [StringLength(255)]
        public string ECheck { get; set; }

        [StringLength(255)]
        public string FileSeqNextNumber { get; set; }

        [StringLength(255)]
        public string FineAccount { get; set; }

        [StringLength(255)]
        public string GLAccount { get; set; }

        [StringLength(255)]
        public string GLInterimAccount { get; set; }

        [StringLength(255)]
        public string IBAN { get; set; }

        [StringLength(255)]
        public string ImportFileName { get; set; }

        [StringLength(255)]
        public string InterestAccount { get; set; }

        [StringLength(255)]
        public string IOFTaxAccount { get; set; }

        [StringLength(255)]
        public string ISRBillerID { get; set; }

        [StringLength(255)]
        public string LockChecksPrinting { get; set; }

        [StringLength(255)]
        public string MaximumLines { get; set; }

        [StringLength(255)]
        public string NextCheckNo { get; set; }

        [StringLength(255)]
        public string NoValidationForStartingEndingBal { get; set; }

        [StringLength(255)]
        public string OtherExpensesAccount { get; set; }

        [StringLength(255)]
        public string OtherIncomesAccount { get; set; }

        [StringLength(255)]
        public string OurNumber { get; set; }

        [StringLength(255)]
        public string PrintOn { get; set; }

        [StringLength(255)]
        public string RetornoFileName { get; set; }

        [StringLength(255)]
        public string ServiceFeeAccount { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string StreetNo { get; set; }

        [StringLength(255)]
        public string TemplateName { get; set; }

        [StringLength(255)]
        public string ToleranceDays { get; set; }

        [StringLength(255)]
        public string UserNo1 { get; set; }

        [StringLength(255)]
        public string UserNo2 { get; set; }

        [StringLength(255)]
        public string UserNo3 { get; set; }

        [StringLength(255)]
        public string UserNo4 { get; set; }

        [StringLength(255)]
        public string ZipCode { get; set; }
    }
}
