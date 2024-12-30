using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.Items;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		protected async Task<Item> CreateAsync(Item x)
		{
			var created = await Request("Items").PostAsync<Item>(x);
			return created;
		}

		public async Task DeleteAsync(Item x)
		{
			await Request("Items", x.ItemCode).DeleteAsync();
		}

		public async Task DeleteItemByIdAsync(object id)
		{
			await Request("Items", id).DeleteAsync();
		}

		public async Task<IList<Item>> GetAllItemsAsync()
		{
			var all = await Request("Items").GetAllAsync<Item>();
			return all;
		}

		public async Task<Item> GetItemAsync(object id)
		{
			var entity = await Request("Items", id).GetAsync<Item>();
			return entity;
		}

		public void LogToCsv(IList<Item> list)
		{
			var log = "ItemType,ItemCode,ItemName\r\n";

			foreach (var v in list)
				log = String.Format($"{log}\"{v.ItemType}\",\"{v.ItemCode}\",\"{v.ItemName}\"{Environment.NewLine}");

			Directory.CreateDirectory(FileOutputFolder);
			File.WriteAllText($"{FileOutputFolder}Items {DateTime.Now:HHmm ssff}.csv", log);
		}

		public async Task PatchAsync(Item x)
		{
			x.CreateDate = null;
			x.CreateTime = null;
			x.UpdateDate = null;
			x.UpdateTime = null;
			await Request("Items", x.ItemCode).PatchAsync(x);
		}

		public async Task<(Item, string ErrorMsg)> TryCreateAsync(Item x)
		{
			try {
				return (await CreateAsync(x), null);
			}

			catch (Exception ex) {
				return (null, GetFullErrorText(ex, null));
			}
		}
	}
}