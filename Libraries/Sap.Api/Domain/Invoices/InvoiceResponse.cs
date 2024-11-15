using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sap.Api.Domain.Invoices
{
	public partial class InvoiceResponse : BaseResponse
	{
		[JsonProperty("value")]
		public IList<Invoice> Invoices;

		public InvoiceResponse()
		{
			Invoices = new List<Invoice>();
		}
	}
}