using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Automation.Utils.Logging;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services;

namespace Sap.Automation
{
	class Program
	{
		public static DefaultLogger logger = new DefaultLogger();

		static async Task Main(string[] args)
		{
			Common.StartProgram();

			try {
				var serviceLayer = new SLConnection(Common.BaseUrl, Common.CompanyDb, Common.Username, Common.Password);
				logger.AddTraceAndErrorLogs(serviceLayer);

				await new AccountCategoryUtil().GetAllAccountCategorys(serviceLayer);
				await new AccountSegmentationCategoryUtil().GetAllAccountSegmentationCategorys(serviceLayer);
				await new AccountSegmentationUtil().GetAllAccountSegmentations(serviceLayer);
				await new BillOfExchangeTransactionUtil().GetAllBillOfExchangeTransactions(serviceLayer);
				await new BusinessPartnerUtil().GetAllBusinessPartners(serviceLayer);
				await new ChartOfAccountUtil().GetAllChartOfAccounts(serviceLayer);
				await new ChecksforPaymentUtil().GetAllChecksforPayments(serviceLayer);
				await new CreditNoteUtil().GetAllCreditNotes(serviceLayer);
				await new DepositUtil().GetAllDeposits(serviceLayer);
				await new FAAccountDeterminationUtil().GetAllFAAccountDeterminations(serviceLayer);
				await new GLAccountAdvancedRuleUtil().GetAllGLAccountAdvancedRules(serviceLayer);
				await new HouseBankAccountUtil().GetAllHouseBankAccounts(serviceLayer);
				await new IncomingPaymentUtil().GetAllIncomingPayments(serviceLayer);
				await new InvoiceUtil().GetAllInvoices(serviceLayer);
				await new ItemUtil().GetAllItems(serviceLayer);
				await new JournalEntryDocumentTypeUtil().GetAllJournalEntryDocumentTypes(serviceLayer);
				await new JournalEntryUtil().GetAllJournalEntrys(serviceLayer);
				await new PurchaseCreditNoteUtil().GetAllPurchaseCreditNotes(serviceLayer);
				await new PurchaseInvoiceUtil().GetAllPurchaseInvoices(serviceLayer);
				await new PurchaseOrderUtil().GetAllPurchaseOrders(serviceLayer);
				await new PurchaseQuotationUtil().GetAllPurchaseQuotations(serviceLayer);
				await new PurchaseTaxInvoiceUtil().GetAllPurchaseTaxInvoices(serviceLayer);
				await new QuotationUtil().GetAllQuotations(serviceLayer);
				await new SalesTaxInvoiceUtil().GetAllSalesTaxInvoices(serviceLayer);
				await new TransactionCodeUtil().GetAllTransactionCodes(serviceLayer);
				await new VendorPaymentUtil().GetAllVendorPayments(serviceLayer);
				new BaseService().StartJob_SAP_ArrowAndBranchWinery_Triggered();
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null)
					Common.logger.Error(String.Format("{0}{2}Exception thrown in Main().{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine));
				else
					Common.logger.Error(String.Format("{0}{2}Exception thrown in INNER EXCEPTION of  Main().{2}{1}{2}{2}", ex.InnerException.Message, ex.InnerException, Environment.NewLine));

				//Console.WriteLine("\n\n. . . Error . . .\n\n");
				//Console.ReadKey(true);
				Common.EndProgram(1);
				#endregion
			}

			//Console.WriteLine("\n\n. . . Success . . .\n\n");
			//Console.ReadKey(true);
			Common.EndProgram(0);
		}
	}
}