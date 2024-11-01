using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sap.Api.Domain.Login;
using Sap.Core.Http;

namespace Sap.Api.Http
{
	public partial class SapClient : BaseClient
	{
		public string BaseUrl;
		public string SessionId;
		public string Version;
		public int? SessionTimeout;
		public DateTime? TimeOutTime;

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
		/// Sets fields and cookie based on the <see cref="LoginResponse"/>.
		/// </summary>
		/// <param name="response">The <see cref="LoginResponse"/>.</param>
		//public void SetFieldsAndCookie(LoginResponse response)
		//{
		//	if (response == null || String.IsNullOrWhiteSpace(response.SessionId))
		//		return;

		//	SessionId = response.SessionId;
		//	Version = response.Version;
		//	SessionTimeout = response.SessionTimeout ?? 20;
		//	TimeOutTime = DateTime.UtcNow.AddMinutes(SessionTimeout);

		//	try {
		//		Client.DefaultRequestHeaders.Remove("Cookie");
		//	}
		//	catch { }

		//	Client.DefaultRequestHeaders.TryAddWithoutValidation("Cookie", $"B1SESSION={SessionId};HttpOnly; ROUTEID=.node1; path=/b1s");
		//}

		/// <summary>
		/// Writes a JSON string to a file on your Desktop.
		/// </summary>
		/// <param name="response">The JSON response string</param>
		public void WriteToFile(string response, string responseName = null)
		{
			if (response == null || String.IsNullOrWhiteSpace(response))
				return;

			var now = DateTime.Now;
			var filename = String.Format("{0}{1}.json", responseName, now.ToString("HHmm ssff"));
			var folder = $"C:/Logs/SAP Automation/{now:yyyy MM}/{now:dd}/";
			Directory.CreateDirectory(folder);

			var parsedJson = JsonConvert.DeserializeObject(response);
			var formatted = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
			File.WriteAllText(Path.Combine(folder, filename), formatted);
		}

		/// <summary>
		/// Writes a JSON string to a file on your Desktop.
		/// </summary>
		/// <param name="response">The JSON response string</param>
		public void WriteToFile(Task<string> response, string responseName = null)
		{
			if (response == null || String.IsNullOrWhiteSpace(response.Result))
				return;

			WriteToFile(response.Result, responseName);
		}
		#endregion

		#region Methods
		public async Task<string> Login(string companyDb, string username, string password)
		{
			if (TimeOutTime == null || TimeOutTime < DateTime.UtcNow) {
				try {
					var endpoint = Path.Combine(BaseUrl, LoginRequest.ACTION);
					var loginRequest = new LoginRequest(companyDb, username, password);
					var json = loginRequest.ToJson();

					using (var content = new StringContent(json, Encoding.Default, "application/json")) {
						using (var response = await Client.PostAsync(endpoint, content)) {
							string responseData = await response.Content.ReadAsStringAsync();
							WriteToFile(responseData, "LoginResponse");
							var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseData);
							//SetFieldsAndCookie(loginResponse);

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

			else {
				try {
					Client.DefaultRequestHeaders.Remove("Cookie");
				}
				catch { }

				Client.DefaultRequestHeaders.TryAddWithoutValidation("Cookie", $"B1SESSION={SessionId};HttpOnly; ROUTEID=.node1; path=/b1s");
				return "";
			}
		}

		public void TryLogin()
		{ }
		#endregion
	}
}