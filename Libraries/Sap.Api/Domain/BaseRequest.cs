namespace Sap.Api.Domain
{
	public abstract class BaseRequest
	{
		/// <summary>
		/// Converts this entity to a JSON string.
		/// </summary>
		/// <returns>The JSON string.</returns>
		public string ToJson()
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
	}
}