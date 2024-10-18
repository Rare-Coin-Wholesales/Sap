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
		/// Gets consigned <see cref="Inventory"/>.
		/// </summary>
		/// <returns>A list of consigned <see cref="Inventory"/>.</returns>
		IList<Inventory> GetConsigned();
		/// <summary>
		/// Gets the Description of a coin.
		/// </summary>
		/// <param name="id">The Inventory ID.</param>
		/// <returns>The Description.</returns>
		string GetDescription(int id);
		/// <summary>
		/// Gets all <see cref="Inventory"/> from recent <see cref="Invoice"/>s.
		/// </summary>
		/// <returns>A list of <see cref="Inventory"/>.</returns>
		IList<Inventory> GetInvoiceInventory();
		/// <summary>
		/// Gets all <see cref="Inventory"/> from recent <see cref="Order"/>s.
		/// </summary>
		/// <returns>A list of <see cref="Inventory"/>.</returns>
		IList<Inventory> GetOrderInventory();
	}
}