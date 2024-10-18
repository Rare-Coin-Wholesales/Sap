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
		/// Gets all <see cref="OrderLineItem"/>s by <see cref="Order"/> ID.
		/// </summary>
		/// <param name="id">The <see cref="Order"/> ID.</param>
		/// <returns>An <see cref="IList{T}"/> of <see cref="OrderLineItem"/>s.</returns>
		IList<OrderLineItem> GetLineItemsByOrderId(int id);
		/// <summary>
		/// Gets all distinct <see cref="Order"/>s that actually have <see cref="OrderLineItem"/>s.
		/// </summary>
		/// <returns>An <see cref="IList{T}"/> of <see cref="Order"/>s that actually have <see cref="OrderLineItem"/>s.</returns>
		IList<Order> GetRecent();
		/// <summary>
		/// Gets recent customer IDs.
		/// </summary>
		/// <returns>A list of customer IDs.</returns>
		IList<string> GetRecentCustomerIds();
	}
}