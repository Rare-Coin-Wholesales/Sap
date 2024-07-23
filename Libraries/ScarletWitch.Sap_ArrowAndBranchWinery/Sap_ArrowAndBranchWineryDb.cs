using System.Data.Entity;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Domain
{
	public partial class Sap_ArrowAndBranchWineryDb : DbContext
	{
		public Sap_ArrowAndBranchWineryDb(string connectionString) : base(connectionString) { }
	}
}