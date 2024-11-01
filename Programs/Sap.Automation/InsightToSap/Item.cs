using System;
using System.Linq;
using Sap.Api.Domain.Items;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Items;
using Sql2023.Intranet.Services.Export;
using Sql2023.Intranet.Services.Inventories;
using Sql2023.Intranet.Services.Logging;

namespace Sap.Automation
{
	internal partial class InsightToSap
	{
		private static readonly IExportManager _exportManager = new ExportManager();
		private static readonly IInventoryService _inventoryService = new InventoryService();
		private static readonly IItemService _itemService = new ItemService();
		private static readonly ILogger _logger = new DefaultLogger();

		public static async void CreateMissingInvoiceCoins()
		{
			var invoiceCoins = _inventoryService.GetInvoiceInventory();

			if (invoiceCoins == null || invoiceCoins.Count == 0)
				return;

			_exportManager.ExportToCsv(invoiceCoins);
			var sapRcwItems = _itemService.GetAll();
			var missingCoins = (from x in invoiceCoins // left join
								from y in sapRcwItems.Where(y => y.ItemCode == x.InventoryID.ToString()).DefaultIfEmpty()
								where y == null || y.ItemCode == null
								select x).ToList();

			foreach (var coin in missingCoins) {
				var created = await Common.RcwServiceLayer.TryCreateAsync(new Item {
					ItemCode = coin.InventoryID.ToString(),
					ItemName = coin.InventoryDescription1.Trim(),
				});

				if (created.Item1 == null)
					Common.nLog.Error(created.ErrorMsg);
			}
		}

		public static async void CreateMissingOrderCoins()
		{
			var orderCoins = _inventoryService.GetOrderInventory();

			if (orderCoins == null || orderCoins.Count == 0)
				return;

			_exportManager.ExportToCsv(orderCoins);
			var sapRcwItems = _itemService.GetAll();
			var missingCoins = (from x in orderCoins // left join
								from y in sapRcwItems.Where(y => y.ItemCode == x.InventoryID.ToString()).DefaultIfEmpty()
								where y == null || y.ItemCode == null
								select x).ToList();

			foreach (var coin in missingCoins) {
				var created = await Common.RcwServiceLayer.TryCreateAsync(new Item {
					ItemCode = coin.InventoryID.ToString(),
					ItemName = coin.InventoryDescription1.Trim(),
				});

				if (created.Item1 == null)
					Common.nLog.Error(created.ErrorMsg);
			}
		}
	}
}