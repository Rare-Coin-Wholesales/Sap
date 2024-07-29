using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Core.Domain.HouseBankAccounts;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="HouseBankAccount"/> with the specified AbsoluteEntry.
		/// </summary>
		/// <param name="absoluteEntry">The AbsoluteEntry.</param>
		public async Task<string> DeleteHouseBankAccount(int absoluteEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{HouseBankAccountRequest.ACTION}({absoluteEntry})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteHouseBankAccount(int absoluteEntry='{absoluteEntry}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="HouseBankAccount"/> with the given BankCode.
		/// </summary>
		/// <param name="absoluteEntry">The AbsoluteEntry.</param>
		public async Task<string> GetHouseBankAccountById(int absoluteEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{HouseBankAccountRequest.ACTION}({absoluteEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetHouseBankAccountById(int absoluteEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, absoluteEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListHouseBankAccounts() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="HouseBankAccount"/>.</returns>
		public IList<HouseBankAccount> ListHouseBankAccounts()
		{
			var list = new List<HouseBankAccount>();
			var response = ListHouseBankAccounts(null);
			var houseBankAccountResponse = JsonConvert.DeserializeObject<HouseBankAccountResponse>(response.Result);

			if (houseBankAccountResponse == null)
				return list;

			list.AddRange(houseBankAccountResponse.HouseBankAccounts);

			while (!String.IsNullOrWhiteSpace(houseBankAccountResponse?.OdataNextLink)) {
				response = ListHouseBankAccounts(houseBankAccountResponse.OdataNextLink);
				houseBankAccountResponse = JsonConvert.DeserializeObject<HouseBankAccountResponse>(response.Result);

				if (houseBankAccountResponse == null)
					return list;

				list.AddRange(houseBankAccountResponse.HouseBankAccounts);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="HouseBankAccount"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListHouseBankAccounts(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, HouseBankAccountRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListHouseBankAccounts(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="HouseBankAccount"/> with the given payload of type <see cref="HouseBankAccount"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="HouseBankAccount"/>.</param>
		public async Task<string> PatchHouseBankAccount(HouseBankAccount x)
		{
			var endpoint = String.Format($"{BaseUrl}{HouseBankAccountRequest.ACTION}({x.AbsoluteEntry})");

			try {
				var houseBankAccountRequest = new HouseBankAccountRequest(x);
				var json = houseBankAccountRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var houseBankAccountResponse = JsonConvert.DeserializeObject<HouseBankAccountResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchHouseBankAccount(HouseBankAccount x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="HouseBankAccount"/> with the given payload of type <see cref="HouseBankAccount"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="HouseBankAccount"/>.</param>
		public async Task<string> PostHouseBankAccount(HouseBankAccount x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, HouseBankAccountRequest.ACTION);
				var houseBankAccountRequest = new HouseBankAccountRequest(x);
				var json = houseBankAccountRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var houseBankAccountResponse = JsonConvert.DeserializeObject<HouseBankAccountResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostHouseBankAccount(HouseBankAccount x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}