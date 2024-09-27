using System.Threading.Tasks;

namespace Sap.Automation
{
	class Program
	{
		static async Task Main(string[] args)
		{
			Common.StartProgram(args);

			//await InsightToSap.ProcessAsync();

			if (Common.doAabrc)
				await Common.ProcessAabrcAsync();
			if (Common.doAabw)
				await Common.ProcessAabwAsync();
			if (Common.doRcw)
				await Common.ProcessRcwAsync();

			Common.EndProgram(0);
		}
	}
}