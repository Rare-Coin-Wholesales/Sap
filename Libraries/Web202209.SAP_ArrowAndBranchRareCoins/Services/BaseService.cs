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
using Web202209.SAP_ArrowAndBranchRareCoins.Domain;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services
{
	/// <summary>
	/// Base service
	/// </summary>
	public abstract partial class BaseService
	{
		protected readonly IEncryptionUtil _encryptionUtil;
		protected readonly SAP_ArrowAndBranchRareCoinsDb _dbContext;
		protected readonly string _connectionString;

		/// <summary>
		/// Constructor
		/// </summary>
		public BaseService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Web202209.SAP_ArrowAndBranchRareCoins"));
			_dbContext = new SAP_ArrowAndBranchRareCoinsDb(_connectionString);
		}

		#region Utilities
		protected string GetColumnMapping(DataColumn column, string destinationTableName)
		{
			if (column == null || String.IsNullOrWhiteSpace(column.ColumnName))
				return string.Empty;

			var col = column.ColumnName.ToUpper();

			switch (col) {
				case "BPLIDASSIGNEDTOINVOICE":
					if (destinationTableName.Equals("Import.CreditNote") || destinationTableName.Equals("Import.PurchaseCreditNote"))
						return "BPL_IDAssignedToInvoice";
					return "BPLIDAssignedToInvoice";
				case "ODATAETAG":
					if (destinationTableName.Equals("Import.CreditNote") || destinationTableName.Equals("Import.PurchaseCreditNote"))
						return "odataetag";
					return "OdataEtag";
				case "POSCASHREGISTER":
					if (destinationTableName.Equals("Import.CreditNote") || destinationTableName.Equals("Import.PurchaseCreditNote"))
						return "POS_CashRegister";
					return "POSCashRegister";
				default:
					return column.ColumnName;
			}
		}

		/// <summary>
		/// Gets all validation errors from SQL.
		/// </summary>
		/// <param name="ex">The DbEntityValidationException.</param>
		protected string GetFullErrorText(DbEntityValidationException ex)
		{
			var msg = string.Empty;
			var list = new List<DbValidationError>();

			foreach (var er in ex.EntityValidationErrors)
				list.AddRange(er.ValidationErrors);

			var temp = list.Select(x => new { x.PropertyName, x.ErrorMessage }).Distinct().ToList();

			foreach (var er in temp)
				msg = $"{msg}Property: {er.PropertyName} Error: {er.ErrorMessage}{Environment.NewLine}";

			return $"{msg}{Environment.NewLine}";
		}

		/// <summary>
		/// Gets a standardized error message for an Exception.
		/// </summary>
		/// <param name="ex">The Exception.</param>
		/// <param name="additionalInfo">Any additional info you want to inject into the returned message.</param>
		protected string GetFullErrorText(Exception ex, string additionalInfo)
		{
			var additionalLine = String.IsNullOrWhiteSpace(additionalInfo) ? string.Empty
																		   : $"{additionalInfo}{Environment.NewLine}{Environment.NewLine}";
			if (ex is DbEntityValidationException dbEx)
				return $"{GetFullErrorText(dbEx)}{additionalLine}";

			if (ex.InnerException == null) {
				var temp = ex.ToString().Length > 1000 ? ex.ToString().Substring(0, 1000)
													   : ex.ToString();

				var msg = $"{ex.Message}{Environment.NewLine}{Environment.NewLine}";
				msg = $"{msg}{additionalLine}";
				return $"{msg}{temp}{Environment.NewLine}{Environment.NewLine}";
			}

			return GetFullErrorText(ex.InnerException, additionalInfo);
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

				Directory.CreateDirectory($"C:/Logs/Sap.Api/{DateTime.Now:yyyy MM}/{DateTime.Now:dd}/");
				File.WriteAllText($"C:/Logs/Sap.Api/{DateTime.Now:yyyy MM}/{DateTime.Now:dd}/{destSchema}.{destTable} {DateTime.Now:HHmm ssff}.txt", sb.ToString());
			}

			#region catch (Exception ex)
			catch (Exception ex) {
				throw new Exception(GetFullErrorText(ex, "Exception thrown in CheckColumnMappings(DataTable sourceDt, string destSchema, string destTable)."));
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

						foreach (DataColumn column in dt.Columns)
							sbc.ColumnMappings.Add(column.ColumnName, GetColumnMapping(column, destinationTableName));

						try {
							sbc.WriteToServer(dt);
						}

						#region catch (Exception ex)
						catch (Exception ex) {
							var log = string.Empty;

							foreach (SqlBulkCopyColumnMapping v in sbc.ColumnMappings) {
								if (v.SourceColumn != v.DestinationColumn)
									log = $"{log}{v.SourceColumn} != {v.DestinationColumn}{Environment.NewLine}";
							}

							errorMessage = GetFullErrorText(ex, $"{log}{Environment.NewLine}Exception thrown running: sbc.WriteToServer(dt);");
							return false;
						}
						#endregion
					}
				}

				return true;
			}

			#region catch (Exception ex)
			catch (Exception ex) {
				errorMessage = GetFullErrorText(ex, $"Exception thrown in TryBulkCopy(DataTable dt, string destinationTableName='{destinationTableName}', out string errorMessage).");
				return false;
			}
			#endregion
		}
	}
}