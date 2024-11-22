using System.Data.Entity;

namespace Web202209.SAP_RareCoinWholesalers.Domain
{
	public partial class SAP_RareCoinWholesalersDb : DbContext
	{
		public SAP_RareCoinWholesalersDb(string connectionString) : base(connectionString) { }
	}
}