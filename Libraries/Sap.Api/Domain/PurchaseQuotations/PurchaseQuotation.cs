using System;
using System.Collections.Generic;
using Sap.Api.Domain.Common;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.PurchaseQuotations
{
	public partial class PurchaseQuotation : BaseEntity
	{
		public DateTime? RequriedDate;
		public IList<DocumentLine> DocumentLines;
		public int? DocEntry;
		public string CardCode;
		public string Code;
		public string Comments;
		public string Description;
		public string DocNum;
		public string DocType;

		public PurchaseQuotation()
		{
			DocumentLines = new List<DocumentLine>();
		}
	}
}