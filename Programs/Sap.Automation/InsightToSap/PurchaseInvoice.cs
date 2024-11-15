using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseInvoices;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.Orders;
using Sql2023.Intranet.Services.Terms;

namespace Sap.Automation
{
	internal partial class InsightToSap
	{
		private static readonly IOrderService _intranetOrderService = new OrderService();

		#region Utilities
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
				DocDate = x.DateEntered,
				DocDueDate = x.DateEntered.Value.AddDays(TermsUtil.GetAddDays(x.Terms)),
				TaxDate = x.DateEntered,
				DocTotal = x.TotalSales / 10000, // Insight adds 4 extra zeros
				DocTotalSys = x.TotalSales / 10000,
				Address = x.ShipToAddress1,
				Address2 = x.ShipToAddress2,
				CardCode = $"V{x.Cust_}",
				JournalMemo = $"A/P Invoices - V{x.Cust_}",
				ControlAccount = PurchaseInvoice_ControlAccount,
				DocumentLines = GetDocumentLines(x),
			};
		}
		#endregion

		/// <summary>
		/// Order => PurchaseInvoice (A/P).
		/// </summary>
		public static async Task CreateMissingPurchaseInvoices()
		{
			var purchaseInvoices = _intranetOrderService.GetRecent().Where(x => x.DateEntered >= SapStartDate).ToList();

			if (purchaseInvoices == null || purchaseInvoices.Count == 0)
				return;

			var scarPurchaseInvoices = _scarPurchaseInvoiceService.GetAllValid();
			var missingPurchaseInvoices = (from x in purchaseInvoices // left join
										   from y in scarPurchaseInvoices.Where(y => y.NumAtCard == x.OrderID.ToString()).DefaultIfEmpty()
										   where y == null || y.NumAtCard == null
										   select x).ToList();

			if (missingPurchaseInvoices != null && missingPurchaseInvoices.Count > 0)
				_exportManager.ExportToCsv(missingPurchaseInvoices);

			foreach (var purchaseInvoice in missingPurchaseInvoices) {
				var created = await Common.RcwServiceLayer.TryCreateAsync(ToPurchaseInvoice(purchaseInvoice));

				if (created.Item1 == null)
					Common.nLog.Error(created.ErrorMsg);
			}
		}
	}
}