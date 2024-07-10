using System.Security.Cryptography;
using System.Text;

namespace Sap.Core
{
	public partial class CryptoUtil
	{
		/// <summary>
		/// Converts plain text to a Base64 string.
		/// </summary>
		/// <param name="plaintext">The plaint text to convert.</param>
		public static string Encrypt(string plaintext)
		{
			try {
				var bytes = Encoding.Unicode.GetBytes(plaintext);
				var inArray = ProtectedData.Protect(bytes, null, DataProtectionScope.LocalMachine);
				return Convert.ToBase64String(inArray);
			}
			catch {
				throw;
			}
		}

		/// <summary>
		/// Converts encrypted Base64 string to plain text.
		/// </summary>
		/// <param name="encryptedText">The encrypted text.</param>
		public static string Decrypt(string encryptedText)
		{
			try {
				var array = Convert.FromBase64String(encryptedText);
				var bytes = ProtectedData.Unprotect(array, null, DataProtectionScope.LocalMachine);
				return Encoding.Unicode.GetString(bytes);
			}
			catch {
				throw;
			}
		}
	}
}