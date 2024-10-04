using System.Collections.Generic;
using System.Linq;
using Sap.Core;
using Sap.Services.Security;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Orders
{
	/// <summary>
	/// Order service
	/// </summary>
	public partial class OrderService : IOrderService
	{
		private readonly IEncryptionUtil _encryptionUtil;
		private readonly IntranetDb _dbContext;
		private readonly string _connectionString;

		/// <summary>
		/// Ctor
		/// </summary>
		public OrderService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Sql2023.Intranet"));
			_dbContext = new IntranetDb(_connectionString);
		}

		/// <inheritdoc/>
		public virtual IList<Order> GetDistinctOrders()
		{
			var query =  (from line in _dbContext.OrderLineItems
						  join ent in _dbContext.Orders on line.OrderID equals ent.OrderID
						  select ent).GroupBy(x => x.OrderID).Select(grp => grp.First());

			return query.ToList();
		}

		/// <inheritdoc/>
		public virtual IList<OrderLineItem> GetLineItemsByOrderId(int id)
		{
			return (from x in _dbContext.OrderLineItems
					where x.OrderID == id
					select x).ToList();
		}
	}
}