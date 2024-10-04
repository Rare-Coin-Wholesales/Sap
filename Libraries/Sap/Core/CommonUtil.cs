using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Sap.Core
{
	public partial class CommonUtil
	{
		private static readonly char[] AtAndDot = new char[] {'@', '.'};
		private static readonly char[] Space = new char[] {' '};
		private static readonly TextInfo EN_US = new CultureInfo("en-US", false).TextInfo;

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
				throw new Exception($"Couldn't get Environment Variable '{name}'.{Environment.NewLine}{ex.Message}");
			}

			if (value == null)
				throw new Exception($"Environment Variable '{name}' doesn't exist on this computer.");
			if (String.IsNullOrWhiteSpace(value))
				throw new Exception($"Environment Variable '{name}' is empty.");

			return value.Trim();
		}

		/// <summary>
		/// Verifies that a string is in valid e-mail format
		/// </summary>
		/// <param name="email">Email to verify</param>
		/// <returns>true if the string is a valid e-mail address and false if it's not</returns>
		public static bool IsValidEmail(string email)
		{
			if (String.IsNullOrWhiteSpace(email))
				return false;

			email = email.Trim();
			return Regex.IsMatch(email, "^(?:[\\w\\!\\#\\$\\%\\&\\'\\*\\+\\-\\/\\=\\?\\^\\`\\{\\|\\}\\~]+\\.)*[\\w\\!\\#\\$\\%\\&\\'\\*\\+\\-\\/\\=\\?\\^\\`\\{\\|\\}\\~]+@(?:(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9\\-](?!\\.)){0,61}[a-zA-Z0-9]?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9\\-](?!$)){0,61}[a-zA-Z0-9]?)|(?:\\[(?:(?:[01]?\\d{1,2}|2[0-4]\\d|25[0-5])\\.){3}(?:[01]?\\d{1,2}|2[0-4]\\d|25[0-5])\\]))$", RegexOptions.IgnoreCase);
		}

		/// <summary>
		/// Formats an email address.
		/// </summary>
		/// <param name="email">The email to format.</param>
		/// <returns>The formatted email.</returns>
		public static string FormatEmail(string email)
		{
			if (String.IsNullOrWhiteSpace(email))
				return string.Empty;

			email = email.Trim();

			try {
				var em = "";
				var temp = new MailAddress(email);

				if (temp.User.Equals(temp.User.ToUpper()))
					em = $"{em}{temp.User.ToLower()}@";
				else
					em = $"{em}{temp.User}@";

				if (temp.Host.Equals(temp.Host.ToUpper()))
					em = $"{em}{temp.Host.ToLower()}";
				else
					em = $"{em}{temp.Host}";

				return em;
			}

			catch {
				if (email.Equals(email.ToUpper()))
					email = email.ToLower();

				return email;
			}
		}

		/// <summary>
		///  Converts a string to Title Case.
		/// </summary>
		/// <param name="str">The string to convert.</param>
		public static string ToTitleCase(string str)
		{
			if (String.IsNullOrWhiteSpace(str))
				return string.Empty;

			var words = new List<string>();
			var split = str.Split(Space, StringSplitOptions.RemoveEmptyEntries);

			foreach (var word in split) {
				if (word.Equals(word.ToUpper()) || word.Equals(word.ToLower()))
					words.Add(EN_US.ToTitleCase(word.ToLower()));
				else
					words.Add(word);
			}

			return String.Join(" ", words);
		}
	}
}