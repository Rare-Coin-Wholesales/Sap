using System;
using System.Collections.Generic;
using System.Linq;
using Sap.Core;
using Sap.Services.Security;
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
		public virtual IList<Inventory> GetConsigned()
		{
			return (from x in _dbContext.Inventories
					where !x.InventoryConsignmentReturned &&
						  (x.InventoryConsignmentNumber != null && x.InventoryConsignmentNumber.Value > 0) &&
						  (x.InventoryConsignmentDate != null) &&
						  (x.InventoryConsignmentVendor != null && x.InventoryConsignmentVendor.Trim() != string.Empty)
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual string GetDescription(int id)
		{
			if (id < 1)
				return string.Empty;

			return (from x in _dbContext.Inventories
					where x.InventoryID == id
					select x.InventoryDescription1).FirstOrDefault();
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