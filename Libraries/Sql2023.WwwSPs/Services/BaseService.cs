using System;
using System.Data.Entity.Validation;
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

		/// <summary>
		/// Gets the full error text. This supports errors reported by SQL.
		/// </summary>
		/// <param name="ex">The <see cref="Exception"/>.</param>
		protected string GetFullErrorText(Exception ex)
		{
			return GetFullErrorText(ex, null);
		}

		/// <summary>
		/// Gets the full error text. This supports errors reported by SQL.
		/// </summary>
		/// <param name="ex">The <see cref="Exception"/>.</param>
		/// <param name="methodName">The calling method's name.</param>
		protected string GetFullErrorText(Exception ex, string methodName)
		{
			var msg = string.Empty;
			var methodLine = String.IsNullOrWhiteSpace(methodName) ? string.Empty
																   : $"Exception thrown in {methodName}.{Environment.NewLine}{Environment.NewLine}";

			if (ex is DbEntityValidationException dbEx) {
				foreach (var valErrors in dbEx.EntityValidationErrors)
					foreach (var er in valErrors.ValidationErrors)
						msg = $"{msg}Property: {er.PropertyName} Error: {er.ErrorMessage}{Environment.NewLine}";

				msg = $"{msg}{methodLine}";
			}

			else if (ex.InnerException == null) {
				msg = $"{msg}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
				msg = $"{msg}{methodLine}";
				msg = $"{msg}{ex}{Environment.NewLine}{Environment.NewLine}";
			}

			else
				msg = GetFullErrorText(ex.InnerException, methodName);

			return msg;
		}
	}
}