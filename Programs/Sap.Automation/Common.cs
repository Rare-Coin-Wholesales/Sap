using System;
using System.Threading.Tasks;
using B1SLayer;
using NLog;
using Sap.Api.Http;
using Sap.Automation.Logging;
using Sap.Core;
using Sap.Services.Security;

namespace Sap.Automation
{
	public static partial class Common
	{
		#region Fields
		public static bool doAabw, doRcw, doAabrc;
		public static DateTime StartTime;
		public static DefaultLogger defaultLogger = new DefaultLogger();
		public static Logger nLog = LogManager.GetCurrentClassLogger();
		public static readonly ApiToScarAabrcMapper.Mapper _aabrcMapper = new ApiToScarAabrcMapper.Mapper();
		public static readonly ApiToScarAabwMapper.Mapper _aabwMapper = new ApiToScarAabwMapper.Mapper();
		public static readonly ApiToScarRcwMapper.Mapper _rcwMapper = new ApiToScarRcwMapper.Mapper();
		public static readonly EncryptionUtil _encryptionUtil = new EncryptionUtil();
		public static readonly string Aabrc_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabrc_CompanyDb");
		public static readonly string Aabrc_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Aabrc_Password"));
		public static readonly string Aabw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Aabw_CompanyDb");
		public static readonly string Aabw_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Aabw_Password"));
		public static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		public static readonly string Rcw_CompanyDb = "A21384_RCW_T01"; // CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		public static readonly string Rcw_Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		public static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");
		public static SapClient client;
		public static Task<string> response;
		#endregion

		public static void HandleArgs(string[] args)
		{
			if (args == null || args.Length == 0) {
				doAabrc = true;
				doAabw = true;
				doRcw = true;
			}

			else {
				doAabrc = false;
				doAabw = false;
				doRcw = false;
				var joined = String.Join(" ", args);

				if (joined.IndexOf("doAabrc", StringComparison.OrdinalIgnoreCase) > -1)
					doAabrc = true;
				if (joined.IndexOf("doAabw", StringComparison.OrdinalIgnoreCase) > -1)
					doAabw = true;
				if (joined.IndexOf("doRcw", StringComparison.OrdinalIgnoreCase) > -1)
					doRcw = true;
			}
		}

		public static async Task ProcessAabrcAsync()
		{
			nLog.Trace("Begin method ProcessAabrcAsync().");

			try {
				var serviceLayer = new SLConnection(Common.BaseUrl, Common.Aabrc_CompanyDb, Common.Username, Common.Aabrc_Password);
				defaultLogger.AddTraceAndErrorLogs(serviceLayer);

				await new Aabrc.Automation.AccountCategoryUtil().GetAllAccountCategorys(serviceLayer);
				await new Aabrc.Automation.AccountSegmentationCategoryUtil().GetAllAccountSegmentationCategorys(serviceLayer);
				await new Aabrc.Automation.AccountSegmentationUtil().GetAllAccountSegmentations(serviceLayer);
				await new Aabrc.Automation.BillOfExchangeTransactionUtil().GetAllBillOfExchangeTransactions(serviceLayer);
				await new Aabrc.Automation.BusinessPartnerUtil().GetAllBusinessPartners(serviceLayer);
				await new Aabrc.Automation.ChartOfAccountUtil().GetAllChartOfAccounts(serviceLayer);
				await new Aabrc.Automation.ChecksforPaymentUtil().GetAllChecksforPayments(serviceLayer);
				await new Aabrc.Automation.CreditNoteUtil().GetAllCreditNotes(serviceLayer);
				await new Aabrc.Automation.DepositUtil().GetAllDeposits(serviceLayer);
				await new Aabrc.Automation.FAAccountDeterminationUtil().GetAllFAAccountDeterminations(serviceLayer);
				await new Aabrc.Automation.GLAccountAdvancedRuleUtil().GetAllGLAccountAdvancedRules(serviceLayer);
				await new Aabrc.Automation.HouseBankAccountUtil().GetAllHouseBankAccounts(serviceLayer);
				await new Aabrc.Automation.IncomingPaymentUtil().GetAllIncomingPayments(serviceLayer);
				await new Aabrc.Automation.InvoiceUtil().GetAllInvoices(serviceLayer);
				await new Aabrc.Automation.ItemUtil().GetAllItems(serviceLayer);
				await new Aabrc.Automation.JournalEntryDocumentTypeUtil().GetAllJournalEntryDocumentTypes(serviceLayer);
				await new Aabrc.Automation.JournalEntryUtil().GetAllJournalEntrys(serviceLayer);
				await new Aabrc.Automation.PurchaseCreditNoteUtil().GetAllPurchaseCreditNotes(serviceLayer);
				await new Aabrc.Automation.PurchaseInvoiceUtil().GetAllPurchaseInvoices(serviceLayer);
				await new Aabrc.Automation.PurchaseOrderUtil().GetAllPurchaseOrders(serviceLayer);
				await new Aabrc.Automation.PurchaseQuotationUtil().GetAllPurchaseQuotations(serviceLayer);
				await new Aabrc.Automation.PurchaseTaxInvoiceUtil().GetAllPurchaseTaxInvoices(serviceLayer);
				await new Aabrc.Automation.QuotationUtil().GetAllQuotations(serviceLayer);
				await new Aabrc.Automation.SalesTaxInvoiceUtil().GetAllSalesTaxInvoices(serviceLayer);
				await new Aabrc.Automation.TransactionCodeUtil().GetAllTransactionCodes(serviceLayer);
				await new Aabrc.Automation.VendorPaymentUtil().GetAllVendorPayments(serviceLayer);
				new ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.BaseService().StartJob_Sap_ArrowAndBranchRareCoins_Triggered();
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null)
					nLog.Error(String.Format("{0}{2}Exception thrown in ProcessAabrcAsync().{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine));
				else
					throw;
				#endregion
			}

			nLog.Trace($"End method ProcessAabrcAsync().{Environment.NewLine}");
		}

		public static async Task ProcessAabwAsync()
		{
			nLog.Trace("Begin method ProcessAabwAsync().");

			try {
				var serviceLayer = new SLConnection(Common.BaseUrl, Common.Aabw_CompanyDb, Common.Username, Common.Aabw_Password);
				defaultLogger.AddTraceAndErrorLogs(serviceLayer);

				await new Aabw.Automation.AccountCategoryUtil().GetAllAccountCategorys(serviceLayer);
				await new Aabw.Automation.AccountSegmentationCategoryUtil().GetAllAccountSegmentationCategorys(serviceLayer);
				await new Aabw.Automation.AccountSegmentationUtil().GetAllAccountSegmentations(serviceLayer);
				await new Aabw.Automation.BillOfExchangeTransactionUtil().GetAllBillOfExchangeTransactions(serviceLayer);
				await new Aabw.Automation.BusinessPartnerUtil().GetAllBusinessPartners(serviceLayer);
				await new Aabw.Automation.ChartOfAccountUtil().GetAllChartOfAccounts(serviceLayer);
				await new Aabw.Automation.ChecksforPaymentUtil().GetAllChecksforPayments(serviceLayer);
				await new Aabw.Automation.CreditNoteUtil().GetAllCreditNotes(serviceLayer);
				await new Aabw.Automation.DepositUtil().GetAllDeposits(serviceLayer);
				await new Aabw.Automation.FAAccountDeterminationUtil().GetAllFAAccountDeterminations(serviceLayer);
				await new Aabw.Automation.GLAccountAdvancedRuleUtil().GetAllGLAccountAdvancedRules(serviceLayer);
				await new Aabw.Automation.HouseBankAccountUtil().GetAllHouseBankAccounts(serviceLayer);
				await new Aabw.Automation.IncomingPaymentUtil().GetAllIncomingPayments(serviceLayer);
				await new Aabw.Automation.InvoiceUtil().GetAllInvoices(serviceLayer);
				await new Aabw.Automation.ItemUtil().GetAllItems(serviceLayer);
				await new Aabw.Automation.JournalEntryDocumentTypeUtil().GetAllJournalEntryDocumentTypes(serviceLayer);
				await new Aabw.Automation.JournalEntryUtil().GetAllJournalEntrys(serviceLayer);
				await new Aabw.Automation.PurchaseCreditNoteUtil().GetAllPurchaseCreditNotes(serviceLayer);
				await new Aabw.Automation.PurchaseInvoiceUtil().GetAllPurchaseInvoices(serviceLayer);
				await new Aabw.Automation.PurchaseOrderUtil().GetAllPurchaseOrders(serviceLayer);
				await new Aabw.Automation.PurchaseQuotationUtil().GetAllPurchaseQuotations(serviceLayer);
				await new Aabw.Automation.PurchaseTaxInvoiceUtil().GetAllPurchaseTaxInvoices(serviceLayer);
				await new Aabw.Automation.QuotationUtil().GetAllQuotations(serviceLayer);
				await new Aabw.Automation.SalesTaxInvoiceUtil().GetAllSalesTaxInvoices(serviceLayer);
				await new Aabw.Automation.TransactionCodeUtil().GetAllTransactionCodes(serviceLayer);
				await new Aabw.Automation.VendorPaymentUtil().GetAllVendorPayments(serviceLayer);
				new ScarletWitch.Sap_ArrowAndBranchWinery.Services.BaseService().StartJob_SAP_ArrowAndBranchWinery_Triggered();
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null)
					nLog.Error(String.Format("{0}{2}Exception thrown in ProcessAabwAsync().{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine));
				else
					throw;
				#endregion
			}

			nLog.Trace($"End method ProcessAabwAsync().{Environment.NewLine}");
		}

		public static async Task ProcessRcwAsync()
		{
			nLog.Trace("Begin method ProcessRcwAsync().");

			try {
				var serviceLayer = new SLConnection(Common.BaseUrl, Common.Rcw_CompanyDb, Common.Username, Common.Rcw_Password);
				defaultLogger.AddTraceAndErrorLogs(serviceLayer);

				//await new Rcw.Automation.AccountCategoryUtil().GetAllAccountCategorys(serviceLayer);
				//await new Rcw.Automation.AccountSegmentationCategoryUtil().GetAllAccountSegmentationCategorys(serviceLayer);
				//await new Rcw.Automation.AccountSegmentationUtil().GetAllAccountSegmentations(serviceLayer);
				//await new Rcw.Automation.BillOfExchangeTransactionUtil().GetAllBillOfExchangeTransactions(serviceLayer);
				//await new Rcw.Automation.BusinessPartnerUtil().GetAllBusinessPartners(serviceLayer);
				await new Rcw.Automation.ChartOfAccountUtil().GetAllChartOfAccounts(serviceLayer);
				//await new Rcw.Automation.ChecksforPaymentUtil().GetAllChecksforPayments(serviceLayer);
				//await new Rcw.Automation.CreditNoteUtil().GetAllCreditNotes(serviceLayer);
				//await new Rcw.Automation.DepositUtil().GetAllDeposits(serviceLayer);
				//await new Rcw.Automation.FAAccountDeterminationUtil().GetAllFAAccountDeterminations(serviceLayer);
				//await new Rcw.Automation.GLAccountAdvancedRuleUtil().GetAllGLAccountAdvancedRules(serviceLayer);
				//await new Rcw.Automation.HouseBankAccountUtil().GetAllHouseBankAccounts(serviceLayer);
				//await new Rcw.Automation.IncomingPaymentUtil().GetAllIncomingPayments(serviceLayer);
				await new Rcw.Automation.InvoiceUtil().GetAllInvoices(serviceLayer);
				await new Rcw.Automation.ItemUtil().GetAllItems(serviceLayer);
				//await new Rcw.Automation.JournalEntryDocumentTypeUtil().GetAllJournalEntryDocumentTypes(serviceLayer);
				//await new Rcw.Automation.JournalEntryUtil().GetAllJournalEntrys(serviceLayer);
				//await new Rcw.Automation.PurchaseCreditNoteUtil().GetAllPurchaseCreditNotes(serviceLayer);
				await new Rcw.Automation.PurchaseInvoiceUtil().GetAllPurchaseInvoices(serviceLayer);
				//await new Rcw.Automation.PurchaseOrderUtil().GetAllPurchaseOrders(serviceLayer);
				//await new Rcw.Automation.PurchaseQuotationUtil().GetAllPurchaseQuotations(serviceLayer);
				//await new Rcw.Automation.PurchaseTaxInvoiceUtil().GetAllPurchaseTaxInvoices(serviceLayer);
				//await new Rcw.Automation.QuotationUtil().GetAllQuotations(serviceLayer);
				//await new Rcw.Automation.SalesTaxInvoiceUtil().GetAllSalesTaxInvoices(serviceLayer);
				//await new Rcw.Automation.TransactionCodeUtil().GetAllTransactionCodes(serviceLayer);
				//await new Rcw.Automation.VendorPaymentUtil().GetAllVendorPayments(serviceLayer);
				//new ScarletWitch.Sap_RareCoinWholesalers.Services.BaseService().StartJob_Sap_RareCoinWholesalers_Triggered();
			}

			catch (Exception ex) {
				#region Log
				if (ex.InnerException == null)
					nLog.Error(String.Format("{0}{2}Exception thrown in ProcessRcwAsync().{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine));
				else
					throw;
				#endregion
			}

			nLog.Trace($"End method ProcessRcwAsync().{Environment.NewLine}");
		}

		#region StartProgram, EndProgram
		public static void StartProgram(string[] args)
		{
			StartTime = DateTime.UtcNow;
			nLog.Info("Starting SAP Automation . . .");
			client = new SapClient(BaseUrl);
			HandleArgs(args);
		}

		/// <summary>
		/// Ends the program and returns an exit code to the operating system.
		/// </summary>
		/// <param name="exitCode">
		/// The exit code to return to the operating system. Use 0 (zero) to indicate that the process completed successfully.
		/// </param>
		public static void EndProgram(int exitCode)
		{
			var endTime = DateTime.UtcNow;
			nLog.Info("Ending SAP Automation . . .");
			string body, subject;
			var ts = endTime - StartTime;

			if (ts.TotalSeconds < 61)
				nLog.Info("It took {0} sec to complete", ts.ToString(@"s\.fff"));
			else if (ts.TotalMinutes < 61)
				nLog.Info("It took {0}m {1}s to complete", ts.Minutes, ts.Seconds);
			else
				nLog.Info("It took {0}h {1}m to complete", ts.Hours, ts.Minutes);

			nLog.Info("{0}{0}========================================", Environment.NewLine);
			LogManager.Flush();

			//Console.WriteLine(". . . Press any key to exit . . .");
			//Console.ReadKey(true);

			Environment.Exit(exitCode);
		}
		#endregion
	}
}