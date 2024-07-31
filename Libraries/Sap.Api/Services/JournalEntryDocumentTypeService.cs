using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Api.Domain.JournalEntryDocumentTypes;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="JournalEntryDocumentType"/> with the specified JournalEntryType.
		/// </summary>
		/// <param name="journalEntryType">The JournalEntryType.</param>
		public async Task<string> DeleteJournalEntryDocumentType(string journalEntryType)
		{
			var endpoint = String.Format($"{BaseUrl}{JournalEntryDocumentTypeRequest.ACTION}({journalEntryType})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteJournalEntryDocumentType(string journalEntryType='{journalEntryType}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="JournalEntryDocumentType"/> with the given BankJournalEntryType.
		/// </summary>
		/// <param name="journalEntryType">The JournalEntryType.</param>
		public async Task<string> GetJournalEntryDocumentTypeById(string journalEntryType)
		{
			var endpoint = String.Format($"{BaseUrl}{JournalEntryDocumentTypeRequest.ACTION}({journalEntryType})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetJournalEntryDocumentTypeById(string journalEntryType='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, journalEntryType);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListJournalEntryDocumentTypes() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="JournalEntryDocumentType"/>.</returns>
		public IList<JournalEntryDocumentType> ListJournalEntryDocumentTypes()
		{
			var list = new List<JournalEntryDocumentType>();
			var response = ListJournalEntryDocumentTypes(null);
			var journalEntryDocumentTypeResponse = JsonConvert.DeserializeObject<JournalEntryDocumentTypeResponse>(response.Result);

			if (journalEntryDocumentTypeResponse == null)
				return list;

			list.AddRange(journalEntryDocumentTypeResponse.JournalEntryDocumentTypes);

			while (!String.IsNullOrWhiteSpace(journalEntryDocumentTypeResponse?.OdataNextLink)) {
				response = ListJournalEntryDocumentTypes(journalEntryDocumentTypeResponse.OdataNextLink);
				journalEntryDocumentTypeResponse = JsonConvert.DeserializeObject<JournalEntryDocumentTypeResponse>(response.Result);

				if (journalEntryDocumentTypeResponse == null)
					return list;

				list.AddRange(journalEntryDocumentTypeResponse.JournalEntryDocumentTypes);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="JournalEntryDocumentType"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListJournalEntryDocumentTypes(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, JournalEntryDocumentTypeRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListJournalEntryDocumentTypes(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="JournalEntryDocumentType"/> with the given payload of type <see cref="JournalEntryDocumentType"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="JournalEntryDocumentType"/>.</param>
		public async Task<string> PatchJournalEntryDocumentType(JournalEntryDocumentType x)
		{
			var endpoint = String.Format($"{BaseUrl}{JournalEntryDocumentTypeRequest.ACTION}({x.JournalEntryType})");

			try {
				var journalEntryDocumentTypeRequest = new JournalEntryDocumentTypeRequest(x);
				var json = journalEntryDocumentTypeRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var journalEntryDocumentTypeResponse = JsonConvert.DeserializeObject<JournalEntryDocumentTypeResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchJournalEntryDocumentType(JournalEntryDocumentType x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="JournalEntryDocumentType"/> with the given payload of type <see cref="JournalEntryDocumentType"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="JournalEntryDocumentType"/>.</param>
		public async Task<string> PostJournalEntryDocumentType(JournalEntryDocumentType x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, JournalEntryDocumentTypeRequest.ACTION);
				var journalEntryDocumentTypeRequest = new JournalEntryDocumentTypeRequest(x);
				var json = journalEntryDocumentTypeRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var journalEntryDocumentTypeResponse = JsonConvert.DeserializeObject<JournalEntryDocumentTypeResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostJournalEntryDocumentType(JournalEntryDocumentType x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}