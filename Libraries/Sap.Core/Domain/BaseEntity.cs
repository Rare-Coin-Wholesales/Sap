namespace Sap.Core.Domain
{
	public abstract class BaseEntity
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