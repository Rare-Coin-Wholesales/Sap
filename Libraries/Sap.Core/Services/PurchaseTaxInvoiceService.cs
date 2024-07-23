using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core.Domain.PurchaseTaxInvoices;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Gets an instance of <see cref="PurchaseTaxInvoice"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetPurchaseTaxInvoiceById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseTaxInvoiceRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetPurchaseTaxInvoiceById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListPurchaseTaxInvoices() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="PurchaseTaxInvoice"/>.</returns>
		public IList<PurchaseTaxInvoice> ListPurchaseTaxInvoices()
		{
			var list = new List<PurchaseTaxInvoice>();
			var response = ListPurchaseTaxInvoices(null);
			var purchaseTaxInvoiceResponse = JsonConvert.DeserializeObject<PurchaseTaxInvoiceResponse>(response.Result);

			if (purchaseTaxInvoiceResponse == null)
				return list;

			list.AddRange(purchaseTaxInvoiceResponse.PurchaseTaxInvoices);

			while (!String.IsNullOrWhiteSpace(purchaseTaxInvoiceResponse?.OdataNextLink)) {
				response = ListPurchaseTaxInvoices(purchaseTaxInvoiceResponse.OdataNextLink);
				purchaseTaxInvoiceResponse = JsonConvert.DeserializeObject<PurchaseTaxInvoiceResponse>(response.Result);

				if (purchaseTaxInvoiceResponse == null)
					return list;

				list.AddRange(purchaseTaxInvoiceResponse.PurchaseTaxInvoices);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="PurchaseTaxInvoice"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListPurchaseTaxInvoices(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, PurchaseTaxInvoiceRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListPurchaseTaxInvoices(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="PurchaseTaxInvoice"/> with the given payload of type <see cref="PurchaseTaxInvoice"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseTaxInvoice"/>.</param>
		public async Task<string> PatchPurchaseTaxInvoice(PurchaseTaxInvoice x)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseTaxInvoiceRequest.ACTION}({x.DocEntry})");

			try {
				var purchaseTaxInvoiceRequest = new PurchaseTaxInvoiceRequest(x);
				var json = purchaseTaxInvoiceRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseTaxInvoiceResponse = JsonConvert.DeserializeObject<PurchaseTaxInvoiceResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchPurchaseTaxInvoice(PurchaseTaxInvoice x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="PurchaseTaxInvoice"/> with the given payload of type <see cref="PurchaseTaxInvoice"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseTaxInvoice"/>.</param>
		public async Task<string> PostPurchaseTaxInvoice(PurchaseTaxInvoice x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, PurchaseTaxInvoiceRequest.ACTION);
				var purchaseTaxInvoiceRequest = new PurchaseTaxInvoiceRequest(x);
				var json = purchaseTaxInvoiceRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseTaxInvoiceResponse = JsonConvert.DeserializeObject<PurchaseTaxInvoiceResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostPurchaseTaxInvoice(PurchaseTaxInvoice x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}