using System.Threading.Tasks;

namespace Rcw.Sap
{
	partial class Program
	{
		static async Task Main(string[] args)
		{
			Start(args);

			if (TryConnectAsync()) {
				await TryInsightToSap();
				await TrySapToSql();
				await TryInsightToSap();
			}

			await End(0);
		}
	}
}