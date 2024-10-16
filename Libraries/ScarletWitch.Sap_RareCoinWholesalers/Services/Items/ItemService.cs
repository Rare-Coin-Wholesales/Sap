using System;
using System.Collections.Generic;
using System.Linq;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;

namespace ScarletWitch.Sap_RareCoinWholesalers.Services.Items
{
	/// <summary>
	/// Item service
	/// </summary>
	public partial class ItemService : BaseService, IItemService
	{
		/// <inheritdoc/>
		public virtual IList<Item> GetAll()
		{
			return (from x in _dbContext.Items
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual void Insert(Item x)
		{
			#region Input check
			if (x == null)
				throw new Exception("Something happened with your connection. Refresh the page and try again.");
			#endregion

			try {
				_dbContext.Items.Add(x);
				_dbContext.SaveChanges();
			}

			catch (Exception ex) {
				#region Handle Exception
				var msg = GetFullErrorText(ex);

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Item");
		}
	}
}