using System.Collections.Generic;
using System.Linq;
using Sap.Core;
using Sap.Services.Security;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.UnixCustomers
{
	/// <summary>
	/// UnixCustomer service
	/// </summary>
	public partial class UnixCustomerService : IUnixCustomerService
	{
		private readonly EncryptionUtil _encryptionUtil;
		private readonly IntranetDb _dbContext;
		private readonly string _connectionString;

		/// <summary>
		/// Ctor
		/// </summary>
		public UnixCustomerService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Sql2023.Intranet"));
			_dbContext = new IntranetDb(_connectionString);
		}

		/// <inheritdoc/>
		public virtual IList<UnixCustomer> GetAll()
		{
			return (from x in _dbContext.UnixCustomers
					select x).ToList();
		}
	}
}