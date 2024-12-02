using System;
using NLog;
using Sap.Core;
using Sap.Services.Security;

namespace Aabrc.Sap
{
	partial class Program
	{
		const string PROGRAM_NAME = "Aabrc.Sap Automation";
		public static readonly Logger nLog = LogManager.GetCurrentClassLogger();
		static DateTime StartTimeUtc;
		static IEncryptionUtil _encryptionUtil;
		static string Aabrc_CompanyDb;
		static string Aabrc_Password;
		static string BaseUrl;
		static string Username;

		static void Start(string[] args)
		{
			StartTimeUtc = DateTime.UtcNow;
			nLog.Info($"Starting {PROGRAM_NAME}. . .");

			_encryptionUtil = new EncryptionUtil();
			Aabrc_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabrc_CompanyDb");
			Aabrc_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Aabrc_Password"));
			BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
			Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		}
	}
}