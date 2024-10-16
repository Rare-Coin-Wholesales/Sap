using System.Collections.Generic;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.Items
{
	/// <summary>
	/// Item service interface
	/// </summary>
	public interface IItemService
	{
		/// <summary>
		/// Gets all <see cref="Item"/>s.
		/// </summary>
		IList<Item> GetAll();
		/// <summary>
		/// Inserts a <see cref="Item"/>.
		/// </summary>
		/// <param name="x">The <see cref="Item"/>.</param>
		void Insert(Item x);
		/// <summary>
		/// Truncates the <see cref="Item"/> table.
		/// </summary>
		void TruncateTable();
	}
}