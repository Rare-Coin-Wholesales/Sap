using Sap.Api;
using Sap.Api.Domain.Items;
using Sap.Core;
using Sap.Services.Security;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Items;
using Sql2023.Intranet.Services.Export;
using Sql2023.Intranet.Services.Inventories;
using Sql2023.Intranet.Services.Logging;

namespace Sap.Tests.Sap.Rcw.IntegrationTests
{
	public class ItemTests
	{
		private const string TEST_COMPANY_DB = "A21384_RCW_T01";
		private static readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string SAP_Rcw_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		private static readonly ServiceLayer _testServiceLayer = new ServiceLayer(BaseUrl, TEST_COMPANY_DB, Username, SAP_Rcw_Password);
		private static readonly IExportManager _exportManager = new ExportManager();
		private static readonly IInventoryService _inventoryService = new InventoryService();
		private static readonly IItemService _itemService = new ItemService();
		private static readonly ILogger _logger = new DefaultLogger();

		[Fact]
		public async void Test_Create_Patch_Delete()
		{
			_testServiceLayer.AddErrorLogs();
			await Test_GetAllItemsAsync();

			var test = await Test_CreateAsync();
			await Test_GetAllItemsAsync();

			test.ItemName = $"UPDA {DateTime.Now:M/d/yyyy HH:mm:ss.ffff}";
			await _testServiceLayer.PatchAsync(test);
			await Test_GetAllItemsAsync();

			await _testServiceLayer.DeleteAsync(test);
			await Test_GetAllItemsAsync();
		}

		[Fact]
		public async void Test_CreateMissingOrderCoins()
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
				try {
					await _testServiceLayer.CreateAsync(new Item {
						ItemCode = coin.InventoryID.ToString(),
						ItemName = coin.InventoryDescription1.Trim(),
						QuantityOnStock = "1",
					});
				}

				#region catch (Exception ex)
				catch (Exception ex) {
					if (ex.InnerException == null)
						_logger.InsertWarning(ex);
					else
						throw;
				}
				#endregion
			}
		}

		[Fact]
		public async Task<Item> Test_CreateAsync()
		{
			_testServiceLayer.AddErrorLogs();
			var now = DateTime.Now;
			var test = new Item
			{
				ItemCode = $"TEST{now:ffff}",
				ItemName = $"TEST {now:M/d/yyyy HH:mm:ss.ffff}",
			};

			var created = await _testServiceLayer.CreateAsync(test);
			created.ShouldNotBeNull();
			return created;
		}

		[Fact]
		public async void Test_DeleteItemByIdAsync()
		{
			_testServiceLayer.AddErrorLogs();
			await _testServiceLayer.DeleteItemByIdAsync("142695");
		}

		[Fact]
		public async void Test_DeleteAllItemsByIdsAsync()
		{
			_testServiceLayer.AddErrorLogs();
			string[] tests = { "142558", "144428", "142962", "144429", "143721", "144463", "137252", "143409", "143525", "143952", "142762", "144474", "143801", "143057", "142577", "143035", "143264", "143235", "142554", "142695", "140848", "143417", "140942", "144020", "142366" };

			foreach (var test in tests)
				await _testServiceLayer.DeleteItemByIdAsync(test);
		}

		[Fact]
		public async Task Test_GetAllItemsAsync()
		{
			_testServiceLayer.AddErrorLogs();
			var all = await _testServiceLayer.GetAllItemsAsync();
			all.ShouldNotBeNull();
			_testServiceLayer.LogToCsv(all);
		}
	}
}