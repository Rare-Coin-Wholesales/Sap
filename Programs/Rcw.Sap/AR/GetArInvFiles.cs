using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sap.Core;

namespace Rcw.Sap
{
	partial class Program
	{
		const string AR_INV = "ARInv*";
		const string AR_FOLDER = @"\\DC-RCW\ftp\Dynamics\";
		static List<string> ArInvFiles;

		private static void GetArInvFiles()
		{
			var dInfo = new DirectoryInfo(AR_FOLDER);
			ArInvFiles = dInfo.EnumerateFiles(AR_INV, SearchOption.TopDirectoryOnly)
							  .Where(x => x.LastWriteTimeUtc >= SapStartDate && x.LastWriteTimeUtc > ThreeMonthsAgo)
							  .Select(x => x.FullName).ToList();
		}

		public static bool TryGetArInvFiles(out string errorMsg)
		{
			try {
				GetArInvFiles();
				errorMsg = string.Empty;
				return true;
			}

			catch (Exception ex) {
				errorMsg = ex.CustomMessage("Exception thrown in GetArInvFiles().");
				return false;
			}
		}
	}
}