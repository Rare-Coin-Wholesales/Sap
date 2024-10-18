using Sap.Core;
using Sap.Services.Security;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services
{
	/// <summary>
	/// Base service
	/// </summary>
	public abstract partial class BaseService
	{
		protected readonly IEncryptionUtil _encryptionUtil;
		protected readonly IntranetDb _dbContext;
		protected readonly string _connectionString;

		/// <summary>
		/// Constructor
		/// </summary>
		public BaseService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Sql2023.Intranet"));
			_dbContext = new IntranetDb(_connectionString);
		}
	}
}