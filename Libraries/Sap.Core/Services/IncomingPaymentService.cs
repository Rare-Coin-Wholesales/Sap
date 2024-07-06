using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.IncomingPayments;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'CancelbyCurrentSystemDate' on this <see cref="IncomingPayment"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelByCurrentSystemDateIncomingPayment(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{IncomingPaymentRequest.ACTION}({docEntry})/CancelbyCurrentSystemDate");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var incomingPaymentResponse = JsonConvert.DeserializeObject<IncomingPaymentResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelByCurrentSystemDateIncomingPayment(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="IncomingPayment"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelIncomingPayment(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{IncomingPaymentRequest.ACTION}({docEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var incomingPaymentResponse = JsonConvert.DeserializeObject<IncomingPaymentResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelIncomingPayment(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Deletes an instance of <see cref="IncomingPayment"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> DeleteIncomingPayment(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{IncomingPaymentRequest.ACTION}({docEntry})");

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
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.DeleteIncomingPayment(int docEntry='{docEntry}').{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'GetApprovalTemplates' on this <see cref="IncomingPayment"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> GetApprovalTemplatesIncomingPayment(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{IncomingPaymentRequest.ACTION}({docEntry})/GetApprovalTemplates");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var incomingPaymentResponse = JsonConvert.DeserializeObject<IncomingPaymentResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.GetApprovalTemplatesIncomingPayment(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="IncomingPayment"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetIncomingPaymentById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{IncomingPaymentRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetIncomingPaymentById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListIncomingPayments() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="IncomingPayment"/>.</returns>
		public IList<IncomingPayment> ListIncomingPayments()
		{
			var list = new List<IncomingPayment>();
			var response = ListIncomingPayments(null);
			var incomingPaymentResponse = JsonConvert.DeserializeObject<IncomingPaymentResponse>(response.Result);

			if (incomingPaymentResponse == null)
				return list;

			list.AddRange(incomingPaymentResponse.IncomingPayments);

			while (!String.IsNullOrWhiteSpace(incomingPaymentResponse?.OdataNextLink)) {
				response = ListIncomingPayments(incomingPaymentResponse.OdataNextLink);
				incomingPaymentResponse = JsonConvert.DeserializeObject<IncomingPaymentResponse>(response.Result);

				if (incomingPaymentResponse == null)
					return list;

				list.AddRange(incomingPaymentResponse.IncomingPayments);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="IncomingPayment"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListIncomingPayments(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, IncomingPaymentRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListIncomingPayments(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="IncomingPayment"/> with the given payload of type <see cref="IncomingPayment"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="IncomingPayment"/>.</param>
		public async Task<string> PatchIncomingPayment(IncomingPayment x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, IncomingPaymentRequest.ACTION);
				var incomingPaymentRequest = new IncomingPaymentRequest(x);
				var json = incomingPaymentRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var incomingPaymentResponse = JsonConvert.DeserializeObject<IncomingPaymentResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchIncomingPayment(IncomingPayment x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="IncomingPayment"/> with the given payload of type <see cref="IncomingPayment"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="IncomingPayment"/>.</param>
		public async Task<string> PostIncomingPayment(IncomingPayment x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, IncomingPaymentRequest.ACTION);
				var incomingPaymentRequest = new IncomingPaymentRequest(x);
				var json = incomingPaymentRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var incomingPaymentResponse = JsonConvert.DeserializeObject<IncomingPaymentResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostIncomingPayment(IncomingPayment x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'RequestApproveCancellation' on this <see cref="IncomingPayment"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> RequestApproveCancellationIncomingPayment(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{IncomingPaymentRequest.ACTION}({docEntry})/RequestApproveCancellation");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var incomingPaymentResponse = JsonConvert.DeserializeObject<IncomingPaymentResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.RequestApproveCancellationIncomingPayment(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}