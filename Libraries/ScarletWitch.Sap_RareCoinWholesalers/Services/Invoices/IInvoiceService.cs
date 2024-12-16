using System.Collections.Generic;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices
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
		/// Inserts a <see cref="Invoice"/>.
		/// </summary>
		/// <param name="x">The <see cref="Invoice"/>.</param>
		void Insert(Invoice x);
		/// <summary>
		/// Inserts a <see cref="Invoice_DocumentLine"/>.
		/// </summary>
		/// <param name="x">The <see cref="Invoice_DocumentLine"/>.</param>
		void Insert(Invoice_DocumentLine x);
		/// <summary>
		/// Truncates the <see cref="Invoice"/> table.
		/// </summary>
		void TruncateTable();
	}
}