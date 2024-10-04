using B1SLayer;
using NLog;

namespace Sap.Automation.Logging
{
	public partial class DefaultLogger : ILogger
	{
		public void AddErrorLogs(SLConnection serviceLayer)
		{
			serviceLayer.OnError(async call => {
				Common.nLog.Error($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
				Common.nLog.Error($"Body sent: {call.RequestBody}");
				Common.nLog.Error($"Response: {call.HttpResponseMessage?.StatusCode}");
				Common.nLog.Error($"Call duration: {call.Duration.Value.TotalSeconds} seconds");
				Common.nLog.Error(await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				LogManager.Flush();
			});
		}

		public void AddInfoLogs(SLConnection serviceLayer)
		{
			serviceLayer.BeforeCall(call => {
				Common.nLog.Info($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
				Common.nLog.Info($"Body sent: {call.RequestBody}");
			});
		}

		public void AddTraceAndErrorLogs(SLConnection serviceLayer)
		{
			AddTraceLogs(serviceLayer);
			AddErrorLogs(serviceLayer);
		}

		public void AddTraceLogs(SLConnection serviceLayer)
		{
			serviceLayer.AfterCall(async call => {
				Common.nLog.Trace($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
				Common.nLog.Trace($"Body sent: {call.RequestBody}");
				Common.nLog.Trace($"Response: {call.HttpResponseMessage?.StatusCode}");
				Common.nLog.Trace(await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				Common.nLog.Trace($"Call duration: {call.Duration.Value.TotalSeconds} seconds");
			});
		}
	}
}