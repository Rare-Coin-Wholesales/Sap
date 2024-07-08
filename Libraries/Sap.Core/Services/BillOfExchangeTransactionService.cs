using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.BillOfExchangeTransactions;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Gets an instance of <see cref="BillOfExchangeTransaction"/> with the given Code.
		/// </summary>
		/// <param name="code">The Code.</param>
		public async Task<string> GetBillOfExchangeTransactionById(int code)
		{
			var endpoint = String.Format($"{BaseUrl}{BillOfExchangeTransactionRequest.ACTION}({code})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetBillOfExchangeTransactionById(int code='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, code);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListBillOfExchangeTransactions() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="BillOfExchangeTransaction"/>.</returns>
		public IList<BillOfExchangeTransaction> ListBillOfExchangeTransactions()
		{
			var list = new List<BillOfExchangeTransaction>();
			var response = ListBillOfExchangeTransactions(null);
			var billOfExchangeTransactionResponse = JsonConvert.DeserializeObject<BillOfExchangeTransactionResponse>(response.Result);

			if (billOfExchangeTransactionResponse == null)
				return list;

			list.AddRange(billOfExchangeTransactionResponse.BillOfExchangeTransactions);

			while (!String.IsNullOrWhiteSpace(billOfExchangeTransactionResponse?.OdataNextLink)) {
				response = ListBillOfExchangeTransactions(billOfExchangeTransactionResponse.OdataNextLink);
				billOfExchangeTransactionResponse = JsonConvert.DeserializeObject<BillOfExchangeTransactionResponse>(response.Result);

				if (billOfExchangeTransactionResponse == null)
					return list;

				list.AddRange(billOfExchangeTransactionResponse.BillOfExchangeTransactions);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="BillOfExchangeTransaction"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListBillOfExchangeTransactions(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, BillOfExchangeTransactionRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListBillOfExchangeTransactions(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="BillOfExchangeTransaction"/> with the given payload of type <see cref="BillOfExchangeTransaction"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="BillOfExchangeTransaction"/>.</param>
		public async Task<string> PostBillOfExchangeTransaction(BillOfExchangeTransaction x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, BillOfExchangeTransactionRequest.ACTION);
				var billOfExchangeTransactionRequest = new BillOfExchangeTransactionRequest(x);
				var json = billOfExchangeTransactionRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var billOfExchangeTransactionResponse = JsonConvert.DeserializeObject<BillOfExchangeTransactionResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostBillOfExchangeTransaction(BillOfExchangeTransaction x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}