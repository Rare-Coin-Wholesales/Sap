using System.Data.Entity;

namespace Sql2023.Intranet.Domain
{
	public partial class IntranetDb : DbContext
	{
		public IntranetDb(string connectionString) : base(connectionString) { }
	}
}