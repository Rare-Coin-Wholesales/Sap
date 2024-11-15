using System;
using Newtonsoft.Json;

namespace Sap.Api.Domain
{
	public abstract class BaseResponse
	{
		[JsonProperty("error")]
		public Error Error;

		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public BaseResponse()
		{
			Error = new Error();
		}

		/// <summary>
		/// Returns whether this response contains an error message or not.
		/// </summary>
		public bool IsError
		{
			get {
				return !(Error == null || Error.Message == null || String.IsNullOrWhiteSpace(Error.Message.Value));
			}
		}

		/// <summary>
		/// Gets the error message returned by the API call.
		/// </summary>
		/// <returns>The error message.</returns>
		public string GetErrorMessage()
		{
			if (Error == null || Error.Message == null || String.IsNullOrWhiteSpace(Error.Message.Value))
				return string.Empty;

			return Error.Message.Value;
		}
	}

	#region public class Error
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
	#endregion

	#region public class Message
	public class Message
	{
		[JsonProperty("lang")]
		public string Lang;

		[JsonProperty("value")]
		public string Value;
	}
	#endregion
}