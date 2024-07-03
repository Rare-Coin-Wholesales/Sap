using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.AccountSegmentationCategories;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="AccountSegmentationCategory"/> with the specified SegmentID and Code.
		/// </summary>
		/// <param name="segmentID">The SegmentID.</param>
		/// <param name="code">The Code.</param>
		public async Task<string> DeleteAccountSegmentationCategory(int segmentID, string code)
		{
			var endpoint = String.Format($"{BaseUrl}{AccountSegmentationCategoryRequest.ACTION}(SegmentID={segmentID},Code='{code}')");

			try {
				using (var response = await Client.DeleteAsync(endpoint)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteAccountSegmentationCategory(int id).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="AccountSegmentationCategory"/> with the given ID.
		/// </summary>
		/// <param name="id">The ID of the <see cref="AccountSegmentationCategory"/>.</param>
		public async Task<string> GetAccountSegmentationCategoryById(int segmentID, string code)
		{
			var endpoint = String.Format($"{BaseUrl}{AccountSegmentationCategoryRequest.ACTION}(SegmentID={segmentID},Code='{code}')");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetAccountSegmentationCategoryById(int? segmentID, string? code).{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListAccountSegmentationCategories() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="AccountSegmentationCategory"/>.</returns>
		public IList<AccountSegmentationCategory> ListAccountSegmentationCategories()
		{
			var list = new List<AccountSegmentationCategory>();
			var response = ListAccountSegmentationCategories(null);
			var accountSegmentationCategoryResponse = JsonConvert.DeserializeObject<AccountSegmentationCategoryResponse>(response.Result);

			if (accountSegmentationCategoryResponse == null)
				return list;

			list.AddRange(accountSegmentationCategoryResponse.AccountSegmentationCategories);

			while (!String.IsNullOrWhiteSpace(accountSegmentationCategoryResponse?.OdataNextLink)) {
				response = ListAccountSegmentationCategories(accountSegmentationCategoryResponse.OdataNextLink);
				accountSegmentationCategoryResponse = JsonConvert.DeserializeObject<AccountSegmentationCategoryResponse>(response.Result);

				if (accountSegmentationCategoryResponse == null)
					return list;

				list.AddRange(accountSegmentationCategoryResponse.AccountSegmentationCategories);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="AccountSegmentationCategory"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListAccountSegmentationCategories(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, AccountSegmentationCategoryRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListAccountSegmentationCategories(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="AccountSegmentationCategory"/> with the given payload of type <see cref="AccountSegmentationCategory"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="AccountSegmentationCategory"/>.</param>
		public async Task<string> PatchAccountSegmentationCategory(AccountSegmentationCategory x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, AccountSegmentationCategoryRequest.ACTION);
				var accountSegmentationCategoryRequest = new AccountSegmentationCategoryRequest(x);
				var json = accountSegmentationCategoryRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var accountSegmentationCategoryResponse = JsonConvert.DeserializeObject<AccountSegmentationCategoryResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchAccountSegmentationCategory(AccountSegmentationCategory x).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="AccountSegmentationCategory"/> with the given payload of type <see cref="AccountSegmentationCategory"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="AccountSegmentationCategory"/>.</param>
		public async Task<string> PostAccountSegmentationCategory(AccountSegmentationCategory x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, AccountSegmentationCategoryRequest.ACTION);
				var accountSegmentationCategoryRequest = new AccountSegmentationCategoryRequest(x);
				var json = accountSegmentationCategoryRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var accountSegmentationCategoryResponse = JsonConvert.DeserializeObject<AccountSegmentationCategoryResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchAccountSegmentationCategory(AccountSegmentationCategory x).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}