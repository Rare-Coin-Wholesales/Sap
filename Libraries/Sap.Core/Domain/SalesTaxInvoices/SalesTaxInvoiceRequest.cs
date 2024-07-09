using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.SalesTaxInvoices
{
	public partial class SalesTaxInvoiceRequest : BaseRequest
	{
		public const string ACTION = "SalesTaxInvoices";
		public int? DocEntry;
		public string? CardCode;
		public string? Comments;
		public string? DocNum;
		public string? DocType;
		public IList<SalesTaxInvoiceLine> SalesTaxInvoiceLines;
		public IList<SalesTaxInvoiceOperationCode> SalesTaxInvoiceOperationCodes;

		public SalesTaxInvoiceRequest()
		{
			SalesTaxInvoiceLines = new List<SalesTaxInvoiceLine>();
			SalesTaxInvoiceOperationCodes = new List<SalesTaxInvoiceOperationCode>();
		}

		public SalesTaxInvoiceRequest(int docEntry)
		{
			DocEntry = docEntry;
			SalesTaxInvoiceLines = new List<SalesTaxInvoiceLine>();
			SalesTaxInvoiceOperationCodes = new List<SalesTaxInvoiceOperationCode>();
		}

		public SalesTaxInvoiceRequest(SalesTaxInvoice x)
		{
			DocEntry = x.DocEntry;
			CardCode = x.CardCode;
			Comments = x.Comments;
			DocNum = x.DocNum;
			DocType = x.DocType;
			SalesTaxInvoiceLines = x.SalesTaxInvoiceLines;
			SalesTaxInvoiceOperationCodes = x.SalesTaxInvoiceOperationCodes;
		}
	}
}