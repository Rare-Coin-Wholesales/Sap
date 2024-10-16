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
	public partial class InventoryService : IInventoryService
	{
		private readonly IEncryptionUtil _encryptionUtil;
		private readonly IntranetDb _dbContext;
		private readonly string _connectionString;
		private static readonly DateTime MinDate = DateTime.Today.AddDays(-92); // 3 months ago

		/// <summary>
		/// Ctor
		/// </summary>
		public InventoryService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Sql2023.Intranet"));
			_dbContext = new IntranetDb(_connectionString);
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