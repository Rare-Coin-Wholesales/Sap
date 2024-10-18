using Sap.Core;
using Sap.Services.Security;
using Sql2023.WwwSPs.Domain;

namespace Sql2023.WwwSPs.Services
{
	/// <summary>
	/// Base service
	/// </summary>
	public abstract partial class BaseService
	{
		protected readonly IEncryptionUtil _encryptionUtil;
		protected readonly WwwSPsDb _dbContext;
		protected readonly string _connectionString;

		/// <summary>
		/// Constructor
		/// </summary>
		public BaseService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Sql2023.WwwSPs"));
			_dbContext = new WwwSPsDb(_connectionString);
		}
	}
}