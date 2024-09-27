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
		/// Gets all <see cref="UnixCustomer"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="UnixCustomer"/>s.</returns>
		IList<UnixCustomer> GetAll();
	}
}