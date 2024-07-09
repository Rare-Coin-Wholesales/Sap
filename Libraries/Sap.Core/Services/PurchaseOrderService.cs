using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.PurchaseOrders;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="PurchaseOrder"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelPurchaseOrder(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseOrderRequest.ACTION}({docEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseOrderResponse = JsonConvert.DeserializeObject<PurchaseOrderResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelPurchaseOrder(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Close' on this <see cref="PurchaseOrder"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ClosePurchaseOrder(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseOrderRequest.ACTION}({docEntry})/Close");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseOrderResponse = JsonConvert.DeserializeObject<PurchaseOrderResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.ClosePurchaseOrder(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'CreateCancellationDocument' on this <see cref="PurchaseOrder"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CreateCancellationDocumentPurchaseOrder(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseOrderRequest.ACTION}({docEntry})/CreateCancellationDocument");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseOrderResponse = JsonConvert.DeserializeObject<PurchaseOrderResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CreateCancellationDocumentPurchaseOrder(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="PurchaseOrder"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetPurchaseOrderById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseOrderRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetPurchaseOrderById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListPurchaseOrders() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="PurchaseOrder"/>.</returns>
		public IList<PurchaseOrder> ListPurchaseOrders()
		{
			var list = new List<PurchaseOrder>();
			var response = ListPurchaseOrders(null);
			var purchaseOrderResponse = JsonConvert.DeserializeObject<PurchaseOrderResponse>(response.Result);

			if (purchaseOrderResponse == null)
				return list;

			list.AddRange(purchaseOrderResponse.PurchaseOrders);

			while (!String.IsNullOrWhiteSpace(purchaseOrderResponse?.OdataNextLink)) {
				response = ListPurchaseOrders(purchaseOrderResponse.OdataNextLink);
				purchaseOrderResponse = JsonConvert.DeserializeObject<PurchaseOrderResponse>(response.Result);

				if (purchaseOrderResponse == null)
					return list;

				list.AddRange(purchaseOrderResponse.PurchaseOrders);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="PurchaseOrder"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListPurchaseOrders(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, PurchaseOrderRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListPurchaseOrders(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="PurchaseOrder"/> with the given payload of type <see cref="PurchaseOrder"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseOrder"/>.</param>
		public async Task<string> PatchPurchaseOrder(PurchaseOrder x)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseOrderRequest.ACTION}({x.DocEntry})");

			try {
				var purchaseOrderRequest = new PurchaseOrderRequest(x);
				var json = purchaseOrderRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseOrderResponse = JsonConvert.DeserializeObject<PurchaseOrderResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchPurchaseOrder(PurchaseOrder x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="PurchaseOrder"/> with the given payload of type <see cref="PurchaseOrder"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseOrder"/>.</param>
		public async Task<string> PostPurchaseOrder(PurchaseOrder x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, PurchaseOrderRequest.ACTION);
				var purchaseOrderRequest = new PurchaseOrderRequest(x);
				var json = purchaseOrderRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseOrderResponse = JsonConvert.DeserializeObject<PurchaseOrderResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostPurchaseOrder(PurchaseOrder x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Reopen' on this <see cref="PurchaseOrder"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ReopenPurchaseOrder(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseOrderRequest.ACTION}({docEntry})/Reopen");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseOrderResponse = JsonConvert.DeserializeObject<PurchaseOrderResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.ReopenPurchaseOrder(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}