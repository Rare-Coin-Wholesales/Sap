using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.FAAccountDeterminations
{
	public partial class FAAccountDeterminationResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<FAAccountDetermination> FAAccountDeterminations;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public FAAccountDeterminationResponse()
		{
			FAAccountDeterminations = new List<FAAccountDetermination>();
		}
	}
}