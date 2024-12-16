using System;
using System.Threading.Tasks;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseInvoices;
using Sql2023.WwwSPs.Services.TradingAccounts;
using Sql2023.WwwSPs.Services.TradingAccountTransactions;

namespace Sap.Automation
{
	partial class InsightToSap
	{
		protected const int SALE_INVOICE = 1;
		protected const string DOCUMENT_SERVICE = "dDocument_Service";
		protected const string TAX_EXEMPT = "EX";
		/// <summary>Nov 1, 2024</summary>
		protected static readonly DateTime SapStartDate = new DateTime(2024, 11, 1);
		protected static readonly DateTime ThreeMonthsAgo = DateTime.Now.AddDays(-92);
		protected static readonly IInvoiceService _scarInvoiceService = new InvoiceService();
		protected static readonly IPurchaseInvoiceService _scarPurchaseInvoiceService = new PurchaseInvoiceService();
		protected static readonly ITradingAccountService _tradingAccountService = new TradingAccountService();
		protected static readonly ITradingAccountTransactionService _tradingAccountTransactionService = new TradingAccountTransactionService();

		public static async Task ProcessAsync()
		{
			Common.RcwServiceLayer.AddErrorLogs();
			await CreateMissingCustomersAndVendors();
			await CreateMissingInvoices();
			await CreateMissingEsds();

			InsertAPTransactions();
			InsertARTransactions();
			_tradingAccountTransactionService.Update();
		}
	}
}