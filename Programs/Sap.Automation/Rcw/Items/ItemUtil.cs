using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Items;

namespace Sap.Rcw.Automation
{
	public partial class ItemUtil
	{
		private readonly ItemService _itemService = new ItemService();

		public async Task GetAllItems(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllItems(SLConnection serviceLayer).");
			var list = await Common.RcwServiceLayer.GetAllItemsAsync();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_itemService.TruncateTable();

				foreach (var v in list) {
					try {
						_itemService.Insert(Common._rcwMapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._rcwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
