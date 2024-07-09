using Newtonsoft.Json;

namespace Sap.Core.Domain.SalesTaxInvoices
{
	public partial class SalesTaxInvoiceResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string? OdataMetadata;

		[JsonProperty("value")]
		public IList<SalesTaxInvoice> SalesTaxInvoices;

		[JsonProperty("odata.nextLink")]
		public string? OdataNextLink;

		public SalesTaxInvoiceResponse()
		{
			SalesTaxInvoices = new List<SalesTaxInvoice>();
		}
	}
}