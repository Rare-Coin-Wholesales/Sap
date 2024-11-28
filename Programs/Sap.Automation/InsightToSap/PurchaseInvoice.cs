using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseInvoices;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.Orders;
using Sql2023.Intranet.Services.Terms;

namespace Sap.Automation
{
	partial class InsightToSap
	{
		const int MIN_DOC_NUMBER = 39820;
		private static readonly IOrderService _intranetOrderService = new OrderService();

		#region Utilities
		private static IList<PurchaseInvoice_DocumentLine> GetDocumentLines(ApInvoice x)
		{
			var lineTotal = x.Amount;
			var list = new List<PurchaseInvoice_DocumentLine> {
				new PurchaseInvoice_DocumentLine {
					ItemDescription = "Coin(s)",
					Quantity = 1,
					Price = lineTotal,
					PriceAfterVAT = lineTotal,
					//Address = x.ShipToAddress1,
					LineTotal = lineTotal,
					TaxTotal = 0,
					TaxCode = TAX_EXEMPT,
					RowTotalSC = lineTotal,
					UnitPrice = lineTotal,
					OpenAmount = lineTotal,
					OpenAmountSC = lineTotal,
					GrossPrice = lineTotal,
					GrossTotal = lineTotal,
					GrossTotalSC = lineTotal,
					AccountCode = INVENTORY_COIN,
				}
			};

			return list;
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

		private static PurchaseInvoice ToPurchaseInvoice(ApInvoice x)
		{
			return new PurchaseInvoice {
				NumAtCard = x.VendorDocNumberStr,
				DocType = DOCUMENT_SERVICE,
				DocDate = x.Date,
				DocDueDate = x.Date,
				TaxDate = x.Date,
				DocTotal = x.Amount,
				DocTotalSys = x.Amount,
				//Address = x.ShipToAddress1,
				//Address2 = x.ShipToAddress2,
				CardCode = x.SapVendorId,
				JournalMemo = $"A/P Invoices - {x.SapVendorId}",
				ControlAccount = PurchaseInvoice_ControlAccount,
				DocumentLines = GetDocumentLines(x),
			};
		}

		private static PurchaseInvoice ToPurchaseInvoice(Order x)
		{
			return new PurchaseInvoice {
				NumAtCard = x.OrderID.ToString(),
				DocType = DOCUMENT_SERVICE,
				DocDate = x.DateEntered,
				DocDueDate = x.DateEntered.Value.AddDays(TermsUtil.GetAddDays(x.Terms)),
				TaxDate = x.DateEntered,
				DocTotal = x.TotalSales,
				DocTotalSys = x.TotalSales,
				Address = x.ShipToAddress1,
				Address2 = x.ShipToAddress2,
				CardCode = $"{x.VendorId}",
				JournalMemo = $"A/P Invoices - {x.VendorId}",
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
			var intranetOrders = _intranetOrderService.GetRecent().Where(x => x.DateEntered >= SapStartDate).ToList();

			if (intranetOrders == null || intranetOrders.Count == 0)
				return;

			intranetOrders.ForEach(x => x.TotalSales /= 10000); // Insight adds 4 extra zeros
			var scarPurchaseInvoices = _scarPurchaseInvoiceService.GetForEsds();
			var missingPurchaseInvoices = (from io in intranetOrders
										   from spi in scarPurchaseInvoices.Where(spi => spi.DocDate == io.DateEntered &&
																						 spi.DocTotal == io.TotalSales && // left join
																						 spi.CardCode == io.VendorId).DefaultIfEmpty()
										   where spi == null || spi.DocDate == null
										   select io).ToList();

			if (missingPurchaseInvoices != null && missingPurchaseInvoices.Count > 0)
				_exportManager.ExportToCsv(missingPurchaseInvoices);

			foreach (var purchaseInvoice in missingPurchaseInvoices) {
				var created = await Common.RcwServiceLayer.TryCreateAsync(ToPurchaseInvoice(purchaseInvoice));

				if (created.Item1 == null)
					Common.nLog.Error(created.ErrorMsg);
			}
		}

		public static async Task CreateMissingEsds()
		{
			if (TryGetApInvFiles(out var errorMsg)) {
				if (TryGetApInvoices(out var errorMsg2)) {
					await CreateMissingApInvoiceVendors();
					var purchaseInvoices = ApInvoices.Where(x => x.VendorDocNumber > MIN_DOC_NUMBER).ToList();

					if (purchaseInvoices == null || purchaseInvoices.Count == 0)
						return;

					var scarPurchaseInvoices = _scarPurchaseInvoiceService.GetForEsds();
					var missingPurchaseInvoices = (from x in purchaseInvoices // left join
												   from y in scarPurchaseInvoices.Where(y => y.DocDate == x.Date && y.DocTotal == x.Amount &&
																							 y.CardCode == x.SapVendorId).DefaultIfEmpty()
												   where y == null || y.DocDate == null
												   select x).ToList();

					if (missingPurchaseInvoices != null && missingPurchaseInvoices.Count > 0)
						ApInvoice.ToCsv(missingPurchaseInvoices);

					foreach (var purchaseInvoice in missingPurchaseInvoices) {
						var created = await Common.RcwServiceLayer.TryCreateAsync(ToPurchaseInvoice(purchaseInvoice));

						if (created.Item1 == null)
							Common.nLog.Error(created.ErrorMsg);
					}
				}

				else
					Common.nLog.Error(errorMsg2);
			}

			else
				Common.nLog.Error(errorMsg);
		}
	}
}