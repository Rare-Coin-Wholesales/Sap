namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Sap_ArrowAndBranchWineryDb : DbContext
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
		public virtual DbSet<Deposit> Deposits { get; set; }
		public virtual DbSet<DocumentInstallment> DocumentInstallments { get; set; }
		public virtual DbSet<DocumentLine> DocumentLines { get; set; }
		public virtual DbSet<DownPaymentsToDraw> DownPaymentsToDraws { get; set; }
		public virtual DbSet<DownPaymentsToDrawDetail> DownPaymentsToDrawDetails { get; set; }
		public virtual DbSet<EWayBillDetail> EWayBillDetails { get; set; }
		public virtual DbSet<FAAccountDetermination> FAAccountDeterminations { get; set; }
		public virtual DbSet<GLAccountAdvancedRule> GLAccountAdvancedRules { get; set; }
		public virtual DbSet<HouseBankAccount> HouseBankAccounts { get; set; }
		public virtual DbSet<IncomingPayment> IncomingPayments { get; set; }
		public virtual DbSet<Invoice> Invoices { get; set; }
		public virtual DbSet<Invoice_DocumentLine> Invoice_DocumentLine { get; set; }
		public virtual DbSet<Item> Items { get; set; }
		public virtual DbSet<JournalEntry> JournalEntries { get; set; }
		public virtual DbSet<JournalEntryDocumentType> JournalEntryDocumentTypes { get; set; }
		public virtual DbSet<JournalEntryLine> JournalEntryLines { get; set; }
		public virtual DbSet<LineTaxJurisdiction> LineTaxJurisdictions { get; set; }
		public virtual DbSet<PaymentCheck> PaymentChecks { get; set; }
		public virtual DbSet<PaymentDocumentReferencesCollection> PaymentDocumentReferencesCollections { get; set; }
		public virtual DbSet<PaymentInvoice> PaymentInvoices { get; set; }
		public virtual DbSet<PurchaseCreditNote> PurchaseCreditNotes { get; set; }
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

			modelBuilder.Entity<CashFlowAssignment>()
				.Property(e => e.AmountLC)
				.IsUnicode(false);

			modelBuilder.Entity<CashFlowAssignment>()
				.Property(e => e.PaymentMeans)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocNum)
				.IsUnicode(false);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocType)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DepositAccount)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DepositNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.DepositType)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.JournalRemarks)
				.IsUnicode(false);

			modelBuilder.Entity<Deposit>()
				.Property(e => e.VoucherAccount)
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

			modelBuilder.Entity<JournalEntryDocumentType>()
				.Property(e => e.JournalEntryType)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryDocumentType>()
				.Property(e => e.DocTypeDescription)
				.IsUnicode(false);

			modelBuilder.Entity<JournalEntryDocumentType>()
				.Property(e => e.ShortName)
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

			modelBuilder.Entity<PaymentDocumentReferencesCollection>()
				.Property(e => e.ExternalReferencedDocNumber)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentDocumentReferencesCollection>()
				.Property(e => e.ReferencedObjectType)
				.IsUnicode(false);

			modelBuilder.Entity<PaymentDocumentReferencesCollection>()
				.Property(e => e.Remark)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.CardCode)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Comments)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.Description)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocNum)
				.IsUnicode(false);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocType)
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
				.Property(e => e.Quantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PriceAfterVAT)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Rate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.CommisionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Height1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Height2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Lengh1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Lengh2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Weight1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Weight2)
				.HasPrecision(19, 4);

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
				.Property(e => e.Width1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.Width2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PickQuantity)
				.HasPrecision(19, 4);

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
				.Property(e => e.ExciseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TotalInclTax)
				.HasPrecision(19, 4);

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
				.Property(e => e.TaxBeforeDPM)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxBeforeDPMFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.TaxBeforeDPMSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.BaseOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.PackageQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossBuyPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.GrossProfitTotalBasePrice)
				.HasPrecision(19, 4);

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
				.Property(e => e.RequiredQuantity)
				.HasPrecision(19, 4);

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
				.Property(e => e.RetirementQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RetirementAPC)
				.HasPrecision(19, 4);

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
				.Property(e => e.InventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.RemainingOpenInventoryQuantity)
				.HasPrecision(19, 4);

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
				.Property(e => e.CtrSealQty)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseInvoice_DocumentLine>()
				.Property(e => e.WeightOfRecycledPlastic)
				.HasPrecision(19, 4);

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
		}
	}
}
