using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Api.Domain.ChecksforPayments;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Gets an instance of <see cref="ChecksforPayment"/> with the given CheckKey.
		/// </summary>
		/// <param name="checkKey">The CheckKey.</param>
		public async Task<string> GetChecksforPaymentById(int checkKey)
		{
			var endpoint = String.Format($"{BaseUrl}{ChecksforPaymentRequest.ACTION}({checkKey})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetChecksforPaymentById(string checkKey='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, checkKey);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListChecksforPayments() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="ChecksforPayment"/>.</returns>
		public IList<ChecksforPayment> ListChecksforPayments()
		{
			var list = new List<ChecksforPayment>();
			var response = ListChecksforPayments(null);
			var checksforPaymentResponse = JsonConvert.DeserializeObject<ChecksforPaymentResponse>(response.Result);

			if (checksforPaymentResponse == null)
				return list;

			list.AddRange(checksforPaymentResponse.ChecksforPayments);

			while (!String.IsNullOrWhiteSpace(checksforPaymentResponse?.OdataNextLink)) {
				response = ListChecksforPayments(checksforPaymentResponse.OdataNextLink);
				checksforPaymentResponse = JsonConvert.DeserializeObject<ChecksforPaymentResponse>(response.Result);

				if (checksforPaymentResponse == null)
					return list;

				list.AddRange(checksforPaymentResponse.ChecksforPayments);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="ChecksforPayment"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListChecksforPayments(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, ChecksforPaymentRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListChecksforPayments(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="ChecksforPayment"/> with the given payload of type <see cref="ChecksforPayment"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="ChecksforPayment"/>.</param>
		public async Task<string> PatchChecksforPayment(ChecksforPayment x)
		{
			var endpoint = String.Format($"{BaseUrl}{ChecksforPaymentRequest.ACTION}({x.CheckKey})");

			try {
				var checksforPaymentRequest = new ChecksforPaymentRequest(x);
				var json = checksforPaymentRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var checksforPaymentResponse = JsonConvert.DeserializeObject<ChecksforPaymentResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchChecksforPayment(ChecksforPayment x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="ChecksforPayment"/> with the given payload of type <see cref="ChecksforPayment"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="ChecksforPayment"/>.</param>
		public async Task<string> PostChecksforPayment(ChecksforPayment x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, ChecksforPaymentRequest.ACTION);
				var checksforPaymentRequest = new ChecksforPaymentRequest(x);
				var json = checksforPaymentRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var checksforPaymentResponse = JsonConvert.DeserializeObject<ChecksforPaymentResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchChecksforPayment(ChecksforPayment x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}