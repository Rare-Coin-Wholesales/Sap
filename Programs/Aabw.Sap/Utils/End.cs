using System;
using NLog;

namespace Aabw.Sap
{
	partial class Program
	{
		static DateTime EndTimeUtc;

		/// <summary>
		/// Ends the program and returns an exit code to the operating system.
		/// </summary>
		/// <param name="exitCode">The exit code to return to the operating system.
		/// Use 0 (zero) to indicate that the process completed successfully.</param>
		public static void End(int exitCode)
		{
			EndTimeUtc = DateTime.UtcNow;
			nLog.Info($"Ending {PROGRAM_NAME}. . .");
			string body, subject;
			var ts = EndTimeUtc - StartTimeUtc;

			if (ts.TotalSeconds < 61)
				nLog.Info("It took {0} sec to complete", ts.ToString(@"s\.fff"));
			else if (ts.TotalMinutes < 61)
				nLog.Info("It took {0}m {1}s to complete", ts.Minutes, ts.Seconds);
			else
				nLog.Info("It took {0}h {1}m to complete", ts.Hours, ts.Minutes);

			nLog.Info("{0}{0}========================================{0}{0}", Environment.NewLine);
			LogManager.Flush();

			//Console.WriteLine(". . . Press any key to exit . . .");
			//Console.ReadKey(true);

			Environment.Exit(exitCode);
		}
	}
}