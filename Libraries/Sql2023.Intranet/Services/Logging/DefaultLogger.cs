using System;
using System.Linq;
using Sap.Core;
using Sap.Services.Security;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Domain.Logging;

namespace Sql2023.Intranet.Services.Logging
{
	/// <summary>
	/// Default logger
	/// </summary>
	public partial class DefaultLogger : ILogger
	{
		#region Fields
		private readonly EncryptionUtil _encryptionUtil;
		private readonly IntranetDb _dbContext;
		private readonly string _connectionString;
		#endregion

		#region Ctor
		/// <summary>
		/// Ctor
		/// </summary>
		public DefaultLogger()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Sql2023.Intranet"));
			_dbContext = new IntranetDb(_connectionString);
		}
		#endregion

		#region Utilities
		protected virtual bool Ignore(Log log)
		{
			if (Exists(log))
				return true;
			if (GetCount(log) > 4)
				return true;

			return false;
		}
		#endregion

		#region Methods
		/// <inheritdoc/>
		public virtual bool Exists(Log log)
		{
			var result = (from x in _dbContext.Logs
						  where x.CreatedOnUtc == log.CreatedOnUtc && x.ShortMessage == log.ShortMessage
						  select 1).FirstOrDefault();

			if (result == 1)
				return true;

			return false;
		}

		/// <inheritdoc/>
		public virtual int GetCount(Log log)
		{
			var minDate = DateTime.UtcNow.AddMinutes(-20);
			return (from x in _dbContext.Logs
					where x.CreatedOnUtc > minDate && x.ShortMessage == log.ShortMessage
					select 1).Count();
		}

		/// <inheritdoc/>
		public virtual Log Insert(Log log)
		{
			if (TryValidate(log, out var errorMsg)) {
				if (Ignore(log))
					return log;

				_dbContext.Logs.Add(log);
				_dbContext.SaveChanges();
				return log;
			}

			else
				throw new Exception(errorMsg);
		}

		/// <inheritdoc/>
		public virtual Log Insert(LogLevel logLevel, string shortMessage, string fullMessage = "", int? customerId = null)
		{
			return Insert(new Log {
				LogLevelId = (int) logLevel,
				ShortMessage = shortMessage,
				FullMessage = fullMessage,
				CustomerId = customerId,
			});
		}

		/// <inheritdoc/>
		public virtual bool TryValidate(Log log, out string errorMsg)
		{
			errorMsg = string.Empty;
			log.CreatedOnUtc = DateTime.UtcNow;
			log.CreatedOn = DateTime.Now;

			if (log.LogLevelId == null)
				log.LogLevelId = (int) LogLevel.Error;

			if (log.CustomerId.HasValue) {
				if (log.CustomerId < 0)
					log.CustomerId = null;
			}

			#region IpAddress
			if (log.IpAddress == null)
				log.IpAddress = "";
			else
				log.IpAddress = log.IpAddress.Trim();
			#endregion

			#region PageUrl
			if (log.PageUrl == null)
				log.PageUrl = "";
			else {
				log.PageUrl = log.PageUrl.Trim();

				if (log.PageUrl.Length > 4000)
					log.PageUrl = log.PageUrl.Substring(0, 4000).Trim();
			}
			#endregion

			#region ReferrerUrl
			if (log.ReferrerUrl == null)
				log.ReferrerUrl = "";
			else {
				log.ReferrerUrl = log.ReferrerUrl.Trim();

				if (log.ReferrerUrl.Length > 4000)
					log.ReferrerUrl = log.ReferrerUrl.Substring(0, 4000).Trim();
			}
			#endregion

			#region ShortMessage & FullMessage
			if (String.IsNullOrWhiteSpace(log.ShortMessage) && String.IsNullOrWhiteSpace(log.FullMessage))
				errorMsg = $"ShortMessage or FullMessage is required.{Environment.NewLine}";
			else {
				if (String.IsNullOrWhiteSpace(log.ShortMessage))
					log.ShortMessage = log.FullMessage;

				log.ShortMessage = log.ShortMessage.Trim();

				if (log.ShortMessage.Length > 400)
					log.ShortMessage = log.ShortMessage.Substring(0, 400).Trim();

				if (String.IsNullOrWhiteSpace(log.FullMessage))
					log.FullMessage = log.ShortMessage;

				log.FullMessage = log.FullMessage.Trim();

				if (log.FullMessage.Length > 4000)
					log.FullMessage = log.FullMessage.Substring(0, 4000).Trim();
			}
			#endregion

			if (String.IsNullOrWhiteSpace(errorMsg))
				return true;

			return false;
		}
		#endregion
	}
}