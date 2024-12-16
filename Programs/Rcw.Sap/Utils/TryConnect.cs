using System;
using Sap.Api;
using Sap.Core;

namespace Rcw.Sap
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
				_serviceLayer = new ServiceLayer(BaseUrl, Rcw_CompanyDb, Rcw_Username, Rcw_Password);
				//AddTraceLogs(); // debug only
				AddErrorLogs();
				return true;
			}

			catch (Exception ex) {
				nLog.Error(ex.CustomMessage($"Couldn't connect to CompanyDb '{Rcw_CompanyDb}' with Username '{Rcw_Username}'."));
				return false;
			}
		}
	}
}