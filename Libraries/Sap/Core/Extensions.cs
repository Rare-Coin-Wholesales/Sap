using System;

namespace Sap.Core
{
	public static class Extensions
	{
		public static string CustomMessage(this Exception ex)
		{
			var msg = $"{ex.Message}{Environment.NewLine}{Environment.NewLine}";
			msg = $"{msg}{ex}{Environment.NewLine}{Environment.NewLine}";
			return msg;
		}
	}
}