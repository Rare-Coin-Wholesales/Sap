using System;
using System.Collections.Generic;
using System.Linq;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Inventories
{
	/// <summary>
	/// Inventory service
	/// </summary>
	public partial class InventoryService : BaseService, IInventoryService
	{
		private static readonly DateTime MinDate = DateTime.Today.AddDays(-92); // 3 months ago

		/// <inheritdoc/>
		public virtual string GetDescription(int id)
		{
			if (id < 1)
				return string.Empty;

			var query = (from x in _dbContext.Inventories
						 where x.InventoryID == id
						 select x).FirstOrDefault();

			var description = query.InventoryDescription1?.Trim();

			if (!String.IsNullOrWhiteSpace(query.InventoryDescription2))
				description = $"{description}. {query.InventoryDescription2.Trim()}";

			return description;
		}

		/// <inheritdoc/>
		public virtual IList<Inventory> GetInvoiceInventory()
		{
			return (from line in _dbContext.InvoiceLineItems
					join ent in _dbContext.Invoices on line.InvoiceID equals ent.InvoiceID
					join i in _dbContext.Inventories on line.CoinID equals i.InventoryID
					where ent.DateEntered > MinDate
					select i).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<Inventory> GetOrderInventory()
		{
			return (from line in _dbContext.OrderLineItems
					join ent in _dbContext.Orders on line.OrderID equals ent.OrderID
					join i in _dbContext.Inventories on line.CoinID equals i.InventoryID
					where ent.DateEntered > MinDate
					select i).ToList();
		}
	}
}