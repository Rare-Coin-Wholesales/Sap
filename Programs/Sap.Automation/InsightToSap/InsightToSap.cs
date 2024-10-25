using System.Threading.Tasks;
using ScarletWitch.Sap_RareCoinWholesalers.Services.Invoices;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseInvoices;
using Sql2023.WwwSPs.Services.TradingAccountTransactions;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		public const int SALE_INVOICE = 1;
		private const string DOCUMENT_SERVICE = "dDocument_Service";
		private const string TAX_EXEMPT = "EX";
		private static readonly ITradingAccountTransactionService _tradingAccountTransactionService = new TradingAccountTransactionService();
		private static readonly IPurchaseInvoiceService _scarPurchaseInvoiceService = new PurchaseInvoiceService();
		private static readonly IInvoiceService _scarInvoiceService = new InvoiceService();

		public static async Task ProcessAsync()
		{
			Common.RcwServiceLayer.AddErrorLogs();
			await CreateMissingCustomers();
			await CreateMissingVendors();
			await CreateMissingInvoices();
			await CreateMissingPurchaseInvoices();
			// Careful, these 2 methods affect LIVE databases
			//InsertAPTransactions();
			//InsertARTransactions();
		}
	}
}