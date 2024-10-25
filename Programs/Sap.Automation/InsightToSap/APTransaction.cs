using System.Collections.Generic;
using System.Linq;
using ScarletWitch.Sap_RareCoinWholesalers.Domain;
using Sql2023.WwwSPs.Domain;
using Sql2023.WwwSPs.Services.TradingAccountTransactions;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		// Insight Order => SAP PurchaseInvoice (A/P)
		public const string AP = "AP";

		#region Utilities
		private static IList<PurchaseInvoice> GetAPTransactions()
		{
			var apTransactions = _tradingAccountTransactionService.GetAPs();
			var scarPurchaseInvoices = _scarPurchaseInvoiceService.GetAll();

			return (from i in scarPurchaseInvoices // left join
					from t in apTransactions.Where(x => x.InsightCustomerId == i.CardCode && x.DocumentId == i.NumAtCard).DefaultIfEmpty()
					where t == null || t.DocumentId == null
					select i).ToList();
		}

		private static TradingAccountTransaction ToTradingAccountTransaction(PurchaseInvoice v)
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
				UnappliedFunds = v.DocTotal,
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
			var list = GetAPTransactions();

			foreach (var v in list)
				_tradingAccountTransactionService.Insert(ToTradingAccountTransaction(v));
		}
	}
}