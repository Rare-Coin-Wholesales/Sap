using Newtonsoft.Json;

namespace Sap.Core.Domain.Deposits
{
	public partial class DepositResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<Deposit> Deposits;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public DepositResponse()
		{
			Deposits = new List<Deposit>();
		}
	}
}