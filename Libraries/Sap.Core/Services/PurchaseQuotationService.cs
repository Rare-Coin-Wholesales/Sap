using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Core.Domain.PurchaseQuotations;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="PurchaseQuotation"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelPurchaseQuotation(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseQuotationRequest.ACTION}({docEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseQuotationResponse = JsonConvert.DeserializeObject<PurchaseQuotationResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelPurchaseQuotation(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Close' on this <see cref="PurchaseQuotation"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ClosePurchaseQuotation(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseQuotationRequest.ACTION}({docEntry})/Close");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseQuotationResponse = JsonConvert.DeserializeObject<PurchaseQuotationResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.ClosePurchaseQuotation(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'CreateCancellationDocument' on this <see cref="PurchaseQuotation"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CreateCancellationDocumentPurchaseQuotation(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseQuotationRequest.ACTION}({docEntry})/CreateCancellationDocument");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseQuotationResponse = JsonConvert.DeserializeObject<PurchaseQuotationResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CreateCancellationDocumentPurchaseQuotation(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="PurchaseQuotation"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetPurchaseQuotationById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseQuotationRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetPurchaseQuotationById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListPurchaseQuotations() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="PurchaseQuotation"/>.</returns>
		public IList<PurchaseQuotation> ListPurchaseQuotations()
		{
			var list = new List<PurchaseQuotation>();
			var response = ListPurchaseQuotations(null);
			var purchaseQuotationResponse = JsonConvert.DeserializeObject<PurchaseQuotationResponse>(response.Result);

			if (purchaseQuotationResponse == null)
				return list;

			list.AddRange(purchaseQuotationResponse.PurchaseQuotations);

			while (!String.IsNullOrWhiteSpace(purchaseQuotationResponse?.OdataNextLink)) {
				response = ListPurchaseQuotations(purchaseQuotationResponse.OdataNextLink);
				purchaseQuotationResponse = JsonConvert.DeserializeObject<PurchaseQuotationResponse>(response.Result);

				if (purchaseQuotationResponse == null)
					return list;

				list.AddRange(purchaseQuotationResponse.PurchaseQuotations);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="PurchaseQuotation"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListPurchaseQuotations(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, PurchaseQuotationRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListPurchaseQuotations(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="PurchaseQuotation"/> with the given payload of type <see cref="PurchaseQuotation"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseQuotation"/>.</param>
		public async Task<string> PatchPurchaseQuotation(PurchaseQuotation x)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseQuotationRequest.ACTION}({x.DocEntry})");

			try {
				var purchaseQuotationRequest = new PurchaseQuotationRequest(x);
				var json = purchaseQuotationRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseQuotationResponse = JsonConvert.DeserializeObject<PurchaseQuotationResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchPurchaseQuotation(PurchaseQuotation x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="PurchaseQuotation"/> with the given payload of type <see cref="PurchaseQuotation"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseQuotation"/>.</param>
		public async Task<string> PostPurchaseQuotation(PurchaseQuotation x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, PurchaseQuotationRequest.ACTION);
				var purchaseQuotationRequest = new PurchaseQuotationRequest(x);
				var json = purchaseQuotationRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseQuotationResponse = JsonConvert.DeserializeObject<PurchaseQuotationResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostPurchaseQuotation(PurchaseQuotation x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Reopen' on this <see cref="PurchaseQuotation"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ReopenPurchaseQuotation(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseQuotationRequest.ACTION}({docEntry})/Reopen");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseQuotationResponse = JsonConvert.DeserializeObject<PurchaseQuotationResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.ReopenPurchaseQuotation(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}