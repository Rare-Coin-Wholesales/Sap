namespace Sap.Services.Security
{
	/// <summary>
	/// Encryption utility interface
	/// </summary>
	public interface IEncryptionUtil
    {
		/// <summary>
		/// Decrypts a ciphered string to plain text. The encryption key should be at least 16 characters long.
		/// </summary>
		/// <param name="cipherText">The ciphered text.</param>
		/// <param name="encryptionPrivateKey">The encryption private key. It should be at least 16 characters long.</param>
		string Decrypt(string cipherText, string encryptionPrivateKey = "");

		/// <summary>
		/// Encrypts plain text to a ciphered string. The encryption key should be at least 16 characters long.
		/// </summary>
		/// <param name="plaintext">The plaint text to convert.</param>
		/// <param name="encryptionPrivateKey">The encryption private key. It should be at least 16 characters long.</param>
		string Encrypt(string plainText, string encryptionPrivateKey = "");
    }
}