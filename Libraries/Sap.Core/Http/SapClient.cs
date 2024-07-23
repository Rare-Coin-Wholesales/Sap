using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Core.Domain.Login;

namespace Sap.Core.Http
{
	public partial class SapClient : BaseClient
	{
		public string BaseUrl { get; set; }
		public string SessionId { get; set; }

		#region Constructor
		public SapClient(string baseUrl)
		{
			if (String.IsNullOrWhiteSpace(baseUrl))
				throw new ArgumentNullException("baseUrl", "'baseUrl' is required.");

			BaseUrl = baseUrl.Trim();

			if (Client.BaseAddress == null)
				Client.BaseAddress = new Uri(BaseUrl);
			if (Client.DefaultRequestHeaders == null || Client.DefaultRequestHeaders.Count() < 1)
				Client.DefaultRequestHeaders.TryAddWithoutValidation("accept", "application/json");
		}
		#endregion

		#region Utilities
		/// <summary>
		/// Writes a JSON string to a file on your Desktop.
		/// </summary>
		/// <param name="response">The JSON response string</param>
		public void WriteToFile(string response)
		{
			if (response == null || String.IsNullOrWhiteSpace(response))
				return;

			var now = DateTime.Now;
			var filename = String.Format("{0}.json", now.ToString("HHmm ssff"));
			var folder = String.Format($"C:/Logs/SapClient/{now:yyyy MM}/{now:dd}/");
			//var folder = Path.Combine("C:/Logs/SapClient/", DateTime.Now.ToString("yyyy MM"));
			Directory.CreateDirectory(folder);

			var parsedJson = JsonConvert.DeserializeObject(response);
			var formatted = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
			File.WriteAllText(Path.Combine(folder, filename), formatted);
		}

		/// <summary>
		/// Writes a JSON string to a file on your Desktop.
		/// </summary>
		/// <param name="response">The JSON response string</param>
		public void WriteToFile(Task<string> response)
		{
			if (response == null || String.IsNullOrWhiteSpace(response.Result))
				return;

			WriteToFile(response.Result);
		}
		#endregion

		#region Methods
		public async Task<string> Login(string companyDb, string username, string password)
		{
			try {
				var endpoint = Path.Combine(BaseUrl, LoginRequest.ACTION);
				var loginRequest = new LoginRequest(companyDb, username, password);
				var json = loginRequest.ToJson();

				using (var content = new StringContent(json, Encoding.Default, "application/json")) {
					using (var response = await Client.PostAsync(endpoint, content)) {
						string responseData = await response.Content.ReadAsStringAsync();
						WriteToFile(responseData);
						var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseData);

						if (loginResponse != null && !String.IsNullOrWhiteSpace(loginResponse.SessionId))
							SessionId = loginResponse.SessionId;

						return responseData;
					}
				}
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null) {
					var log = String.Format("{0}{2}Exception thrown in SapClient.Login(string companyDb='{3}', string username='{4}', string password).{2}{1}{2}{2}", ex.Message, ex.ToString(), Environment.NewLine, companyDb, username);
					throw new Exception(log);
				}

				else throw;
				#endregion
			}
		}
		#endregion
	}
}