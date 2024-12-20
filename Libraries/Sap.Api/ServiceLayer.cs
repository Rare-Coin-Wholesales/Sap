using System;
using System.IO;
using B1SLayer;

namespace Sap.Api
{
	/// <inheritdoc/>
	public partial class ServiceLayer : SLConnection
	{
		public const string CANCEL_STATUS_NO = "csNo";
		public const string CANCEL_STATUS_YES = "csYes";
		public const string CANCELLED_NO = "tNO";
		public const string CANCELLED_YES = "tYES";

		public ServiceLayer(string serviceLayerRoot, string companyDb, string username, string password)
			: base(serviceLayerRoot, companyDb, username, password) { }

		public void AddErrorLogs()
		{
			OnError(async call => {
				var response = await call.HttpResponseMessage?.Content?.ReadAsStringAsync();

				if (response.IndexOf("already assigned to a business partner", StringComparison.OrdinalIgnoreCase) > -1)
					return;

				var log = string.Empty;
				log = $"{log}Request: {call.HttpRequestMessage.Method}  {call.HttpRequestMessage.RequestUri}{Environment.NewLine}";
				log = $"{log}Body sent: {call.RequestBody}{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";
				log = $"{log}Response: {call.HttpResponseMessage?.StatusCode}{Environment.NewLine}";
				log = $"{log}{response}";
				log = $"{log}Call duration: {(DateTime.UtcNow - call.StartedUtc).TotalSeconds:n3} seconds{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";

				var folder = $"C:/Logs/Sap.Api/{DateTime.Now:yyyy MM}/";
				Directory.CreateDirectory(folder);
				File.WriteAllText($"{folder}Error {DateTime.Now:dd HHmm ssff}.log", log);
			});
		}

		/// <summary>
		/// Gets a standardized error message for an Exception.
		/// </summary>
		/// <param name="ex">The Exception.</param>
		/// <param name="additionalInfo">Any additional info you want to inject into the returned message.</param>
		protected string GetFullErrorText(Exception ex, string additionalInfo)
		{
			var additionalLine = String.IsNullOrWhiteSpace(additionalInfo) ? string.Empty
																		   : $"{additionalInfo}.{Environment.NewLine}{Environment.NewLine}";
			if (ex is SLException)
				return $"{additionalLine}{ex.Message}";

			if (ex.InnerException == null) {
				var temp = ex.ToString().Length > 1000 ? ex.ToString().Substring(0, 1000)
													   : ex.ToString();

				var msg = $"{ex.Message}{Environment.NewLine}{Environment.NewLine}";
					msg = $"{msg}{additionalLine}";
				return $"{msg}{temp}{Environment.NewLine}{Environment.NewLine}";
			}

			return GetFullErrorText(ex.InnerException, additionalInfo);
		}
	}
}