using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.JournalEntryDocumentTypes
{
	public partial class JournalEntryDocumentTypeResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<JournalEntryDocumentType> JournalEntryDocumentTypes;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public JournalEntryDocumentTypeResponse()
		{
			JournalEntryDocumentTypes = new List<JournalEntryDocumentType>();
		}
	}
}