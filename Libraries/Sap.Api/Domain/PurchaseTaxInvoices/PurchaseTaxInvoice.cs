using System;
using System.Collections.Generic;
using Sap.Api.Domain.Common;
using Sap.Core;
using Sap.Core.Http;

namespace Sap.Api.Domain.PurchaseTaxInvoices
{
	public partial class PurchaseTaxInvoice : BaseEntity
	{
		public int? DocEntry;
		public string CardCode;
		public string Comments;
		public string DocNum;
		public string DocType;
		public IList<PurchaseTaxInvoiceLine> PurchaseTaxInvoiceLines;
		public IList<PurchaseTaxInvoiceOperationCode> PurchaseTaxInvoiceOperationCodes;

		public PurchaseTaxInvoice()
		{
			PurchaseTaxInvoiceLines = new List<PurchaseTaxInvoiceLine>();
			PurchaseTaxInvoiceOperationCodes = new List<PurchaseTaxInvoiceOperationCode>();
		}
	}
}