using Sap.Services.Security;

namespace Sap.Tests.Security
{
	public class EncryptionUtilTests
	{
		private readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();

		[Fact]
		public void Can_encrypt_and_decrypt()
		{
			var password = "MyLittleSecret";
			var encryptedPassword = _encryptionUtil.Encrypt(password);
			var decryptedPassword = _encryptionUtil.Decrypt(encryptedPassword);
			Assert.Equal(password, decryptedPassword);
		}
	}
}