using Newtonsoft.Json;

namespace Sap.Core.Domain.TransactionCodes
{
	public partial class TransactionCodeResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<TransactionCode> TransactionCodes;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public TransactionCodeResponse()
		{
			TransactionCodes = new List<TransactionCode>();
		}
	}
}