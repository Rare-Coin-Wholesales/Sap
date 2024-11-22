namespace Web202209.SAP_ArrowAndBranchRareCoins.Domain
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class SAP_ArrowAndBranchRareCoinsDb : DbContext
	{
		public virtual DbSet<CreditNote> CreditNotes { get; set; }
		public virtual DbSet<CreditNote_DocumentLine> CreditNote_DocumentLine { get; set; }
		public virtual DbSet<PurchaseCreditNote> PurchaseCreditNotes { get; set; }
		public virtual DbSet<PurchaseCreditNote_DocumentLine> PurchaseCreditNote_DocumentLine { get; set; }
		public virtual DbSet<AccountSegmentationCategory> AccountSegmentationCategories { get; set; }
		public virtual DbSet<BPIntrastatExtension> BPIntrastatExtensions { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

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
				.Property(e => e.DocTotalFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.DocTotalSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.WTAppliedFC)
				.HasPrecision(19, 4);

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
				.Property(e => e.DownPayment)
				.HasPrecision(19, 4);

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
				.Property(e => e.RoundingDiffAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.RoundingDiffAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.RoundingDiffAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TotalDiscountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.TotalDiscountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaidToDate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaidToDateFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote>()
				.Property(e => e.PaidToDateSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Quantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PriceAfterVAT)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Rate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.CommisionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Height1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Height2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Lengh1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Lengh2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Weight1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Weight2)
				.HasPrecision(19, 4);

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
				.Property(e => e.Volume)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Width1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.Width2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PickQuantity)
				.HasPrecision(19, 4);

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
				.Property(e => e.ExciseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TotalInclTax)
				.HasPrecision(19, 4);

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
				.Property(e => e.TaxBeforeDPM)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPMFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPMSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.BaseOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.PackageQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossBuyPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.GrossProfitTotalBasePrice)
				.HasPrecision(19, 4);

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
				.Property(e => e.RequiredQuantity)
				.HasPrecision(19, 4);

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
				.Property(e => e.RetirementQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RetirementAPC)
				.HasPrecision(19, 4);

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
				.Property(e => e.ReturnCost)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.InventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<CreditNote_DocumentLine>()
				.Property(e => e.RemainingOpenInventoryQuantity)
				.HasPrecision(19, 4);

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
				.Property(e => e.CtrSealQty)
				.HasPrecision(19, 4);

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
				.Property(e => e.WeightOfRecycledPlastic)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocTotal)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocRate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

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
				.Property(e => e.DocTotalFc)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.DocTotalSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTApplied)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.WTAppliedFC)
				.HasPrecision(19, 4);

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
				.Property(e => e.DownPayment)
				.HasPrecision(19, 4);

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
				.Property(e => e.RoundingDiffAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.RoundingDiffAmountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.RoundingDiffAmountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TotalDiscountFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.TotalDiscountSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaidToDate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaidToDateFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote>()
				.Property(e => e.PaidToDateSys)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Quantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PriceAfterVAT)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Rate)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.DiscountPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.CommisionPercent)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Height1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Height2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Lengh1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Lengh2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Weight1)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.Weight2)
				.HasPrecision(19, 4);

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
				.Property(e => e.Width2)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PickQuantity)
				.HasPrecision(19, 4);

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
				.Property(e => e.ExciseAmount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxPerUnit)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TotalInclTax)
				.HasPrecision(19, 4);

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
				.Property(e => e.TaxBeforeDPM)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPMFC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.TaxBeforeDPMSC)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.BaseOpenQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.UnitPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.PackageQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossBuyPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.GrossProfitTotalBasePrice)
				.HasPrecision(19, 4);

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
				.Property(e => e.RequiredQuantity)
				.HasPrecision(19, 4);

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
				.Property(e => e.RetirementQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RetirementAPC)
				.HasPrecision(19, 4);

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
				.Property(e => e.InventoryQuantity)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.RemainingOpenInventoryQuantity)
				.HasPrecision(19, 4);

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
				.Property(e => e.CtrSealQty)
				.HasPrecision(19, 4);

			modelBuilder.Entity<PurchaseCreditNote_DocumentLine>()
				.Property(e => e.WeightOfRecycledPlastic)
				.HasPrecision(19, 4);

			modelBuilder.Entity<AccountSegmentationCategory>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<AccountSegmentationCategory>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<AccountSegmentationCategory>()
				.Property(e => e.ShortName)
				.IsUnicode(false);
		}
	}
}
