using System.Data.Entity;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Domain
{
	public partial class SAP_ArrowAndBranchRareCoinsDb : DbContext
	{
		public SAP_ArrowAndBranchRareCoinsDb(string connectionString) : base(connectionString) { }
	}
}