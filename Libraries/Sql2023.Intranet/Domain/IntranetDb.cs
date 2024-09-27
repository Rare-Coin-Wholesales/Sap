namespace Sql2023.Intranet.Domain
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;
	using Sql2023.Intranet.Domain.Logging;

	public partial class IntranetDb : DbContext
	{
		public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }
		public virtual DbSet<Invoice> Invoices { get; set; }
		public virtual DbSet<Log> Logs { get; set; }
		public virtual DbSet<OrderLineItem> OrderLineItems { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<SalesXRef> SalesXRefs { get; set; }
		public virtual DbSet<UnixCustomer> UnixCustomers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Invoice>()
				.Property(e => e.Cust_)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipToName1)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipToName2)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipToAddress1)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipToAddress2)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipToCity)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipToState)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipToZip)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Territory)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.SalesRep)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.Terms)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.OrderNumber)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.TaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.CustomerPO)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipVia)
				.IsUnicode(false);

			modelBuilder.Entity<Invoice>()
				.Property(e => e.ShipTracking)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.Cust_)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.ShipToName1)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.ShipToName2)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.ShipToAddress1)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.ShipToAddress2)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.ShipToCity)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.ShipToState)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.ShipToZip)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.Territory)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.SalesRep)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.Terms)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.TaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.SpecialInstructions)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.CustomerPO)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.ShipVia)
				.IsUnicode(false);

			modelBuilder.Entity<Order>()
				.Property(e => e.ShipTracking)
				.IsUnicode(false);

			modelBuilder.Entity<SalesXRef>()
				.Property(e => e.InsightSalesRep)
				.IsUnicode(false);

			modelBuilder.Entity<SalesXRef>()
				.Property(e => e.SalesRep)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustID)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustName)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustContact)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustAddress1)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustAddress2)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustCity)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustState)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustZip)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustTaxCode)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustPhone1)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustPhone2)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustReseller)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.CustTerms)
				.IsUnicode(false);

			modelBuilder.Entity<UnixCustomer>()
				.Property(e => e.GM_AccountNo)
				.IsUnicode(false);
		}
	}
}