using System;
using System.Threading.Tasks;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseInvoices;
using Sql2023.WwwSPs.Services.TradingAccountTransactions;

namespace Sap.Automation
{
	internal partial class InsightToSap
	{
		protected const int SALE_INVOICE = 1;
		protected const string DOCUMENT_SERVICE = "dDocument_Service";
		protected const string TAX_EXEMPT = "EX";
		/// <summary>Nov 1, 2024</summary>
		protected static readonly DateTime SapStartDate = new DateTime(2024, 11, 1);
		protected static readonly IInvoiceService _scarInvoiceService = new InvoiceService();
		protected static readonly IPurchaseInvoiceService _scarPurchaseInvoiceService = new PurchaseInvoiceService();
		protected static readonly ITradingAccountTransactionService _tradingAccountTransactionService = new TradingAccountTransactionService();

		public static async Task ProcessAsync()
		{
			Common.RcwServiceLayer.AddErrorLogs();
			await CreateMissingCustomersAndVendors();
			await CreateMissingInvoices();
			await CreateMissingPurchaseInvoices();
			// NTA Transaction processing. Careful, these 2 methods affect LIVE databases
			InsertAPTransactions();
			InsertARTransactions();
			_tradingAccountTransactionService.Update();
		}
	}
}