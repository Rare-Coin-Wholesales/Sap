using System;
using System.Data.Entity.Validation;
using Sap.Core;
using Sap.Core.Services.Security;
using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services
{
	/// <summary>
	/// Base service.
	/// </summary>
	public abstract class BaseService
	{
		protected EncryptionUtil _encryptionUtil;
		protected Sap_ArrowAndBranchWineryDb _dbContext;
		protected string ConnectionString;

		/// <summary>
		/// Constructor
		/// </summary>
		public BaseService()
		{
			_encryptionUtil = new EncryptionUtil();
			ConnectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("ScarletWitch.Sap_ArrowAndBranchWinery"));
			_dbContext = new Sap_ArrowAndBranchWineryDb(ConnectionString);
		}

		/// <summary>
		/// Converts an <see cref="Exception"/> to a standardized error message.
		/// It has the ability to get SQL Validation errors and displays those as well.
		/// </summary>
		/// <param name="ex">The <see cref="Exception"/>.</param>
		protected string GetFullErrorText(Exception ex)
		{
			var msg = String.Empty;

			if (ex is DbEntityValidationException dbEx) {
				foreach (var validationErrors in dbEx.EntityValidationErrors)
					foreach (var er in validationErrors.ValidationErrors)
						msg = String.Format("{0}Property: {1} Error: {2}{3}", msg, er.PropertyName, er.ErrorMessage, Environment.NewLine);

				return msg;
			}

			else if (ex.InnerException == null) {
				msg = String.Format($"{msg}{ex.Message}{Environment.NewLine}");
				msg = String.Format($"{msg}{ex}{Environment.NewLine}{Environment.NewLine}");
				return msg;
			}

			return msg;
		}

		/// <summary>
		/// Truncates a table.
		/// </summary>
		/// <param name="table">The table to truncate.</param>
		protected virtual void TruncateTable(string table)
		{
			if (String.IsNullOrWhiteSpace(table))
				throw new ArgumentException("'table' is required.", table);

			_dbContext.Database.ExecuteSqlCommand($"TRUNCATE TABLE [SAP_ArrowAndBranchWinery].[dbo].[{table}]");
		}
	}
}