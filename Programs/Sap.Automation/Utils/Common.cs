using System;
using System.Collections.Generic;
using ApiToScarletWitchMapper;
using NLog;
using Sap.Core;
using Sap.Services.Security;

namespace Sap.Automation
{
	public static partial class Common
	{
		public static Logger logger = LogManager.GetCurrentClassLogger();
		public static readonly EncryptionUtil _encryptionUtil = new EncryptionUtil();
		public static readonly Mapper _mapper = new Mapper();
		public static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		public static readonly string CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_CompanyDb");
		public static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		public static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Password"));
		public static DateTime StartTime;

		public static void StartProgram()
		{
			StartTime = DateTime.UtcNow;
			logger.Info("Starting SAP Automation . . .");
		}

		/// <summary>
		/// Ends the program and returns an exit code to the operating system.
		/// </summary>
		/// <param name="exitCode">
		/// The exit code to return to the operating system. Use 0 (zero) to indicate that the process completed successfully.
		/// </param>
		public static void EndProgram(int exitCode)
		{
			var endTime = DateTime.UtcNow;
			logger.Info("Ending SAP Automation . . .");
			string body, subject;
			var ts = endTime - StartTime;
			var log = new List<string> { "Ending program" };

			if (ts.TotalSeconds < 61)
				log.Add(String.Format("It took {0} sec to complete", ts.ToString(@"s\.fff")));
			else if (ts.TotalMinutes < 61)
				log.Add(String.Format("It took {0}m {1}s to complete", ts.Minutes, ts.Seconds));
			else
				log.Add(String.Format("It took {0}h {1}m to complete", ts.Hours, ts.Minutes));

			foreach (var l in log)
				logger.Info(l);

			logger.Info("{0}{0}", Environment.NewLine);
			LogManager.Flush();

			Environment.Exit(exitCode);
		}
	}
}