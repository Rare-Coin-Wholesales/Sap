using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.PurchaseTaxInvoices
{
	public partial class PurchaseTaxInvoiceRequest : BaseRequest
	{
		public const string ACTION = "PurchaseTaxInvoices";
		public int? DocEntry;
		public string? CardCode;
		public string? Comments;
		public string? DocNum;
		public string? DocType;
		public IList<PurchaseTaxInvoiceLine> PurchaseTaxInvoiceLines;
		public IList<PurchaseTaxInvoiceOperationCode> PurchaseTaxInvoiceOperationCodes;

		public PurchaseTaxInvoiceRequest()
		{
			PurchaseTaxInvoiceLines = new List<PurchaseTaxInvoiceLine>();
			PurchaseTaxInvoiceOperationCodes = new List<PurchaseTaxInvoiceOperationCode>();
		}

		public PurchaseTaxInvoiceRequest(int docEntry)
		{
			DocEntry = docEntry;
			PurchaseTaxInvoiceLines = new List<PurchaseTaxInvoiceLine>();
			PurchaseTaxInvoiceOperationCodes = new List<PurchaseTaxInvoiceOperationCode>();
		}

		public PurchaseTaxInvoiceRequest(PurchaseTaxInvoice x)
		{
			DocEntry = x.DocEntry;
			CardCode = x.CardCode;
			Comments = x.Comments;
			DocNum = x.DocNum;
			DocType = x.DocType;
			PurchaseTaxInvoiceLines = x.PurchaseTaxInvoiceLines;
			PurchaseTaxInvoiceOperationCodes = x.PurchaseTaxInvoiceOperationCodes;
		}
	}
}