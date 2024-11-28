using System;
using NLog;

namespace Aabw.Sap
{
	partial class Program
	{
		static void AddTraceLogs()
		{
			_serviceLayer.AfterCall(async call => {
				var response = await call.HttpResponseMessage?.Content?.ReadAsStringAsync();

				if (response.IndexOf("already assigned to a business partner", StringComparison.OrdinalIgnoreCase) > -1)
					return;

				nLog.Trace($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
				nLog.Trace($"Body sent: {call.RequestBody}");
				nLog.Trace($"Response: {call.HttpResponseMessage?.StatusCode}");

				var duration = call.Duration ?? DateTime.UtcNow - call.StartedUtc;

				nLog.Trace($"Call duration: {duration.TotalSeconds} seconds");
				nLog.Trace(response);
				LogManager.Flush();
			});
		}
	}
}