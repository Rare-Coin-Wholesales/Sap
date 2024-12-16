using System;
using System.Threading.Tasks;
using Sap.Core;

namespace Rcw.Sap
{
	partial class Program
	{
		static async Task Main(string[] args)
		{
			Start(args);

			if (TryConnectAsync()) {
				try {
					await InsightToSap();
				}

				catch (Exception ex) {
					nLog.Error(ex.CustomMessage);
				}

				try {
					await SapToSql();
				}

				catch (Exception ex) {
					nLog.Error(ex.CustomMessage);
				}

				try {
					await InsightToSap();
				}

				catch (Exception ex) {
					nLog.Error(ex.CustomMessage);
				}
			}

			await End(0);
		}
	}
}