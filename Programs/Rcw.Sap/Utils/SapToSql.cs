using System;
using System.Threading.Tasks;
using Sap.Api;
using Sap.ApiToScarRcwMapper;
using Sap.Core;

namespace Rcw.Sap
{
	partial class Program
	{
		public const int ALL_PAGE_SIZE = 4000;
		public const int RECENT_PAGE_SIZE = 200;
		public static Mapper _mapper;
		public static ServiceLayer _serviceLayer;
		static readonly DateTime AllDateThreshold = DateTime.Today.AddMonths(-12);
		static readonly DateTime RecentDateThreshold = DateTime.Today.AddDays(-14);
		/// <summary>3am</summary>
		static readonly DateTime LowerBound = DateTime.Today.AddHours(3).AddMinutes(0);
		/// <summary>10:30pm</summary>
		static readonly DateTime UpperBound = DateTime.Today.AddHours(22).AddMinutes(30);

		static async Task SapToSql()
		{
			nLog.Trace("Begin method SapToSql().");

			try {
				_mapper = new Mapper();

				if (DateTime.Now < LowerBound || DateTime.Now > UpperBound) {
					await new BusinessPartnerUtil().GetBusinessPartnersByUpdateDate(AllDateThreshold, ALL_PAGE_SIZE);
					await new DepositUtil().GetDepositsByDepositDateAsync(AllDateThreshold, ALL_PAGE_SIZE);
					await new IncomingPaymentUtil().GetIncomingPaymentsByDocDate(AllDateThreshold, ALL_PAGE_SIZE);
					await new InvoiceUtil().GetInvoicesByUpdateDate(AllDateThreshold, ALL_PAGE_SIZE);
					await new JournalEntryUtil().GetJournalEntriesByReferenceDate(AllDateThreshold, ALL_PAGE_SIZE);
				}

				else {
					await new BusinessPartnerUtil().GetBusinessPartnersByUpdateDate(RecentDateThreshold, RECENT_PAGE_SIZE);
					await new DepositUtil().GetDepositsByDepositDateAsync(RecentDateThreshold, RECENT_PAGE_SIZE);
					await new IncomingPaymentUtil().GetIncomingPaymentsByDocDate(RecentDateThreshold, RECENT_PAGE_SIZE);
					await new InvoiceUtil().GetInvoicesByUpdateDate(RecentDateThreshold, RECENT_PAGE_SIZE);
					await new JournalEntryUtil().GetJournalEntriesByReferenceDate(RecentDateThreshold, RECENT_PAGE_SIZE);
				}

				await new AccountCategoryUtil().GetAllAccountCategorys();
				await new AccountSegmentationCategoryUtil().GetAllAccountSegmentationCategorys();
				await new AccountSegmentationUtil().GetAllAccountSegmentations();
				await new BillOfExchangeTransactionUtil().GetAllBillOfExchangeTransactions();
				await new ChartOfAccountUtil().GetAllChartOfAccounts();
				await new ChecksforPaymentUtil().GetAllChecksforPayments();
				await new CreditNoteUtil().GetAllCreditNotes();
				await new FAAccountDeterminationUtil().GetAllFAAccountDeterminations();
				await new GLAccountAdvancedRuleUtil().GetAllGLAccountAdvancedRules();
				await new HouseBankAccountUtil().GetAllHouseBankAccounts();
				await new ItemUtil().GetAllItems();
				await new JournalEntryDocumentTypeUtil().GetAllJournalEntryDocumentTypes();
				await new PurchaseCreditNoteUtil().GetAllPurchaseCreditNotes();
				await new PurchaseInvoiceUtil().GetAllPurchaseInvoices();
				await new PurchaseOrderUtil().GetAllPurchaseOrders();
				await new PurchaseQuotationUtil().GetAllPurchaseQuotations();
				await new PurchaseTaxInvoiceUtil().GetAllPurchaseTaxInvoices();
				await new QuotationUtil().GetAllQuotations();
				await new SalesTaxInvoiceUtil().GetAllSalesTaxInvoices();
				await new TransactionCodeUtil().GetAllTransactionCodes();
				await new VendorPaymentUtil().GetAllVendorPayments();
				new ScarletWitch.Sap_RareCoinWholesalers.Services.BaseService().StartJob_Sap_RareCoinWholesalers_Triggered();
			}

			#region catch (Exception ex)
			catch (Exception ex) {
				nLog.Error(ex.CustomMessage("Exception thrown in SapToSql()."));
			}
			#endregion
		}

		public static async Task<bool> TrySapToSql()
		{
			try {
				await SapToSql();
				return true;
			}

			catch (Exception ex) {
				nLog.Error(GetFullErrorText(ex, "Exception thrown in TrySapToSql()."));
				return false;
			}
		}
	}
}