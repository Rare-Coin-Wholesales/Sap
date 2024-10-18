using System.Data.Entity;

namespace Sql2023.WwwSPs.Domain
{
	public partial class WwwSPsDb : DbContext
	{
		public WwwSPsDb(string connectionString) : base(connectionString) { }
	}
}