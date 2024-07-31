using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Sap.Api.Domain.AccountSegmentationCategories;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.AccountSegmentations
{
	public partial class AccountSegmentation : BaseEntity
	{
		public int? Numerator;
		public string Name;
		public int? Size;
		public string Type;
		[JsonProperty("AccountSegmentationsCategories")]
		public IList<AccountSegmentationCategory> AccountSegmentationsCategories;

		public AccountSegmentation() {
			AccountSegmentationsCategories = new List<AccountSegmentationCategory>();
		}
	}
}