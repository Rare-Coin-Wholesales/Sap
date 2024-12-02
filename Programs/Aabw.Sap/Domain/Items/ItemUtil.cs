using System;
using System.Threading.Tasks;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.Items;

namespace Aabw.Sap
{
	public partial class ItemUtil
	{
		private readonly ItemService _itemService = new ItemService();

		public async Task GetAllItems()
		{
			Program.nLog.Trace("Begin method GetAllItems().");
			var list = await Program._serviceLayer.GetAllItemsAsync();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_itemService.TruncateTable();

				foreach (var v in list) {
					try {
						_itemService.Insert(Program._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Program.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Program._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
