using System;
using System.Collections.Generic;
using System.Linq;
using NLog;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;
using Sql2023.WwwSPs.Domain;

namespace Sap.Automation
{
	partial class InsightToSap
	{
		// Insight Invoice => SAP Invoice (A/R)
		public const string AR = "AR";

		#region Utilities
		private static IList<Invoice> GetARTransactions()
		{
			var tradingAccounts = _tradingAccountService.GetAll();
			var tradingAccountTransactions = _tradingAccountTransactionService.GetARs();
			var sapInvoices = _scarInvoiceService.GetAllValid();
			sapInvoices = sapInvoices.Where(x => x.DocDate.Value >= SapStartDate).ToList();

			return (from sap in sapInvoices
					join ta in tradingAccounts on sap.CardCode equals ta.InsightCustomerId // left join
					from tat in tradingAccountTransactions.Where(x => x.DocumentId == sap.NumAtCard && sap.CardCode == x.InsightCustomerId).DefaultIfEmpty()
					where tat == null || tat.DocumentId == null
					select sap).ToList();
		}

		private static TradingAccountTransaction ToTradingAccountTransaction(Invoice v)
		{
			var docTotal = v.DocTotal == null ? null : -v.DocTotal;
			var numAtCard = v.NumAtCard ?? string.Empty;

			return new TradingAccountTransaction {
				InsightCustomerId = v.CardCode,
				DocumentId = GetDocumentId(numAtCard),
				CheckVoucherId = string.Empty,
				DocumentType = GetDocumentType(AR, numAtCard, docTotal),
				DocumentDate = v.DocDate,
				PostedDate = v.CreationDate.Value,
				GeneralLedgerPostedDate = v.CreationDate,
				PaymentTerms = GetPaymentTerms(AR, numAtCard),
				UnappliedFunds = docTotal,
				AppliedFunds = 0,
				RMDocumentType = SALE_INVOICE,
				TransactionType = AR,
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
		/// Inserts all AR Transactions.
		/// </summary>
		public static void InsertARTransactions()
		{
			string msg;
			LogManager.Flush();
			var list = GetARTransactions();

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