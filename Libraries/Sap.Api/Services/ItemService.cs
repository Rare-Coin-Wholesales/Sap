using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Api.Domain.Items;
using Sap.Core.Http;

namespace Sap.Api.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="Item"/> with the specified ItemCode.
		/// </summary>
		/// <param name="itemCode">The ItemCode</param>
		public async Task<string> CancelItem(string itemCode)
		{
			var endpoint = String.Format($"{BaseUrl}{ItemRequest.ACTION}({itemCode})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var itemResponse = JsonConvert.DeserializeObject<ItemResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelItem(string itemCode).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
		/// <summary>
		/// Gets an instance of <see cref="Item"/> with the given ItemCode.
		/// </summary>
		/// <param name="itemCode">The ItemCode.</param>
		public async Task<string> GetItemById(string itemCode)
		{
			var endpoint = String.Format($"{BaseUrl}{ItemRequest.ACTION}({itemCode})");

			try {
				using (var response = await Client.GetAsync(endpoint)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetItemById(string itemCode='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, itemCode);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListItems() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="Item"/>.</returns>
		public IList<Item> ListItems()
		{
			var list = new List<Item>();
			var response = ListItems(null);
			var itemResponse = JsonConvert.DeserializeObject<ItemResponse>(response.Result);

			if (itemResponse == null)
				return list;

			list.AddRange(itemResponse.Items);

			while (!String.IsNullOrWhiteSpace(itemResponse?.OdataNextLink)) {
				response = ListItems(itemResponse.OdataNextLink);
				itemResponse = JsonConvert.DeserializeObject<ItemResponse>(response.Result);

				if (itemResponse == null)
					return list;

				list.AddRange(itemResponse.Items);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="Item"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListItems(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, ItemRequest.ACTION);
			else
				endpoint = Path.Combine(BaseUrl, nextLink);

			try {
				using (var response = await Client.GetAsync(endpoint)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListItems(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="Item"/> with the given payload of type <see cref="Item"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="Item"/>.</param>
		public async Task<string> PatchItem(Item x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, ItemRequest.ACTION);
				var itemRequest = new ItemRequest(x);
				var json = itemRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var itemResponse = JsonConvert.DeserializeObject<ItemResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchItem(Item x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="Item"/> with the given payload of type <see cref="Item"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="Item"/>.</param>
		public async Task<string> PostItem(Item x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, ItemRequest.ACTION);
				var itemRequest = new ItemRequest(x);
				var json = itemRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var itemResponse = JsonConvert.DeserializeObject<ItemResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostItem(Item x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}