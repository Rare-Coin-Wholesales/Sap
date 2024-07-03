using Newtonsoft.Json;

namespace Sap.Core.Domain
{
	public abstract class BaseResponse
	{
		[JsonProperty("error")]
		public Error Error;

		public BaseResponse()
		{
			Error = new Error();
		}
	}

	public class Error
	{
		[JsonProperty("code")]
		public int? Code;
		[JsonProperty("message")]
		public Message Message;

		public Error()
		{
			Message = new Message();
		}
	}

	public class Message
	{
		[JsonProperty("lang")]
		public string? Lang;
		[JsonProperty("value")]
		public string? Value;
	}
}