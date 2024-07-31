using System;

namespace Sap.Core
{
	public partial class CommonUtil
	{
		/// <summary>
		/// Gets the value of an environment variable from the Windows operating system registry key for the local machine.
		/// </summary>
		/// <param name="name">The name of an environment variable.</param>
		public static string GetEnvironmentVariable(string name)
		{
			if (String.IsNullOrWhiteSpace(name))
				return "";

			string value;

			try {
				value = Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Machine);
			}

			catch (Exception ex) {
				throw new Exception($"Couldn't get Environment Variable '{name}'. {ex.Message}");
			}

			if (value == null)
				throw new Exception($"Environment Variable '{name}' doesn't exist on this computer.");
			else if (String.IsNullOrWhiteSpace(value))
				throw new Exception($"Environment Variable '{name}' is empty.");

			return value.Trim();
		}
	}
}