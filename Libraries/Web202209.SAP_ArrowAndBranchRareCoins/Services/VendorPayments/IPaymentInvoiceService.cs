using System.Data;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services.VendorPayments
{
	/// <summary>
	/// PaymentInvoice service interface
	/// </summary>
	public interface IPaymentInvoiceService
	{
		/// <summary>
		/// Truncates the [Import].[PaymentInvoice] table.
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