using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sap.Api.Domain.BusinessPartners
{
	public partial class BusinessPartnerResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<BusinessPartner> BusinessPartners;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public BusinessPartnerResponse()
		{
			BusinessPartners = new List<BusinessPartner>();
		}
	}
}