using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Api.Domain.AccountCategories;
using Sap.Core.Http;

namespace Sap.Api.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="AccountCategory"/> with the specified CategoryCode.
		/// </summary>
		/// <param name="categoryCode">The CategoryCode.</param>
		public async Task<string> DeleteAccountCategory(int categoryCode)
		{
			var endpoint = String.Format($"{BaseUrl}{AccountCategoryRequest.ACTION}({categoryCode})");

			try {
				using (var response = await Client.DeleteAsync(endpoint)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var accountCategoryResponse = JsonConvert.DeserializeObject<AccountCategoryResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteAccountCategory(int id).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="AccountCategory"/> with the given ID.
		/// </summary>
		/// <param name="id">The ID of the <see cref="AccountCategory"/>.</param>
		public async Task<string> GetAccountCategoryById(int id)
		{
			var endpoint = String.Format($"{BaseUrl}{AccountCategoryRequest.ACTION}({id})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetAccountCategoryById(int id='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, id);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListAccountCategories() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="AccountCategory"/>.</returns>
		public IList<AccountCategory> ListAccountCategories()
		{
			var list = new List<AccountCategory>();
			var response = ListAccountCategories(null);
			var accountCategoryResponse = JsonConvert.DeserializeObject<AccountCategoryResponse>(response.Result);

			if (accountCategoryResponse == null)
				return list;

			list.AddRange(accountCategoryResponse.AccountCategories);

			while (!String.IsNullOrWhiteSpace(accountCategoryResponse?.OdataNextLink)) {
				response = ListAccountCategories(accountCategoryResponse.OdataNextLink);
				accountCategoryResponse = JsonConvert.DeserializeObject<AccountCategoryResponse>(response.Result);

				if (accountCategoryResponse == null)
					return list;

				list.AddRange(accountCategoryResponse.AccountCategories);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="AccountCategory"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListAccountCategories(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, AccountCategoryRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListAccountCategories(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="AccountCategory"/> with the given payload of type <see cref="AccountCategory"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="categoryCode">The category code.</param>
		/// <param name="categoryName">The category name.</param>
		/// <param name="categorySource">The category source.</param>
		public async Task<string> PatchAccountCategory(int? categoryCode, string categoryName, string categorySource)
		{
			var endpoint = String.Format($"{BaseUrl}{AccountCategoryRequest.ACTION}({categoryCode})");

			try {
				var accountCategoryRequest = new AccountCategoryRequest(categoryCode, categoryName, categorySource);
				var json = accountCategoryRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var accountCategoryResponse = JsonConvert.DeserializeObject<AccountCategoryResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchAccountCategory(int? categoryCode='{categoryCode}', string categoryName='{categoryName}', string categorySource='{categorySource}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="AccountCategory"/> with the given payload of type <see cref="AccountCategory"/> in JSON format.
		/// </summary>
		/// <param name="categoryCode">The category code.</param>
		/// <param name="categoryName">The category name.</param>
		/// <param name="categorySource">The category source.</param>
		public async Task<string> PostAccountCategory(int? categoryCode, string categoryName, string categorySource)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, AccountCategoryRequest.ACTION);
				var accountCategoryRequest = new AccountCategoryRequest(categoryCode, categoryName, categorySource);
				var json = accountCategoryRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var accountCategoryResponse = JsonConvert.DeserializeObject<AccountCategoryResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostAccountCategory(int? categoryCode='{categoryCode}', string categoryName='{categoryName}', string categorySource='{categorySource}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}