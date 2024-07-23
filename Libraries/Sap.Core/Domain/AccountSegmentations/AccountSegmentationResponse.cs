using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace Sap.Core.Domain.AccountSegmentations
{
	public partial class AccountSegmentationResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<AccountSegmentation> AccountSegmentations;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public AccountSegmentationResponse()
		{
			AccountSegmentations = new List<AccountSegmentation>();
		}
	}
}