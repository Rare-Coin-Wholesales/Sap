using System;
using System.Collections.Generic;
using System.Linq;
using NLog;
using Sql2023.WwwSPs.Domain;
using Web202209.SAP_RareCoinWholesalers.Domain;

namespace Rcw.Sap
{
	partial class Program
	{
		// Insight Order => SAP PurchaseInvoice (A/P)
		public const string AP = "AP";

		#region Utilities
		private static IList<PurchaseInvoice> GetAPTransactions()
		{
			var tradingAccounts = _tradingAccountService.GetAll();
			var tradingAccountTransactions = _tradingAccountTransactionService.GetAPs();
			var sapPurchaseInvoices = _purchaseInvoiceService.GetAllValid();
			sapPurchaseInvoices = sapPurchaseInvoices.Where(x => x.DocDate.Value >= SapStartDate).ToList();

			return (from sap in sapPurchaseInvoices // Remember: AP BusinessPartners start with "V"
					join ta in tradingAccounts on sap.CardCode equals ta.VendorId // left join
					from tat in tradingAccountTransactions.Where(x => x.DocumentId == sap.NumAtCard && sap.CardCode == x.VendorId).DefaultIfEmpty()
					where tat == null
					select sap).ToList(); // Where(x => x.CardCode == "V10017" && x.NumAtCard == "39848").ToList();
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
				//if (_tradingAccountTransactionService.TryInsert(ToTradingAccountTransaction(v), out var errorMsg))
				//	continue;
				//else {
				//	if (errorMsg.IndexOf("Violation of PRIMARY KEY constraint 'PK_TradingAccountTransactions", StringComparison.OrdinalIgnoreCase) < 0) {
				//		msg = errorMsg.Replace("Exception thrown in", $"NumAtCard: {v.NumAtCard}, CardCode: {v.CardCode}, CardName: {v.CardName}{Environment.NewLine}{Environment.NewLine}Exception thrown in");
				//		nLog.Error(msg);
				//	}
				//}

				if (!_tradingAccountTransactionService.TryInsert(ToTradingAccountTransaction(v), out var errorMsg)) {
					if (errorMsg.IndexOf("Violation of PRIMARY KEY constraint 'PK_TradingAccountTransactions", StringComparison.OrdinalIgnoreCase) < 0) {
						msg = errorMsg.Replace("Exception thrown in", $"NumAtCard: {v.NumAtCard}, CardCode: {v.CardCode}, CardName: {v.CardName}{Environment.NewLine}{Environment.NewLine}Exception thrown in");
						nLog.Error(msg);
					}
				}
			}

			LogManager.Flush();
		}
	}
}