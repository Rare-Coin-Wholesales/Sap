namespace Sap.Core.Domain.Login
{
	public partial class LoginRequest
	{
		public const string ACTION = "Login";
		public string CompanyDB { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }

		public LoginRequest(string companyDb, string username, string password)
		{
			CompanyDB = companyDb;
			UserName = username;
			Password = password;
		}

		public string ToJson()
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
	}
}