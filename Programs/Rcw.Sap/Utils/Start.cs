using System;
using NLog;
using Sap.Core;
using Sap.Services.Security;

namespace Rcw.Sap
{
	partial class Program
	{
		const string PROGRAM_NAME = "Rcw.Sap Automation";
		public static readonly Logger nLog = LogManager.GetCurrentClassLogger();
		static DateTime StartTimeUtc;
		static IEncryptionUtil _encryptionUtil;
		static string Rcw_CompanyDb;
		static string Rcw_Password;
		static string Rcw_Username;
		static string BaseUrl;

		static void Start(string[] args)
		{
			StartTimeUtc = DateTime.UtcNow;
			nLog.Info($"Starting {PROGRAM_NAME}. . .");

			_encryptionUtil = new EncryptionUtil();
			Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
			Rcw_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
			Rcw_Username = CommonUtil.GetEnvironmentVariable("SAP_Rcw_Username");
			BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		}
	}
}