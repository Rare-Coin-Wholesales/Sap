using System;
using NLog;

namespace Rcw.Sap
{
	partial class Program
	{
		static void AddErrorLogs()
		{
			_serviceLayer.OnError(async call => {
				var response = string.Empty;

				try {
					response = await call.HttpResponseMessage?.Content?.ReadAsStringAsync();
				}
				catch {
					return;
				}

				if (response.IndexOf("already assigned to a business partner", StringComparison.OrdinalIgnoreCase) > -1)
					return;
				if (response.IndexOf("There is already a record with duplicated customer", StringComparison.OrdinalIgnoreCase) > -1)
					return;

				nLog.Error($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
				nLog.Error($"Body sent: {call.RequestBody}");
				nLog.Error($"Response: {call.HttpResponseMessage?.StatusCode}");

				var duration = call.Duration ?? DateTime.UtcNow - call.StartedUtc;

				nLog.Error($"Call duration: {duration.TotalSeconds:n3} seconds");
				nLog.Error(response);

				LogManager.Flush();
			});
		}
	}
}