using System.Data.Entity;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain
{
	public partial class Sap_ArrowAndBranchRareCoinsDb : DbContext
	{
		public Sap_ArrowAndBranchRareCoinsDb(string connectionString) : base(connectionString) { }
	}
}