using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Api.Domain.BusinessPartners;
using Sap.Core.Http;

namespace Sap.Api.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Gets an instance of <see cref="BusinessPartner"/> with the given Code.
		/// </summary>
		/// <param name="cardCode">The Code.</param>
		public async Task<string> GetBusinessPartnerById(string cardCode)
		{
			var endpoint = String.Format($"{BaseUrl}{BusinessPartnerRequest.ACTION}({cardCode})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetBusinessPartnerById(string cardCode='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, cardCode);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListBusinessPartners() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="BusinessPartner"/>.</returns>
		public IList<BusinessPartner> ListBusinessPartners()
		{
			var list = new List<BusinessPartner>();
			var response = ListBusinessPartners(null);
			var businessPartnerResponse = JsonConvert.DeserializeObject<BusinessPartnerResponse>(response.Result);

			if (businessPartnerResponse == null)
				return list;

			list.AddRange(businessPartnerResponse.BusinessPartners);

			while (!String.IsNullOrWhiteSpace(businessPartnerResponse?.OdataNextLink)) {
				response = ListBusinessPartners(businessPartnerResponse.OdataNextLink);
				businessPartnerResponse = JsonConvert.DeserializeObject<BusinessPartnerResponse>(response.Result);

				if (businessPartnerResponse == null)
					return list;

				list.AddRange(businessPartnerResponse.BusinessPartners);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="BusinessPartner"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListBusinessPartners(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, BusinessPartnerRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListBusinessPartners(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="BusinessPartner"/> with the given payload of type <see cref="BusinessPartner"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="BusinessPartner"/>.</param>
		public async Task<string> PostBusinessPartner(BusinessPartner x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, BusinessPartnerRequest.ACTION);
				var businessPartnerRequest = new BusinessPartnerRequest(x);
				var json = businessPartnerRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var businessPartnerResponse = JsonConvert.DeserializeObject<BusinessPartnerResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostBusinessPartner(BusinessPartner x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}