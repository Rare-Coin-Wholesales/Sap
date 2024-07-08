using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.ChartOfAccounts;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="ChartOfAccount"/> with the specified Code.
		/// </summary>
		/// <param name="code">The Code.</param>
		public async Task<string> DeleteChartOfAccount(string code)
		{
			var endpoint = String.Format($"{BaseUrl}{ChartOfAccountRequest.ACTION}({code})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteChartOfAccount(string code='{code}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="ChartOfAccount"/> with the given ID.
		/// </summary>
		/// <param name="id">The ID of the <see cref="ChartOfAccount"/>.</param>
		public async Task<string> GetChartOfAccountById(int id)
		{
			var endpoint = String.Format($"{BaseUrl}{ChartOfAccountRequest.ACTION}({id})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetChartOfAccountById(int id='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, id);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListChartOfAccounts() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="ChartOfAccount"/>.</returns>
		public IList<ChartOfAccount> ListChartOfAccounts()
		{
			var list = new List<ChartOfAccount>();
			var response = ListChartOfAccounts(null);
			var chartOfAccountResponse = JsonConvert.DeserializeObject<ChartOfAccountResponse>(response.Result);

			if (chartOfAccountResponse == null)
				return list;

			list.AddRange(chartOfAccountResponse.ChartOfAccounts);

			while (!String.IsNullOrWhiteSpace(chartOfAccountResponse?.OdataNextLink)) {
				response = ListChartOfAccounts(chartOfAccountResponse.OdataNextLink);
				chartOfAccountResponse = JsonConvert.DeserializeObject<ChartOfAccountResponse>(response.Result);

				if (chartOfAccountResponse == null)
					return list;

				list.AddRange(chartOfAccountResponse.ChartOfAccounts);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="ChartOfAccount"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListChartOfAccounts(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, ChartOfAccountRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListChartOfAccounts(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="ChartOfAccount"/> with the given payload of type <see cref="ChartOfAccount"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="categoryCode">The category code.</param>
		/// <param name="categoryName">The category name.</param>
		/// <param name="categorySource">The category source.</param>
		public async Task<string> PatchChartOfAccount(ChartOfAccount x)
		{
			var endpoint = String.Format($"{BaseUrl}{ChartOfAccountRequest.ACTION}({x.Code})");

			try {
				var chartOfAccountRequest = new ChartOfAccountRequest(x);
				var json = chartOfAccountRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var chartOfAccountResponse = JsonConvert.DeserializeObject<ChartOfAccountResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchChartOfAccount(ChartOfAccount x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="ChartOfAccount"/> with the given payload of type <see cref="ChartOfAccount"/> in JSON format.
		/// </summary>
		/// <param name="categoryCode">The category code.</param>
		/// <param name="categoryName">The category name.</param>
		/// <param name="categorySource">The category source.</param>
		public async Task<string> PostChartOfAccount(ChartOfAccount x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, ChartOfAccountRequest.ACTION);
				var chartOfAccountRequest = new ChartOfAccountRequest(x);
				var json = chartOfAccountRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var chartOfAccountResponse = JsonConvert.DeserializeObject<ChartOfAccountResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostChartOfAccount(ChartOfAccount x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}