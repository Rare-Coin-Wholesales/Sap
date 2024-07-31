using System.Collections.Generic;
using Sap.Api.Domain.Common;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.CreditNotes
{
	public partial class CreditNote : BaseEntity
	{
		public IList<DocumentLine> DocumentLines;
		public int? DocEntry;
		public string CardCode;
		public string Code;
		public string Comments;
		public string Description;
		public string DocNum;
		public string DocType;

		public CreditNote() {
			DocumentLines = new List<DocumentLine>();
		}
	}
}