namespace Sap.Core.Domain.CreditNotes
{
	public partial class CreditNoteRequest : BaseRequest
	{
		public const string ACTION = "CreditNotes";
		public int? DocEntry;
		public string? CardCode;
		public string? Code;
		public string? Comments;
		public string? Description;
		public string? DocNum;
		public string? DocType;

		public CreditNoteRequest() { }

		public CreditNoteRequest(int docEntry)
		{
			DocEntry = docEntry;
		}

		public CreditNoteRequest(CreditNote x)
		{
			CardCode = x.CardCode;
			Code = x.Code;
			Comments = x.Comments;
			Description = x.Description;
			DocEntry = x.DocEntry;
			DocNum = x.DocNum;
			DocType = x.DocType;
		}
	}
}