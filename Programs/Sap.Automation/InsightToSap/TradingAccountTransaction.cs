using System.Collections.Generic;
using System.Linq;
using Sql2023.Intranet.Domain;
using Sql2023.WwwSPs.Domain;
using Sql2023.WwwSPs.Services.TradingAccounts;
using Sql2023.WwwSPs.Services.TradingAccountTransactions;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		private static readonly ITradingAccountService _tradingAccountService = new TradingAccountService();
		private static readonly ITradingAccountTransactionService _tradingAccountTransactionService = new TradingAccountTransactionService();

		private static IList<TradingAccountTransaction> GetConsignmentTransactions()
		{
			var inventory = _inventoryService.GetConsigned();
			var tradingAccounts = _tradingAccountService.GetAll();
			var tradingAccountTransactions = _tradingAccountTransactionService.GetAllTaDocumentIds();

			var query = (from t in tradingAccounts
						 from i in inventory.Where(x => x.InventoryConsignmentVendor == t.InsightCustomerId)
						 from tat in tradingAccountTransactions.Where(x => x == i.InventoryConsignmentNumber.ToString()).DefaultIfEmpty()
						 where tat == null
						 select i)
						 .GroupBy(x => new { x.InventoryConsignmentNumber, x.InventoryConsignmentDate, x.InventoryConsignmentVendor, x.InventoryConsignmentTABases })
						 .Select(s => new TradingAccountTransaction {
							 InsightCustomerId = s.First().InventoryConsignmentVendor,
							 DocumentId = s.First().InventoryConsignmentNumber.ToString(),

							 //TODO: finish
						 })
						 .ToList();


			return null;
		}
	}
}