using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.Invoices;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="Invoice"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelInvoice(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{InvoiceRequest.ACTION}({docEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var invoiceResponse = JsonConvert.DeserializeObject<InvoiceResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelInvoice(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Close' on this <see cref="Invoice"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CloseInvoice(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{InvoiceRequest.ACTION}({docEntry})/Close");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var invoiceResponse = JsonConvert.DeserializeObject<InvoiceResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CloseInvoice(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'CreateCancellationDocument' on this <see cref="Invoice"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CreateCancellationDocumentInvoice(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{InvoiceRequest.ACTION}({docEntry})/CreateCancellationDocument");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var invoiceResponse = JsonConvert.DeserializeObject<InvoiceResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CreateCancellationDocumentInvoice(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="Invoice"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetInvoiceById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{InvoiceRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetInvoiceById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListInvoices() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="Invoice"/>.</returns>
		public IList<Invoice> ListInvoices()
		{
			var list = new List<Invoice>();
			var response = ListInvoices(null);
			var invoiceResponse = JsonConvert.DeserializeObject<InvoiceResponse>(response.Result);

			if (invoiceResponse == null)
				return list;

			list.AddRange(invoiceResponse.Invoices);

			while (!String.IsNullOrWhiteSpace(invoiceResponse?.OdataNextLink)) {
				response = ListInvoices(invoiceResponse.OdataNextLink);
				invoiceResponse = JsonConvert.DeserializeObject<InvoiceResponse>(response.Result);

				if (invoiceResponse == null)
					return list;

				list.AddRange(invoiceResponse.Invoices);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="Invoice"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListInvoices(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, InvoiceRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListInvoices(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="Invoice"/> with the given payload of type <see cref="Invoice"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="Invoice"/>.</param>
		public async Task<string> PatchInvoice(Invoice x)
		{
			var endpoint = String.Format($"{BaseUrl}{InvoiceRequest.ACTION}({x.DocEntry})");

			try {
				var invoiceRequest = new InvoiceRequest(x);
				var json = invoiceRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var invoiceResponse = JsonConvert.DeserializeObject<InvoiceResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchInvoice(Invoice x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="Invoice"/> with the given payload of type <see cref="Invoice"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="Invoice"/>.</param>
		public async Task<string> PostInvoice(Invoice x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, InvoiceRequest.ACTION);
				var invoiceRequest = new InvoiceRequest(x);
				var json = invoiceRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var invoiceResponse = JsonConvert.DeserializeObject<InvoiceResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostInvoice(Invoice x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Reopen' on this <see cref="Invoice"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ReopenInvoice(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{InvoiceRequest.ACTION}({docEntry})/Reopen");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var invoiceResponse = JsonConvert.DeserializeObject<InvoiceResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.ReopenInvoice(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}