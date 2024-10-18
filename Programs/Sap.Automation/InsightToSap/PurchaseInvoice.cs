using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseInvoices;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseInvoices;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.Orders;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		private const string ACCOUNTS_PAYABLE_TRADE = "_SYS00000000046";
		private const string AMEX_72006 = "_SYS00000000047";
		private const string INVENTORY_COIN = "_SYS00000000022";
		private static readonly IPurchaseInvoiceService _scarPurchaseInvoiceService = new PurchaseInvoiceService();
		private static readonly IOrderService _intranetOrderService = new OrderService();

		#region Utilities
		private static void AddErrorLogs()
		{
			Common.RcwServiceLayer.OnError(async call => {
				var log = string.Empty;
				log = $"{log}Request: {call.HttpRequestMessage.Method}  {call.HttpRequestMessage.RequestUri}{Environment.NewLine}";
				log = $"{log}Body sent: {call.RequestBody}{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";
				log = $"{log}Response: {call.HttpResponseMessage?.StatusCode}{Environment.NewLine}";
				log = $"{log}{await call.HttpResponseMessage?.Content?.ReadAsStringAsync()}";
				log = $"{log}Call duration: {(DateTime.UtcNow - call.StartedUtc).TotalSeconds:n4} seconds{Environment.NewLine}";
				log = $"{log}{Environment.NewLine}";

				_exportManager.WriteToFile(log, "Error");
			});
		}

		private static IList<PurchaseInvoice_DocumentLine> GetDocumentLines(Order x)
		{
			decimal lineTotal;
			var list = new List<PurchaseInvoice_DocumentLine>();
			var lineItems = _intranetOrderService.GetLineItemsByOrderId(x.OrderID);

			if (lineItems == null || lineItems.Count == 0)
				return list;

			foreach (var item in lineItems.OrderBy(y => y.OrderLine).ToList()) {
				lineTotal = (item.Price ?? 0) * (item.QtyOrdered ?? 1);
				list.Add(new PurchaseInvoice_DocumentLine {
					ItemDescription = $"Coin {item.CoinID}",
					Quantity = item.QtyOrdered,
					Price = item.Price,
					PriceAfterVAT = item.Price,
					Address = x.ShipToAddress1,
					LineTotal = lineTotal,
					TaxTotal = 0,
					TaxCode = TAX_EXEMPT,
					RowTotalSC = lineTotal,
					UnitPrice = item.Price,
					OpenAmount = item.Price,
					OpenAmountSC = item.Price,
					GrossPrice = lineTotal,
					GrossTotal = lineTotal,
					GrossTotalSC = lineTotal,
					AccountCode = INVENTORY_COIN,
				});
			}

			return list;
		}

		private static PurchaseInvoice ToPurchaseInvoice(Order x)
		{
			return new PurchaseInvoice {
				NumAtCard = x.OrderID.ToString(),
				DocType = DOCUMENT_SERVICE,
				CreationDate = x.DateEntered,
				DocDate = x.DateEntered,
				DocDueDate = x.DateEntered,
				TaxDate = x.DateEntered,
				UpdateDate = x.DateRevised,
				DocTotal = x.TotalSales / 10000, // Insight adds 4 extra zeros
				DocTotalSys = x.TotalSales / 10000,
				Address = x.ShipToAddress1,
				Address2 = x.ShipToAddress2,
				CardCode = $"V{x.Cust_}",
				JournalMemo = $"A/P Invoices - V{x.Cust_}",
				ControlAccount = AMEX_72006,
				DocumentLines = GetDocumentLines(x),
			};
		}
		#endregion

		public static async Task CreateMissingPurchaseInvoices()
		{
			AddErrorLogs();
			var purchaseInvoices = _intranetOrderService.GetRecent();

			if (purchaseInvoices == null || purchaseInvoices.Count == 0)
				return;

			_exportManager.ExportToCsv(purchaseInvoices);
			var scarPurchaseInvoices = _scarPurchaseInvoiceService.GetAll();
			var missingPurchaseInvoices = (from x in purchaseInvoices // left join
										   from y in scarPurchaseInvoices.Where(y => y.NumAtCard.StartsWith(x.OrderID.ToString()) ||
																	   y.NumAtCard.EndsWith(x.OrderID.ToString())).DefaultIfEmpty()
										   where y == null || y.NumAtCard == null
										   select x).Take(10).ToList();

			foreach (var purchaseInvoice in missingPurchaseInvoices) {
				try {
					await Common.RcwServiceLayer.CreateAsync(ToPurchaseInvoice(purchaseInvoice));
				}

				#region catch (Exception ex)
				catch (Exception ex) {
					if (ex.InnerException == null)
						_logger.InsertWarning(ex);
					else
						throw;
				}
				#endregion
			}
		}
	}
}