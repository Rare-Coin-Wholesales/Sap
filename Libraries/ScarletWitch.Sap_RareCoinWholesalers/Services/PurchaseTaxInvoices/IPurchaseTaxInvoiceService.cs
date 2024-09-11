using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseTaxInvoices
{
	/// <summary>
	/// PurchaseTaxInvoice service interface
	/// </summary>
	public interface IPurchaseTaxInvoiceService
	{
		/// <summary>
		/// Inserts a <see cref="PurchaseTaxInvoice"/>.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseTaxInvoice"/>.</param>
		void Insert(PurchaseTaxInvoice x);
		/// <summary>
		/// Truncates the <see cref="PurchaseTaxInvoice"/> table.
		/// </summary>
		void TruncateTable();
	}
}