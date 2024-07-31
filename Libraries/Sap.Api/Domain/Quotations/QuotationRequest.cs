using System;
using System.Collections.Generic;
using Sap.Api.Domain.Common;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.Quotations
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