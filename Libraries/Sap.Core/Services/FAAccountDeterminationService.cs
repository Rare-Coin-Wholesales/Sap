using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.FAAccountDeterminations;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="FAAccountDetermination"/> with the specified Code.
		/// </summary>
		/// <param name="code">The Code.</param>
		public async Task<string> DeleteFAAccountDetermination(string code)
		{
			var endpoint = String.Format($"{BaseUrl}{FAAccountDeterminationRequest.ACTION}({code})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteFAAccountDetermination(string code='{code}').{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="FAAccountDetermination"/> with the given ID.
		/// </summary>
		/// <param name="id">The ID of the <see cref="FAAccountDetermination"/>.</param>
		public async Task<string> GetFAAccountDeterminationById(int id)
		{
			var endpoint = String.Format($"{BaseUrl}{FAAccountDeterminationRequest.ACTION}({id})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetFAAccountDeterminationById(int id='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, id);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListFAAccountDeterminations() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="FAAccountDetermination"/>.</returns>
		public IList<FAAccountDetermination> ListFAAccountDeterminations()
		{
			var list = new List<FAAccountDetermination>();
			var response = ListFAAccountDeterminations(null);
			var fAAccountDeterminationResponse = JsonConvert.DeserializeObject<FAAccountDeterminationResponse>(response.Result);

			if (fAAccountDeterminationResponse == null)
				return list;

			list.AddRange(fAAccountDeterminationResponse.FAAccountDeterminations);

			while (!String.IsNullOrWhiteSpace(fAAccountDeterminationResponse?.OdataNextLink)) {
				response = ListFAAccountDeterminations(fAAccountDeterminationResponse.OdataNextLink);
				fAAccountDeterminationResponse = JsonConvert.DeserializeObject<FAAccountDeterminationResponse>(response.Result);

				if (fAAccountDeterminationResponse == null)
					return list;

				list.AddRange(fAAccountDeterminationResponse.FAAccountDeterminations);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="FAAccountDetermination"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListFAAccountDeterminations(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, FAAccountDeterminationRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListFAAccountDeterminations(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="FAAccountDetermination"/> with the given payload of type <see cref="FAAccountDetermination"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="FAAccountDetermination"/>.</param>
		public async Task<string> PatchFAAccountDetermination(FAAccountDetermination x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, FAAccountDeterminationRequest.ACTION);
				var fAAccountDeterminationRequest = new FAAccountDeterminationRequest(x);
				var json = fAAccountDeterminationRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var fAAccountDeterminationResponse = JsonConvert.DeserializeObject<FAAccountDeterminationResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchFAAccountDetermination(FAAccountDetermination x).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="FAAccountDetermination"/> with the given payload of type <see cref="FAAccountDetermination"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="FAAccountDetermination"/>.</param>
		public async Task<string> PostFAAccountDetermination(FAAccountDetermination x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, FAAccountDeterminationRequest.ACTION);
				var fAAccountDeterminationRequest = new FAAccountDeterminationRequest(x);
				var json = fAAccountDeterminationRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var fAAccountDeterminationResponse = JsonConvert.DeserializeObject<FAAccountDeterminationResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostFAAccountDetermination(FAAccountDetermination x).{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}