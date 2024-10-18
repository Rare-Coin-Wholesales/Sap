using System.Collections.Generic;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.UnixCustomers
{
	/// <summary>
	/// UnixCustomer service interface
	/// </summary>
	public partial interface IUnixCustomerService
	{
		/// <summary>
		/// Determines the SAP CardType based on Insight's CustID or SAP's CardCode.
		/// </summary>
		/// <param name="id">The CustID or CardCode.</param>
		/// <param name="name">The name.</param>
		/// <returns>"C" if the CustID is numeric. "S" otherwise.</returns>
		string DetermineBpType(string id, string name);
		/// <summary>
		/// Gets all <see cref="UnixCustomer"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="UnixCustomer"/>s.</returns>
		IList<UnixCustomer> GetAll();
		/// <summary>
		/// Gets all <see cref="UnixCustomer"/>s from recent <see cref="Invoice"/>s.
		/// </summary>
		/// <returns>A list of <see cref="UnixCustomer"/>.</returns>
		IList<UnixCustomer> GetInvoiceUnixCustomers();
		/// <summary>
		/// Gets all <see cref="UnixCustomer"/>s from recent <see cref="Order"/>s.
		/// </summary>
		/// <returns>A list of <see cref="UnixCustomer"/>.</returns>
		IList<UnixCustomer> GetOrderUnixCustomers();
		/// <summary>
		/// Gets recent <see cref="UnixCustomer"/>s.
		/// </summary>
		/// <returns>A list of <see cref="UnixCustomer"/>.</returns>
		IList<UnixCustomer> GetRecent();
	}
}