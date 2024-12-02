using System;

namespace Sap.Core
{
	public static class Extensions
	{
		/// <summary>
		/// Gets a standard, formatted message from an Exception.
		/// </summary>
		/// <param name="ex">The Exception.</param>
		public static string CustomMessage(this Exception ex)
		{
			return ex.CustomMessage(null);
		}

		/// <summary>
		/// Gets a standard, formatted message from an Exception.
		/// </summary>
		/// <param name="ex">The Exception.</param>
		/// <param name="additionalInfo">Any additional info you want to inject into the returned message.</param>
		public static string CustomMessage(this Exception ex, string additionalInfo)
		{
			var msg = string.Empty;
			var methodLine = String.IsNullOrWhiteSpace(additionalInfo) ? string.Empty
																	   : $"{additionalInfo}{Environment.NewLine}{Environment.NewLine}";

			if (ex.InnerException == null) {
				var temp = ex.ToString().Length <= 1000 ? ex.ToString()
														: ex.ToString().Substring(0,1000);
				msg = $"{msg}{ex.Message}{Environment.NewLine}{Environment.NewLine}";
				msg = $"{msg}{methodLine}";
				msg = $"{msg}{temp}{Environment.NewLine}{Environment.NewLine}";
			}

			else
				msg = ex.InnerException.CustomMessage(additionalInfo);

			return msg;
		}
	}
}