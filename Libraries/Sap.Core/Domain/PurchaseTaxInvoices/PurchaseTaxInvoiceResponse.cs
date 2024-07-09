using Newtonsoft.Json;

namespace Sap.Core.Domain.PurchaseTaxInvoices
{
	public partial class PurchaseTaxInvoiceResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<PurchaseTaxInvoice> PurchaseTaxInvoices;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public PurchaseTaxInvoiceResponse()
		{
			PurchaseTaxInvoices = new List<PurchaseTaxInvoice>();
		}
	}
}