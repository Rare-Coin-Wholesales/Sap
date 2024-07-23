using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Sap.Core.Services.Security
{
	/// <summary>
	/// Encryption utility class
	/// </summary>
	public class EncryptionUtil : IEncryptionUtil
	{
		#region Private Utilities
		/// <summary>
		/// Decrypts text from memory.
		/// </summary>
		/// <param name="data">The data to decrypt.</param>
		/// <param name="key">The decryption key.</param>
		/// <param name="iv">The decryption initialization vector.</param>
		private string DecryptTextFromMemory(byte[] data, byte[] key, byte[] iv)
		{
			using (var ms = new MemoryStream(data)) {
				using (var cs = new CryptoStream(ms, new TripleDESCryptoServiceProvider().CreateDecryptor(key, iv), CryptoStreamMode.Read)) {
					using (var sr = new StreamReader(cs, Encoding.Unicode)) {
						return sr.ReadToEnd();
					}
				}
			}
		}

		/// <summary>
		/// Encrypts text to memory.
		/// </summary>
		/// <param name="data">The data to encrypt.</param>
		/// <param name="key">The encryption key.</param>
		/// <param name="iv">The encryption initialization vector.</param>
		private byte[] EncryptTextToMemory(string data, byte[] key, byte[] iv)
		{
			using (var ms = new MemoryStream()) {
				using (var cs = new CryptoStream(ms, new TripleDESCryptoServiceProvider().CreateEncryptor(key, iv), CryptoStreamMode.Write)) {
					byte[] toEncrypt = Encoding.Unicode.GetBytes(data);
					cs.Write(toEncrypt, 0, toEncrypt.Length);
					cs.FlushFinalBlock();
				}

				return ms.ToArray();
			}
		}
		#endregion

		#region Public Methods
		/// <inheritdoc/>
		public virtual string Decrypt(string cipherText, string encryptionPrivateKey = "")
		{
			if (string.IsNullOrEmpty(cipherText))
				return cipherText;
			if (string.IsNullOrEmpty(encryptionPrivateKey))
				encryptionPrivateKey = CommonUtil.GetEnvironmentVariable("EncryptionKey");

			using (var provider = new TripleDESCryptoServiceProvider()) {
				provider.Key = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(0, 16));
				provider.IV = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(8, 8));
				byte[] buffer = Convert.FromBase64String(cipherText);
				return DecryptTextFromMemory(buffer, provider.Key, provider.IV);
			}
		}

		/// <inheritdoc/>
		public virtual string Encrypt(string plainText, string encryptionPrivateKey = "")
		{
			if (string.IsNullOrEmpty(plainText))
				return plainText;
			if (string.IsNullOrEmpty(encryptionPrivateKey))
				encryptionPrivateKey = CommonUtil.GetEnvironmentVariable("EncryptionKey");

			using (var provider = new TripleDESCryptoServiceProvider()) {
				provider.Key = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(0, 16));
				provider.IV = Encoding.ASCII.GetBytes(encryptionPrivateKey.Substring(8, 8));
				byte[] encryptedBinary = EncryptTextToMemory(plainText, provider.Key, provider.IV);
				return Convert.ToBase64String(encryptedBinary);
			}
		}
		#endregion
	}
}