using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.TransactionCodes;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="TransactionCode"/> with the specified Code.
		/// </summary>
		/// <param name="code">The Code.</param>
		public async Task<string> DeleteTransactionCode(int code)
		{
			var endpoint = String.Format($"{BaseUrl}{TransactionCodeRequest.ACTION}({code})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteTransactionCode(int code='{code}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="TransactionCode"/> with the given BankCode.
		/// </summary>
		/// <param name="code">The Code.</param>
		public async Task<string> GetTransactionCodeById(int code)
		{
			var endpoint = String.Format($"{BaseUrl}{TransactionCodeRequest.ACTION}({code})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetTransactionCodeById(int code='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, code);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListTransactionCodes() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="TransactionCode"/>.</returns>
		public IList<TransactionCode> ListTransactionCodes()
		{
			var list = new List<TransactionCode>();
			var response = ListTransactionCodes(null);
			var transactionCodeResponse = JsonConvert.DeserializeObject<TransactionCodeResponse>(response.Result);

			if (transactionCodeResponse == null)
				return list;

			list.AddRange(transactionCodeResponse.TransactionCodes);

			while (!String.IsNullOrWhiteSpace(transactionCodeResponse?.OdataNextLink)) {
				response = ListTransactionCodes(transactionCodeResponse.OdataNextLink);
				transactionCodeResponse = JsonConvert.DeserializeObject<TransactionCodeResponse>(response.Result);

				if (transactionCodeResponse == null)
					return list;

				list.AddRange(transactionCodeResponse.TransactionCodes);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="TransactionCode"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListTransactionCodes(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, TransactionCodeRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListTransactionCodes(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="TransactionCode"/> with the given payload of type <see cref="TransactionCode"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="TransactionCode"/>.</param>
		public async Task<string> PatchTransactionCode(TransactionCode x)
		{
			var endpoint = String.Format($"{BaseUrl}{TransactionCodeRequest.ACTION}({x.Code})");

			try {
				var transactionCodeRequest = new TransactionCodeRequest(x);
				var json = transactionCodeRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var transactionCodeResponse = JsonConvert.DeserializeObject<TransactionCodeResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchTransactionCode(TransactionCode x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="TransactionCode"/> with the given payload of type <see cref="TransactionCode"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="TransactionCode"/>.</param>
		public async Task<string> PostTransactionCode(TransactionCode x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, TransactionCodeRequest.ACTION);
				var transactionCodeRequest = new TransactionCodeRequest(x);
				var json = transactionCodeRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var transactionCodeResponse = JsonConvert.DeserializeObject<TransactionCodeResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostTransactionCode(TransactionCode x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}