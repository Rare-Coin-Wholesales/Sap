using System;
using System.Collections.Generic;
using Sap.Api.Domain.Common;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.PurchaseCreditNotes
{
	public partial class PurchaseCreditNoteRequest : BaseRequest
	{
		public const string ACTION = "PurchaseCreditNotes";
		public IList<DocumentLine> DocumentLines;
		public int? DocEntry;
		public string CardCode;
		public string Code;
		public string Comments;
		public string Description;
		public string DocNum;
		public string DocType;

		public PurchaseCreditNoteRequest()
		{
			DocumentLines = new List<DocumentLine>();
		}

		public PurchaseCreditNoteRequest(int docEntry)
		{
			DocEntry = docEntry;
			DocumentLines = new List<DocumentLine>();
		}

		public PurchaseCreditNoteRequest(PurchaseCreditNote x)
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