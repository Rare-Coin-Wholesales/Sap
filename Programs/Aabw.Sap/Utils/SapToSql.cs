using System;
using System.Threading.Tasks;
using Sap.Api;
using Sap.ApiToScarAabwMapper;
using Sap.Core;

namespace Aabw.Sap
{
	partial class Program
	{
		public static Mapper _mapper;
		public static ServiceLayer _serviceLayer;
		static readonly DateTime DateThreshold = DateTime.Today.AddDays(-30);
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
					await new BusinessPartnerUtil().GetAllBusinessPartners();
					await new DepositUtil().GetAllDeposits();
					await new IncomingPaymentUtil().GetAllIncomingPayments();
					await new InvoiceUtil().GetAllInvoices();
					await new JournalEntryUtil().GetAllJournalEntries();
				}

				else {
					await new BusinessPartnerUtil().GetBusinessPartnersByUpdateDate(DateThreshold);
					await new DepositUtil().GetDepositsByDepositDateAsync(DateThreshold);
					await new IncomingPaymentUtil().GetIncomingPaymentsByDocDate(DateThreshold);
					await new InvoiceUtil().GetInvoicesByUpdateDate(DateThreshold);
					await new JournalEntryUtil().GetJournalEntriesByReferenceDate(DateThreshold);
				}

				await new AccountCategoryUtil().GetAllAccountCategorys();
				await new AccountSegmentationCategoryUtil().GetAllAccountSegmentationCategorys();
				await new AccountSegmentationUtil().GetAllAccountSegmentations();
				await new BillOfExchangeTransactionUtil().GetAllBillOfExchangeTransactions();
				await new ChartOfAccountUtil().GetAllChartOfAccounts();
				await new ChecksforPaymentUtil().GetAllChecksforPayments();
				await new CreditNoteUtil().GetAllCreditNotes();
				await new DepositUtil().GetAllDeposits();
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
				new ScarletWitch.Sap_ArrowAndBranchWinery.Services.BaseService().StartJob_SAP_ArrowAndBranchWinery_Triggered();
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