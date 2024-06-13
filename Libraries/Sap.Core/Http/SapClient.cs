using System.Text;
using Newtonsoft.Json;
using Sap.Core.Domain.Login;

namespace Sap.Core.Http
{
	public class SapClient : BaseClient
	{
		public string BaseUrl { get; set; }

		#region Constructor
		public SapClient(string baseUrl)
		{
			if (String.IsNullOrWhiteSpace(baseUrl))
				throw new ArgumentNullException("baseUrl", "'baseUrl' is required.");

			BaseUrl = baseUrl.Trim();
			Client.BaseAddress = new Uri(BaseUrl);
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

			var filename = String.Format("{0}.json", DateTime.Now.ToString("dd HHmm ssff"));
			var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), DateTime.Now.ToString("yyyy MM"));
			Directory.CreateDirectory(folder);

			dynamic? parsedJson = JsonConvert.DeserializeObject(response);
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