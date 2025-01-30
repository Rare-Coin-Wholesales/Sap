using System.Collections.Generic;
using System.Data;
using Web202209.SAP_ArrowAndBranchWinery.Domain;

namespace Web202209.SAP_ArrowAndBranchWinery.Services.PurchaseInvoices
{
	/// <summary>
	/// PurchaseInvoice service interface
	/// </summary>
	public interface IPurchaseInvoiceService
	{
		/// <summary>
		/// Gets all <see cref="PurchaseInvoice"/>s.
		/// </summary>
		IList<PurchaseInvoice> GetAll();
		/// <summary>
		/// Gets all non-cancelled PurchaseInvoices with NumAtCards.
		/// </summary>
		IList<PurchaseInvoice> GetAllValid();
		/// <summary>
		/// Gets PurchaseInvoices for ESD insert.
		/// </summary>
		IList<PurchaseInvoice> GetForEsds();
		/// <summary>
		/// Transfers [PurchaseInvoice] to [dbo].
		/// </summary>
		void TransferToDbo();
		/// <summary>
		/// Truncates the [Import].[PurchaseInvoice] table.
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