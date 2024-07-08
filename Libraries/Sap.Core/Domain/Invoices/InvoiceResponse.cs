using Newtonsoft.Json;

namespace Sap.Core.Domain.Invoices
{
	public partial class InvoiceResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<Invoice> Invoices;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public InvoiceResponse()
		{
			Invoices = new List<Invoice>();
		}
	}
}