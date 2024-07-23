using System;
using System.Collections.Generic;
using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.Quotations
{
	public partial class QuotationRequest : BaseRequest
	{
		public const string ACTION = "Quotations";
		public IList<DocumentLine> DocumentLines;
		public int? DocEntry;
		public string CardCode;
		public string Code;
		public string Comments;
		public string Description;
		public string DocNum;
		public string DocType;

		public QuotationRequest()
		{
			DocumentLines = new List<DocumentLine>();
		}

		public QuotationRequest(int docEntry)
		{
			DocEntry = docEntry;
			DocumentLines = new List<DocumentLine>();
		}

		public QuotationRequest(Quotation x)
		{
			DocEntry = x.DocEntry;
			CardCode = x.CardCode;
			Comments = x.Comments;
			DocNum = x.DocNum;
			DocType = x.DocType;
			DocumentLines = x.DocumentLines;
		}
	}
}