using System;
using System.Collections.Generic;
using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.CreditNotes
{
	public partial class CreditNoteRequest : BaseRequest
	{
		public const string ACTION = "CreditNotes";
		public IList<DocumentLine> DocumentLines;
		public int? DocEntry;
		public string CardCode;
		public string Code;
		public string Comments;
		public string Description;
		public string DocNum;
		public string DocType;

		public CreditNoteRequest()
		{
			DocumentLines = new List<DocumentLine>();
		}

		public CreditNoteRequest(int docEntry)
		{
			DocEntry = docEntry;
			DocumentLines = new List<DocumentLine>();
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
			DocumentLines = x.DocumentLines;
		}
	}
}