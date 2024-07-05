using System.Text.Json.Serialization;

namespace Sap.Core.Domain.Login
{
	public partial class LoginResponse : BaseResponse
	{
		[JsonPropertyName("odata.metadata")]
		public string? Odata_Metadata { get; set; }
		public string? SessionId { get; set; }
		[JsonPropertyName("odata.metadata")]
		public string? Version { get; set; }
		public int SessionTimeout { get; set; }
	}
}