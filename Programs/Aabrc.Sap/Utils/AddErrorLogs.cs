using System;
using NLog;

namespace Aabrc.Sap
{
	partial class Program
	{
		static void AddErrorLogs()
		{
			_serviceLayer.OnError(async call => {
				var response = await call.HttpResponseMessage?.Content?.ReadAsStringAsync();

				if (response.IndexOf("already assigned to a business partner", StringComparison.OrdinalIgnoreCase) > -1)
					return;

				nLog.Error($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
				nLog.Error($"Body sent: {call.RequestBody}");
				nLog.Error($"Response: {call.HttpResponseMessage?.StatusCode}");

				var duration = call.Duration ?? DateTime.UtcNow - call.StartedUtc;

				nLog.Error($"Call duration: {duration.TotalSeconds} seconds");
				nLog.Error(response);
				LogManager.Flush();
			});
		}
	}
}