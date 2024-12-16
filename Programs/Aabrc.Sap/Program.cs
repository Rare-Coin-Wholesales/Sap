using System;
using System.Threading.Tasks;
using Sap.Core;

namespace Aabrc.Sap
{
	partial class Program
	{
		static async Task Main(string[] args)
		{
			Start(args);

			try {
				await ProcessAsync();
			}

			catch (Exception ex) {
				nLog.Error(ex.CustomMessage);
				await End(1);
			}

			await End(0);
		}
	}
}