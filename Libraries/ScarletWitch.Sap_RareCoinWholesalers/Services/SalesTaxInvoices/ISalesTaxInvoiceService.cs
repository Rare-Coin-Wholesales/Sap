using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.SalesTaxInvoices
{
	/// <summary>
	/// SalesTaxInvoice service interface
	/// </summary>
	public interface ISalesTaxInvoiceService
	{
		/// <summary>
		/// Inserts a <see cref="SalesTaxInvoice"/>.
		/// </summary>
		/// <param name="x">The <see cref="SalesTaxInvoice"/>.</param>
		void Insert(SalesTaxInvoice x);
		/// <summary>
		/// Truncates the <see cref="SalesTaxInvoice"/> table.
		/// </summary>
		void TruncateTable();
	}
}