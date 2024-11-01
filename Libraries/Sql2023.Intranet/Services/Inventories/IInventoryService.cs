using System.Collections.Generic;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Inventories
{
	/// <summary>
	/// Inventory service interface
	/// </summary>
	public partial interface IInventoryService
	{
		/// <summary>
		/// Gets the Description of a coin.
		/// </summary>
		/// <param name="id">The Inventory ID.</param>
		string GetDescription(int id);
		/// <summary>
		/// Gets all <see cref="Inventory"/> from recent <see cref="Invoice"/>s.
		/// </summary>
		IList<Inventory> GetInvoiceInventory();
		/// <summary>
		/// Gets all <see cref="Inventory"/> from recent <see cref="Order"/>s.
		/// </summary>
		IList<Inventory> GetOrderInventory();
	}
}