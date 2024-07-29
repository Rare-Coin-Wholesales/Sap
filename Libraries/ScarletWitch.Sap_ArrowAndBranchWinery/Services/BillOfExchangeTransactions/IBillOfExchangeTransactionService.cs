using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.BillOfExchangeTransactions
{
	/// <summary>
	/// BillOfExchangeTransaction service interface
	/// </summary>
	public interface IBillOfExchangeTransactionService
	{
		/// <summary>
		/// Inserts a <see cref="BillOfExchangeTransaction"/>.
		/// </summary>
		/// <param name="x">The <see cref="BillOfExchangeTransaction"/>.</param>
		void Insert(BillOfExchangeTransaction x);
		/// <summary>
		/// Truncates the <see cref="BillOfExchangeTransaction"/> table.
		/// </summary>
		void TruncateTable();
	}
}