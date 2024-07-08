using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.Deposits;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="Deposit"/> with the specified AbsEntry.
		/// </summary>
		/// <param name="absEntry">The AbsEntry</param>
		public async Task<string> CancelDeposit(int absEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{DepositRequest.ACTION}({absEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var depositResponse = JsonConvert.DeserializeObject<DepositResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.CancelDeposit(int absEntry).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'CancelDepositbyCurrentSystemDate' on this <see cref="Deposit"/> with the specified AbsEntry.
		/// </summary>
		/// <param name="absEntry">The AbsEntry</param>
		public async Task<string> CancelDepositbyCurrentSystemDate(int absEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{DepositRequest.ACTION}({absEntry})/CancelDepositbyCurrentSystemDate");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var depositResponse = JsonConvert.DeserializeObject<DepositResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.CancelDepositbyCurrentSystemDate(int absEntry).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Deletes an instance of <see cref="Deposit"/> with the specified AbsEntry.
		/// </summary>
		/// <param name="absEntry">The AbsEntry.</param>
		public async Task<string> DeleteDeposit(int absEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{DepositRequest.ACTION}({absEntry})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteDeposit(int absEntry='{absEntry}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="Deposit"/> with the given BankAbsEntry.
		/// </summary>
		/// <param name="absEntry">The AbsEntry.</param>
		public async Task<string> GetDepositById(int absEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{DepositRequest.ACTION}({absEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetDepositById(int absEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, absEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListDeposits() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="Deposit"/>.</returns>
		public IList<Deposit> ListDeposits()
		{
			var list = new List<Deposit>();
			var response = ListDeposits(null);
			var depositResponse = JsonConvert.DeserializeObject<DepositResponse>(response.Result);

			if (depositResponse == null)
				return list;

			list.AddRange(depositResponse.Deposits);

			while (!String.IsNullOrWhiteSpace(depositResponse?.OdataNextLink)) {
				response = ListDeposits(depositResponse.OdataNextLink);
				depositResponse = JsonConvert.DeserializeObject<DepositResponse>(response.Result);

				if (depositResponse == null)
					return list;

				list.AddRange(depositResponse.Deposits);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="Deposit"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListDeposits(string? nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, DepositRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListDeposits(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="Deposit"/> with the given payload of type <see cref="Deposit"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="Deposit"/>.</param>
		public async Task<string> PatchDeposit(Deposit x)
		{
			var endpoint = String.Format($"{BaseUrl}{DepositRequest.ACTION}({x.AbsEntry})");

			try {
				var depositRequest = new DepositRequest(x);
				var json = depositRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PatchAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var depositResponse = JsonConvert.DeserializeObject<DepositResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchDeposit(Deposit x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="Deposit"/> with the given payload of type <see cref="Deposit"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="Deposit"/>.</param>
		public async Task<string> PostDeposit(Deposit x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, DepositRequest.ACTION);
				var depositRequest = new DepositRequest(x);
				var json = depositRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var depositResponse = JsonConvert.DeserializeObject<DepositResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostDeposit(Deposit x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}