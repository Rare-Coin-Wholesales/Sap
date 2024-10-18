using System.Collections.Generic;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Invoices
{
	/// <summary>
	/// Invoice service interface
	/// </summary>
	public partial interface IInvoiceService
	{
		/// <summary>
		/// Gets all <see cref="InvoiceLineItem"/>s by <see cref="Invoice"/> ID.
		/// </summary>
		/// <param name="id">The <see cref="Invoice"/> ID.</param>
		/// <returns>An <see cref="IList{T}"/> of <see cref="InvoiceLineItem"/>s.</returns>
		IList<InvoiceLineItem> GetLineItemsByInvoiceId(int id);
		/// <summary>
		/// Gets all recent <see cref="Invoice"/>s that actually have <see cref="InvoiceLineItem"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="Invoice"/>s that actually have <see cref="InvoiceLineItem"/>s.</returns>
		IList<Invoice> GetRecent();
		/// <summary>
		/// Gets recent customer IDs.
		/// </summary>
		/// <returns>A list of customer IDs.</returns>
		IList<string> GetRecentCustomerIds();
	}
}