using System;
using System.Collections.Generic;
using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.PurchaseQuotations
{
	public partial class PurchaseQuotationRequest : BaseRequest
	{
		public const string ACTION = "PurchaseQuotations";
		public DateTime? RequriedDate;
		public IList<DocumentLine> DocumentLines;
		public int? DocEntry;
		public string CardCode;
		public string Code;
		public string Comments;
		public string Description;
		public string DocNum;
		public string DocType;

		public PurchaseQuotationRequest()
		{
			DocumentLines = new List<DocumentLine>();
		}

		public PurchaseQuotationRequest(int docEntry)
		{
			DocEntry = docEntry;
			DocumentLines = new List<DocumentLine>();
		}

		public PurchaseQuotationRequest(PurchaseQuotation x)
		{
			RequriedDate = x.RequriedDate;
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