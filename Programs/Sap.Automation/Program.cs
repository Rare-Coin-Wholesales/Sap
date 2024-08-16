using System;

namespace Sap.Automation
{
	class Program
	{
		static void Main(string[] args)
		{
			Common.StartProgram();

			try {
				new AccountCategoryUtil().GetAllAccountCategorys();
				//new AccountSegmentationCategoryUtil().GetAllAccountSegmentationCategorys();
				//new AccountSegmentationUtil().GetAllAccountSegmentations();
				//new BillOfExchangeTransactionUtil().GetAllBillOfExchangeTransactions();
				//new BusinessPartnerUtil().GetAllBusinessPartners();
				//new ChartOfAccountUtil().GetAllChartOfAccounts();
				//new ChecksforPaymentUtil().GetAllChecksforPayments();
				//new CreditNoteUtil().GetAllCreditNotes();
				//new DepositUtil().GetAllDeposits();
				//new FAAccountDeterminationUtil().GetAllFAAccountDeterminations();
				//new GLAccountAdvancedRuleUtil().GetAllGLAccountAdvancedRules();
				//new HouseBankAccountUtil().GetAllHouseBankAccounts();
				//new IncomingPaymentUtil().GetAllIncomingPayments();
				//new InvoiceUtil().GetAllInvoices();
				//new ItemUtil().GetAllItems();
				//new JournalEntryDocumentTypeUtil().GetAllJournalEntryDocumentTypes();
				//new JournalEntryUtil().GetAllJournalEntrys();
				//new PurchaseCreditNoteUtil().GetAllPurchaseCreditNotes();
				//new PurchaseInvoiceUtil().GetAllPurchaseInvoices();
				//new PurchaseOrderUtil().GetAllPurchaseOrders();
				//new PurchaseQuotationUtil().GetAllPurchaseQuotations();
				//new PurchaseTaxInvoiceUtil().GetAllPurchaseTaxInvoices();
				//new QuotationUtil().GetAllQuotations();
				//new SalesTaxInvoiceUtil().GetAllSalesTaxInvoices();
				//new TransactionCodeUtil().GetAllTransactionCodes();
				//new VendorPaymentUtil().GetAllVendorPayments();
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null)
					Common.logger.Error("{0}{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
				else
					throw;

				Common.EndProgram(1);
				#endregion
			}

			Common.EndProgram(0);
		}
	}
}