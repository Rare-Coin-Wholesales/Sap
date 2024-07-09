using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.PurchaseInvoices;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="PurchaseInvoice"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelPurchaseInvoice(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseInvoiceRequest.ACTION}({docEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseInvoiceResponse = JsonConvert.DeserializeObject<PurchaseInvoiceResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelPurchaseInvoice(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Close' on this <see cref="PurchaseInvoice"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ClosePurchaseInvoice(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseInvoiceRequest.ACTION}({docEntry})/Close");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseInvoiceResponse = JsonConvert.DeserializeObject<PurchaseInvoiceResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.ClosePurchaseInvoice(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'CreateCancellationDocument' on this <see cref="PurchaseInvoice"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CreateCancellationDocumentPurchaseInvoice(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseInvoiceRequest.ACTION}({docEntry})/CreateCancellationDocument");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseInvoiceResponse = JsonConvert.DeserializeObject<PurchaseInvoiceResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CreateCancellationDocumentPurchaseInvoice(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="PurchaseInvoice"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetPurchaseInvoiceById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseInvoiceRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetPurchaseInvoiceById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListPurchaseInvoices() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="PurchaseInvoice"/>.</returns>
		public IList<PurchaseInvoice> ListPurchaseInvoices()
		{
			var list = new List<PurchaseInvoice>();
			var response = ListPurchaseInvoices(null);
			var purchaseInvoiceResponse = JsonConvert.DeserializeObject<PurchaseInvoiceResponse>(response.Result);

			if (purchaseInvoiceResponse == null)
				return list;

			list.AddRange(purchaseInvoiceResponse.PurchaseInvoices);

			while (!String.IsNullOrWhiteSpace(purchaseInvoiceResponse?.OdataNextLink)) {
				response = ListPurchaseInvoices(purchaseInvoiceResponse.OdataNextLink);
				purchaseInvoiceResponse = JsonConvert.DeserializeObject<PurchaseInvoiceResponse>(response.Result);

				if (purchaseInvoiceResponse == null)
					return list;

				list.AddRange(purchaseInvoiceResponse.PurchaseInvoices);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="PurchaseInvoice"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListPurchaseInvoices(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, PurchaseInvoiceRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListPurchaseInvoices(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="PurchaseInvoice"/> with the given payload of type <see cref="PurchaseInvoice"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseInvoice"/>.</param>
		public async Task<string> PatchPurchaseInvoice(PurchaseInvoice x)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseInvoiceRequest.ACTION}({x.DocEntry})");

			try {
				var purchaseInvoiceRequest = new PurchaseInvoiceRequest(x);
				var json = purchaseInvoiceRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseInvoiceResponse = JsonConvert.DeserializeObject<PurchaseInvoiceResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchPurchaseInvoice(PurchaseInvoice x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="PurchaseInvoice"/> with the given payload of type <see cref="PurchaseInvoice"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseInvoice"/>.</param>
		public async Task<string> PostPurchaseInvoice(PurchaseInvoice x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, PurchaseInvoiceRequest.ACTION);
				var purchaseInvoiceRequest = new PurchaseInvoiceRequest(x);
				var json = purchaseInvoiceRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseInvoiceResponse = JsonConvert.DeserializeObject<PurchaseInvoiceResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostPurchaseInvoice(PurchaseInvoice x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Reopen' on this <see cref="PurchaseInvoice"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ReopenPurchaseInvoice(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseInvoiceRequest.ACTION}({docEntry})/Reopen");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseInvoiceResponse = JsonConvert.DeserializeObject<PurchaseInvoiceResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.ReopenPurchaseInvoice(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}