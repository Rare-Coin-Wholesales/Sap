using System;
using System.Threading.Tasks;
using Sap.Api;
using Sap.ApiToScarAabrcMapper;
using Sap.Core;

namespace Aabrc.Sap
{
	partial class Program
	{
		public static Mapper _mapper;
		public static ServiceLayer _serviceLayer;
		/// <summary>8:30am</summary>
		static readonly DateTime LowerBound = DateTime.Today.AddHours(8).AddMinutes(30);
		/// <summary>8:00pm</summary>
		static readonly DateTime UpperBound = DateTime.Today.AddHours(20).AddMinutes(0);

		static async Task ProcessAsync()
		{
			nLog.Trace("Begin method ProcessAsync().");

			try {
				_mapper = new Mapper();
				_serviceLayer = new ServiceLayer(BaseUrl, Aabrc_CompanyDb, Username, Aabrc_Password);
				//AddTraceLogs(); // debug only
				AddErrorLogs();

				await new AccountCategoryUtil().GetAllAccountCategorys();
				await new AccountSegmentationCategoryUtil().GetAllAccountSegmentationCategorys();
				await new AccountSegmentationUtil().GetAllAccountSegmentations();
				await new BillOfExchangeTransactionUtil().GetAllBillOfExchangeTransactions();

				if (DateTime.Now < LowerBound || DateTime.Now > UpperBound)
					await new BusinessPartnerUtil().GetAllBusinessPartners();

				await new ChartOfAccountUtil().GetAllChartOfAccounts();
				await new ChecksforPaymentUtil().GetAllChecksforPayments();
				await new CreditNoteUtil().GetAllCreditNotes();
				await new DepositUtil().GetAllDeposits();
				await new FAAccountDeterminationUtil().GetAllFAAccountDeterminations();
				await new GLAccountAdvancedRuleUtil().GetAllGLAccountAdvancedRules();
				await new HouseBankAccountUtil().GetAllHouseBankAccounts();
				await new IncomingPaymentUtil().GetAllIncomingPayments();
				await new InvoiceUtil().GetAllInvoices();
				await new ItemUtil().GetAllItems();
				await new JournalEntryDocumentTypeUtil().GetAllJournalEntryDocumentTypes();
				await new JournalEntryUtil().GetAllJournalEntrys();
				await new PurchaseCreditNoteUtil().GetAllPurchaseCreditNotes();
				await new PurchaseInvoiceUtil().GetAllPurchaseInvoices();
				await new PurchaseOrderUtil().GetAllPurchaseOrders();
				await new PurchaseQuotationUtil().GetAllPurchaseQuotations();
				await new PurchaseTaxInvoiceUtil().GetAllPurchaseTaxInvoices();
				await new QuotationUtil().GetAllQuotations();
				await new SalesTaxInvoiceUtil().GetAllSalesTaxInvoices();
				await new TransactionCodeUtil().GetAllTransactionCodes();
				await new VendorPaymentUtil().GetAllVendorPayments();
				new ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.BaseService().StartJob_Sap_ArrowAndBranchRareCoins_Triggered();
			}

			#region catch (Exception ex)
			catch (Exception ex) {
				nLog.Error(ex.CustomMessage("Exception thrown in ProcessAabrcAsync()."));
			}
			#endregion
		}
	}
}