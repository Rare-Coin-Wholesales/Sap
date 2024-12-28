namespace Web202209.SAP_RareCoinWholesalers.Domain
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class SAP_RareCoinWholesalersDb : DbContext
	{
		public virtual DbSet<AccountCategory> AccountCategories { get; set; }
		public virtual DbSet<AccountSegmentation> AccountSegmentations { get; set; }
		public virtual DbSet<AccountSegmentationCategory> AccountSegmentationCategories { get; set; }
		public virtual DbSet<AddressExtension> AddressExtensions { get; set; }
		public virtual DbSet<BillOfExchange> BillOfExchanges { get; set; }
		public virtual DbSet<BillOfExchangeTransaction> BillOfExchangeTransactions { get; set; }
		public virtual DbSet<BPAddress> BPAddresses { get; set; }
		public virtual DbSet<BPIntrastatExtension> BPIntrastatExtensions { get; set; }
		public virtual DbSet<BPPaymentMethod> BPPaymentMethods { get; set; }
		public virtual DbSet<BusinessPartner> BusinessPartners { get; set; }
		public virtual DbSet<CashFlowAssignment> CashFlowAssignments { get; set; }
		public virtual DbSet<ChartOfAccount> ChartOfAccounts { get; set; }
		public virtual DbSet<ChecksforPayment> ChecksforPayments { get; set; }
		public virtual DbSet<ChecksforPaymentLine> ChecksforPaymentLines { get; set; }
		public virtual DbSet<ContactEmployee> ContactEmployees { get; set; }
		public virtual DbSet<CreditLine> CreditLines { get; set; }
		public virtual DbSet<CreditNote> CreditNotes { get; set; }
		public virtual DbSet<CreditNote_DocumentLine> CreditNote_DocumentLine { get; set; }
		public virtual DbSet<Deposit> Deposits { get; set; }
		public virtual DbSet<Deposit_CheckLine> Deposit_CheckLine { get; set; }
		public virtual DbSet<DocumentInstallment> DocumentInstallments { get; set; }
		public virtual DbSet<DocumentLine> DocumentLines { get; set; }
		public virtual DbSet<DownPaymentsToDraw> DownPaymentsToDraws { get; set; }
		public virtual DbSet<DownPaymentsToDrawDetail> DownPaymentsToDrawDetails { get; set; }
		public virtual DbSet<EWayBillDetail> EWayBillDetails { get; set; }
		public virtual DbSet<FAAccountDetermination> FAAccountDeterminations { get; set; }
		public virtual DbSet<GLAccountAdvancedRule> GLAccountAdvancedRules { get; set; }
		public virtual DbSet<HouseBankAccount> HouseBankAccounts { get; set; }
		public virtual DbSet<IncomingPayment> IncomingPayments { get; set; }
		public virtual DbSet<IncomingPayment_PaymentCheck> IncomingPayment_PaymentCheck { get; set; }
		public virtual DbSet<IncomingPayment_PaymentInvoice> IncomingPayment_PaymentInvoice { get; set; }
		public virtual DbSet<Invoice> Invoices { get; set; }
		public virtual DbSet<Invoice_DocumentLine> Invoice_DocumentLine { get; set; }
		public virtual DbSet<Item> Items { get; set; }
		public virtual DbSet<JournalEntry> JournalEntries { get; set; }
		public virtual DbSet<JournalEntryDocumentType> JournalEntryDocumentTypes { get; set; }
		public virtual DbSet<JournalEntryLine> JournalEntryLines { get; set; }
		public virtual DbSet<LineTaxJurisdiction> LineTaxJurisdictions { get; set; }
		public virtual DbSet<Log> Logs { get; set; }
		public virtual DbSet<LogLevel> LogLevels { get; set; }
		public virtual DbSet<PaymentCheck> PaymentChecks { get; set; }
		public virtual DbSet<PaymentDocumentReferencesCollection> PaymentDocumentReferencesCollections { get; set; }
		public virtual DbSet<PaymentInvoice> PaymentInvoices { get; set; }
		public virtual DbSet<PurchaseCreditNote> PurchaseCreditNotes { get; set; }
		public virtual DbSet<PurchaseCreditNote_DocumentLine> PurchaseCreditNote_DocumentLine { get; set; }
		public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
		public virtual DbSet<PurchaseInvoice_DocumentLine> PurchaseInvoice_DocumentLine { get; set; }
		public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
		public virtual DbSet<PurchaseQuotation> PurchaseQuotations { get; set; }
		public virtual DbSet<PurchaseTaxInvoice> PurchaseTaxInvoices { get; set; }
		public virtual DbSet<PurchaseTaxInvoiceLine> PurchaseTaxInvoiceLines { get; set; }
		public virtual DbSet<PurchaseTaxInvoiceOperationCode> PurchaseTaxInvoiceOperationCodes { get; set; }
		public virtual DbSet<Quotation> Quotations { get; set; }
		public virtual DbSet<SalesTaxInvoice> SalesTaxInvoices { get; set; }
		public virtual DbSet<SalesTaxInvoiceLine> SalesTaxInvoiceLines { get; set; }
		public virtual DbSet<SalesTaxInvoiceOperationCode> SalesTaxInvoiceOperationCodes { get; set; }
		public virtual DbSet<SapCode_QbAccountNumber_Mapping> SapCode_QbAccountNumber_Mapping { get; set; }
		public virtual DbSet<TaxExtension> TaxExtensions { get; set; }
		public virtual DbSet<TransactionCode> TransactionCodes { get; set; }
		public virtual DbSet<VendorPayment> VendorPayments { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AccountCategory>()
				.Property(e => e.CategoryName)
				.IsUnicode(false);

			modelBuilder.Entity<AccountCategory>()
				.Property(e => e.CategorySource)
				.IsUnicode(false);

			modelBuilder.Entity<AccountSegmentation>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<AccountSegmentation>()
				.Property(e => e.Type)
				.IsUnicode(false);

			modelBuilder.Entity<AccountSegmentationCategory>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<AccountSegmentationCategory>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<AccountSegmentationCategory>()
				.Property(e => e.ShortName)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToAddress2)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToAddress3)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToAddressType)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToBlock)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToBuilding)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToCity)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToCountry)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToCounty)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToGlobalLocationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToState)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToStreet)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToStreetNo)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.BillToZipCode)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceBlock)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceBP)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceBuilding)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceCity)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceCNPJ)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceCountry)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceCounty)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceCPF)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceDepartureDate)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceEMail)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlacePhone)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceState)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceStreet)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceStreetNo)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.DeliveryPlaceZip)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceBlock)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceBP)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceBuilding)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceCity)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceCNPJ)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceCountry)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceCounty)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceCPF)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceDepartureDate)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceEMail)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlacePhone)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceState)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceStreet)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceStreetNo)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.GoodsIssuePlaceZip)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.PlaceOfSupply)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.PurchasePlaceOfSupply)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToAddress2)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToAddress3)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToAddressType)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToBlock)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToBuilding)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToCity)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToCountry)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToCounty)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToGlobalLocationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToState)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToStreet)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToStreetNo)
				.IsUnicode(false);

			modelBuilder.Entity<AddressExtension>()
				.Property(e => e.ShipToZipCode)
				.IsUnicode(false);

			modelBuilder.Entity<BillOfExchangeTransaction>()
				.Property(e => e.BOETransactionkey)
				.IsUnicode(false);

			modelBuilder.Entity<BillOfExchangeTransaction>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<BillOfExchangeTransaction>()
				.Property(e => e.IsBoeReconciled)
				.IsUnicode(false);

			modelBuilder.Entity<BillOfExchangeTransaction>()
				.Property(e => e.StatusFrom)
				.IsUnicode(false);

			modelBuilder.Entity<BillOfExchangeTransaction>()
				.Property(e => e.StatusTo)
				.IsUnicode(false);

			modelBuilder.Entity<BillOfExchangeTransaction>()
				.Property(e => e.TransactionDate)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.AddressName)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.Street)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.Block)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.ZipCode)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.City)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.County)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.Country)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.State)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.TaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.BuildingFloorRoom)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.AddressType)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.AddressName2)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.AddressName3)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.TypeOfAddress)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.StreetNo)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.BPCode)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.GlobalLocationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.Nationality)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.TaxOffice)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.GSTIN)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.GstType)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.CreateTime)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.MYFType)
				.IsUnicode(false);

			modelBuilder.Entity<BPAddress>()
				.Property(e => e.TaasEnabled)
				.IsUnicode(false);

			modelBuilder.Entity<BPPaymentMethod>()
				.Property(e => e.PaymentMethodCode)
				.IsUnicode(false);

			modelBuilder.Entity<BPPaymentMethod>()
				.Property(e => e.BPCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.OdataEtag)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CardName)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CardType)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ZipCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.MailAddress)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.MailZipCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Phone1)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Phone2)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Fax)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ContactPerson)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Notes)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CreditLimit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.MaxCommitment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.VatLiable)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DeductibleAtSource)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DeductionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DeductionValidUntil)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.IntrestRatePercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CommissionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FreeText)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Currency)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.RateDiffAccount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Cellular)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.AvarageLate)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.City)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.County)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Country)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.MailCity)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.MailCounty)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.MailCountry)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EmailAddress)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Picture)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DefaultAccount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DefaultBranch)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DefaultBankCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.AdditionalID)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Pager)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FatherCard)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CardForeignName)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FatherType)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DeductionOffice)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ExportCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.MinIntrest)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CurrentAccountBalance)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.OpenDeliveryNotesBalance)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.OpenOrdersBalance)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.OpenChecksBalance)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.VatGroup)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ShippingType)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Password)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Indicator)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.IBAN)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CreditCardNum)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CreditCardExpiration)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DebitorAccount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.OpenOpportunities)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Valid)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ValidFrom)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ValidTo)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ValidRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Frozen)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FrozenFrom)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FrozenTo)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FrozenRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Block)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BillToState)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ShipToState)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ExemptNum)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Box1099)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.PeymentMethodCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BackOrder)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.PartialDelivery)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BlockDunning)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BankCountry)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.HouseBank)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.HouseBankCountry)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.HouseBankAccount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ShipToDefault)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DunningLevel)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CollectionAuthorization)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DME)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.InstructionKey)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.SinglePayment)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ISRBillerID)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.PaymentBlock)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ReferenceDetails)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.HouseBankBranch)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.OwnerIDNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.TaxExemptionLetterNum)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.MaxAmountOfExemption)
				.HasPrecision(19, 4);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.LinkedBusinessPartner)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.LastMultiReconciliationNum)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Equalization)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.SubjectToWithholdingTax)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CertificateNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.NationalInsuranceNum)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.AccrualCriteria)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.WTCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BillToBuildingFloorRoom)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DownPaymentClearAct)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ChannelBP)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DefaultTechnician)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BilltoDefault)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CustomerBillofExchangDisc)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Territory)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ShipToBuildingFloorRoom)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CustomerBillofExchangPres)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.VatGroupLatinAmerica)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DunningTerm)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Website)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.OtherReceivablePayable)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BillofExchangeonCollection)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CompanyPrivate)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.UnpaidBillofExchange)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ClosingDateProcedureNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Profession)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BankChargesAllocationCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.TaxRoundingRule)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties1)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties2)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties3)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties4)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties5)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties6)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties7)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties8)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties9)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties10)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties11)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties12)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties13)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties14)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties15)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties16)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties17)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties18)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties19)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties20)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties21)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties22)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties23)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties24)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties25)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties26)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties27)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties28)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties29)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties30)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties31)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties32)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties33)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties34)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties35)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties36)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties37)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties38)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties39)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties40)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties41)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties42)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties43)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties44)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties45)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties46)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties47)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties48)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties49)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties50)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties51)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties52)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties53)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties54)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties55)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties56)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties57)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties58)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties59)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties60)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties61)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties62)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties63)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Properties64)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CompanyRegistrationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.VerificationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DiscountBaseObject)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DiscountRelations)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.TypeReport)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ThresholdOverlook)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.SurchargeOverlook)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Remark1)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ConCerti)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DownPaymentInterimAccount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.OperationCode347)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.InsuranceOperation347)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.HierarchicalDeduction)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ShaamGroup)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.WithholdingTaxCertified)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BookkeepingCertified)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.PlanningGroup)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Affiliate)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.Industry)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.VatIDNum)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DatevAccount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DatevFirstDataEntry)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.UseShippedGoodsAccount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.GTSRegNo)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.GTSBankAccountNo)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.GTSBillingAddrTel)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ETaxWebSite)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.HouseBankIBAN)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.VATRegistrationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.RepresentativeName)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.IndustryType)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BusinessType)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.AutomaticPosting)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.InterestAccount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FeeAccount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CampaignNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.AliasName)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DefaultBlanketAgreementNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EffectiveDiscount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.NoDiscounts)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EffectivePrice)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EffectivePriceConsidersPriceBeforeDiscount)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.GlobalLocationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDISenderID)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDIRecipientID)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ResidenNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.RelationshipCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.UnifiedFederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.TypeOfOperation)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EndorsableChecksFromBP)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.AcceptsEndorsedChecks)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.OwnerCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.BlockSendingMarketingContent)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.AgentCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.PriceMode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocGenerationType)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocStreet)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocStreetNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocBuildingNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocZipCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocCity)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocCountry)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocDistrict)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocRepresentativeFirstName)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocRepresentativeSurname)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocRepresentativeCompany)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocRepresentativeFiscalCode)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocRepresentativeAdditionalId)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EDocPECAddress)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.IPACodeForPA)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.UpdateTime)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ExemptionMaxAmountValidationType)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ECommerceMerchantID)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.UseBillToAddrToDetermineTax)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CreateTime)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DefaultTransporterEntry)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DefaultTransporterLineNumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FCERelevant)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FCEValidateBaseDelivery)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.MainUsage)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EBooksVATExemptionCause)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.LegalText)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ExchangeRateForIncomingPayment)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.ExchangeRateForOutgoingPayment)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.CertificateDetails)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.DefaultCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.EORINumber)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.FCEAsPaymentMeans)
				.IsUnicode(false);

			modelBuilder.Entity<BusinessPartner>()
				.Property(e => e.NotRelevantForMonthlyInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<CashFlowAssignment>()
				.Property(e => e.AmountLC)
				.IsUnicode(false);

			modelBuilder.Entity<CashFlowAssignment>()
				.Property(e => e.PaymentMeans)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.Balance)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.CashAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.BudgetAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ActiveAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.PrimaryAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DataExportCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.FatherAccountKey)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ExternalCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.RateConversion)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.TaxLiableAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.TaxExemptAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ExternalReconNo)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.AccountType)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.AcctCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.BalanceSyscurr)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.BalanceFrgnCurr)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.Protected)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ReconciledAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.LiableForAdvances)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ForeignName)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.Details)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.RevaluationCoordinated)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.LockManualTransaction)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.FormatCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.AllowChangeVatGroup)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DefaultVatGroup)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.Category)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.TransactionCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.LoadingType)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.LoadingFactorCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.LoadingFactorCode2)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.LoadingFactorCode3)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.LoadingFactorCode4)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.LoadingFactorCode5)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.PlanningLevel)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DatevAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DatevAutoAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DatevFirstDataEntry)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.AllowMultipleLinking)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ProjectRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DistributionRuleRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DistributionRule2Relevant)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DistributionRule3Relevant)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DistributionRule4Relevant)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.DistributionRule5Relevant)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.BPLID)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.BPLName)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.VATRegNum)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.AccountPurposeCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ReferentialAccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ValidFor)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ValidFrom)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ValidTo)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ValidRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.FrozenFor)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.FrozenFrom)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.FrozenTo)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.FrozenRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.BlockManualPosting)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.CashFlowRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.PCN874ReportRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.PrimaryClosingAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.CostAccountingOnly)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.CostElementRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.CostElementCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.StandardAccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.TaxonomyCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.IncomeClassificationCategory)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.IncomeClassificationType)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ExpenseClassificationCategory)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.ExpenseClassificationType)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.OfficialAccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChartOfAccount>()
				.Property(e => e.UINV)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.BankCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.Branch)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.BankName)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.AccountNumber)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.Details)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.JournalEntryReference)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.CheckAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.Transferable)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.VendorCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.CheckCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.Canceled)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.CardOrAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.Printed)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.VendorName)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.Signature)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.CustomerAccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.CreateJournalEntry)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.TaxTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.DeductionRefundAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.CountryCode)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.TotalinWords)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.AddressName)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.ManualCheck)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.ECheck)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPayment>()
				.Property(e => e.PrintConfirm)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPaymentLine>()
				.Property(e => e.RowDetails)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPaymentLine>()
				.Property(e => e.RowTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ChecksforPaymentLine>()
				.Property(e => e.RowCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPaymentLine>()
				.Property(e => e.TaxDefinition)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPaymentLine>()
				.Property(e => e.TaxPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ChecksforPaymentLine>()
				.Property(e => e.CreditedAccount)
				.IsUnicode(false);

			modelBuilder.Entity<ChecksforPaymentLine>()
				.Property(e => e.LineTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Position)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Phone1)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Phone2)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.MobilePhone)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Fax)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.EMail)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Pager)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Remarks1)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Remarks2)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Password)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.PlaceOfBirth)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Gender)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Profession)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Title)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.CityOfBirth)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.Active)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.FirstName)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.MiddleName)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.EmailGroupCode)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.BlockSendingMarketingContent)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.CreateTime)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.UpdateTime)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.ConnectedAddressName)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.ConnectedAddressType)
				.IsUnicode(false);

			modelBuilder.Entity<ContactEmployee>()
				.Property(e => e.ForeignCountry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.odataetag)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.HandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Printed)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CardName)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.NumAtCard)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Reference1)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Reference2)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.JournalMemo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocTime)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Confirmed)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ImportFileNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SummeryType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ShowSCN)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PartialSupply)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocObjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ShipToCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Indicator)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaymentReference)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.VatSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.VatSumSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.VatSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.NetProcedure)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocTotalFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocTotalSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Form1099)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Box1099)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.RevisionPo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.RequriedDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CancelDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BlockDunning)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Submitted)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PickStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Pick)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaymentMethod)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaymentBlock)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaymentBlockEntry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CentralBankIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.MaximumCashDiscount)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Reserve)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Project)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ExemptionValidityDateFrom)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ExemptionValidityDateTo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WareHouseUpdateType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Rounding)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ExternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.InternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.NextCorrectingDocument)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TaxExemptionLetterNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTAppliedFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BillOfExchangeReserved)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.AgentCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTAppliedSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ApplyTaxOnFirstInstallment)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TaxOnInstallments)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTNonSubjectAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTNonSubjectAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTNonSubjectAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTExemptedAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTExemptedAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTExemptedAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BaseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BaseAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BaseAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.VatDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocumentsOwner)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FolioPrefixString)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocumentSubType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BPChannelCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BPChannelContact)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Address2)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocumentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PeriodIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PayToCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ManualNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.UseShpdGoodsAct)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.IsPayToBank)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PayToBankCountry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PayToBankCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PayToBankAccountNo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PayToBankBranch)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BPL_IDAssignedToInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DownPayment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ReserveInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TrackingNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PickRemark)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SequenceCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SequenceSerial)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SubSeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SequenceModel)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.UseCorrectionVATGroup)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TotalDiscount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DownPaymentAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DownPaymentPercentage)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DownPaymentType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DownPaymentAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DownPaymentAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.VatPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ServiceGrossProfitPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.OpeningRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ClosingRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.RoundingDiffAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.RoundingDiffAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.RoundingDiffAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Cancelled)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SignatureInputMessage)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SignatureDigest)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CertificationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PrivateKeyVersion)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ControlAccount)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.InsuranceOperation347)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ArchiveNonremovableSalesQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.GTSChecker)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.GTSPayee)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.StartFrom)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.NTSApproved)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ETaxWebSite)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ETaxNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.NTSApprovedNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EDocGenerationType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EDocSeries)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EDocExportFormat)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EDocStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EDocErrorCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EDocErrorMessage)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DownPaymentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.GroupSeries)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.GroupNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.GroupHandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ReopenOriginalDocument)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ReopenManuallyClosedOrCanceledDocument)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CreateOnlineQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.POSEquipmentNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.POSManufacturerSerialNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.POSCashierNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ApplyCurrentVATRatesForDownPaymentsToDraw)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ClosingOption)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SpecifiedClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.OpenForLandedCosts)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.AuthorizationStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TotalDiscountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TotalDiscountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.RelevantToGTS)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BPLName)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.VATRegNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.AnnualInvoiceDeclarationReference)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Supplier)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Releaser)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Receiver)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.BlanketAgreementNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.IsAlteration)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CancelStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.AssetValueDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocumentDelivery)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.AuthorizationCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.StartDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.StartDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EndDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EndDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.VehiclePlate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ATDocumentType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ElecCommStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ElecCommMessage)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ReuseDocumentNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ReuseNotaFiscalNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PrintSEPADirect)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FiscalDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.POSDailySummaryNo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.POSReceiptNo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PointOfIssueCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Letter)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FolioNumberFrom)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FolioNumberTo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.InterimType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.RelatedEntry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.SAPPassport)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocumentTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DateOfReportingControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ReportingSectionControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ExcludeFromTaxReportControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.POS_CashRegister)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.UpdateTime)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CreateQRCodeFrom)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PriceMode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.OriginalRefNo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.OriginalRefDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Revision)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.GSTTransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.OriginalCreditOrDebitNo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.OriginalCreditOrDebitDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ShipFrom)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CommissionTrade)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CommissionTradeReturn)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.UseBillToAddrToDetermineTax)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.EDocType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FCEAsPaymentMeans)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaidToDate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaidToDateFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaidToDateSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FatherCard)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FatherType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ShipState)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.ShipPlace)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CustOffice)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.FCI)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.AddLegIn)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.LegTextF)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DANFELgTxt)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.IndFinal)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.LastPageFolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.InventoryStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PlasticPackagingTaxRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.NotRelevantForMonthlyInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.AllocationNumberIL)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ItemCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ItemDescription)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Quantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ShipDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PriceAfterVAT)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Currency)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Rate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.VendorNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.SerialNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.WarehouseCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CommisionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TreeType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.AccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.UseBaseUnits)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.SupplierCatNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CostingCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.BarCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.VatGroup)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Height1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Hight1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Height2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Height2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Lengh1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Lengh1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Lengh2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Lengh2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Weight1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Weight1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Weight2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Weight2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Factor1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Factor2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Factor3)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Factor4)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.BaseEntry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.BaseLine)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Volume)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.VolumeUnit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Width1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Width1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Width2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Width2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxLiable)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PickStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PickQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PickListIdNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.OriginalItem)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.BackOrder)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.FreeText)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.POTargetNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.POTargetEntry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.POTargetRowNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CorrectionInvoiceItem)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CorrInvAmountToStock)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CorrInvAmountToDiffAcct)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.AppliedTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.AppliedTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.AppliedTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.WTLiable)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.EqualizationTaxPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.NetTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.NetTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.NetTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.MeasureUnit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.UnitsOfMeasurment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.LineTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxPercentagePerRow)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ConsumerSalesForecast)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ExciseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TotalInclTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CountryOrg)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.SWW)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.DistributeExpense)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RowTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RowTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.LastBuyInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.LastBuyDistributeSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.LastBuyDistributeSumSc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.LastBuyDistributeSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.StockDistributesumForeign)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.StockDistributesumSystem)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.StockDistributesum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.StockInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PickStatusEx)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPM)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPMFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPMSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CFOPCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CSTCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Usage)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxOnly)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.BaseOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.LineStatus)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PackageQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Text)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.LineType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.COGSAccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ChangeAssemlyBoMWarehouse)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossBuyPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossProfitTotalBasePrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CostingCode2)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CostingCode3)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CostingCode4)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CostingCode5)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ItemDetails)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.LocationCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RemainingOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.OpenAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.OpenAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.OpenAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ExLineNo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RequiredDate)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RequiredQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode2)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode3)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode4)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode5)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CSTforIPI)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CSTforPIS)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CSTforCOFINS)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CreditOriginCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.WithoutInventoryMovement)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.AgreementNo)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.AgreementRowNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ActualBaseEntry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ActualBaseLine)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Surpluses)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.DefectAndBreakup)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Shortages)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ConsiderQuantity)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PartialRetirement)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RetirementQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RetirementAPC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ThirdParty)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PoNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PoItmNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ExpenseType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ReceiptNumber)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ExpenseOperationType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossProfit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossProfitFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossProfitSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PriceSource)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.EnableReturnCost)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ReturnCost)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.StgSeqNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.StgEntry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.StgDesc)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.UoMCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.InventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RemainingOpenInventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ParentLineNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Incoterms)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TransportMode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.NatureOfTransaction)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.DestinationCountryForImport)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.DestinationRegionForImport)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.OriginCountryForExport)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.OriginRegionForExport)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ItemType)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ChangeInventoryQuantityIndependently)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.FreeOfChargeBP)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.SACEntry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.HSNEntry)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.NVECode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.IndEscala)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CtrSealQty)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CNJPMan)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CESTCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.UFFiscalBenefitCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ReverseCharge)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ShipToCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ShipToDescription)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.OwnerCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ExternalCalcTaxRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ExternalCalcTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ExternalCalcTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ExternalCalcTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.StandardItemIdentification)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CommodityClassification)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.WeightOfRecycledPlastic)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PlasticPackageExemptionReason)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.LegalText)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.UnencumberedReason)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CUSplit)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.ListNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RecognizedTaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DepositType)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DepositCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DepositAccount)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DepositorName)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.Bank)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.BankAccountNum)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.BankBranch)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.BankReference)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.JournalRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.TotalLC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.TotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.TotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.AllocationAccount)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.TaxAccount)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.TaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.CommissionAccount)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.Commission)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.CommissionDate)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.TaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DepositAccountType)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.ReconcileAfterDeposit)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.VoucherAccount)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.Project)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DistributionRule)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DistributionRule2)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DistributionRule3)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DistributionRule4)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DistributionRule5)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.CommissionCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.CommissionSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.CommissionFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.TaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.TaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.BPLID)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.CheckDepositType)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.IncomeTaxAccount)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.IncomeTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.IncomeTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.IncomeTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit_CheckLine>()
				.Property(e => e.Bank)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit_CheckLine>()
				.Property(e => e.Branch)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit_CheckLine>()
				.Property(e => e.CashCheck)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit_CheckLine>()
				.Property(e => e.Customer)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit_CheckLine>()
				.Property(e => e.CheckAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Deposit_CheckLine>()
				.Property(e => e.Deposited)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit_CheckLine>()
				.Property(e => e.Transferred)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit_CheckLine>()
				.Property(e => e.AccountNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit_CheckLine>()
				.Property(e => e.CheckCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentInstallment>()
				.Property(e => e.Percentage)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentInstallment>()
				.Property(e => e.Total)
				.HasPrecision(19, 3);

			modelBuilder.Entity<DocumentInstallment>()
				.Property(e => e.LastDunningDate)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentInstallment>()
				.Property(e => e.PaymentOrdered)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentInstallment>()
				.Property(e => e.TotalFC)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.AppliedTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.AppliedTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.AppliedTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.BaseOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CommisionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CorrInvAmountToDiffAcct)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CorrInvAmountToStock)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CtrSealQty)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.DefectAndBreakup)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.EqualizationTaxPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ExciseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ExternalCalcTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ExternalCalcTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ExternalCalcTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ExternalCalcTaxRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Factor1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Factor2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Factor3)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Factor4)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.GrossBuyPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.GrossPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.GrossProfit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.GrossProfitFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.GrossProfitSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.GrossProfitTotalBasePrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.GrossTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.GrossTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.GrossTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Height1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Height2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.InventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.LastBuyDistributeSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.LastBuyDistributeSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.LastBuyDistributeSumSc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.LastBuyInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Lengh1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Lengh2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.LineTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.NetTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.NetTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.NetTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.OpenAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.OpenAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.OpenAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PackageQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PickQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PriceAfterVAT)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Quantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Rate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.RemainingOpenInventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.RemainingOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.RequiredQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.RetirementAPC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.RetirementQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.RowTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.RowTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Shortages)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.StockDistributesum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.StockDistributesumForeign)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.StockDistributesumSystem)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.StockInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Surpluses)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxBeforeDPM)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxBeforeDPMFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxBeforeDPMSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxPercentagePerRow)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TotalInclTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.UnitsOfMeasurment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Volume)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Weight1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Weight2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.WeightOfRecycledPlastic)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Width1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Width2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.AccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ActualBaseEntry)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ActualBaseLine)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.AgreementNo)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.AgreementRowNumber)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.BackOrder)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.BarCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.BaseEntry)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.BaseLine)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CFOPCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ChangeAssemlyBoMWarehouse)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ChangeInventoryQuantityIndependently)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CNJPMan)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.COGSAccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.COGSCostingCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.COGSCostingCode2)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.COGSCostingCode3)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.COGSCostingCode4)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.COGSCostingCode5)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ConsiderQuantity)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ConsumerSalesForecast)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CorrectionInvoiceItem)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CostingCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CostingCode2)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CostingCode3)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CostingCode4)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CostingCode5)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CountryOrg)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CreditOriginCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CSTCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CSTforCOFINS)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CSTforIPI)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CSTforPIS)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Currency)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.CUSplit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.DestinationCountryForImport)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.DestinationRegionForImport)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.DistributeExpense)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ExLineNo)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ExpenseOperationType)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ExpenseType)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.FreeOfChargeBP)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.FreeText)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Height2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Hight1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.HSNEntry)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.IndEscala)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ItemCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ItemDescription)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ItemDetails)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ItemType)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.LegalText)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Lengh1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Lengh2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.LineStatus)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.LineType)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ListNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.LocationCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.MeasureUnit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.NatureOfTransaction)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.NVECode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.OriginalItem)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.OriginCountryForExport)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.OriginRegionForExport)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.OwnerCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ParentLineNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PartialRetirement)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PickListIdNumber)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PickStatus)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PickStatusEx)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PlasticPackageExemptionReason)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PoItmNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PoNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.POTargetEntry)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.POTargetNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.POTargetRowNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.PriceSource)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ReceiptNumber)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.RecognizedTaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.RequiredDate)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ReverseCharge)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.SACEntry)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.SerialNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ShipToCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ShipToDescription)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.StgDesc)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.StgEntry)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.StgSeqNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.SupplierCatNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.SWW)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxLiable)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxOnly)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TaxType)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Text)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.ThirdParty)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.TreeType)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.UFFiscalBenefitCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.UnencumberedReason)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.UoMCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Usage)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.UseBaseUnits)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.VatGroup)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.VendorNum)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.WarehouseCode)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Weight1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Weight2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Width1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.Width2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.WithoutInventoryMovement)
				.IsUnicode(false);

			modelBuilder.Entity<DocumentLine>()
				.Property(e => e.WTLiable)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.AmountToDraw)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.AmountToDrawSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.GrossAmountToDraw)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.GrossAmountToDrawFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.GrossAmountToDrawSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.Tax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.TaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.TaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.AmountToDrawFC)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.Details)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.DownPaymentType)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.IsGrossLine)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDraw>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.AmountToDraw)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.AmountToDrawSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.GrossAmountToDraw)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.GrossAmountToDrawFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.GrossAmountToDrawSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.Tax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.TaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.VatPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.AmountToDrawFC)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.IsGrossLine)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.LineType)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.TaxAdjust)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.TaxFC)
				.IsUnicode(false);

			modelBuilder.Entity<DownPaymentsToDrawDetail>()
				.Property(e => e.VatGroupCode)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.AccumulatedOrdinaryDepr)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.AccumulatedSpecialDepr)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.AccumulatedUnplannedDepr)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.AssetBalanceSheetAccount)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.ClearingAccountAcquisition)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.LeavewithExpenseNBVGross)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.LeavewithRevenueNBVGross)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.OrdinaryDepreciation)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.RetirementwithExpenseNet)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.RetirementwithRevenueNet)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.RevaluationReserveAccount)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.RevaluationReserveClearing)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.RevenueAccountforRetirement)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.RevenueClearingAccount)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.RevenuefromAssetSalesNet)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.SpecialDepreciation)
				.IsUnicode(false);

			modelBuilder.Entity<FAAccountDetermination>()
				.Property(e => e.UnplannedDepreciation)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.BeginningofFinancialYear)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.EUExpensesAccount)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.EURevenuesAccount)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.ExpenseClearingAct)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.ExpensesAccount)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.ForeignExpensAcc)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.ForeignRevenueAcc)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.FromDate)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.IsActive)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.Period)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.RevenuesAccount)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.ToDate)
				.IsUnicode(false);

			modelBuilder.Entity<GLAccountAdvancedRule>()
				.Property(e => e.Warehouse)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.DiscountLimit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.MaxAmountofBillofExchan)
				.HasPrecision(19, 4);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.MinAmountofBillofExchang)
				.HasPrecision(19, 4);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.AccNo)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.AccountCheckDigit)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.AccountName)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.AddressType)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.AgreementNumber)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.BankCode)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.BankonCollection)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.BankonDiscounted)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.BICSwiftCode)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.BISR)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.Block)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.Branch)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.BranchCheckDigit)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.Building)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.City)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.CollectionCode)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.ControlKey)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.Country)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.County)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.CustomerIdNumber)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.DaysInAdvance)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.DebtofDiscountedBillofExc)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.DiscountAccount)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.DSC1STREETALIAS)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.ECheck)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.FileSeqNextNumber)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.FineAccount)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.GLAccount)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.GLInterimAccount)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.IBAN)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.ImportFileName)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.InterestAccount)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.IOFTaxAccount)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.ISRBillerID)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.LockChecksPrinting)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.MaximumLines)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.NextCheckNo)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.NoValidationForStartingEndingBal)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.OtherExpensesAccount)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.OtherIncomesAccount)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.OurNumber)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.PrintOn)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.RetornoFileName)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.ServiceFeeAccount)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.State)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.StreetNo)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.TemplateName)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.ToleranceDays)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.UserNo1)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.UserNo2)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.UserNo3)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.UserNo4)
				.IsUnicode(false);

			modelBuilder.Entity<HouseBankAccount>()
				.Property(e => e.ZipCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BankChargeAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BankChargeAmountInFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BankChargeAmountInSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BillOfExchangeAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BillOfExchangeAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BillOfExchangeAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CashSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CashSumFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CashSumSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.DeductionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.DeductionSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.TransferRealAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.TransferSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.UnderOverpaymentdifference)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.UnderOverpaymentdiffFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.UnderOverpaymentdiffSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.WTAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.WTAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.WTAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.WtBaseSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.WtBaseSumFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.WtBaseSumSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.WTTaxableAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.ApplyVAT)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.AuthorizationStatus)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BankAccount)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BankCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BillOfExchangeAgent)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BillofExchangeStatus)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BlanketAgreement)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BoeAccount)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BPLID)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.BPLName)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.Cancelled)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CardName)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CashAccount)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CertificationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CheckAccount)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.ContactPersonCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.ControlAccount)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CounterReference)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.CurrencyIsLocal)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.DocCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.DocObjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.DocTypte)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.EDocExportFormat)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.ElecCommMessage)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.ElecCommStatus)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.HandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.IsPayToBank)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.JournalRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.LocalCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.LocationCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.PaymentByWTCertif)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.PaymentPriority)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.PaymentType)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.PayToBankAccountNo)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.PayToBankBranch)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.PayToBankCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.PayToBankCountry)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.PayToCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.Printed)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.PrivateKeyVersion)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.Proforma)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.Reference1)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.Reference2)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.Remarks)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.SignatureDigest)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.SignatureInputMessage)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.SplitTransaction)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.SplitVendorCreditRow)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.TaxGroup)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.TransactionCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.TransferAccount)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.TransferReference)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.VATRegNum)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.WTAccount)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment>()
				.Property(e => e.WTCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.BankCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.Branch)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.AccounttNum)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.Details)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.Trnsfrable)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.CheckSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.Currency)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.CountryCode)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.CheckAccount)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.ManualCheck)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.FiscalID)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.OriginallyIssuedBy)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.Endorse)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.EndorsableCheckNo)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentCheck>()
				.Property(e => e.ECheck)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.SumApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.AppliedFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.AppliedSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.InvoiceType)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.PaidSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.WitholdingTaxApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.WitholdingTaxAppliedFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.WitholdingTaxAppliedSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.LinkDate)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.DistributionRule)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.DistributionRule2)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.DistributionRule3)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.DistributionRule4)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.DistributionRule5)
				.IsUnicode(false);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.TotalDiscount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.TotalDiscountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<IncomingPayment_PaymentInvoice>()
				.Property(e => e.TotalDiscountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BaseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BaseAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BaseAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocTotalFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocTotalSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DownPayment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DownPaymentAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DownPaymentAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DownPaymentAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DownPaymentPercentage)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PaidToDate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PaidToDateFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PaidToDateSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.RoundingDiffAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.RoundingDiffAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.RoundingDiffAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TotalDiscount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TotalDiscountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TotalDiscountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.VatPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.VatSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.VatSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.VatSumSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTAppliedFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTAppliedSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTExemptedAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTExemptedAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTExemptedAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTNonSubjectAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTNonSubjectAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WTNonSubjectAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.AddLegIn)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Address2)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.AgentCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.AllocationNumberIL)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.AnnualInvoiceDeclarationReference)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ApplyCurrentVATRatesForDownPaymentsToDraw)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ApplyTaxOnFirstInstallment)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ArchiveNonremovableSalesQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.AssetValueDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ATDocumentType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.AuthorizationCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.AuthorizationStatus)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BaseEntry)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BillOfExchangeReserved)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BlanketAgreementNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BlockDunning)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Box1099)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BPChannelCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BPChannelContact)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BPLIDAssignedToInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.BPLName)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CancelDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Cancelled)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CancelStatus)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CardName)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CentralBankIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CertificationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ClosingOption)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ClosingRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CommissionTrade)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CommissionTradeReturn)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Confirmed)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ControlAccount)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CreateOnlineQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CreateQRCodeFrom)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CustOffice)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DANFELgTxt)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DateOfReportingControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocObjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocTime)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocumentDelivery)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocumentsOwner)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocumentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocumentSubType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DocumentTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DownPaymentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.DownPaymentType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ECommerceGSTIN)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ECommerceOperator)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EDocErrorCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EDocErrorMessage)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EDocExportFormat)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EDocGenerationType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EDocSeries)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EDocStatus)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EDocType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ElecCommMessage)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ElecCommStatus)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EndDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.EndDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ETaxNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ETaxWebSite)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ExcludeFromTaxReportControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ExemptionValidityDateFrom)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ExemptionValidityDateTo)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ExternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FatherCard)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FatherType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FCEAsPaymentMeans)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FCI)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FiscalDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FolioNumberFrom)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FolioNumberTo)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.FolioPrefixString)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Form1099)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.GroupHandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.GroupNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.GroupSeries)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.GSTTransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.GTSChecker)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.GTSPayee)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.HandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ImportFileNum)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.IndFinal)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Indicator)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.InsuranceOperation347)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.InterimType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.InternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.InventoryStatus)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.InvoicePayment)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.IsAlteration)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.IsPayToBank)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.JournalMemo)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.LastPageFolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.LegTextF)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Letter)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ManualNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.MaximumCashDiscount)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.NetProcedure)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.NextCorrectingDocument)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.NotRelevantForMonthlyInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.NTSApproved)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.NTSApprovedNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.NumAtCard)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.OdataEtag)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.OpenForLandedCosts)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.OpeningRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.OriginalCreditOrDebitDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.OriginalCreditOrDebitNo)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.OriginalRefDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.OriginalRefNo)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PartialSupply)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PaymentBlock)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PaymentBlockEntry)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PaymentMethod)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PaymentReference)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PayToBankAccountNo)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PayToBankBranch)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PayToBankCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PayToBankCountry)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PayToCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PeriodIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Pick)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PickRemark)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PickStatus)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PlasticPackagingTaxRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PointOfIssueCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.POSCashierNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.POSCashRegister)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.POSDailySummaryNo)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.POSEquipmentNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.POSManufacturerSerialNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.POSReceiptNo)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PriceMode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Printed)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PrintSEPADirect)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.PrivateKeyVersion)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Project)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Receiver)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Reference1)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Reference2)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.RelatedEntry)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Releaser)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.RelevantToGTS)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ReopenManuallyClosedOrCanceledDocument)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ReopenOriginalDocument)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ReportingSectionControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.RequriedDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Reserve)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ReserveInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ReuseDocumentNum)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ReuseNotaFiscalNum)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Revision)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.RevisionPo)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Rounding)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SAPPassport)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SequenceCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SequenceModel)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SequenceSerial)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ServiceGrossProfitPercent)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipFrom)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipPlace)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipState)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipToCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShowSCN)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SignatureDigest)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SignatureInputMessage)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SpecifiedClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.StartDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.StartDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.StartFrom)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Submitted)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SubSeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SummeryType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Supplier)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TaxExemptionLetterNum)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TaxOnInstallments)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TrackingNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.UpdateTime)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.UseBillToAddrToDetermineTax)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.UseCorrectionVATGroup)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.UseShpdGoodsAct)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.VatDate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.VATRegNum)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.VehiclePlate)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.WareHouseUpdateType)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Quantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.PriceAfterVAT)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Rate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.CommisionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Height1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Height2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Lengh1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Lengh2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Weight1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Weight2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Factor1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Factor2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Factor3)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Factor4)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Volume)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Width1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Width2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.PickQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.CorrInvAmountToStock)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.CorrInvAmountToDiffAcct)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.AppliedTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.AppliedTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.AppliedTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.EqualizationTaxPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.NetTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.NetTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.NetTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.UnitsOfMeasurment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.LineTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TaxPercentagePerRow)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TaxTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.ExciseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TaxPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TotalInclTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.RowTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.RowTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.LastBuyInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.LastBuyDistributeSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.LastBuyDistributeSumSc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.LastBuyDistributeSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.StockDistributesumForeign)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.StockDistributesumSystem)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.StockDistributesum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.StockInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TaxBeforeDPM)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TaxBeforeDPMFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.TaxBeforeDPMSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.BaseOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.PackageQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.GrossBuyPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.GrossProfitTotalBasePrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.RemainingOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.OpenAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.OpenAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.OpenAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.RequiredQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Surpluses)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.DefectAndBreakup)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.Shortages)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.RetirementQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.RetirementAPC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.GrossProfit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.GrossProfitFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.GrossProfitSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.InventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.RemainingOpenInventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.GrossPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.GrossTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.GrossTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.GrossTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.CtrSealQty)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.ExternalCalcTaxRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.ExternalCalcTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.ExternalCalcTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.ExternalCalcTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Invoice_DocumentLine>()
				.Property(e => e.WeightOfRecycledPlastic)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.DesiredInventory)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.MinInventory)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.CommissionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.CommissionSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.QuantityOnStock)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.QuantityOrderedFromVendors)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.QuantityOrderedByCustomers)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.SalesItemsPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.SalesQtyPerPackUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.SalesUnitVolume)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.PurchaseItemsPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.PurchaseQtyPerPackUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.PurchaseUnitVolume)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.SalesFactor1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.SalesFactor2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.SalesFactor3)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.SalesFactor4)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.PurchaseFactor1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.PurchaseFactor2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.PurchaseFactor3)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.PurchaseFactor4)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.MovingAveragePrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.AvgStdPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.MaxInventory)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.OrderMultiple)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.MinOrderQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.CountingItemsPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.ProdStdCost)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.CapitalGoodsOnHoldPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.CapitalGoodsOnHoldLimit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.AssessableValue)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.AssVal4WTR)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.CtrSealQty)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Item>()
				.Property(e => e.WeightOfRecycledPlastic)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Memo)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Reference)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Reference2)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.TransactionCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Indicator)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.UseAutoStorno)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.StornoDate)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.VatDate)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.StampTax)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.AutoVAT)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.FolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.FolioPrefixString)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.ReportEU)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Report347)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Printed)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.LocationCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.OriginalJournal)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.BaseReference)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.BlockDunningLetter)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.AutomaticWT)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.WTSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.WTSumSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.WTSumFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.SignatureInputMessage)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.SignatureDigest)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.CertificationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.PrivateKeyVersion)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Corisptivi)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Reference3)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.DocumentType)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.BlanketAgreementNumber)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.OperationCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.ResidenceNumberType)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.ECDPostingType)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.ExposedTransNumber)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.PointOfIssueCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Letter)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.FolioNumberFrom)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.FolioNumberTo)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.IsCostCenterTransfer)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.ReportingSectionControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.ExcludeFromTaxReportControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.SAPPassport)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.AdjustTransaction)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.SAFTTransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntry>()
				.Property(e => e.AllocationNumberIL)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryDocumentType>()
				.Property(e => e.JournalEntryType)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryDocumentType>()
				.Property(e => e.DocTypeDescription)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryDocumentType>()
				.Property(e => e.ShortName)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.AccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.Debit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.Credit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.FCDebit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.FCCredit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.FCCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.ShortName)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.ContraAccount)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.LineMemo)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.ReferenceDate2)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.Reference1)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.Reference2)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.CostingCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.BaseSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.TaxGroup)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.DebitSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.CreditSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.VatDate)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.VatLine)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.SystemBaseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.VatAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.SystemVatAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.GrossValue)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.AdditionalReference)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.CostingCode2)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.CostingCode3)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.CostingCode4)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.TaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.TaxPostAccount)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.CostingCode5)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.LocationCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.ControlAccount)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.EqualizationTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.SystemEqualizationTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.TotalTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.SystemTotalTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.WTLiable)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.WTRow)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.PaymentBlock)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.BlockReason)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.BPLID)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.BPLName)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.VATRegNum)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.PaymentOrdered)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.ExposedTransNumber)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.CostElementCode)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.IncomeClassificationCategory)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.IncomeClassificationType)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.ExpensesClassificationCategory)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.ExpensesClassificationType)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.VATClassificationCategory)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.VATClassificationType)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryLine>()
				.Property(e => e.VATExemptionCause)
				.IsUnicode(false);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.BaseSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.ExternalCalcTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.ExternalCalcTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.ExternalCalcTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.ExternalCalcTaxRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.NonDeductiblePercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.TaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.TaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.TaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.TaxRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.Exempt)
				.IsUnicode(false);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.JurisdictionCode)
				.IsUnicode(false);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.TaxInPrice)
				.IsUnicode(false);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.TaxOnReserveInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<LineTaxJurisdiction>()
				.Property(e => e.Unencumbered)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.BankCode)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.Branch)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.AccounttNum)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.Details)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.Trnsfrable)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.CheckSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.Currency)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.CountryCode)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.CheckAccount)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.ManualCheck)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.FiscalID)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.OriginallyIssuedBy)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.Endorse)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.EndorsableCheckNo)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.ECheck)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.Canceled)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.VendorCode)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentCheck>()
				.Property(e => e.VendorName)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentDocumentReferencesCollection>()
				.Property(e => e.ExternalReferencedDocNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentDocumentReferencesCollection>()
				.Property(e => e.ReferencedObjectType)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentDocumentReferencesCollection>()
				.Property(e => e.Remark)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.SumApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.AppliedFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.AppliedSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.InvoiceType)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.PaidSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.WitholdingTaxApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.WitholdingTaxAppliedFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.WitholdingTaxAppliedSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.DistributionRule)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.DistributionRule2)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.DistributionRule3)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.DistributionRule4)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.DistributionRule5)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.TotalDiscount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.TotalDiscountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PaymentInvoice>()
				.Property(e => e.TotalDiscountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.odataetag)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.HandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Printed)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CardName)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.NumAtCard)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Reference1)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Reference2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.JournalMemo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Confirmed)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ImportFileNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SummeryType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ShowSCN)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PartialSupply)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocObjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ShipToCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Indicator)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaymentReference)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.VatSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.VatSumSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.VatSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.NetProcedure)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocTotalFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocTotalSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Form1099)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Box1099)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.RevisionPo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.RequriedDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CancelDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BlockDunning)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Submitted)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PickStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Pick)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaymentMethod)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaymentBlock)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaymentBlockEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CentralBankIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.MaximumCashDiscount)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Reserve)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Project)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ExemptionValidityDateFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ExemptionValidityDateTo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WareHouseUpdateType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Rounding)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ExternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.InternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.NextCorrectingDocument)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TaxExemptionLetterNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTAppliedFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BillOfExchangeReserved)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.AgentCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTAppliedSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ApplyTaxOnFirstInstallment)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TaxOnInstallments)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTNonSubjectAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTNonSubjectAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTNonSubjectAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTExemptedAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTExemptedAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTExemptedAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BaseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BaseAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BaseAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.VatDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocumentsOwner)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.FolioPrefixString)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.FolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocumentSubType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BPChannelCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BPChannelContact)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Address2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocumentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PeriodIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PayToCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ManualNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.UseShpdGoodsAct)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.IsPayToBank)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PayToBankCountry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PayToBankCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PayToBankAccountNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PayToBankBranch)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BPL_IDAssignedToInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DownPayment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ReserveInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TrackingNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PickRemark)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SequenceCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SequenceSerial)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SubSeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SequenceModel)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.UseCorrectionVATGroup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TotalDiscount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DownPaymentAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DownPaymentPercentage)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DownPaymentType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DownPaymentAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DownPaymentAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.VatPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ServiceGrossProfitPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.OpeningRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ClosingRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.RoundingDiffAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.RoundingDiffAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.RoundingDiffAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Cancelled)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SignatureInputMessage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SignatureDigest)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CertificationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PrivateKeyVersion)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ControlAccount)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.InsuranceOperation347)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ArchiveNonremovableSalesQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.GTSChecker)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.GTSPayee)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.StartFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.NTSApproved)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ETaxWebSite)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ETaxNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.NTSApprovedNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.EDocGenerationType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.EDocSeries)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.EDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.EDocExportFormat)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.EDocStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.EDocErrorCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.EDocErrorMessage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DownPaymentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.GroupSeries)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.GroupNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.GroupHandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ReopenOriginalDocument)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ReopenManuallyClosedOrCanceledDocument)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CreateOnlineQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.POSEquipmentNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.POSManufacturerSerialNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.POSCashierNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ApplyCurrentVATRatesForDownPaymentsToDraw)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ClosingOption)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SpecifiedClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.OpenForLandedCosts)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.AuthorizationStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TotalDiscountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TotalDiscountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.RelevantToGTS)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BPLName)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.VATRegNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.AnnualInvoiceDeclarationReference)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Supplier)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Releaser)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Receiver)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.BlanketAgreementNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.IsAlteration)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CancelStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.AssetValueDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocumentDelivery)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.AuthorizationCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.StartDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.StartDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.EndDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.EndDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.VehiclePlate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ATDocumentType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ElecCommStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ElecCommMessage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ReuseDocumentNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ReuseNotaFiscalNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PrintSEPADirect)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.FiscalDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.POSDailySummaryNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.POSReceiptNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PointOfIssueCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Letter)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.FolioNumberFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.FolioNumberTo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.InterimType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.RelatedEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.SAPPassport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocumentTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DateOfReportingControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ReportingSectionControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ExcludeFromTaxReportControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.POS_CashRegister)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.UpdateTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CreateQRCodeFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PriceMode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.OriginalRefNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.OriginalRefDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Revision)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.GSTTransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.OriginalCreditOrDebitNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.OriginalCreditOrDebitDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TaxInvoiceNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TaxInvoiceDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ShipFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CommissionTrade)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CommissionTradeReturn)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.UseBillToAddrToDetermineTax)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaidToDate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaidToDateFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaidToDateSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.FatherCard)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.FatherType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ShipState)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.ShipPlace)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CustOffice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.FCI)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.AddLegIn)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.LegTextF)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DANFELgTxt)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.LastPageFolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.InventoryStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PlasticPackagingTaxRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.NotRelevantForMonthlyInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ItemCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ItemDescription)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Quantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ShipDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PriceAfterVAT)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Currency)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Rate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.VendorNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.SerialNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.WarehouseCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CommisionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TreeType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.AccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.UseBaseUnits)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.SupplierCatNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CostingCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.BarCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.VatGroup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Height1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Hight1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Height2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Height2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Lengh1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Lengh1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Lengh2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Lengh2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Weight1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Weight1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Weight2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Weight2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Factor1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Factor2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Factor3)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Factor4)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Volume)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Width1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Width1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Width2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Width2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxLiable)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PickStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PickQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PickListIdNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.OriginalItem)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.BackOrder)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.FreeText)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.POTargetNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.POTargetEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.POTargetRowNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CorrectionInvoiceItem)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CorrInvAmountToStock)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CorrInvAmountToDiffAcct)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.AppliedTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.AppliedTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.AppliedTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.WTLiable)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.EqualizationTaxPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.NetTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.NetTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.NetTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.MeasureUnit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.UnitsOfMeasurment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.LineTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxPercentagePerRow)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ConsumerSalesForecast)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ExciseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TotalInclTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CountryOrg)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.SWW)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.DistributeExpense)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RowTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RowTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.LastBuyInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.LastBuyDistributeSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.LastBuyDistributeSumSc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.LastBuyDistributeSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.StockDistributesumForeign)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.StockDistributesumSystem)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.StockDistributesum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.StockInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PickStatusEx)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPM)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPMFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPMSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CFOPCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CSTCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Usage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxOnly)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.BaseOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.LineStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PackageQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Text)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.LineType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.COGSAccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ChangeAssemlyBoMWarehouse)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossBuyPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossBase)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossProfitTotalBasePrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CostingCode2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CostingCode3)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CostingCode4)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CostingCode5)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ItemDetails)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.LocationCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RemainingOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.OpenAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.OpenAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.OpenAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ExLineNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RequiredDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RequiredQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode3)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode4)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.COGSCostingCode5)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CSTforIPI)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CSTforPIS)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CSTforCOFINS)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CreditOriginCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.WithoutInventoryMovement)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.AgreementNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.AgreementRowNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ActualBaseEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ActualBaseLine)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Surpluses)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.DefectAndBreakup)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Shortages)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ConsiderQuantity)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PartialRetirement)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RetirementQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RetirementAPC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ThirdParty)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PoNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PoItmNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ExpenseType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ReceiptNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ExpenseOperationType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossProfit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossProfitFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossProfitSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PriceSource)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.StgSeqNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.StgEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.StgDesc)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.UoMCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.InventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RemainingOpenInventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ParentLineNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.NatureOfTransaction)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.DestinationCountryForImport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.DestinationRegionForImport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.OriginCountryForExport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.OriginRegionForExport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ItemType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ChangeInventoryQuantityIndependently)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.FreeOfChargeBP)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.SACEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.HSNEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.NVECode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.IndEscala)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CtrSealQty)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CNJPMan)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.UFFiscalBenefitCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ReverseCharge)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ShipFromCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ShipFromDescription)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.OwnerCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.WeightOfRecycledPlastic)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PlasticPackageExemptionReason)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.LegalText)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.UnencumberedReason)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CUSplit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.ListNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RecognizedTaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BaseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BaseAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BaseAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocTotalFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocTotalSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DownPayment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DownPaymentAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DownPaymentAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DownPaymentAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DownPaymentPercentage)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PaidToDate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PaidToDateFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PaidToDateSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.RoundingDiffAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.RoundingDiffAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.RoundingDiffAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ServiceGrossProfitPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TotalDiscount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TotalDiscountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TotalDiscountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.VatPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.VatSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.VatSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.VatSumSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTAppliedFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTAppliedSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTExemptedAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTExemptedAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTExemptedAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTNonSubjectAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTNonSubjectAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WTNonSubjectAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.AddLegIn)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Address2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.AgentCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.AllocationNumberIL)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.AnnualInvoiceDeclarationReference)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ApplyCurrentVATRatesForDownPaymentsToDraw)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ApplyTaxOnFirstInstallment)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ArchiveNonremovableSalesQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.AssetValueDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ATDocumentType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.AuthorizationCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.AuthorizationStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BaseEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BillOfExchangeReserved)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BlanketAgreementNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BlockDunning)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Box1099)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BPChannelCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BPChannelContact)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BPLIDAssignedToInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.BPLName)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CancelDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Cancelled)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CancelStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CardName)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CentralBankIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CertificationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ClosingOption)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ClosingRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CommissionTrade)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CommissionTradeReturn)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Confirmed)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ControlAccount)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CreateOnlineQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CreateQRCodeFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.CustOffice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DANFELgTxt)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DateOfReportingControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocObjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocumentDelivery)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocumentsOwner)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocumentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocumentSubType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DocumentTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DownPaymentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.DownPaymentType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.EDocErrorCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.EDocErrorMessage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.EDocExportFormat)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.EDocGenerationType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.EDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.EDocSeries)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.EDocStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ElecCommMessage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ElecCommStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.EndDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.EndDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ETaxNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ETaxWebSite)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ExcludeFromTaxReportControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ExemptionValidityDateFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ExemptionValidityDateTo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ExternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.FatherCard)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.FatherType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.FCI)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.FiscalDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.FolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.FolioNumberFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.FolioNumberTo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.FolioPrefixString)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Form1099)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.GroupHandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.GroupNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.GroupSeries)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.GSTTransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.GTSChecker)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.GTSPayee)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.HandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ImportFileNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Indicator)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.InsuranceOperation347)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.InterimType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.InternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.InventoryStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.InvoicePayment)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.IsAlteration)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.IsPayToBank)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.JournalMemo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.LastPageFolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.LegTextF)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Letter)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ManualNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.MaximumCashDiscount)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.NetProcedure)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.NextCorrectingDocument)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.NotRelevantForMonthlyInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.NTSApproved)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.NTSApprovedNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.NumAtCard)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.OdataEtag)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.OpenForLandedCosts)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.OpeningRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.OriginalCreditOrDebitDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.OriginalCreditOrDebitNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.OriginalRefDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.OriginalRefNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PartialSupply)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PaymentBlock)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PaymentBlockEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PaymentMethod)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PaymentReference)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PayToBankAccountNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PayToBankBranch)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PayToBankCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PayToBankCountry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PayToCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PeriodIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Pick)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PickRemark)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PickStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PlasticPackagingTaxRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PointOfIssueCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.POSCashierNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.POSCashRegister)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.POSDailySummaryNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.POSEquipmentNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.POSManufacturerSerialNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.POSReceiptNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PriceMode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Printed)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PrintSEPADirect)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.PrivateKeyVersion)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Project)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Receiver)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Reference1)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Reference2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.RelatedEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Releaser)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.RelevantToGTS)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ReopenManuallyClosedOrCanceledDocument)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ReopenOriginalDocument)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ReportingSectionControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.RequriedDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Reserve)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ReserveInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ReuseDocumentNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ReuseNotaFiscalNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Revision)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.RevisionPo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Rounding)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SAPPassport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SequenceCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SequenceModel)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SequenceSerial)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ShipFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ShipPlace)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ShipState)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ShipToCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.ShowSCN)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SignatureDigest)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SignatureInputMessage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SOIWizardId)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SpecifiedClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.StartDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.StartDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.StartFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Submitted)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SubSeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.SummeryType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.Supplier)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TaxExemptionLetterNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TaxInvoiceDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TaxInvoiceNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TaxOnInstallments)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.TrackingNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.UpdateTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.UseBillToAddrToDetermineTax)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.UseCorrectionVATGroup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.UseShpdGoodsAct)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.VatDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.VATRegNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.VehiclePlate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice>()
				.Property(e => e.WareHouseUpdateType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ItemCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ItemDescription)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Quantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PriceAfterVAT)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Currency)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Rate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.VendorNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.SerialNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.WarehouseCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CommisionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TreeType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.AccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.UseBaseUnits)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.SupplierCatNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CostingCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.BarCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.VatGroup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Height1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Hight1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Height2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Height2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Lengh1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Lengh1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Lengh2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Lengh2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Weight1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Weight1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Weight2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Weight2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Factor1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Factor2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Factor3)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Factor4)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Volume)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.VolumeUnit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Width1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Width1Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Width2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Width2Unit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxLiable)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PickStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PickQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PickListIdNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.OriginalItem)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.BackOrder)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.FreeText)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.POTargetNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.POTargetEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.POTargetRowNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CorrectionInvoiceItem)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CorrInvAmountToStock)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CorrInvAmountToDiffAcct)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.AppliedTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.AppliedTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.AppliedTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.WTLiable)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.EqualizationTaxPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.NetTaxAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.NetTaxAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.NetTaxAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.MeasureUnit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.UnitsOfMeasurment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.LineTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxPercentagePerRow)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ConsumerSalesForecast)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ExciseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TotalInclTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CountryOrg)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.SWW)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.DistributeExpense)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RowTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RowTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.LastBuyInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.LastBuyDistributeSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.LastBuyDistributeSumSc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.LastBuyDistributeSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.StockDistributesumForeign)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.StockDistributesumSystem)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.StockDistributesum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.StockInmPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PickStatusEx)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxBeforeDPM)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxBeforeDPMFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxBeforeDPMSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CFOPCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CSTCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Usage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxOnly)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.BaseOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.LineStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PackageQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Text)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.LineType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.COGSCostingCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.COGSAccountCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ChangeAssemlyBoMWarehouse)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossBuyPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossBase)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossProfitTotalBasePrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CostingCode2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CostingCode3)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CostingCode4)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CostingCode5)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ItemDetails)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.LocationCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RemainingOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.OpenAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.OpenAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.OpenAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ExLineNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RequiredQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.COGSCostingCode2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.COGSCostingCode3)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.COGSCostingCode4)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.COGSCostingCode5)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CSTforIPI)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CSTforPIS)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CSTforCOFINS)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CreditOriginCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.WithoutInventoryMovement)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.AgreementNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.AgreementRowNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ActualBaseEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ActualBaseLine)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Surpluses)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.DefectAndBreakup)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Shortages)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ConsiderQuantity)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PartialRetirement)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RetirementQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RetirementAPC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ThirdParty)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PoNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PoItmNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ExpenseType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ReceiptNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ExpenseOperationType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossProfit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossProfitFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossProfitSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PriceSource)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.StgSeqNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.StgEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.StgDesc)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.UoMCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.InventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RemainingOpenInventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ParentLineNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Incoterms)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TransportMode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.NatureOfTransaction)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.DestinationCountryForImport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.DestinationRegionForImport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.OriginCountryForExport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.OriginRegionForExport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ItemType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ChangeInventoryQuantityIndependently)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.FreeOfChargeBP)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.SACEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.HSNEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossTotalFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossTotalSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.NVECode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.IndEscala)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CtrSealQty)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CNJPMan)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CESTCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.UFFiscalBenefitCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ReverseCharge)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ShipFromCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ShipFromDescription)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.OwnerCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.StandardItemIdentification)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CommodityClassification)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.WeightOfRecycledPlastic)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PlasticPackageExemptionReason)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.LegalText)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.UnencumberedReason)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CUSplit)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.ListNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RecognizedTaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BaseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BaseAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BaseAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocTotalFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocTotalSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DownPayment)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DownPaymentAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DownPaymentAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DownPaymentAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DownPaymentPercentage)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.RoundingDiffAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.RoundingDiffAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.RoundingDiffAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TotalDiscount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TotalDiscountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TotalDiscountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TotalEqualizationTax)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TotalEqualizationTaxFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TotalEqualizationTaxSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.VatPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.VatSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.VatSumFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.VatSumSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTAppliedFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTAppliedSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTExemptedAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTExemptedAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTExemptedAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTNonSubjectAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTNonSubjectAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WTNonSubjectAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.AddLegIn)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Address2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.AgentCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.AnnualInvoiceDeclarationReference)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ApplyCurrentVATRatesForDownPaymentsToDraw)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ApplyTaxOnFirstInstallment)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ArchiveNonremovableSalesQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.AssetValueDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ATDocumentType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.AuthorizationCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.AuthorizationStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BillOfExchangeReserved)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BlanketAgreementNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BlockDunning)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Box1099)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BPChannelCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BPChannelContact)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BPLIDAssignedToInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.BPLName)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CancelDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Cancelled)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CancelStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CardName)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CentralBankIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CertificationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ClosingOption)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ClosingRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CommissionTrade)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CommissionTradeReturn)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Confirmed)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ControlAccount)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CreateOnlineQuotation)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CreateQRCodeFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.CustOffice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DANFELgTxt)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DateOfReportingControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DeferredTax)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocObjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocumentDelivery)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocumentsOwner)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocumentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocumentSubType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DocumentTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DownPaymentStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.DownPaymentType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.EDocErrorCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.EDocErrorMessage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.EDocExportFormat)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.EDocGenerationType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.EDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.EDocSeries)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.EDocStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ElecCommMessage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ElecCommStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.EndDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.EndDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ETaxNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ETaxWebSite)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ExcludeFromTaxReportControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ExemptionValidityDateFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ExemptionValidityDateTo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ExternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.FatherCard)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.FatherType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.FCI)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.FederalTaxID)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.FiscalDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.FolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.FolioNumberFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.FolioNumberTo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.FolioPrefixString)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Form1099)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.GroupHandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.GroupNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.GroupSeries)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.GTSChecker)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.GTSPayee)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.HandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ImportFileNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Indicator)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.InsuranceOperation347)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.InterimType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.InternalCorrectedDocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.InventoryStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.IsAlteration)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.IsPayToBank)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.JournalMemo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.LastPageFolioNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.LegTextF)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Letter)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ManualNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.MaximumCashDiscount)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.NetProcedure)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.NextCorrectingDocument)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.NotRelevantForMonthlyInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.NTSApproved)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.NTSApprovedNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.NumAtCard)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.OdataEtag)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.OpenForLandedCosts)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.OpeningRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PartialSupply)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PaymentBlock)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PaymentBlockEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PaymentMethod)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PaymentReference)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PayToBankAccountNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PayToBankBranch)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PayToBankCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PayToBankCountry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PayToCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PeriodIndicator)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Pick)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PickRemark)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PickStatus)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PlasticPackagingTaxRelevant)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PointOfIssueCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.POSCashierNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.POSCashRegister)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.POSDailySummaryNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.POSEquipmentNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.POSManufacturerSerialNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.POSReceiptNo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PriceMode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Printed)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PrintSEPADirect)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.PrivateKeyVersion)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Project)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Receiver)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Reference1)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Reference2)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.RelatedEntry)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Releaser)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.RelevantToGTS)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ReopenManuallyClosedOrCanceledDocument)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ReopenOriginalDocument)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ReportingSectionControlStatementVAT)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.RequriedDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Reserve)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ReserveInvoice)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ReuseDocumentNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ReuseNotaFiscalNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.RevisionPo)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Rounding)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SAPPassport)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SequenceCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SequenceModel)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SequenceSerial)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ServiceGrossProfitPercent)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ShipFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ShipPlace)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ShipState)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ShipToCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.ShowSCN)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SignatureDigest)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SignatureInputMessage)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SpecifiedClosingDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.StartDeliveryDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.StartDeliveryTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.StartFrom)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Submitted)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SubSeriesString)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.SummeryType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.Supplier)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TaxExemptionLetterNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TaxOnInstallments)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TrackingNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.TransNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.UpdateTime)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.UseBillToAddrToDetermineTax)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.UseCorrectionVATGroup)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.UseShpdGoodsAct)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.VatDate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.VATRegNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.VehiclePlate)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseOrder>()
				.Property(e => e.WareHouseUpdateType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseQuotation>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseQuotation>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseQuotation>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseQuotation>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseQuotation>()
				.Property(e => e.DocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseQuotation>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseTaxInvoice>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseTaxInvoice>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseTaxInvoice>()
				.Property(e => e.DocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseTaxInvoice>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseTaxInvoiceLine>()
				.Property(e => e.RefEntry1)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseTaxInvoiceOperationCode>()
				.Property(e => e.OpCode)
				.IsUnicode(false);

			modelBuilder.Entity<Quotation>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<Quotation>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<Quotation>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<Quotation>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<Quotation>()
				.Property(e => e.DocNum)
				.IsUnicode(false);

			modelBuilder.Entity<Quotation>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<SalesTaxInvoice>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<SalesTaxInvoice>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<SalesTaxInvoice>()
				.Property(e => e.DocNum)
				.IsUnicode(false);

			modelBuilder.Entity<SalesTaxInvoice>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<SalesTaxInvoiceLine>()
				.Property(e => e.RefEntry1)
				.IsUnicode(false);

			modelBuilder.Entity<SalesTaxInvoiceOperationCode>()
				.Property(e => e.OpCode)
				.IsUnicode(false);

			modelBuilder.Entity<SapCode_QbAccountNumber_Mapping>()
				.Property(e => e.SapCode)
				.IsUnicode(false);

			modelBuilder.Entity<SapCode_QbAccountNumber_Mapping>()
				.Property(e => e.AccountNumber2)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.BoEValue)
				.HasPrecision(19, 4);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.GrossWeight)
				.HasPrecision(19, 4);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.NetWeight)
				.HasPrecision(19, 4);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.BillOfEntryDate)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.BillOfEntryNo)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.BlockB)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.BlockS)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.Brand)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.BuildingB)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.BuildingS)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.Carrier)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.CityB)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.CityS)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.ClaimRefund)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.CountryB)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.CountryS)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.County)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.CountyB)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.CountyS)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.DifferentialOfTaxRate)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.GlobalLocationNumberB)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.GlobalLocationNumberS)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.ImportOrExport)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.ImportOrExportType)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.Incoterms)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.IsIGSTAccount)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.MainUsage)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.NFRef)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.OriginalBillOfEntryDate)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.OriginalBillOfEntryNo)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.PackDescription)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.PackQuantity)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.PortCode)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.ShipUnitNo)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.State)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.StateB)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.StateS)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.StreetB)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.StreetS)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId0)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId1)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId12)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId13)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId14)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId2)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId3)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId4)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId5)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId6)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId7)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId8)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.TaxId9)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.Vehicle)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.VehicleState)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.ZipCodeB)
				.IsUnicode(false);

			modelBuilder.Entity<TaxExtension>()
				.Property(e => e.ZipCodeS)
				.IsUnicode(false);

			modelBuilder.Entity<TransactionCode>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<TransactionCode>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.HandWritten)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.Printed)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CardName)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.Address)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CashAccount)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.DocCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CashSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CheckAccount)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.TransferAccount)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.TransferSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.TransferReference)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.LocalCurrency)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.Reference1)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.Reference2)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CounterReference)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.Remarks)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.JournalRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.SplitTransaction)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.ContactPersonCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.ApplyVAT)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BankCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BankAccount)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.ProjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CurrencyIsLocal)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.DeductionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.DeductionSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CashSumFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CashSumSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BoeAccount)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BillOfExchangeAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BillofExchangeStatus)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BillOfExchangeAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BillOfExchangeAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BillOfExchangeAgent)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.WTCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.WTAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.WTAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.WTAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.WTAccount)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.WTTaxableAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.Proforma)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.PayToBankCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.PayToBankBranch)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.PayToBankAccountNo)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.PayToCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.PayToBankCountry)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.IsPayToBank)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.PaymentPriority)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.TaxGroup)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BankChargeAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BankChargeAmountInFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BankChargeAmountInSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.UnderOverpaymentdifference)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.UnderOverpaymentdiffSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.WtBaseSum)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.WtBaseSumFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.WtBaseSumSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.TransactionCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.PaymentType)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.TransferRealAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.DocObjectCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.DocTypte)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.LocationCode)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.Cancelled)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.ControlAccount)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.UnderOverpaymentdiffFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.AuthorizationStatus)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BPLID)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BPLName)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.VATRegNum)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.BlanketAgreement)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.PaymentByWTCertif)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.Cig)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.Cup)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.AttachmentEntry)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.SignatureInputMessage)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.SignatureDigest)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.CertificationNumber)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.PrivateKeyVersion)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.EDocExportFormat)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.ElecCommStatus)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.ElecCommMessage)
				.IsUnicode(false);

			modelBuilder.Entity<VendorPayment>()
				.Property(e => e.SplitVendorCreditRow)
				.IsUnicode(false);
		}
	}
}
