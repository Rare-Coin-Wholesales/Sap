namespace Sap.Core.Services.Security
{
	/// <summary>
	/// Encryption utility interface
	/// </summary>
	public interface IEncryptionUtil
    {
		/// <summary>
		/// Decrypts a ciphered string to plain text.
		/// </summary>
		/// <param name="cipherText">The ciphered text.</param>
		/// <param name="encryptionPrivateKey">The encryption private key.</param>
		string Decrypt(string cipherText, string encryptionPrivateKey = "");

		/// <summary>
		/// Encrypts plain text to a ciphered string.
		/// </summary>
		/// <param name="plaintext">The plaint text to convert.</param>
		/// <param name="encryptionPrivateKey">The encryption private key.</param>
		string Encrypt(string plainText, string encryptionPrivateKey = "");
    }
}