using Sap.Core.Domain.Common;

namespace Sap.Core.Domain.SalesTaxInvoices
{
	public partial class SalesTaxInvoice : BaseEntity
	{
		public int? DocEntry;
		public string? CardCode;
		public string? Comments;
		public string? DocNum;
		public string? DocType;
		public IList<SalesTaxInvoiceLine> SalesTaxInvoiceLines;
		public IList<SalesTaxInvoiceOperationCode> SalesTaxInvoiceOperationCodes;

		public SalesTaxInvoice()
		{
			SalesTaxInvoiceLines = new List<SalesTaxInvoiceLine>();
			SalesTaxInvoiceOperationCodes = new List<SalesTaxInvoiceOperationCode>();
		}
	}
}