using System.Data.Entity;

namespace ScarletWitch.Sap_RareCoinWholesalers.Domain
{
	public partial class Sap_RareCoinWholesalersDb : DbContext
	{
		public Sap_RareCoinWholesalersDb(string connectionString) : base(connectionString) { }
	}
}