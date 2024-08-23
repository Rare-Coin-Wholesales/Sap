using B1SLayer;

namespace Sap.Automation.Utils.Logging
{
	public partial class DefaultLogger : ILogger
	{
		public void AddErrorLogs(SLConnection serviceLayer)
		{
			serviceLayer.OnError(async call => {
				Common.logger.Error($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
				Common.logger.Error($"Body sent: {call.RequestBody}");
				Common.logger.Error($"Response: {call.HttpResponseMessage?.StatusCode}");
				Common.logger.Error(await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				Common.logger.Error($"Call duration: {call.Duration.Value.TotalSeconds} seconds");
			});
		}

		public void AddInfoLogs(SLConnection serviceLayer)
		{
			serviceLayer.BeforeCall(call => {
				Common.logger.Info($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
				Common.logger.Info($"Body sent: {call.RequestBody}");
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
				Common.logger.Trace($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
				Common.logger.Trace($"Body sent: {call.RequestBody}");
				Common.logger.Trace($"Response: {call.HttpResponseMessage?.StatusCode}");
				Common.logger.Trace(await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
				Common.logger.Trace($"Call duration: {call.Duration.Value.TotalSeconds} seconds");
			});
		}
	}
}