using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseInvoices
{
	/// <summary>
	/// PurchaseInvoice service interface
	/// </summary>
	public interface IPurchaseInvoiceService
	{
		/// <summary>
		/// Inserts a <see cref="PurchaseInvoice"/>.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseInvoice"/>.</param>
		void Insert(PurchaseInvoice x);
		/// <summary>
		/// Truncates the <see cref="PurchaseInvoice"/> table.
		/// </summary>
		void TruncateTable();
	}
}