using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
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

		protected string GetDbEntityValidationExceptionMessage(DbEntityValidationException dbEx)
		{
			var msg = string.Empty;
			var list = new List<DbValidationError>();

			foreach (var valErrors in dbEx.EntityValidationErrors)
				list.AddRange(valErrors.ValidationErrors);

			var temp = list.Select(x => new { x.PropertyName, x.ErrorMessage }).Distinct().ToList();

			foreach (var er in temp)
				msg = $"{msg}Property: {er.PropertyName} Error: {er.ErrorMessage}{Environment.NewLine}";

			return msg;
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
				msg = GetDbEntityValidationExceptionMessage(dbEx);
				msg = $"{msg}{methodLine}";
			}

			else if (ex.InnerException == null) {
				var temp = ex.ToString().Length <= 1000 ? ex.ToString()
														: ex.ToString().Substring(0,1000);
				msg = $"{msg}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
				msg = $"{msg}{methodLine}";
				msg = $"{msg}{temp}{Environment.NewLine}{Environment.NewLine}";
			}

			else
				msg = GetFullErrorText(ex.InnerException, methodName);

			return msg;
		}
	}
}