using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Core.Domain.PurchaseCreditNotes;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="PurchaseCreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelPurchaseCreditNote(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseCreditNoteRequest.ACTION}({docEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseCreditNoteResponse = JsonConvert.DeserializeObject<PurchaseCreditNoteResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelPurchaseCreditNote(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Close' on this <see cref="PurchaseCreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ClosePurchaseCreditNote(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseCreditNoteRequest.ACTION}({docEntry})/Close");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseCreditNoteResponse = JsonConvert.DeserializeObject<PurchaseCreditNoteResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.ClosePurchaseCreditNote(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'CreateCancellationDocument' on this <see cref="PurchaseCreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CreateCancellationDocumentPurchaseCreditNote(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseCreditNoteRequest.ACTION}({docEntry})/CreateCancellationDocument");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseCreditNoteResponse = JsonConvert.DeserializeObject<PurchaseCreditNoteResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CreateCancellationDocumentPurchaseCreditNote(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Deletes an instance of <see cref="PurchaseCreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> DeletePurchaseCreditNotes(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseCreditNoteRequest.ACTION}({docEntry})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeletePurchaseCreditNotes(int docEntry='{docEntry}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="PurchaseCreditNote"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetPurchaseCreditNoteById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseCreditNoteRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetPurchaseCreditNoteById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListPurchaseCreditNotes() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="PurchaseCreditNote"/>.</returns>
		public IList<PurchaseCreditNote> ListPurchaseCreditNotes()
		{
			var list = new List<PurchaseCreditNote>();
			var response = ListPurchaseCreditNotes(null);
			var purchaseCreditNoteResponse = JsonConvert.DeserializeObject<PurchaseCreditNoteResponse>(response.Result);

			if (purchaseCreditNoteResponse == null)
				return list;

			list.AddRange(purchaseCreditNoteResponse.PurchaseCreditNotes);

			while (!String.IsNullOrWhiteSpace(purchaseCreditNoteResponse?.OdataNextLink)) {
				response = ListPurchaseCreditNotes(purchaseCreditNoteResponse.OdataNextLink);
				purchaseCreditNoteResponse = JsonConvert.DeserializeObject<PurchaseCreditNoteResponse>(response.Result);

				if (purchaseCreditNoteResponse == null)
					return list;

				list.AddRange(purchaseCreditNoteResponse.PurchaseCreditNotes);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="PurchaseCreditNote"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListPurchaseCreditNotes(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, PurchaseCreditNoteRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListPurchaseCreditNotes(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="PurchaseCreditNote"/> with the given payload of type <see cref="PurchaseCreditNote"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseCreditNote"/>.</param>
		public async Task<string> PatchPurchaseCreditNote(PurchaseCreditNote x)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseCreditNoteRequest.ACTION}({x.DocEntry})");

			try {
				var purchaseCreditNoteRequest = new PurchaseCreditNoteRequest(x);
				var json = purchaseCreditNoteRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseCreditNoteResponse = JsonConvert.DeserializeObject<PurchaseCreditNoteResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchPurchaseCreditNote(PurchaseCreditNote x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="PurchaseCreditNote"/> with the given payload of type <see cref="PurchaseCreditNote"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseCreditNote"/>.</param>
		public async Task<string> PostPurchaseCreditNote(PurchaseCreditNote x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, PurchaseCreditNoteRequest.ACTION);
				var purchaseCreditNoteRequest = new PurchaseCreditNoteRequest(x);
				var json = purchaseCreditNoteRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var purchaseCreditNoteResponse = JsonConvert.DeserializeObject<PurchaseCreditNoteResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostPurchaseCreditNote(PurchaseCreditNote x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Reopen' on this <see cref="PurchaseCreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ReopenPurchaseCreditNote(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{PurchaseCreditNoteRequest.ACTION}({docEntry})/Reopen");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var purchaseCreditNoteResponse = JsonConvert.DeserializeObject<PurchaseCreditNoteResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.ReopenPurchaseCreditNote(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}