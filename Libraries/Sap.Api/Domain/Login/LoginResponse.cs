using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.Login
{
	public partial class LoginResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string Odata_Metadata { get; set; }
		public string SessionId { get; set; }
		public string Version { get; set; }
		public int SessionTimeout { get; set; }
	}
}