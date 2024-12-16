using System;
using Sap.Api;
using Sap.Core;

namespace Aabrc.Sap
{
	partial class Program
	{
		/// <summary>
		/// Tries to connect and add logs.
		/// </summary>
		/// <returns>True if connected and added logs. False otherwise.</returns>
		static bool TryConnectAsync()
		{
			try {
				_serviceLayer = new ServiceLayer(BaseUrl, Aabrc_CompanyDb, Aabrc_Username, Aabrc_Password);
				//AddTraceLogs(); // debug only
				AddErrorLogs();
				return true;
			}

			catch (Exception ex) {
				nLog.Error(ex.CustomMessage($"Couldn't connect to CompanyDb '{Aabrc_CompanyDb}' with Username '{Aabrc_Username}'."));
				return false;
			}
		}
	}
}