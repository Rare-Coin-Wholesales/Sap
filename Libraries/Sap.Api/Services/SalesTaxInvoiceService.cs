using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Api.Domain.SalesTaxInvoices;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="SalesTaxInvoice"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> DeleteSalesTaxInvoice(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{SalesTaxInvoiceRequest.ACTION}({docEntry})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteSalesTaxInvoice(int docEntry='{docEntry}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="SalesTaxInvoice"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetSalesTaxInvoiceById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{SalesTaxInvoiceRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetSalesTaxInvoiceById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListSalesTaxInvoices() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="SalesTaxInvoice"/>.</returns>
		public IList<SalesTaxInvoice> ListSalesTaxInvoices()
		{
			var list = new List<SalesTaxInvoice>();
			var response = ListSalesTaxInvoices(null);
			var salesTaxInvoiceResponse = JsonConvert.DeserializeObject<SalesTaxInvoiceResponse>(response.Result);

			if (salesTaxInvoiceResponse == null)
				return list;

			list.AddRange(salesTaxInvoiceResponse.SalesTaxInvoices);

			while (!String.IsNullOrWhiteSpace(salesTaxInvoiceResponse?.OdataNextLink)) {
				response = ListSalesTaxInvoices(salesTaxInvoiceResponse.OdataNextLink);
				salesTaxInvoiceResponse = JsonConvert.DeserializeObject<SalesTaxInvoiceResponse>(response.Result);

				if (salesTaxInvoiceResponse == null)
					return list;

				list.AddRange(salesTaxInvoiceResponse.SalesTaxInvoices);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="SalesTaxInvoice"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListSalesTaxInvoices(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, SalesTaxInvoiceRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListSalesTaxInvoices(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="SalesTaxInvoice"/> with the given payload of type <see cref="SalesTaxInvoice"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="SalesTaxInvoice"/>.</param>
		public async Task<string> PatchSalesTaxInvoice(SalesTaxInvoice x)
		{
			var endpoint = String.Format($"{BaseUrl}{SalesTaxInvoiceRequest.ACTION}({x.DocEntry})");

			try {
				var salesTaxInvoiceRequest = new SalesTaxInvoiceRequest(x);
				var json = salesTaxInvoiceRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var salesTaxInvoiceResponse = JsonConvert.DeserializeObject<SalesTaxInvoiceResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchSalesTaxInvoice(SalesTaxInvoice x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="SalesTaxInvoice"/> with the given payload of type <see cref="SalesTaxInvoice"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="SalesTaxInvoice"/>.</param>
		public async Task<string> PostSalesTaxInvoice(SalesTaxInvoice x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, SalesTaxInvoiceRequest.ACTION);
				var salesTaxInvoiceRequest = new SalesTaxInvoiceRequest(x);
				var json = salesTaxInvoiceRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var salesTaxInvoiceResponse = JsonConvert.DeserializeObject<SalesTaxInvoiceResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostSalesTaxInvoice(SalesTaxInvoice x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}