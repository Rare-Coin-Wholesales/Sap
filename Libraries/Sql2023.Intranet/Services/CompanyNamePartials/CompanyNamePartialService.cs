using System;
using System.Collections.Generic;
using System.Linq;
using Sap.Core;
using Sap.Services.Security;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.CompanyNamePartials
{
	/// <summary>
	/// CompanyNamePartial service
	/// </summary>
	public partial class CompanyNamePartialService : ICompanyNamePartialService
	{
		private readonly EncryptionUtil _encryptionUtil;
		private readonly IntranetDb _dbContext;
		private readonly string _connectionString;
		private static DateTime LastGetTime;
		private static IList<string> CompanyNamePartials;

		/// <summary>
		/// Ctor
		/// </summary>
		public CompanyNamePartialService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Sql2023.Intranet"));
			_dbContext = new IntranetDb(_connectionString);
			LastGetTime = DateTime.MinValue;
		}

		/// <inheritdoc/>
		public virtual bool ContainsPartial(string name)
		{
			if (String.IsNullOrWhiteSpace(name))
				return false;

			GetAll();

			foreach (var partial in CompanyNamePartials) {
				if (name.IndexOf(partial, StringComparison.OrdinalIgnoreCase) > -1)
					return true;
			}

			return false;
		}

		/// <inheritdoc/>
		public virtual IList<string> GetAll()
		{
			if (LastGetTime < DateTime.UtcNow.AddMinutes(-20)) {
				CompanyNamePartials = (from x in _dbContext.CompanyNamePartials
									   select x.Name).ToList();
				LastGetTime = DateTime.UtcNow;
			}

			return CompanyNamePartials;
		}
	}
}