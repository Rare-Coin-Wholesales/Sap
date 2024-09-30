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
		/// Gets all <see cref="Invoice"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="Invoice"/>s.</returns>
		IList<Invoice> GetAll();
		/// <summary>
		/// Gets all <see cref="InvoiceLineItem"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="InvoiceLineItem"/>s.</returns>
		IList<InvoiceLineItem> GetAllLineItems();
	}
}