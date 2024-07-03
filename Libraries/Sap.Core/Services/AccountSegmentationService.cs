using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.AccountSegmentations;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="AccountSegmentation"/> with the specified Numerator.
		/// </summary>
		/// <param name="numerator">The Numerator.</param>
		public async Task<string> DeleteAccountSegmentation(int numerator)
		{
			var endpoint = String.Format($"{BaseUrl}{AccountSegmentationRequest.ACTION}({numerator})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteAccountSegmentation(int numerator='{numerator}').{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="AccountSegmentation"/> with the given ID.
		/// </summary>
		/// <param name="numerator">The Numerator.</param>
		public async Task<string> GetAccountSegmentationById(int numerator)
		{
			var endpoint = String.Format($"{BaseUrl}{AccountSegmentationRequest.ACTION}({numerator})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetAccountSegmentationById(int numerator='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, numerator);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListAccountSegmentations() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="AccountSegmentation"/>.</returns>
		public IList<AccountSegmentation> ListAccountSegmentations()
		{
			var list = new List<AccountSegmentation>();
			var response = ListAccountSegmentations(null);
			var accountSegmentationResponse = JsonConvert.DeserializeObject<AccountSegmentationResponse>(response.Result);

			if (accountSegmentationResponse == null)
				return list;

			list.AddRange(accountSegmentationResponse.AccountSegmentations);

			while (!String.IsNullOrWhiteSpace(accountSegmentationResponse?.OdataNextLink)) {
				response = ListAccountSegmentations(accountSegmentationResponse.OdataNextLink);
				accountSegmentationResponse = JsonConvert.DeserializeObject<AccountSegmentationResponse>(response.Result);

				if (accountSegmentationResponse == null)
					return list;

				list.AddRange(accountSegmentationResponse.AccountSegmentations);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="AccountSegmentation"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListAccountSegmentations(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, AccountSegmentationRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListAccountSegmentations(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="AccountSegmentation"/> with the given payload of type <see cref="AccountSegmentation"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="AccountSegmentation"/></param>
		public async Task<string> PatchAccountSegmentation(AccountSegmentation x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, AccountSegmentationRequest.ACTION);
				var accountSegmentationRequest = new AccountSegmentationRequest(x);
				var json = accountSegmentationRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var accountSegmentationResponse = JsonConvert.DeserializeObject<AccountSegmentationResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchAccountSegmentation(AccountSegmentation x).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="AccountSegmentation"/> with the given payload of type <see cref="AccountSegmentation"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="AccountSegmentation"/></param>
		public async Task<string> PostAccountSegmentation(AccountSegmentation x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, AccountSegmentationRequest.ACTION);
				var accountSegmentationRequest = new AccountSegmentationRequest(x);
				var json = accountSegmentationRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var accountSegmentationResponse = JsonConvert.DeserializeObject<AccountSegmentationResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostAccountSegmentation(AccountSegmentation x).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}