using System;
using System.IO;
using B1SLayer;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		public ServiceLayer(string serviceLayerRoot, string companyDb, string username, string password)
			: base(serviceLayerRoot, companyDb, username, password) { }

		public void AddErrorLogs()
		{
			OnError(async call => {
				var log = string.Empty;
				log = $"{log}Request: {call.HttpRequestMessage.Method}  {call.HttpRequestMessage.RequestUri}{Environment.NewLine}";
				log = $"{log}Body sent: {call.RequestBody}{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";
				log = $"{log}Response: {call.HttpResponseMessage?.StatusCode}{Environment.NewLine}";
				log = $"{log}{await call.HttpResponseMessage?.Content?.ReadAsStringAsync()}";
				log = $"{log}Call duration: {(DateTime.UtcNow - call.StartedUtc).TotalSeconds:n4} seconds{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";

				var folder = $"C:/Logs/Sap.Api/{DateTime.Now:yyyy MM}/";
				Directory.CreateDirectory(folder);
				File.WriteAllText($"{folder}Error {DateTime.Now:dd HHmm ssff}.log", log);
			});
		}
	}
}