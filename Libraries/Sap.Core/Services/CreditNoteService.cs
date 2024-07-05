using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.CreditNotes;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		#region Methods
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="CreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelCreditNote(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{CreditNoteRequest.ACTION}({docEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var creditNoteResponse = JsonConvert.DeserializeObject<CreditNoteResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.CancelCreditNote(int docEntry).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Close' on this <see cref="CreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CloseCreditNote(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{CreditNoteRequest.ACTION}({docEntry})/Close");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var creditNoteResponse = JsonConvert.DeserializeObject<CreditNoteResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.CloseCreditNote(int docEntry).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'CreateCancellationDocument' on this <see cref="CreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CreateCancellationDocumentCreditNote(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{CreditNoteRequest.ACTION}({docEntry})/CreateCancellationDocument");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var creditNoteResponse = JsonConvert.DeserializeObject<CreditNoteResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.CreateCancellationDocumentCreditNote(int docEntry).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Deletes an instance of <see cref="CreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> DeleteCreditNote(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{CreditNoteRequest.ACTION}({docEntry})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteCreditNote(int docEntry='{docEntry}').{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="CreditNote"/> with the given DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetCreditNoteById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{CreditNoteRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetCreditNoteById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListCreditNotes() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="CreditNote"/>.</returns>
		public IList<CreditNote> ListCreditNotes()
		{
			var list = new List<CreditNote>();
			var response = ListCreditNotes(null);
			var creditNoteResponse = JsonConvert.DeserializeObject<CreditNoteResponse>(response.Result);

			if (creditNoteResponse == null)
				return list;

			list.AddRange(creditNoteResponse.CreditNotes);

			while (!String.IsNullOrWhiteSpace(creditNoteResponse?.OdataNextLink)) {
				response = ListCreditNotes(creditNoteResponse.OdataNextLink);
				creditNoteResponse = JsonConvert.DeserializeObject<CreditNoteResponse>(response.Result);

				if (creditNoteResponse == null)
					return list;

				list.AddRange(creditNoteResponse.CreditNotes);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="CreditNote"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListCreditNotes(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, CreditNoteRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListCreditNotes(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="CreditNote"/> with the given payload of type <see cref="CreditNote"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="CreditNote"/>.</param>
		public async Task<string> PatchCreditNote(CreditNote x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, CreditNoteRequest.ACTION);
				var creditNoteRequest = new CreditNoteRequest(x);
				var json = creditNoteRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var creditNoteResponse = JsonConvert.DeserializeObject<CreditNoteResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchCreditNote(CreditNote x).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="CreditNote"/> with the given payload of type <see cref="CreditNote"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="CreditNote"/>.</param>
		public async Task<string> PostCreditNote(CreditNote x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, CreditNoteRequest.ACTION);
				var creditNoteRequest = new CreditNoteRequest(x);
				var json = creditNoteRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var creditNoteResponse = JsonConvert.DeserializeObject<CreditNoteResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostCreditNote(CreditNote x).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Reopen' on this <see cref="CreditNote"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> ReopenCreditNote(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{CreditNoteRequest.ACTION}({docEntry})/Reopen");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var creditNoteResponse = JsonConvert.DeserializeObject<CreditNoteResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.ReopenCreditNote(int docEntry).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
		#endregion
	}
}