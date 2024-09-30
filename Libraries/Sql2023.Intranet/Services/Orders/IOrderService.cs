using System.Collections.Generic;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Orders
{
	/// <summary>
	/// Order service interface
	/// </summary>
	public partial interface IOrderService
	{
		/// <summary>
		/// Gets all <see cref="Order"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="Order"/>s.</returns>
		IList<Order> GetAll();
		/// <summary>
		/// Gets all <see cref="OrderLineItem"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="OrderLineItem"/>s.</returns>
		IList<OrderLineItem> GetAllLineItems();
	}
}