using System;
using System.Collections.Generic;
using System.Linq;
using Sap.Core;
using Sap.Services.Security;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.CompanyNamePartials;

namespace Sql2023.Intranet.Services.UnixCustomers
{
	/// <summary>
	/// UnixCustomer service
	/// </summary>
	public partial class UnixCustomerService : IUnixCustomerService
	{
		private readonly ICompanyNamePartialService _companyNamePartialService;
		private readonly IEncryptionUtil _encryptionUtil;
		private readonly IntranetDb _dbContext;
		private readonly string _connectionString;

		/// <summary>
		/// Ctor
		/// </summary>
		public UnixCustomerService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Sql2023.Intranet"));
			_companyNamePartialService = new CompanyNamePartialService();
			_dbContext = new IntranetDb(_connectionString);
		}

		/// <inheritdoc/>
		public virtual string DetermineBpType(string id, string name)
		{
			if (String.IsNullOrWhiteSpace(id))
				return "C";
			if (_companyNamePartialService.ContainsPartial(name))
				return "S";
			if (long.TryParse(id, out _))
				return "C";

			return "S";
		}

		/// <inheritdoc/>
		public virtual IList<UnixCustomer> GetAll()
		{
			return (from x in _dbContext.UnixCustomers
					select x).ToList();
		}
	}
}