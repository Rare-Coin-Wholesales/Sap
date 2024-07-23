using System;
using System.Collections.Generic;
using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.Quotations
{
	public partial class Quotation : BaseEntity
	{
		public IList<DocumentLine> DocumentLines;
		public int? DocEntry;
		public string CardCode;
		public string Code;
		public string Comments;
		public string Description;
		public string DocNum;
		public string DocType;

		public Quotation()
		{
			DocumentLines = new List<DocumentLine>();
		}
	}
}