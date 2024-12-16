using System;
using NLog;
using Sap.Core;
using Sap.Services.Security;

namespace Aabw.Sap
{
	partial class Program
	{
		const string PROGRAM_NAME = "Aabw.Sap Automation";
		public static readonly Logger nLog = LogManager.GetCurrentClassLogger();
		static DateTime StartTimeUtc;
		static IEncryptionUtil _encryptionUtil;
		static string Aabw_CompanyDb;
		static string Aabw_Password;
		static string Aabw_Username;
		static string BaseUrl;

		static void Start(string[] args)
		{
			StartTimeUtc = DateTime.UtcNow;
			nLog.Info($"Starting {PROGRAM_NAME}. . .");

			_encryptionUtil = new EncryptionUtil();
			Aabw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabw_CompanyDb");
			Aabw_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Aabw_Password"));
			Aabw_Username = CommonUtil.GetEnvironmentVariable("SAP_Aabw_Username");
			BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		}
	}
}