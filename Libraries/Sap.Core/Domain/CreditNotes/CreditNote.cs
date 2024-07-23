using System.Collections.Generic;
using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.CreditNotes
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