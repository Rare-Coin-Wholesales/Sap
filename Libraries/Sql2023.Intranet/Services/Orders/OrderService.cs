using System;
using System.Collections.Generic;
using System.Linq;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Orders
{
	/// <summary>
	/// Order service
	/// </summary>
	public partial class OrderService : BaseService, IOrderService
	{
		private static readonly DateTime MinDate = DateTime.Today.AddDays(-92); // 3 months ago

		/// <inheritdoc/>
		public virtual IList<OrderLineItem> GetLineItemsByOrderId(int id)
		{
			return (from x in _dbContext.OrderLineItems
					where x.OrderID == id
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<Order> GetRecent()
		{
			var query =  (from line in _dbContext.OrderLineItems
						  join ent in _dbContext.Orders on line.OrderID equals ent.OrderID
						  where ent.DateEntered > MinDate
						  select ent).GroupBy(x => x.OrderID).Select(grp => grp.FirstOrDefault());

			return query.ToList();
		}

		/// <inheritdoc/>
		public virtual IList<string> GetRecentCustomerIds()
		{
			var query =  (from x in _dbContext.Orders
						  where x.DateEntered > MinDate
						  select x.Cust_).GroupBy(x => x).Select(grp => grp.FirstOrDefault());

			return query.ToList();
		}
	}
}