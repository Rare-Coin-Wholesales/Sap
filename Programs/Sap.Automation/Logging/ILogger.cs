using B1SLayer;

namespace Sap.Automation.Logging
{
	public partial interface ILogger
	{
		void AddErrorLogs(SLConnection serviceLayer);

		void AddInfoLogs(SLConnection serviceLayer);

		void AddTraceAndErrorLogs(SLConnection serviceLayer);

		void AddTraceLogs(SLConnection serviceLayer);
	}
}