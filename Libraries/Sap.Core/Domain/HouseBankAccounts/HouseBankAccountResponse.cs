using Newtonsoft.Json;

namespace Sap.Core.Domain.HouseBankAccounts
{
	public partial class HouseBankAccountResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<HouseBankAccount> HouseBankAccounts;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public HouseBankAccountResponse()
		{
			HouseBankAccounts = new List<HouseBankAccount>();
		}
	}
}