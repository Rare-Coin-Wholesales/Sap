using System.Collections.Generic;
using Web202209.SAP_RareCoinWholesalers.Domain;

namespace Web202209.SAP_RareCoinWholesalers.Services.PurchaseInvoices
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
	}
}