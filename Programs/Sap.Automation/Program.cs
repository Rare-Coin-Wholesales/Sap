using System.Threading.Tasks;

namespace Sap.Automation
{
	class Program
	{
		static async Task Main(string[] args)
		{
			Common.StartProgram(args);

			if (Common.doAabrc)
				await Common.ProcessAabrcAsync();
			if (Common.doAabw)
				await Common.ProcessAabwAsync();

			Common.EndProgram(0);
		}
	}
}