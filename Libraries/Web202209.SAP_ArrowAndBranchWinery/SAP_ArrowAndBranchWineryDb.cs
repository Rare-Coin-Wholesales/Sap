using System.Data.Entity;

namespace Web202209.SAP_ArrowAndBranchWinery.Domain
{
	public partial class SAP_ArrowAndBranchWineryDb : DbContext
	{
		public SAP_ArrowAndBranchWineryDb(string connectionString) : base(connectionString) { }
	}
}