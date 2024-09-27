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
		private readonly EncryptionUtil _encryptionUtil;
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
		public virtual IList<Order> GetAll()
		{
			return (from x in _dbContext.Orders
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<OrderLineItem> GetAllLineItems()
		{
			return (from x in _dbContext.OrderLineItems
					select x).ToList();
		}
	}
}