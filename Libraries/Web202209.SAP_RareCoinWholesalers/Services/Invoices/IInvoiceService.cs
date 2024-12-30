using System.Collections.Generic;
using System.Data;
using Web202209.SAP_RareCoinWholesalers.Domain;

namespace Web202209.SAP_RareCoinWholesalers.Services.Invoices
{
	/// <summary>
	/// Invoice service interface
	/// </summary>
	public interface IInvoiceService
	{
		/// <summary>
		/// Gets all <see cref="Invoice"/>s.
		/// </summary>
		IList<Invoice> GetAll();
		/// <summary>
		/// Gets all non-cancelled Invoices with NumAtCards.
		/// </summary>
		IList<Invoice> GetAllValid();
		/// <summary>
		/// Gets Invoices for PDSJ insert.
		/// </summary>
		IList<Invoice> GetForPdsjs();
		/// <summary>
		/// Transfers [Invoice] to [dbo].
		/// </summary>
		void TransferToDbo();
		/// <summary>
		/// Truncates the [Import].[Invoice] table.
		/// </summary>
		void TruncateTable();
		/// <summary>
		/// Tries to perform <see cref="SqlBulkCopy"/> to fast-import a <see cref="DataTable"/> into a SQL table.
		/// </summary>
		/// <param name="dt">The <see cref="DataTable"/> to import.</param>
		/// <param name="destinationTableName">The destination table name to insert into.</param>
		/// <param name="errorMessage">The output error message if any. Otherwise, empty string.</param>
		/// <returns>True if inserted successfully. False otherwise.</returns>
		bool TryBulkCopy(DataTable dt, out string errorMessage);
	}
}