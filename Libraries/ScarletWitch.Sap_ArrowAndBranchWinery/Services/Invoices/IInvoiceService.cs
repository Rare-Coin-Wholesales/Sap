using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.Invoices
{
	/// <summary>
	/// Invoice service interface
	/// </summary>
	public interface IInvoiceService
	{
		/// <summary>
		/// Inserts a <see cref="Invoice"/>.
		/// </summary>
		/// <param name="x">The <see cref="Invoice"/>.</param>
		void Insert(Invoice x);
		/// <summary>
		/// Truncates the <see cref="Invoice"/> table.
		/// </summary>
		void TruncateTable();
	}
}