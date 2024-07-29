using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Core.Domain.VendorPayments;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Invokes the method 'CancelbyCurrentSystemDate' on this <see cref="VendorPayment"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelByCurrentSystemDateVendorPayment(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{VendorPaymentRequest.ACTION}({docEntry})/CancelbyCurrentSystemDate");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var vendorPaymentResponse = JsonConvert.DeserializeObject<VendorPaymentResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelByCurrentSystemDateVendorPayment(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'Cancel' on this <see cref="VendorPayment"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> CancelVendorPayment(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{VendorPaymentRequest.ACTION}({docEntry})/Cancel");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var vendorPaymentResponse = JsonConvert.DeserializeObject<VendorPaymentResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.CancelVendorPayment(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Invokes the method 'GetApprovalTemplates' on this <see cref="VendorPayment"/> with the specified DocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry</param>
		public async Task<string> GetApprovalTemplatesVendorPayment(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{VendorPaymentRequest.ACTION}({docEntry})/GetApprovalTemplates");

			try {
				using (var response = await Client.PostAsync(endpoint, null)) {
					string responseData = await response.Content.ReadAsStringAsync();
					WriteToFile(responseData);
					var vendorPaymentResponse = JsonConvert.DeserializeObject<VendorPaymentResponse>(responseData);

					return responseData;
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.GetApprovalTemplatesVendorPayment(int docEntry).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="VendorPayment"/> with the given BankDocEntry.
		/// </summary>
		/// <param name="docEntry">The DocEntry.</param>
		public async Task<string> GetVendorPaymentById(int docEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{VendorPaymentRequest.ACTION}({docEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetVendorPaymentById(int docEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, docEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListVendorPayments() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="VendorPayment"/>.</returns>
		public IList<VendorPayment> ListVendorPayments()
		{
			var list = new List<VendorPayment>();
			var response = ListVendorPayments(null);
			var vendorPaymentResponse = JsonConvert.DeserializeObject<VendorPaymentResponse>(response.Result);

			if (vendorPaymentResponse == null)
				return list;

			list.AddRange(vendorPaymentResponse.VendorPayments);

			while (!String.IsNullOrWhiteSpace(vendorPaymentResponse?.OdataNextLink)) {
				response = ListVendorPayments(vendorPaymentResponse.OdataNextLink);
				vendorPaymentResponse = JsonConvert.DeserializeObject<VendorPaymentResponse>(response.Result);

				if (vendorPaymentResponse == null)
					return list;

				list.AddRange(vendorPaymentResponse.VendorPayments);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="VendorPayment"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListVendorPayments(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, VendorPaymentRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListVendorPayments(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="VendorPayment"/> with the given payload of type <see cref="VendorPayment"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="VendorPayment"/>.</param>
		public async Task<string> PatchVendorPayment(VendorPayment x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, VendorPaymentRequest.ACTION);
				var vendorPaymentRequest = new VendorPaymentRequest(x);
				var json = vendorPaymentRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var vendorPaymentResponse = JsonConvert.DeserializeObject<VendorPaymentResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PatchVendorPayment(VendorPayment x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="VendorPayment"/> with the given payload of type <see cref="VendorPayment"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="VendorPayment"/>.</param>
		public async Task<string> PostVendorPayment(VendorPayment x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, VendorPaymentRequest.ACTION);
				var vendorPaymentRequest = new VendorPaymentRequest(x);
				var json = vendorPaymentRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var vendorPaymentResponse = JsonConvert.DeserializeObject<VendorPaymentResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = "";
					log = String.Format($"{log}{ex.Message}{Environment.NewLine}");
					log = String.Format($"{log}Exception thrown in SapClient.PostVendorPayment(VendorPayment x).{Environment.NewLine}");
					log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}