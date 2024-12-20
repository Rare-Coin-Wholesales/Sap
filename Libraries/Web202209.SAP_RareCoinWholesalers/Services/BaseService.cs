using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Sap.Core;
using Sap.Services.Security;
using Web202209.SAP_RareCoinWholesalers.Domain;

namespace Web202209.SAP_RareCoinWholesalers.Services
{
	/// <summary>
	/// Base service
	/// </summary>
	public abstract partial class BaseService
	{
		protected readonly IEncryptionUtil _encryptionUtil;
		protected readonly SAP_RareCoinWholesalersDb _dbContext;
		protected readonly string _connectionString;

		/// <summary>
		/// Constructor
		/// </summary>
		public BaseService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Web202209.SAP_RareCoinWholesalers"));
			_dbContext = new SAP_RareCoinWholesalersDb(_connectionString);
		}

		#region Utilities
		protected string GetColumnMapping(DataColumn column)
		{
			if (column == null || String.IsNullOrWhiteSpace(column.ColumnName))
				return string.Empty;

			var col = column.ColumnName.ToUpper();

			switch (col) {
				case "BPLIDASSIGNEDTOINVOICE":
					return "BPL_IDAssignedToInvoice";
				case "ODATAETAG":
					return "odataetag";
				case "POSCASHREGISTER":
					return "POS_CashRegister";
				default:
					return column.ColumnName;
			}
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
		#endregion

		public virtual void CheckColumnMappings(DataTable sourceDt, string destSchema, string destTable)
		{
			var sb = new StringBuilder();
			var cmdText = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '{destSchema}' AND TABLE_NAME = N'{destTable}'";

			try {
				using (var conn = new SqlConnection(_connectionString)) {
					using (SqlCommand command = new SqlCommand(cmdText, conn)) {
						var columnNames = new DataTable();
						conn.Open();
						columnNames.Load(command.ExecuteReader());
						var i = 0;
						string columnNameInDB;

						foreach (DataColumn column in sourceDt.Columns) {
							columnNameInDB = columnNames.Rows[i++]["COLUMN_NAME"].ToString();

							if (columnNameInDB != column.ColumnName)
								sb.AppendLine($"{column.ColumnName} != {columnNameInDB}");
						}
					}
				}

				File.WriteAllText($"C:/Logs/SAP Automation/{DateTime.Now:yyyy MM}/{DateTime.Now:dd}/CheckColumnMappings().txt", sb.ToString());
			}

			#region catch (Exception ex)
			catch (Exception ex) {
				throw new Exception(GetFullErrorText(ex, "CheckColumnMappings(DataTable sourceDt, string destSchema, string destTable)"));
			}
			#endregion

		}

		/// <summary>
		/// Truncates a table.
		/// </summary>
		/// <param name="table">The table to truncate.</param>
		public virtual void TruncateTable(string table)
		{
			TruncateTable("dbo", table);
		}

		/// <summary>
		/// Truncates a table.
		/// </summary>
		/// <param name="schema">The schema of the table to truncate.</param>
		/// <param name="table">The table to truncate.</param>
		/// <exception cref="ArgumentException"></exception>
		public virtual void TruncateTable(string schema, string table)
		{
			if (String.IsNullOrWhiteSpace(schema))
				throw new ArgumentException("'schema' is required.", schema);
			if (String.IsNullOrWhiteSpace(table))
				throw new ArgumentException("'table' is required.", table);

			_dbContext.Database.ExecuteSqlCommand($"TRUNCATE TABLE [{schema}].[{table}]");
		}

		/// <summary>
		/// Tries to perform <see cref="SqlBulkCopy"/> to fast-import a <see cref="DataTable"/> into a SQL table.
		/// </summary>
		/// <param name="dt">The <see cref="DataTable"/> to import.</param>
		/// <param name="destinationTableName">The destination table name to insert into.</param>
		/// <param name="errorMessage">The output error message if any. Otherwise, empty string.</param>
		public virtual bool TryBulkCopy(DataTable dt, string destinationTableName, out string errorMessage)
		{
			#region Log
			errorMessage = "";

			if (dt == null)
				errorMessage = $"{errorMessage}dt is null.{Environment.NewLine}";
			else if (dt.Rows.Count < 1)
				return true;

			if (String.IsNullOrWhiteSpace(destinationTableName))
				errorMessage = $"{errorMessage}destinationTableName is required.{Environment.NewLine}";
			else
				destinationTableName = destinationTableName.Trim();

			if (!String.IsNullOrWhiteSpace(errorMessage))
				return false;
			#endregion

			try {
				using (var conn = new SqlConnection(_connectionString)) {
					conn.Open();
					using (var sbc = new SqlBulkCopy(conn)) {
						sbc.DestinationTableName = destinationTableName;
						sbc.BulkCopyTimeout = 300;

						foreach (DataColumn column in dt.Columns) {
							try {
								sbc.ColumnMappings.Add(column.ColumnName, GetColumnMapping(column));
							}

							#region catch (Exception ex)
							catch (Exception ex) {
								errorMessage = GetFullErrorText(ex, $"column: {column}");
								return false;
							}
							#endregion
						}

						sbc.WriteToServer(dt);
					}
				}

				return true;
			}

			#region catch (Exception ex)
			catch (Exception ex) {
				errorMessage = GetFullErrorText(ex, "TryBulkCopy(DataTable dt, string destinationTableName, out string errorMessage)");
				return false;
			}
			#endregion
		}
	}
}