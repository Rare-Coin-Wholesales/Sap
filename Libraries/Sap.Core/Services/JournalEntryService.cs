using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.JournalEntries;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="JournalEntry"/> with the specified JdtNum.
		/// </summary>
		/// <param name="jdtNum">The JdtNum</param>
		public async Task<string> CancelJournalEntry(int jdtNum)
		{
			var endpoint = String.Format($"{BaseUrl}{JournalEntryRequest.ACTION}({jdtNum})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var journalEntryResponse = JsonConvert.DeserializeObject<JournalEntryResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelJournalEntry(int jdtNum).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="JournalEntry"/> with the given BankJdtNum.
		/// </summary>
		/// <param name="jdtNum">The JdtNum.</param>
		public async Task<string> GetJournalEntryById(int jdtNum)
		{
			var endpoint = String.Format($"{BaseUrl}{JournalEntryRequest.ACTION}({jdtNum})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetJournalEntryById(int jdtNum='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, jdtNum);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListJournalEntries() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="JournalEntry"/>.</returns>
		public IList<JournalEntry> ListJournalEntries()
		{
			var list = new List<JournalEntry>();
			var response = ListJournalEntries(null);
			var journalEntryResponse = JsonConvert.DeserializeObject<JournalEntryResponse>(response.Result);

			if (journalEntryResponse == null)
				return list;

			list.AddRange(journalEntryResponse.JournalEntries);

			while (!String.IsNullOrWhiteSpace(journalEntryResponse?.OdataNextLink)) {
				response = ListJournalEntries(journalEntryResponse.OdataNextLink);
				journalEntryResponse = JsonConvert.DeserializeObject<JournalEntryResponse>(response.Result);

				if (journalEntryResponse == null)
					return list;

				list.AddRange(journalEntryResponse.JournalEntries);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="JournalEntry"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListJournalEntries(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, JournalEntryRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListJournalEntries(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="JournalEntry"/> with the given payload of type <see cref="JournalEntry"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="JournalEntry"/>.</param>
		public async Task<string> PatchJournalEntry(JournalEntry x)
		{
			var endpoint = String.Format($"{BaseUrl}{JournalEntryRequest.ACTION}({x.JdtNum})");

			try {
				var journalEntryRequest = new JournalEntryRequest(x);
				var json = journalEntryRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var journalEntryResponse = JsonConvert.DeserializeObject<JournalEntryResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchJournalEntry(JournalEntry x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="JournalEntry"/> with the given payload of type <see cref="JournalEntry"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="JournalEntry"/>.</param>
		public async Task<string> PostJournalEntry(JournalEntry x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, JournalEntryRequest.ACTION);
				var journalEntryRequest = new JournalEntryRequest(x);
				var json = journalEntryRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var journalEntryResponse = JsonConvert.DeserializeObject<JournalEntryResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostJournalEntry(JournalEntry x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}