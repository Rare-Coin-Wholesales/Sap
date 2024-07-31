using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.GLAccountAdvancedRules
{
	public partial class GLAccountAdvancedRuleResponse : BaseResponse
	{
		[JsonProperty("odata.metadata")]
		public string OdataMetadata;

		[JsonProperty("value")]
		public IList<GLAccountAdvancedRule> GLAccountAdvancedRules;

		[JsonProperty("odata.nextLink")]
		public string OdataNextLink;

		public GLAccountAdvancedRuleResponse()
		{
			GLAccountAdvancedRules = new List<GLAccountAdvancedRule>();
		}
	}
}