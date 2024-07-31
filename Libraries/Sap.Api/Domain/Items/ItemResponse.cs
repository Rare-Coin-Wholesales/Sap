using System.Collections.Generic;
using Newtonsoft.Json;

namespace Sap.Api.Domain.Items
{
    public partial class ItemResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<Item> Items;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public ItemResponse()
		{
            Items = new List<Item>();
		}
	}
}