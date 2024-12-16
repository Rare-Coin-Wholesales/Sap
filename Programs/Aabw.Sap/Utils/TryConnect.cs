using System;
using Sap.Api;
using Sap.Core;

namespace Aabw.Sap
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
				_serviceLayer = new ServiceLayer(BaseUrl, Aabw_CompanyDb, Aabw_Username, Aabw_Password);
				//AddTraceLogs(); // debug only
				AddErrorLogs();
				return true;
			}

			catch (Exception ex) {
				nLog.Error(ex.CustomMessage($"Couldn't connect to CompanyDb '{Aabw_CompanyDb}' with Username '{Aabw_Username}'."));
				return false;
			}
		}
	}
}