namespace Web202209.SAP_RareCoinWholesalers.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessPartner")]
    public partial class BusinessPartner
    {
        [StringLength(400)]
        public string OdataEtag { get; set; }

        [Key]
        [StringLength(400)]
        public string CardCode { get; set; }

        [StringLength(400)]
        public string CardName { get; set; }

        [StringLength(400)]
        public string CardType { get; set; }

        public int? GroupCode { get; set; }

        [StringLength(400)]
        public string Address { get; set; }

        [StringLength(400)]
        public string ZipCode { get; set; }

        [StringLength(400)]
        public string MailAddress { get; set; }

        [StringLength(400)]
        public string MailZipCode { get; set; }

        [StringLength(400)]
        public string Phone1 { get; set; }

        [StringLength(400)]
        public string Phone2 { get; set; }

        [StringLength(400)]
        public string Fax { get; set; }

        [StringLength(400)]
        public string ContactPerson { get; set; }

        [StringLength(400)]
        public string Notes { get; set; }

        public int? PayTermsGrpCode { get; set; }

        public decimal? CreditLimit { get; set; }

        public decimal? MaxCommitment { get; set; }

        public decimal? DiscountPercent { get; set; }

        [StringLength(400)]
        public string VatLiable { get; set; }

        [StringLength(400)]
        public string FederalTaxID { get; set; }

        [StringLength(400)]
        public string DeductibleAtSource { get; set; }

        public decimal? DeductionPercent { get; set; }

        [StringLength(400)]
        public string DeductionValidUntil { get; set; }

        public int? PriceListNum { get; set; }

        public decimal? IntrestRatePercent { get; set; }

        public decimal? CommissionPercent { get; set; }

        public int? CommissionGroupCode { get; set; }

        [StringLength(400)]
        public string FreeText { get; set; }

        public int? SalesPersonCode { get; set; }

        [StringLength(400)]
        public string Currency { get; set; }

        [StringLength(400)]
        public string RateDiffAccount { get; set; }

        [StringLength(400)]
        public string Cellular { get; set; }

        [StringLength(400)]
        public string AvarageLate { get; set; }

        [StringLength(400)]
        public string City { get; set; }

        [StringLength(400)]
        public string County { get; set; }

        [StringLength(400)]
        public string Country { get; set; }

        [StringLength(400)]
        public string MailCity { get; set; }

        [StringLength(400)]
        public string MailCounty { get; set; }

        [StringLength(400)]
        public string MailCountry { get; set; }

        [StringLength(400)]
        public string EmailAddress { get; set; }

        [StringLength(400)]
        public string Picture { get; set; }

        [StringLength(400)]
        public string DefaultAccount { get; set; }

        [StringLength(400)]
        public string DefaultBranch { get; set; }

        [StringLength(400)]
        public string DefaultBankCode { get; set; }

        [StringLength(400)]
        public string AdditionalID { get; set; }

        [StringLength(400)]
        public string Pager { get; set; }

        [StringLength(400)]
        public string FatherCard { get; set; }

        [StringLength(400)]
        public string CardForeignName { get; set; }

        [StringLength(400)]
        public string FatherType { get; set; }

        [StringLength(400)]
        public string DeductionOffice { get; set; }

        [StringLength(400)]
        public string ExportCode { get; set; }

        public decimal? MinIntrest { get; set; }

        public decimal? CurrentAccountBalance { get; set; }

        public decimal? OpenDeliveryNotesBalance { get; set; }

        public decimal? OpenOrdersBalance { get; set; }

        public decimal? OpenChecksBalance { get; set; }

        [StringLength(400)]
        public string VatGroup { get; set; }

        [StringLength(400)]
        public string ShippingType { get; set; }

        [StringLength(400)]
        public string Password { get; set; }

        [StringLength(400)]
        public string Indicator { get; set; }

        [StringLength(400)]
        public string IBAN { get; set; }

        public int? CreditCardCode { get; set; }

        [StringLength(400)]
        public string CreditCardNum { get; set; }

        [StringLength(400)]
        public string CreditCardExpiration { get; set; }

        [StringLength(400)]
        public string DebitorAccount { get; set; }

        [StringLength(400)]
        public string OpenOpportunities { get; set; }

        [StringLength(400)]
        public string Valid { get; set; }

        [StringLength(400)]
        public string ValidFrom { get; set; }

        [StringLength(400)]
        public string ValidTo { get; set; }

        [StringLength(400)]
        public string ValidRemarks { get; set; }

        [StringLength(400)]
        public string Frozen { get; set; }

        [StringLength(400)]
        public string FrozenFrom { get; set; }

        [StringLength(400)]
        public string FrozenTo { get; set; }

        [StringLength(400)]
        public string FrozenRemarks { get; set; }

        [StringLength(400)]
        public string Block { get; set; }

        [StringLength(400)]
        public string BillToState { get; set; }

        [StringLength(400)]
        public string ShipToState { get; set; }

        [StringLength(400)]
        public string ExemptNum { get; set; }

        public int? Priority { get; set; }

        public int? FormCode1099 { get; set; }

        [StringLength(400)]
        public string Box1099 { get; set; }

        [StringLength(400)]
        public string PeymentMethodCode { get; set; }

        [StringLength(400)]
        public string BackOrder { get; set; }

        [StringLength(400)]
        public string PartialDelivery { get; set; }

        [StringLength(400)]
        public string BlockDunning { get; set; }

        [StringLength(400)]
        public string BankCountry { get; set; }

        [StringLength(400)]
        public string HouseBank { get; set; }

        [StringLength(400)]
        public string HouseBankCountry { get; set; }

        [StringLength(400)]
        public string HouseBankAccount { get; set; }

        [StringLength(400)]
        public string ShipToDefault { get; set; }

        [StringLength(400)]
        public string DunningLevel { get; set; }

        public DateTime? DunningDate { get; set; }

        [StringLength(400)]
        public string CollectionAuthorization { get; set; }

        [StringLength(400)]
        public string DME { get; set; }

        [StringLength(400)]
        public string InstructionKey { get; set; }

        [StringLength(400)]
        public string SinglePayment { get; set; }

        [StringLength(400)]
        public string ISRBillerID { get; set; }

        [StringLength(400)]
        public string PaymentBlock { get; set; }

        [StringLength(400)]
        public string ReferenceDetails { get; set; }

        [StringLength(400)]
        public string HouseBankBranch { get; set; }

        [StringLength(400)]
        public string OwnerIDNumber { get; set; }

        public int? PaymentBlockDescription { get; set; }

        [StringLength(400)]
        public string TaxExemptionLetterNum { get; set; }

        public decimal? MaxAmountOfExemption { get; set; }

        public DateTime? ExemptionValidityDateFrom { get; set; }

        public DateTime? ExemptionValidityDateTo { get; set; }

        [StringLength(400)]
        public string LinkedBusinessPartner { get; set; }

        [StringLength(400)]
        public string LastMultiReconciliationNum { get; set; }

        [StringLength(400)]
        public string DeferredTax { get; set; }

        [StringLength(400)]
        public string Equalization { get; set; }

        [StringLength(400)]
        public string SubjectToWithholdingTax { get; set; }

        [StringLength(400)]
        public string CertificateNumber { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [StringLength(400)]
        public string NationalInsuranceNum { get; set; }

        [StringLength(400)]
        public string AccrualCriteria { get; set; }

        [StringLength(400)]
        public string WTCode { get; set; }

        [StringLength(400)]
        public string BillToBuildingFloorRoom { get; set; }

        [StringLength(400)]
        public string DownPaymentClearAct { get; set; }

        [StringLength(400)]
        public string ChannelBP { get; set; }

        [StringLength(400)]
        public string DefaultTechnician { get; set; }

        [StringLength(400)]
        public string BilltoDefault { get; set; }

        [StringLength(400)]
        public string CustomerBillofExchangDisc { get; set; }

        [StringLength(400)]
        public string Territory { get; set; }

        [StringLength(400)]
        public string ShipToBuildingFloorRoom { get; set; }

        [StringLength(400)]
        public string CustomerBillofExchangPres { get; set; }

        [StringLength(400)]
        public string ProjectCode { get; set; }

        [StringLength(400)]
        public string VatGroupLatinAmerica { get; set; }

        [StringLength(400)]
        public string DunningTerm { get; set; }

        [StringLength(400)]
        public string Website { get; set; }

        [StringLength(400)]
        public string OtherReceivablePayable { get; set; }

        [StringLength(400)]
        public string BillofExchangeonCollection { get; set; }

        [StringLength(400)]
        public string CompanyPrivate { get; set; }

        public int? LanguageCode { get; set; }

        [StringLength(400)]
        public string UnpaidBillofExchange { get; set; }

        public int? WithholdingTaxDeductionGroup { get; set; }

        [StringLength(400)]
        public string ClosingDateProcedureNumber { get; set; }

        [StringLength(400)]
        public string Profession { get; set; }

        [StringLength(400)]
        public string BankChargesAllocationCode { get; set; }

        [StringLength(400)]
        public string TaxRoundingRule { get; set; }

        [StringLength(400)]
        public string Properties1 { get; set; }

        [StringLength(400)]
        public string Properties2 { get; set; }

        [StringLength(400)]
        public string Properties3 { get; set; }

        [StringLength(400)]
        public string Properties4 { get; set; }

        [StringLength(400)]
        public string Properties5 { get; set; }

        [StringLength(400)]
        public string Properties6 { get; set; }

        [StringLength(400)]
        public string Properties7 { get; set; }

        [StringLength(400)]
        public string Properties8 { get; set; }

        [StringLength(400)]
        public string Properties9 { get; set; }

        [StringLength(400)]
        public string Properties10 { get; set; }

        [StringLength(400)]
        public string Properties11 { get; set; }

        [StringLength(400)]
        public string Properties12 { get; set; }

        [StringLength(400)]
        public string Properties13 { get; set; }

        [StringLength(400)]
        public string Properties14 { get; set; }

        [StringLength(400)]
        public string Properties15 { get; set; }

        [StringLength(400)]
        public string Properties16 { get; set; }

        [StringLength(400)]
        public string Properties17 { get; set; }

        [StringLength(400)]
        public string Properties18 { get; set; }

        [StringLength(400)]
        public string Properties19 { get; set; }

        [StringLength(400)]
        public string Properties20 { get; set; }

        [StringLength(400)]
        public string Properties21 { get; set; }

        [StringLength(400)]
        public string Properties22 { get; set; }

        [StringLength(400)]
        public string Properties23 { get; set; }

        [StringLength(400)]
        public string Properties24 { get; set; }

        [StringLength(400)]
        public string Properties25 { get; set; }

        [StringLength(400)]
        public string Properties26 { get; set; }

        [StringLength(400)]
        public string Properties27 { get; set; }

        [StringLength(400)]
        public string Properties28 { get; set; }

        [StringLength(400)]
        public string Properties29 { get; set; }

        [StringLength(400)]
        public string Properties30 { get; set; }

        [StringLength(400)]
        public string Properties31 { get; set; }

        [StringLength(400)]
        public string Properties32 { get; set; }

        [StringLength(400)]
        public string Properties33 { get; set; }

        [StringLength(400)]
        public string Properties34 { get; set; }

        [StringLength(400)]
        public string Properties35 { get; set; }

        [StringLength(400)]
        public string Properties36 { get; set; }

        [StringLength(400)]
        public string Properties37 { get; set; }

        [StringLength(400)]
        public string Properties38 { get; set; }

        [StringLength(400)]
        public string Properties39 { get; set; }

        [StringLength(400)]
        public string Properties40 { get; set; }

        [StringLength(400)]
        public string Properties41 { get; set; }

        [StringLength(400)]
        public string Properties42 { get; set; }

        [StringLength(400)]
        public string Properties43 { get; set; }

        [StringLength(400)]
        public string Properties44 { get; set; }

        [StringLength(400)]
        public string Properties45 { get; set; }

        [StringLength(400)]
        public string Properties46 { get; set; }

        [StringLength(400)]
        public string Properties47 { get; set; }

        [StringLength(400)]
        public string Properties48 { get; set; }

        [StringLength(400)]
        public string Properties49 { get; set; }

        [StringLength(400)]
        public string Properties50 { get; set; }

        [StringLength(400)]
        public string Properties51 { get; set; }

        [StringLength(400)]
        public string Properties52 { get; set; }

        [StringLength(400)]
        public string Properties53 { get; set; }

        [StringLength(400)]
        public string Properties54 { get; set; }

        [StringLength(400)]
        public string Properties55 { get; set; }

        [StringLength(400)]
        public string Properties56 { get; set; }

        [StringLength(400)]
        public string Properties57 { get; set; }

        [StringLength(400)]
        public string Properties58 { get; set; }

        [StringLength(400)]
        public string Properties59 { get; set; }

        [StringLength(400)]
        public string Properties60 { get; set; }

        [StringLength(400)]
        public string Properties61 { get; set; }

        [StringLength(400)]
        public string Properties62 { get; set; }

        [StringLength(400)]
        public string Properties63 { get; set; }

        [StringLength(400)]
        public string Properties64 { get; set; }

        [StringLength(400)]
        public string CompanyRegistrationNumber { get; set; }

        [StringLength(400)]
        public string VerificationNumber { get; set; }

        [StringLength(400)]
        public string DiscountBaseObject { get; set; }

        [StringLength(400)]
        public string DiscountRelations { get; set; }

        [StringLength(400)]
        public string TypeReport { get; set; }

        [StringLength(400)]
        public string ThresholdOverlook { get; set; }

        [StringLength(400)]
        public string SurchargeOverlook { get; set; }

        [StringLength(400)]
        public string Remark1 { get; set; }

        [StringLength(400)]
        public string ConCerti { get; set; }

        [StringLength(400)]
        public string DownPaymentInterimAccount { get; set; }

        [StringLength(400)]
        public string OperationCode347 { get; set; }

        [StringLength(400)]
        public string InsuranceOperation347 { get; set; }

        [StringLength(400)]
        public string HierarchicalDeduction { get; set; }

        [StringLength(400)]
        public string ShaamGroup { get; set; }

        [StringLength(400)]
        public string WithholdingTaxCertified { get; set; }

        [StringLength(400)]
        public string BookkeepingCertified { get; set; }

        [StringLength(400)]
        public string PlanningGroup { get; set; }

        [StringLength(400)]
        public string Affiliate { get; set; }

        [StringLength(400)]
        public string Industry { get; set; }

        [StringLength(400)]
        public string VatIDNum { get; set; }

        [StringLength(400)]
        public string DatevAccount { get; set; }

        [StringLength(400)]
        public string DatevFirstDataEntry { get; set; }

        [StringLength(400)]
        public string UseShippedGoodsAccount { get; set; }

        [StringLength(400)]
        public string GTSRegNo { get; set; }

        [StringLength(400)]
        public string GTSBankAccountNo { get; set; }

        [StringLength(400)]
        public string GTSBillingAddrTel { get; set; }

        [StringLength(400)]
        public string ETaxWebSite { get; set; }

        [StringLength(400)]
        public string HouseBankIBAN { get; set; }

        [StringLength(400)]
        public string VATRegistrationNumber { get; set; }

        [StringLength(400)]
        public string RepresentativeName { get; set; }

        [StringLength(400)]
        public string IndustryType { get; set; }

        [StringLength(400)]
        public string BusinessType { get; set; }

        public int? Series { get; set; }

        [StringLength(400)]
        public string AutomaticPosting { get; set; }

        [StringLength(400)]
        public string InterestAccount { get; set; }

        [StringLength(400)]
        public string FeeAccount { get; set; }

        [StringLength(400)]
        public string CampaignNumber { get; set; }

        [StringLength(400)]
        public string AliasName { get; set; }

        [StringLength(400)]
        public string DefaultBlanketAgreementNumber { get; set; }

        [StringLength(400)]
        public string EffectiveDiscount { get; set; }

        [StringLength(400)]
        public string NoDiscounts { get; set; }

        [StringLength(400)]
        public string EffectivePrice { get; set; }

        [StringLength(400)]
        public string EffectivePriceConsidersPriceBeforeDiscount { get; set; }

        [StringLength(400)]
        public string GlobalLocationNumber { get; set; }

        [StringLength(400)]
        public string EDISenderID { get; set; }

        [StringLength(400)]
        public string EDIRecipientID { get; set; }

        [StringLength(400)]
        public string ResidenNumber { get; set; }

        [StringLength(400)]
        public string RelationshipCode { get; set; }

        public DateTime? RelationshipDateFrom { get; set; }

        public DateTime? RelationshipDateTill { get; set; }

        [StringLength(400)]
        public string UnifiedFederalTaxID { get; set; }

        [StringLength(400)]
        public string AttachmentEntry { get; set; }

        [StringLength(400)]
        public string TypeOfOperation { get; set; }

        [StringLength(400)]
        public string EndorsableChecksFromBP { get; set; }

        [StringLength(400)]
        public string AcceptsEndorsedChecks { get; set; }

        [StringLength(400)]
        public string OwnerCode { get; set; }

        [StringLength(400)]
        public string BlockSendingMarketingContent { get; set; }

        [StringLength(400)]
        public string AgentCode { get; set; }

        [StringLength(400)]
        public string PriceMode { get; set; }

        [StringLength(400)]
        public string EDocGenerationType { get; set; }

        [StringLength(400)]
        public string EDocStreet { get; set; }

        [StringLength(400)]
        public string EDocStreetNumber { get; set; }

        [StringLength(400)]
        public string EDocBuildingNumber { get; set; }

        [StringLength(400)]
        public string EDocZipCode { get; set; }

        [StringLength(400)]
        public string EDocCity { get; set; }

        [StringLength(400)]
        public string EDocCountry { get; set; }

        [StringLength(400)]
        public string EDocDistrict { get; set; }

        [StringLength(400)]
        public string EDocRepresentativeFirstName { get; set; }

        [StringLength(400)]
        public string EDocRepresentativeSurname { get; set; }

        [StringLength(400)]
        public string EDocRepresentativeCompany { get; set; }

        [StringLength(400)]
        public string EDocRepresentativeFiscalCode { get; set; }

        [StringLength(400)]
        public string EDocRepresentativeAdditionalId { get; set; }

        [StringLength(400)]
        public string EDocPECAddress { get; set; }

        [StringLength(400)]
        public string IPACodeForPA { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(400)]
        public string UpdateTime { get; set; }

        [StringLength(400)]
        public string ExemptionMaxAmountValidationType { get; set; }

        [StringLength(400)]
        public string ECommerceMerchantID { get; set; }

        [StringLength(400)]
        public string UseBillToAddrToDetermineTax { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(400)]
        public string CreateTime { get; set; }

        [StringLength(400)]
        public string DefaultTransporterEntry { get; set; }

        [StringLength(400)]
        public string DefaultTransporterLineNumber { get; set; }

        [StringLength(400)]
        public string FCERelevant { get; set; }

        [StringLength(400)]
        public string FCEValidateBaseDelivery { get; set; }

        [StringLength(400)]
        public string MainUsage { get; set; }

        [StringLength(400)]
        public string EBooksVATExemptionCause { get; set; }

        [StringLength(400)]
        public string LegalText { get; set; }

        public int? DataVersion { get; set; }

        [StringLength(400)]
        public string ExchangeRateForIncomingPayment { get; set; }

        [StringLength(400)]
        public string ExchangeRateForOutgoingPayment { get; set; }

        [StringLength(400)]
        public string CertificateDetails { get; set; }

        [StringLength(400)]
        public string DefaultCurrency { get; set; }

        [StringLength(400)]
        public string EORINumber { get; set; }

        [StringLength(400)]
        public string FCEAsPaymentMeans { get; set; }

        [StringLength(400)]
        public string NotRelevantForMonthlyInvoice { get; set; }
    }
}
