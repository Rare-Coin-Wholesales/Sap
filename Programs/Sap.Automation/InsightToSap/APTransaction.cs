using System;
using System.Collections.Generic;
using System.Linq;
using NLog;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;
using Sql2023.WwwSPs.Domain;

namespace Sap.Automation
{
	internal partial class InsightToSap
	{
		// Insight Order => SAP PurchaseInvoice (A/P)
		public const string AP = "AP";

		#region Utilities
		private static IList<PurchaseInvoice> GetAPTransactions()
		{
			var accounts = _tradingAccountService.GetAll();
			var apTransactions = _tradingAccountTransactionService.GetAPs();
			var scarPurchaseInvoices = _scarPurchaseInvoiceService.GetAllValid();

			return (from i in scarPurchaseInvoices // Remember: AP BusinessPartners start with "V"
					join ta in accounts on i.CardCode equals "V" + ta.InsightCustomerId // left join
					from t in apTransactions.Where(x => x.DocumentId == i.NumAtCard && i.CardCode == "V" + x.InsightCustomerId).DefaultIfEmpty()
					where t == null || t.DocumentId == null
					select i).ToList();
		}

		private static TradingAccountTransaction ToTradingAccountTransaction(PurchaseInvoice v)
		{
			var docTotal = v.DocTotal ?? null;
			var numAtCard = v.NumAtCard ?? string.Empty;

			return new TradingAccountTransaction {
				InsightCustomerId = v.CardCode.Substring(1),
				DocumentId = GetDocumentId(numAtCard),
				CheckVoucherId = string.Empty,
				DocumentType = GetDocumentType(AP, numAtCard, docTotal),
				DocumentDate = v.DocDate,
				PostedDate = v.CreationDate.Value,
				GeneralLedgerPostedDate = v.CreationDate,
				PaymentTerms = GetPaymentTerms(AP, numAtCard),
				UnappliedFunds = docTotal,
				AppliedFunds = 0,
				RMDocumentType = SALE_INVOICE,
				TransactionType = AP,
				IsBasis = false,
				IsDistribution = false,
				IsCoinDistribution = false,
				IsNonNta = false,
				Void = false,
				TransactionSubtype = null,
			};
		}
		#endregion

		/// <summary>
		/// Inserts all AP Transactions.
		/// </summary>
		public static void InsertAPTransactions()
		{
			string msg;
			LogManager.Flush();
			var list = GetAPTransactions();

			foreach (var v in list) {
				if (!_tradingAccountTransactionService.TryInsert(ToTradingAccountTransaction(v), out var errorMsg)) {
					if (errorMsg.IndexOf("Violation of PRIMARY KEY constraint 'PK_TradingAccountTransactions", StringComparison.OrdinalIgnoreCase) < 0) {
						msg = errorMsg.Replace("Exception thrown in", $"NumAtCard: {v.NumAtCard}, CardCode: {v.CardCode}, CardName: {v.CardName}{Environment.NewLine}{Environment.NewLine}Exception thrown in");
						Common.nLog.Error(msg);
					}
				}
			}

			LogManager.Flush();
		}
	}
}