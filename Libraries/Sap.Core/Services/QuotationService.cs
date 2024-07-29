using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Core.Domain.Quotations;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="Quotation"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelQuotation(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{QuotationRequest.ACTION}({docEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var quotationResponse = JsonConvert.DeserializeObject<QuotationResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.CancelQuotation(int docEntry).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Close' on this <see cref="Quotation"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CloseQuotation(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{QuotationRequest.ACTION}({docEntry})/Close");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var quotationResponse = JsonConvert.DeserializeObject<QuotationResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.CloseQuotation(int docEntry).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'CreateCancellationDocument' on this <see cref="Quotation"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CreateCancellationDocumentQuotation(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{QuotationRequest.ACTION}({docEntry})/CreateCancellationDocument");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var quotationResponse = JsonConvert.DeserializeObject<QuotationResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.CreateCancellationDocumentQuotation(int docEntry).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="Quotation"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetQuotationById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{QuotationRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetQuotationById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListQuotations() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="Quotation"/>.</returns>
		public IList<Quotation> ListQuotations()
		{
			var list = new List<Quotation>();
			var response = ListQuotations(null);
			var quotationResponse = JsonConvert.DeserializeObject<QuotationResponse>(response.Result);

			if (quotationResponse == null)
				return list;

			list.AddRange(quotationResponse.Quotations);

			while (!String.IsNullOrWhiteSpace(quotationResponse?.OdataNextLink)) {
				response = ListQuotations(quotationResponse.OdataNextLink);
				quotationResponse = JsonConvert.DeserializeObject<QuotationResponse>(response.Result);

				if (quotationResponse == null)
					return list;

				list.AddRange(quotationResponse.Quotations);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="Quotation"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListQuotations(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, QuotationRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListQuotations(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="Quotation"/> with the given payload of type <see cref="Quotation"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="Quotation"/>.</param>
		public async Task<string> PatchQuotation(Quotation x)
		{
			var endpoint = String.Format($"{BaseUrl}{QuotationRequest.ACTION}({x.DocEntry})");

			try {
				var quotationRequest = new QuotationRequest(x);
				var json = quotationRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var quotationResponse = JsonConvert.DeserializeObject<QuotationResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchQuotation(Quotation x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="Quotation"/> with the given payload of type <see cref="Quotation"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="Quotation"/>.</param>
		public async Task<string> PostQuotation(Quotation x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, QuotationRequest.ACTION);
				var quotationRequest = new QuotationRequest(x);
				var json = quotationRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var quotationResponse = JsonConvert.DeserializeObject<QuotationResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostQuotation(Quotation x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Reopen' on this <see cref="Quotation"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ReopenQuotation(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{QuotationRequest.ACTION}({docEntry})/Reopen");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var quotationResponse = JsonConvert.DeserializeObject<QuotationResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.ReopenQuotation(int docEntry).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}