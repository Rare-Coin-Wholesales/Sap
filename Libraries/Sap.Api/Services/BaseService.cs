using System;
using B1SLayer;

namespace Sap.Api.Services
{
	public abstract class BaseService
	{
		public const string CANCEL_STATUS_NO = "csNo";
		public const string CANCEL_STATUS_YES = "csYes";
		public const string CANCELLED_NO = "tNO";
		public const string CANCELLED_YES = "tYES";
		public SLConnection ServiceLayer;

		public BaseService(SLConnection serviceLayer)
		{
			if (serviceLayer == null)
				throw new ArgumentNullException("serviceLayer", "SLConnection 'serviceLayer' is required.");
			else {
				if (serviceLayer.ServiceLayerRoot == null || String.IsNullOrWhiteSpace(serviceLayer.ServiceLayerRoot.AbsoluteUri))
					throw new ArgumentNullException("serviceLayer.ServiceLayerRoot", "SLConnection.ServiceLayerRoot is required.");
				if (String.IsNullOrWhiteSpace(serviceLayer.CompanyDB))
					throw new ArgumentNullException("serviceLayer.CompanyDB", "SLConnection.CompanyDB is required.");
				if (String.IsNullOrWhiteSpace(serviceLayer.UserName))
					throw new ArgumentNullException("serviceLayer.UserName", "SLConnection.UserName is required.");
				if (String.IsNullOrWhiteSpace(serviceLayer.Password))
					throw new ArgumentNullException("serviceLayer.Password", "SLConnection.Password is required.");
			}

			ServiceLayer = serviceLayer;
		}

		/// <summary>
		/// Standardizes the error message from an <see cref="Exception"/>. If InnerException is not null, this will return an empty string.
		/// </summary>
		/// <param name="ex">The <see cref="Exception"/>.</param>
		/// <param name="methodName">The calling method's name for trace/debug purposes.</param>
		/// <returns>The standardized full error text.</returns>
		public string GetFullErrorText(Exception ex, string methodName)
		{
			var log = string.Empty;

			if (ex.InnerException == null) {
				log = String.Format($"{log}{ex.Message}{Environment.NewLine}");

				if (!String.IsNullOrWhiteSpace(methodName))
					log = String.Format($"{log}Exception thrown in {methodName}.{Environment.NewLine}");

				log = String.Format($"{log}{ex}{Environment.NewLine}{Environment.NewLine}");
			}

			return log;
		}
	}
}