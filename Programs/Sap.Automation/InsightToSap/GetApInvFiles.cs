using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sap.Core;

namespace Sap.Automation
{
	partial class InsightToSap
	{
		const string AP_INV = "APInv*";
		const string FOLDER = @"\\DC-RCW\ftp\Dynamics\AP\Imported\";
		static List<string> ApInvFiles;

		private static void GetApInvFiles()
		{
			var dInfo = new DirectoryInfo(FOLDER);
			ApInvFiles = dInfo.EnumerateFiles(AP_INV, SearchOption.TopDirectoryOnly)
							  .Where(x => x.LastWriteTimeUtc >= SapStartDate && x.LastWriteTimeUtc > ThreeMonthsAgo)
							  .Select(x => x.FullName).ToList();
		}

		public static bool TryGetApInvFiles(out string errorMsg)
		{
			try {
				GetApInvFiles();
				errorMsg = string.Empty;
				return true;
			}

			catch (Exception ex) {
				errorMsg = ex.CustomMessage("Exception thrown in GetApInvFiles().");
				return false;
			}
		}
	}
}