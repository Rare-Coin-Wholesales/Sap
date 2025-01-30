namespace Web202209.SAP_ArrowAndBranchWinery.Domain
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class SAP_ArrowAndBranchWineryDb : DbContext
	{
		public virtual DbSet<AccountSegmentationCategory> AccountSegmentationCategories { get; set; }
		public virtual DbSet<BPIntrastatExtension> BPIntrastatExtensions { get; set; }
		public virtual DbSet<CreditNote> CreditNotes { get; set; }
		public virtual DbSet<CreditNote_DocumentLine> CreditNote_DocumentLine { get; set; }
		public virtual DbSet<PurchaseCreditNote> PurchaseCreditNotes { get; set; }
		public virtual DbSet<PurchaseCreditNote_DocumentLine> PurchaseCreditNote_DocumentLine { get; set; }
		public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
		public virtual DbSet<PurchaseInvoice_DocumentLine> PurchaseInvoice_DocumentLine { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AccountSegmentationCategory>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<AccountSegmentationCategory>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<AccountSegmentationCategory>()
				.Property(e => e.ShortName)
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
		}
	}
}
