using System.Collections.Generic;
using System.Linq;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;
using Sql2023.WwwSPs.Domain;

namespace Sap.Automation
{
	internal partial class InsightToSap
	{
		// Insight Invoice => SAP Invoice (A/R)
		public const string AR = "AR";

		#region Utilities
		private static IList<Invoice> GetARTransactions()
		{
			var arTransactions = _tradingAccountTransactionService.GetARs();
			var scarInvoices = _scarInvoiceService.GetNonCancelled();

			return (from i in scarInvoices // left join
					from t in arTransactions.Where(x => x.InsightCustomerId == i.CardCode && x.DocumentId == i.NumAtCard).DefaultIfEmpty()
					where t == null || t.DocumentId == null
					select i).ToList();
		}

		private static TradingAccountTransaction ToTradingAccountTransaction(Invoice v)
		{
			return new TradingAccountTransaction {
				InsightCustomerId = v.CardCode,
				DocumentId = v.NumAtCard ?? "",
				CheckVoucherId = "",
				DocumentType = null,
				DocumentDate = v.DocDate,
				PostedDate = v.CreationDate.Value,
				GeneralLedgerPostedDate = v.CreationDate,
				PaymentTerms = "Trading Account",
				UnappliedFunds = -v.DocTotal,
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
			var list = GetARTransactions();

			foreach (var v in list)
				_tradingAccountTransactionService.Insert(ToTradingAccountTransaction(v));
		}
	}
}