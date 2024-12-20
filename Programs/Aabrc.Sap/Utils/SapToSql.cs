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
		static readonly DateTime DateThreshold = DateTime.Today.AddDays(-14);
		/// <summary>7:45am</summary>
		static readonly DateTime LowerBound = DateTime.Today.AddHours(7).AddMinutes(45);
		/// <summary>8:00pm</summary>
		static readonly DateTime UpperBound = DateTime.Today.AddHours(20).AddMinutes(0);

		static async Task SapToSql()
		{
			nLog.Trace("Begin method SapToSql().");

			try {
				_mapper = new Mapper();

				if (DateTime.Now < LowerBound || DateTime.Now > UpperBound) {
					await new BusinessPartnerUtil().GetAllBusinessPartners();
					await new IncomingPaymentUtil().GetAllIncomingPayments();
				}

				else {
					await new IncomingPaymentUtil().GetIncomingPaymentsByDocDate(DateThreshold);
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