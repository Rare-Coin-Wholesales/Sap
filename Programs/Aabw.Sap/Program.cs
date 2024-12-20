using System.Threading.Tasks;

namespace Aabw.Sap
{
	partial class Program
	{
		static async Task Main(string[] args)
		{
			Start(args);

			if (TryConnectAsync())
				await TrySapToSql();

			await End(0);
		}
	}
}