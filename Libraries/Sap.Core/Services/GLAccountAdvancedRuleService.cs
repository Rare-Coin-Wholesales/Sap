using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core.Domain.GLAccountAdvancedRules;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		/// <summary>
		/// Deletes an instance of <see cref="GLAccountAdvancedRule"/> with the specified AbsoluteEntry.
		/// </summary>
		/// <param name="absoluteEntry">The AbsoluteEntry.</param>
		public async Task<string> DeleteGLAccountAdvancedRule(int absoluteEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{GLAccountAdvancedRuleRequest.ACTION}({absoluteEntry})");

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
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.DeleteGLAccountAdvancedRule(int absoluteEntry='{absoluteEntry}').{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Gets an instance of <see cref="GLAccountAdvancedRule"/> with the given AbsoluteEntry.
		/// </summary>
		/// <param name="absoluteEntry">The AbsoluteEntry.</param>
		public async Task<string> GetGLAccountAdvancedRuleById(int absoluteEntry)
		{
			var endpoint = String.Format($"{BaseUrl}{GLAccountAdvancedRuleRequest.ACTION}({absoluteEntry})");

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
					var log = String.Format("{0}{2}Exception thrown in SapClient.GetGLAccountAdvancedRuleById(int absoluteEntry='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, absoluteEntry);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Friendly version of ListGLAccountAdvancedRules() that will loop through all pages and return a list of objects instead of a <see cref="Task"/>.
		/// </summary>
		/// <returns>A list of <see cref="GLAccountAdvancedRule"/>.</returns>
		public IList<GLAccountAdvancedRule> ListGLAccountAdvancedRules()
		{
			var list = new List<GLAccountAdvancedRule>();
			var response = ListGLAccountAdvancedRules(null);
			var gLAccountAdvancedRuleResponse = JsonConvert.DeserializeObject<GLAccountAdvancedRuleResponse>(response.Result);

			if (gLAccountAdvancedRuleResponse == null)
				return list;

			list.AddRange(gLAccountAdvancedRuleResponse.GLAccountAdvancedRules);

			while (!String.IsNullOrWhiteSpace(gLAccountAdvancedRuleResponse?.OdataNextLink)) {
				response = ListGLAccountAdvancedRules(gLAccountAdvancedRuleResponse.OdataNextLink);
				gLAccountAdvancedRuleResponse = JsonConvert.DeserializeObject<GLAccountAdvancedRuleResponse>(response.Result);

				if (gLAccountAdvancedRuleResponse == null)
					return list;

				list.AddRange(gLAccountAdvancedRuleResponse.GLAccountAdvancedRules);
			}

			return list;
		}

		/// <summary>
		/// Gets a list of <see cref="GLAccountAdvancedRule"/>s.
		/// </summary>
		/// <param name="nextLink">Optional action to call to skip to the next page of results.</param>
		public async Task<string> ListGLAccountAdvancedRules(string nextLink)
		{
			string endpoint;

			if (String.IsNullOrWhiteSpace(nextLink))
				endpoint = Path.Combine(BaseUrl, GLAccountAdvancedRuleRequest.ACTION);
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
					var log = String.Format("{0}{2}Exception thrown in SapClient.ListGLAccountAdvancedRules(string nextLink='{3}').{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, nextLink);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Updates an instance of <see cref="GLAccountAdvancedRule"/> with the given payload of type <see cref="GLAccountAdvancedRule"/> in JSON format and with the specified ID.
		/// </summary>
		/// <param name="x">The <see cref="GLAccountAdvancedRule"/>.</param>
		public async Task<string> PatchGLAccountAdvancedRule(GLAccountAdvancedRule x)
		{
			var endpoint = String.Format($"{BaseUrl}{GLAccountAdvancedRuleRequest.ACTION}({x.AbsoluteEntry})");

			try {
				var gLAccountAdvancedRuleRequest = new GLAccountAdvancedRuleRequest(x);
				var json = gLAccountAdvancedRuleRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PutAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var gLAccountAdvancedRuleResponse = JsonConvert.DeserializeObject<GLAccountAdvancedRuleResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PatchGLAccountAdvancedRule(GLAccountAdvancedRule x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="GLAccountAdvancedRule"/> with the given payload of type <see cref="GLAccountAdvancedRule"/> in JSON format.
		/// </summary>
		/// <param name="x">The <see cref="GLAccountAdvancedRule"/>.</param>
		public async Task<string> PostGLAccountAdvancedRule(GLAccountAdvancedRule x)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, GLAccountAdvancedRuleRequest.ACTION);
				var gLAccountAdvancedRuleRequest = new GLAccountAdvancedRuleRequest(x);
				var json = gLAccountAdvancedRuleRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var gLAccountAdvancedRuleResponse = JsonConvert.DeserializeObject<GLAccountAdvancedRuleResponse>(responseData);

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format($"{ex.Message}{Environment.NewLine}Exception thrown in SapClient.PostGLAccountAdvancedRule(GLAccountAdvancedRule x).{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
	}
}