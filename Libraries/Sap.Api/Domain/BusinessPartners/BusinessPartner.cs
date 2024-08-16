using Newtonsoft.Json;
using System.Collections.Generic;
using Sap.Core;

namespace Sap.Api.Domain.BusinessPartners
{
	public partial class BusinessPartner : BaseEntity
	{
		#region Fields
		[JsonProperty("odata.etag")]
		public string OdataEtag;

		[JsonProperty("CardCode")]
		public string CardCode;

		[JsonProperty("CardName")]
		public string CardName;

		[JsonProperty("CardType")]
		public string CardType;

		[JsonProperty("GroupCode")]
		public string GroupCode;

		[JsonProperty("Address")]
		public string Address;

		[JsonProperty("ZipCode")]
		public string ZipCode;

		[JsonProperty("MailAddress")]
		public string MailAddress;

		[JsonProperty("MailZipCode")]
		public string MailZipCode;

		[JsonProperty("Phone1")]
		public string Phone1;

		[JsonProperty("Phone2")]
		public string Phone2;

		[JsonProperty("Fax")]
		public string Fax;

		[JsonProperty("ContactPerson")]
		public string ContactPerson;

		[JsonProperty("Notes")]
		public string Notes;

		[JsonProperty("PayTermsGrpCode")]
		public string PayTermsGrpCode;

		[JsonProperty("CreditLimit")]
		public string CreditLimit;

		[JsonProperty("MaxCommitment")]
		public string MaxCommitment;

		[JsonProperty("DiscountPercent")]
		public string DiscountPercent;

		[JsonProperty("VatLiable")]
		public string VatLiable;

		[JsonProperty("FederalTaxID")]
		public string FederalTaxID;

		[JsonProperty("DeductibleAtSource")]
		public string DeductibleAtSource;

		[JsonProperty("DeductionPercent")]
		public string DeductionPercent;

		[JsonProperty("DeductionValidUntil")]
		public string DeductionValidUntil;

		[JsonProperty("PriceListNum")]
		public string PriceListNum;

		[JsonProperty("IntrestRatePercent")]
		public string IntrestRatePercent;

		[JsonProperty("CommissionPercent")]
		public string CommissionPercent;

		[JsonProperty("CommissionGroupCode")]
		public string CommissionGroupCode;

		[JsonProperty("FreeText")]
		public string FreeText;

		[JsonProperty("SalesPersonCode")]
		public string SalesPersonCode;

		[JsonProperty("Currency")]
		public string Currency;

		[JsonProperty("RateDiffAccount")]
		public string RateDiffAccount;

		[JsonProperty("Cellular")]
		public string Cellular;

		[JsonProperty("AvarageLate")]
		public string AvarageLate;

		[JsonProperty("City")]
		public string City;

		[JsonProperty("County")]
		public string County;

		[JsonProperty("Country")]
		public string Country;

		[JsonProperty("MailCity")]
		public string MailCity;

		[JsonProperty("MailCounty")]
		public string MailCounty;

		[JsonProperty("MailCountry")]
		public string MailCountry;

		[JsonProperty("EmailAddress")]
		public string EmailAddress;

		[JsonProperty("Picture")]
		public string Picture;

		[JsonProperty("DefaultAccount")]
		public string DefaultAccount;

		[JsonProperty("DefaultBranch")]
		public string DefaultBranch;

		[JsonProperty("DefaultBankCode")]
		public string DefaultBankCode;

		[JsonProperty("AdditionalID")]
		public string AdditionalID;

		[JsonProperty("Pager")]
		public string Pager;

		[JsonProperty("FatherCard")]
		public string FatherCard;

		[JsonProperty("CardForeignName")]
		public string CardForeignName;

		[JsonProperty("FatherType")]
		public string FatherType;

		[JsonProperty("DeductionOffice")]
		public string DeductionOffice;

		[JsonProperty("ExportCode")]
		public string ExportCode;

		[JsonProperty("MinIntrest")]
		public string MinIntrest;

		[JsonProperty("CurrentAccountBalance")]
		public string CurrentAccountBalance;

		[JsonProperty("OpenDeliveryNotesBalance")]
		public string OpenDeliveryNotesBalance;

		[JsonProperty("OpenOrdersBalance")]
		public string OpenOrdersBalance;

		[JsonProperty("OpenChecksBalance")]
		public string OpenChecksBalance;

		[JsonProperty("VatGroup")]
		public string VatGroup;

		[JsonProperty("ShippingType")]
		public string ShippingType;

		[JsonProperty("Password")]
		public string Password;

		[JsonProperty("Indicator")]
		public string Indicator;

		[JsonProperty("IBAN")]
		public string IBAN;

		[JsonProperty("CreditCardCode")]
		public string CreditCardCode;

		[JsonProperty("CreditCardNum")]
		public string CreditCardNum;

		[JsonProperty("CreditCardExpiration")]
		public string CreditCardExpiration;

		[JsonProperty("DebitorAccount")]
		public string DebitorAccount;

		[JsonProperty("OpenOpportunities")]
		public string OpenOpportunities;

		[JsonProperty("Valid")]
		public string Valid;

		[JsonProperty("ValidFrom")]
		public string ValidFrom;

		[JsonProperty("ValidTo")]
		public string ValidTo;

		[JsonProperty("ValidRemarks")]
		public string ValidRemarks;

		[JsonProperty("Frozen")]
		public string Frozen;

		[JsonProperty("FrozenFrom")]
		public string FrozenFrom;

		[JsonProperty("FrozenTo")]
		public string FrozenTo;

		[JsonProperty("FrozenRemarks")]
		public string FrozenRemarks;

		[JsonProperty("Block")]
		public string Block;

		[JsonProperty("BillToState")]
		public string BillToState;

		[JsonProperty("ShipToState")]
		public string ShipToState;

		[JsonProperty("ExemptNum")]
		public string ExemptNum;

		[JsonProperty("Priority")]
		public string Priority;

		[JsonProperty("FormCode1099")]
		public string FormCode1099;

		[JsonProperty("Box1099")]
		public string Box1099;

		[JsonProperty("PeymentMethodCode")]
		public string PeymentMethodCode;

		[JsonProperty("BackOrder")]
		public string BackOrder;

		[JsonProperty("PartialDelivery")]
		public string PartialDelivery;

		[JsonProperty("BlockDunning")]
		public string BlockDunning;

		[JsonProperty("BankCountry")]
		public string BankCountry;

		[JsonProperty("HouseBank")]
		public string HouseBank;

		[JsonProperty("HouseBankCountry")]
		public string HouseBankCountry;

		[JsonProperty("HouseBankAccount")]
		public string HouseBankAccount;

		[JsonProperty("ShipToDefault")]
		public string ShipToDefault;

		[JsonProperty("DunningLevel")]
		public string DunningLevel;

		[JsonProperty("DunningDate")]
		public string DunningDate;

		[JsonProperty("CollectionAuthorization")]
		public string CollectionAuthorization;

		[JsonProperty("DME")]
		public string DME;

		[JsonProperty("InstructionKey")]
		public string InstructionKey;

		[JsonProperty("SinglePayment")]
		public string SinglePayment;

		[JsonProperty("ISRBillerID")]
		public string ISRBillerID;

		[JsonProperty("PaymentBlock")]
		public string PaymentBlock;

		[JsonProperty("ReferenceDetails")]
		public string ReferenceDetails;

		[JsonProperty("HouseBankBranch")]
		public string HouseBankBranch;

		[JsonProperty("OwnerIDNumber")]
		public string OwnerIDNumber;

		[JsonProperty("PaymentBlockDescription")]
		public string PaymentBlockDescription;

		[JsonProperty("TaxExemptionLetterNum")]
		public string TaxExemptionLetterNum;

		[JsonProperty("MaxAmountOfExemption")]
		public string MaxAmountOfExemption;

		[JsonProperty("ExemptionValidityDateFrom")]
		public string ExemptionValidityDateFrom;

		[JsonProperty("ExemptionValidityDateTo")]
		public string ExemptionValidityDateTo;

		[JsonProperty("LinkedBusinessPartner")]
		public string LinkedBusinessPartner;

		[JsonProperty("LastMultiReconciliationNum")]
		public string LastMultiReconciliationNum;

		[JsonProperty("DeferredTax")]
		public string DeferredTax;

		[JsonProperty("Equalization")]
		public string Equalization;

		[JsonProperty("SubjectToWithholdingTax")]
		public string SubjectToWithholdingTax;

		[JsonProperty("CertificateNumber")]
		public string CertificateNumber;

		[JsonProperty("ExpirationDate")]
		public string ExpirationDate;

		[JsonProperty("NationalInsuranceNum")]
		public string NationalInsuranceNum;

		[JsonProperty("AccrualCriteria")]
		public string AccrualCriteria;

		[JsonProperty("WTCode")]
		public string WTCode;

		[JsonProperty("BillToBuildingFloorRoom")]
		public string BillToBuildingFloorRoom;

		[JsonProperty("DownPaymentClearAct")]
		public string DownPaymentClearAct;

		[JsonProperty("ChannelBP")]
		public string ChannelBP;

		[JsonProperty("DefaultTechnician")]
		public string DefaultTechnician;

		[JsonProperty("BilltoDefault")]
		public string BilltoDefault;

		[JsonProperty("CustomerBillofExchangDisc")]
		public string CustomerBillofExchangDisc;

		[JsonProperty("Territory")]
		public string Territory;

		[JsonProperty("ShipToBuildingFloorRoom")]
		public string ShipToBuildingFloorRoom;

		[JsonProperty("CustomerBillofExchangPres")]
		public string CustomerBillofExchangPres;

		[JsonProperty("ProjectCode")]
		public string ProjectCode;

		[JsonProperty("VatGroupLatinAmerica")]
		public string VatGroupLatinAmerica;

		[JsonProperty("DunningTerm")]
		public string DunningTerm;

		[JsonProperty("Website")]
		public string Website;

		[JsonProperty("OtherReceivablePayable")]
		public string OtherReceivablePayable;

		[JsonProperty("BillofExchangeonCollection")]
		public string BillofExchangeonCollection;

		[JsonProperty("CompanyPrivate")]
		public string CompanyPrivate;

		[JsonProperty("LanguageCode")]
		public string LanguageCode;

		[JsonProperty("UnpaidBillofExchange")]
		public string UnpaidBillofExchange;

		[JsonProperty("WithholdingTaxDeductionGroup")]
		public string WithholdingTaxDeductionGroup;

		[JsonProperty("ClosingDateProcedureNumber")]
		public string ClosingDateProcedureNumber;

		[JsonProperty("Profession")]
		public string Profession;

		[JsonProperty("BankChargesAllocationCode")]
		public string BankChargesAllocationCode;

		[JsonProperty("TaxRoundingRule")]
		public string TaxRoundingRule;

		[JsonProperty("Properties1")]
		public string Properties1;

		[JsonProperty("Properties2")]
		public string Properties2;

		[JsonProperty("Properties3")]
		public string Properties3;

		[JsonProperty("Properties4")]
		public string Properties4;

		[JsonProperty("Properties5")]
		public string Properties5;

		[JsonProperty("Properties6")]
		public string Properties6;

		[JsonProperty("Properties7")]
		public string Properties7;

		[JsonProperty("Properties8")]
		public string Properties8;

		[JsonProperty("Properties9")]
		public string Properties9;

		[JsonProperty("Properties10")]
		public string Properties10;

		[JsonProperty("Properties11")]
		public string Properties11;

		[JsonProperty("Properties12")]
		public string Properties12;

		[JsonProperty("Properties13")]
		public string Properties13;

		[JsonProperty("Properties14")]
		public string Properties14;

		[JsonProperty("Properties15")]
		public string Properties15;

		[JsonProperty("Properties16")]
		public string Properties16;

		[JsonProperty("Properties17")]
		public string Properties17;

		[JsonProperty("Properties18")]
		public string Properties18;

		[JsonProperty("Properties19")]
		public string Properties19;

		[JsonProperty("Properties20")]
		public string Properties20;

		[JsonProperty("Properties21")]
		public string Properties21;

		[JsonProperty("Properties22")]
		public string Properties22;

		[JsonProperty("Properties23")]
		public string Properties23;

		[JsonProperty("Properties24")]
		public string Properties24;

		[JsonProperty("Properties25")]
		public string Properties25;

		[JsonProperty("Properties26")]
		public string Properties26;

		[JsonProperty("Properties27")]
		public string Properties27;

		[JsonProperty("Properties28")]
		public string Properties28;

		[JsonProperty("Properties29")]
		public string Properties29;

		[JsonProperty("Properties30")]
		public string Properties30;

		[JsonProperty("Properties31")]
		public string Properties31;

		[JsonProperty("Properties32")]
		public string Properties32;

		[JsonProperty("Properties33")]
		public string Properties33;

		[JsonProperty("Properties34")]
		public string Properties34;

		[JsonProperty("Properties35")]
		public string Properties35;

		[JsonProperty("Properties36")]
		public string Properties36;

		[JsonProperty("Properties37")]
		public string Properties37;

		[JsonProperty("Properties38")]
		public string Properties38;

		[JsonProperty("Properties39")]
		public string Properties39;

		[JsonProperty("Properties40")]
		public string Properties40;

		[JsonProperty("Properties41")]
		public string Properties41;

		[JsonProperty("Properties42")]
		public string Properties42;

		[JsonProperty("Properties43")]
		public string Properties43;

		[JsonProperty("Properties44")]
		public string Properties44;

		[JsonProperty("Properties45")]
		public string Properties45;

		[JsonProperty("Properties46")]
		public string Properties46;

		[JsonProperty("Properties47")]
		public string Properties47;

		[JsonProperty("Properties48")]
		public string Properties48;

		[JsonProperty("Properties49")]
		public string Properties49;

		[JsonProperty("Properties50")]
		public string Properties50;

		[JsonProperty("Properties51")]
		public string Properties51;

		[JsonProperty("Properties52")]
		public string Properties52;

		[JsonProperty("Properties53")]
		public string Properties53;

		[JsonProperty("Properties54")]
		public string Properties54;

		[JsonProperty("Properties55")]
		public string Properties55;

		[JsonProperty("Properties56")]
		public string Properties56;

		[JsonProperty("Properties57")]
		public string Properties57;

		[JsonProperty("Properties58")]
		public string Properties58;

		[JsonProperty("Properties59")]
		public string Properties59;

		[JsonProperty("Properties60")]
		public string Properties60;

		[JsonProperty("Properties61")]
		public string Properties61;

		[JsonProperty("Properties62")]
		public string Properties62;

		[JsonProperty("Properties63")]
		public string Properties63;

		[JsonProperty("Properties64")]
		public string Properties64;

		[JsonProperty("CompanyRegistrationNumber")]
		public string CompanyRegistrationNumber;

		[JsonProperty("VerificationNumber")]
		public string VerificationNumber;

		[JsonProperty("DiscountBaseObject")]
		public string DiscountBaseObject;

		[JsonProperty("DiscountRelations")]
		public string DiscountRelations;

		[JsonProperty("TypeReport")]
		public string TypeReport;

		[JsonProperty("ThresholdOverlook")]
		public string ThresholdOverlook;

		[JsonProperty("SurchargeOverlook")]
		public string SurchargeOverlook;

		[JsonProperty("Remark1")]
		public string Remark1;

		[JsonProperty("ConCerti")]
		public string ConCerti;

		[JsonProperty("DownPaymentInterimAccount")]
		public string DownPaymentInterimAccount;

		[JsonProperty("OperationCode347")]
		public string OperationCode347;

		[JsonProperty("InsuranceOperation347")]
		public string InsuranceOperation347;

		[JsonProperty("HierarchicalDeduction")]
		public string HierarchicalDeduction;

		[JsonProperty("ShaamGroup")]
		public string ShaamGroup;

		[JsonProperty("WithholdingTaxCertified")]
		public string WithholdingTaxCertified;

		[JsonProperty("BookkeepingCertified")]
		public string BookkeepingCertified;

		[JsonProperty("PlanningGroup")]
		public string PlanningGroup;

		[JsonProperty("Affiliate")]
		public string Affiliate;

		[JsonProperty("Industry")]
		public string Industry;

		[JsonProperty("VatIDNum")]
		public string VatIDNum;

		[JsonProperty("DatevAccount")]
		public string DatevAccount;

		[JsonProperty("DatevFirstDataEntry")]
		public string DatevFirstDataEntry;

		[JsonProperty("UseShippedGoodsAccount")]
		public string UseShippedGoodsAccount;

		[JsonProperty("GTSRegNo")]
		public string GTSRegNo;

		[JsonProperty("GTSBankAccountNo")]
		public string GTSBankAccountNo;

		[JsonProperty("GTSBillingAddrTel")]
		public string GTSBillingAddrTel;

		[JsonProperty("ETaxWebSite")]
		public string ETaxWebSite;

		[JsonProperty("HouseBankIBAN")]
		public string HouseBankIBAN;

		[JsonProperty("VATRegistrationNumber")]
		public string VATRegistrationNumber;

		[JsonProperty("RepresentativeName")]
		public string RepresentativeName;

		[JsonProperty("IndustryType")]
		public string IndustryType;

		[JsonProperty("BusinessType")]
		public string BusinessType;

		[JsonProperty("Series")]
		public string Series;

		[JsonProperty("AutomaticPosting")]
		public string AutomaticPosting;

		[JsonProperty("InterestAccount")]
		public string InterestAccount;

		[JsonProperty("FeeAccount")]
		public string FeeAccount;

		[JsonProperty("CampaignNumber")]
		public string CampaignNumber;

		[JsonProperty("AliasName")]
		public string AliasName;

		[JsonProperty("DefaultBlanketAgreementNumber")]
		public string DefaultBlanketAgreementNumber;

		[JsonProperty("EffectiveDiscount")]
		public string EffectiveDiscount;

		[JsonProperty("NoDiscounts")]
		public string NoDiscounts;

		[JsonProperty("EffectivePrice")]
		public string EffectivePrice;

		[JsonProperty("EffectivePriceConsidersPriceBeforeDiscount")]
		public string EffectivePriceConsidersPriceBeforeDiscount;

		[JsonProperty("GlobalLocationNumber")]
		public string GlobalLocationNumber;

		[JsonProperty("EDISenderID")]
		public string EDISenderID;

		[JsonProperty("EDIRecipientID")]
		public string EDIRecipientID;

		[JsonProperty("ResidenNumber")]
		public string ResidenNumber;

		[JsonProperty("RelationshipCode")]
		public string RelationshipCode;

		[JsonProperty("RelationshipDateFrom")]
		public string RelationshipDateFrom;

		[JsonProperty("RelationshipDateTill")]
		public string RelationshipDateTill;

		[JsonProperty("UnifiedFederalTaxID")]
		public string UnifiedFederalTaxID;

		[JsonProperty("AttachmentEntry")]
		public string AttachmentEntry;

		[JsonProperty("TypeOfOperation")]
		public string TypeOfOperation;

		[JsonProperty("EndorsableChecksFromBP")]
		public string EndorsableChecksFromBP;

		[JsonProperty("AcceptsEndorsedChecks")]
		public string AcceptsEndorsedChecks;

		[JsonProperty("OwnerCode")]
		public string OwnerCode;

		[JsonProperty("BlockSendingMarketingContent")]
		public string BlockSendingMarketingContent;

		[JsonProperty("AgentCode")]
		public string AgentCode;

		[JsonProperty("PriceMode")]
		public string PriceMode;

		[JsonProperty("EDocGenerationType")]
		public string EDocGenerationType;

		[JsonProperty("EDocStreet")]
		public string EDocStreet;

		[JsonProperty("EDocStreetNumber")]
		public string EDocStreetNumber;

		[JsonProperty("EDocBuildingNumber")]
		public string EDocBuildingNumber;

		[JsonProperty("EDocZipCode")]
		public string EDocZipCode;

		[JsonProperty("EDocCity")]
		public string EDocCity;

		[JsonProperty("EDocCountry")]
		public string EDocCountry;

		[JsonProperty("EDocDistrict")]
		public string EDocDistrict;

		[JsonProperty("EDocRepresentativeFirstName")]
		public string EDocRepresentativeFirstName;

		[JsonProperty("EDocRepresentativeSurname")]
		public string EDocRepresentativeSurname;

		[JsonProperty("EDocRepresentativeCompany")]
		public string EDocRepresentativeCompany;

		[JsonProperty("EDocRepresentativeFiscalCode")]
		public string EDocRepresentativeFiscalCode;

		[JsonProperty("EDocRepresentativeAdditionalId")]
		public string EDocRepresentativeAdditionalId;

		[JsonProperty("EDocPECAddress")]
		public string EDocPECAddress;

		[JsonProperty("IPACodeForPA")]
		public string IPACodeForPA;

		[JsonProperty("UpdateDate")]
		public string UpdateDate;

		[JsonProperty("UpdateTime")]
		public string UpdateTime;

		[JsonProperty("ExemptionMaxAmountValidationType")]
		public string ExemptionMaxAmountValidationType;

		[JsonProperty("ECommerceMerchantID")]
		public string ECommerceMerchantID;

		[JsonProperty("UseBillToAddrToDetermineTax")]
		public string UseBillToAddrToDetermineTax;

		[JsonProperty("CreateDate")]
		public string CreateDate;

		[JsonProperty("CreateTime")]
		public string CreateTime;

		[JsonProperty("DefaultTransporterEntry")]
		public string DefaultTransporterEntry;

		[JsonProperty("DefaultTransporterLineNumber")]
		public string DefaultTransporterLineNumber;

		[JsonProperty("FCERelevant")]
		public string FCERelevant;

		[JsonProperty("FCEValidateBaseDelivery")]
		public string FCEValidateBaseDelivery;

		[JsonProperty("MainUsage")]
		public string MainUsage;

		[JsonProperty("EBooksVATExemptionCause")]
		public string EBooksVATExemptionCause;

		[JsonProperty("LegalText")]
		public string LegalText;

		[JsonProperty("DataVersion")]
		public string DataVersion;

		[JsonProperty("ExchangeRateForIncomingPayment")]
		public string ExchangeRateForIncomingPayment;

		[JsonProperty("ExchangeRateForOutgoingPayment")]
		public string ExchangeRateForOutgoingPayment;

		[JsonProperty("CertificateDetails")]
		public string CertificateDetails;

		[JsonProperty("DefaultCurrency")]
		public string DefaultCurrency;

		[JsonProperty("EORINumber")]
		public string EORINumber;

		[JsonProperty("FCEAsPaymentMeans")]
		public string FCEAsPaymentMeans;

		[JsonProperty("NotRelevantForMonthlyInvoice")]
		public string NotRelevantForMonthlyInvoice;

		[JsonProperty("ElectronicProtocols")]
		public IList<object> ElectronicProtocols;

		[JsonProperty("BPAddresses")]
		public IList<BPAddress> BPAddresses;

		[JsonProperty("ContactEmployees")]
		public IList<ContactEmployee> ContactEmployees;

		[JsonProperty("BPAccountReceivablePaybleCollection")]
		public IList<object> BPAccountReceivablePaybleCollection;

		[JsonProperty("BPPaymentMethods")]
		public IList<BPPaymentMethod> BPPaymentMethods;

		[JsonProperty("BPWithholdingTaxCollection")]
		public IList<object> BPWithholdingTaxCollection;

		[JsonProperty("BPPaymentDates")]
		public IList<object> BPPaymentDates;

		[JsonProperty("BPBranchAssignment")]
		public IList<object> BPBranchAssignment;

		[JsonProperty("BPBankAccounts")]
		public IList<object> BPBankAccounts;

		[JsonProperty("BPFiscalTaxIDCollection")]
		public IList<object> BPFiscalTaxIDCollection;

		[JsonProperty("DiscountGroups")]
		public IList<object> DiscountGroups;

		[JsonProperty("BPIntrastatExtension")]
		public BPIntrastatExtension BPIntrastatExtension;

		[JsonProperty("BPBlockSendingMarketingContents")]
		public IList<object> BPBlockSendingMarketingContents;

		[JsonProperty("BPCurrenciesCollection")]
		public IList<object> BPCurrenciesCollection;
		#endregion

		public BusinessPartner()
		{
			BPIntrastatExtension = new BPIntrastatExtension();
			BPAddresses = new List<BPAddress>();
			BPPaymentMethods = new List<BPPaymentMethod>();
			ContactEmployees = new List<ContactEmployee>();
			BPAccountReceivablePaybleCollection = new List<object>();
			BPBankAccounts = new List<object>();
			BPBlockSendingMarketingContents = new List<object>();
			BPBranchAssignment = new List<object>();
			BPCurrenciesCollection = new List<object>();
			BPFiscalTaxIDCollection = new List<object>();
			BPPaymentDates = new List<object>();
			BPWithholdingTaxCollection = new List<object>();
			DiscountGroups = new List<object>();
			ElectronicProtocols = new List<object>();
		}
	}
}