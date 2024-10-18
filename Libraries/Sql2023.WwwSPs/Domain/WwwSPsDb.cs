namespace Sql2023.WwwSPs.Domain
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class WwwSPsDb : DbContext
	{
		public virtual DbSet<NtaCoinException> NtaCoinExceptions { get; set; }
		public virtual DbSet<PerformanceSummary> PerformanceSummaries { get; set; }
		public virtual DbSet<ReloadStatus> ReloadStatuses { get; set; }
		public virtual DbSet<TradingAccount> TradingAccounts { get; set; }
		public virtual DbSet<TradingAccountSummary> TradingAccountSummaries { get; set; }
		public virtual DbSet<TradingAccountTransaction> TradingAccountTransactions { get; set; }
		public virtual DbSet<TradingAccountTransactionHide> TradingAccountTransactionHides { get; set; }
		public virtual DbSet<UnrealizedProfit> UnrealizedProfits { get; set; }
		public virtual DbSet<TradingAccountTransactionBasisVoid> TradingAccountTransactionBasisVoids { get; set; }
		public virtual DbSet<TradingAccountTransactionDeleted> TradingAccountTransactionDeleteds { get; set; }
		public virtual DbSet<NtaClientNameEmail> NtaClientNameEmails { get; set; }
		public virtual DbSet<NtaCoin> NtaCoins { get; set; }
		public virtual DbSet<NTACoinAutoReloadOnly> NTACoinAutoReloadOnlies { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.InsightCustomerId)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.CertNumber)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.GradingService)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.Grade)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.PurchaseDocumentId)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.SoldDocumentId)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.PurchasePrice)
				.HasPrecision(18, 0);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.ProRataSoldPrice)
				.HasPrecision(18, 0);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.SoldPrice)
				.HasPrecision(18, 0);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.WholesalePrice)
				.HasPrecision(18, 0);

			modelBuilder.Entity<NtaCoinException>()
				.Property(e => e.Designation)
				.IsUnicode(false);

			modelBuilder.Entity<PerformanceSummary>()
				.Property(e => e.TimeWeightedReturn)
				.HasPrecision(18, 7);

			modelBuilder.Entity<ReloadStatus>()
				.Property(e => e.ReloadStatus1)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccount>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccount>()
				.Property(e => e.InsightCustomerId)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccount>()
				.Property(e => e.ReloadStatus)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.InsightCustomerID)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.InitialBasis)
				.HasPrecision(16, 2);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.CurrentBasis)
				.HasPrecision(16, 2);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.TotalProfit)
				.HasPrecision(16, 2);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.TotalDistribution)
				.HasPrecision(16, 2);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.RateOfReturn)
				.HasPrecision(9, 9);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.AnnualizedRateOfReturn)
				.HasPrecision(9, 9);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.BasisInCoins)
				.HasPrecision(16, 2);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.UninvestedCashOnAccount)
				.HasPrecision(16, 2);

			modelBuilder.Entity<TradingAccountSummary>()
				.Property(e => e.TotalAccountBalance)
				.HasPrecision(16, 2);

			modelBuilder.Entity<TradingAccountTransaction>()
				.Property(e => e.Id)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransaction>()
				.Property(e => e.InsightCustomerId)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransaction>()
				.Property(e => e.DocumentId)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransaction>()
				.Property(e => e.CheckVoucherId)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransaction>()
				.Property(e => e.PaymentTerms)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransaction>()
				.Property(e => e.TransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransaction>()
				.Property(e => e.TransactionSubtype)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransaction>()
				.Property(e => e.DescriptiveType)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionHide>()
				.Property(e => e.InsightCustomerId)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionHide>()
				.Property(e => e.DocumentId)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<UnrealizedProfit>()
				.Property(e => e.AccountId)
				.IsUnicode(false);

			modelBuilder.Entity<UnrealizedProfit>()
				.Property(e => e.UnrealizedProfitPercent)
				.HasPrecision(18, 7);

			modelBuilder.Entity<TradingAccountTransactionBasisVoid>()
				.Property(e => e.Id)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionBasisVoid>()
				.Property(e => e.InsightCustomerId)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionBasisVoid>()
				.Property(e => e.DocumentId)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionBasisVoid>()
				.Property(e => e.CheckVoucherId)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionBasisVoid>()
				.Property(e => e.PaymentTerms)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionBasisVoid>()
				.Property(e => e.TransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionBasisVoid>()
				.Property(e => e.TransactionSubtype)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionBasisVoid>()
				.Property(e => e.DescriptiveType)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionDeleted>()
				.Property(e => e.Id)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionDeleted>()
				.Property(e => e.InsightCustomerId)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionDeleted>()
				.Property(e => e.DocumentId)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionDeleted>()
				.Property(e => e.CheckVoucherId)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionDeleted>()
				.Property(e => e.PaymentTerms)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionDeleted>()
				.Property(e => e.TransactionType)
				.IsUnicode(false);

			modelBuilder.Entity<TradingAccountTransactionDeleted>()
				.Property(e => e.TransactionSubtype)
				.IsUnicode(false);

			modelBuilder.Entity<NtaClientNameEmail>()
				.Property(e => e.InsightCustomerId)
				.IsUnicode(false);

			modelBuilder.Entity<NtaClientNameEmail>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<NtaClientNameEmail>()
				.Property(e => e.Email)
				.IsUnicode(false);

			modelBuilder.Entity<NtaClientNameEmail>()
				.Property(e => e.ReloadStatus)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoin>()
				.Property(e => e.InsightCustomerId)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoin>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoin>()
				.Property(e => e.CertNumber)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoin>()
				.Property(e => e.GradingService)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoin>()
				.Property(e => e.Grade)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoin>()
				.Property(e => e.PurchaseDocumentId)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoin>()
				.Property(e => e.SoldDocumentId)
				.IsUnicode(false);

			modelBuilder.Entity<NtaCoin>()
				.Property(e => e.Designation)
				.IsUnicode(false);

			modelBuilder.Entity<NTACoinAutoReloadOnly>()
				.Property(e => e.Class)
				.IsUnicode(false);

			modelBuilder.Entity<NTACoinAutoReloadOnly>()
				.Property(e => e.Grade)
				.IsUnicode(false);

			modelBuilder.Entity<NTACoinAutoReloadOnly>()
				.Property(e => e.Description1)
				.IsUnicode(false);

			modelBuilder.Entity<NTACoinAutoReloadOnly>()
				.Property(e => e.Description2)
				.IsUnicode(false);

			modelBuilder.Entity<NTACoinAutoReloadOnly>()
				.Property(e => e.Service)
				.IsUnicode(false);

			modelBuilder.Entity<NTACoinAutoReloadOnly>()
				.Property(e => e.ConsignmentVendor)
				.IsUnicode(false);

			modelBuilder.Entity<NTACoinAutoReloadOnly>()
				.Property(e => e.Notes)
				.IsUnicode(false);
		}
	}
}
