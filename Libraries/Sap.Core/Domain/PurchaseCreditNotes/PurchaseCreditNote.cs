using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.PurchaseCreditNotes
{
	public partial class PurchaseCreditNote : BaseEntity
	{
		public IList<DocumentLine> DocumentLines;
		public int? DocEntry;
		public string? CardCode;
		public string? Code;
		public string? Comments;
		public string? Description;
		public string? DocNum;
		public string? DocType;

		public PurchaseCreditNote()
		{
			DocumentLines = new List<DocumentLine>();
		}
	}
}