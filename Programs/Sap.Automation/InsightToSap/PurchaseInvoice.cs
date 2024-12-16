using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseInvoices;

namespace Sap.Automation
{
	partial class InsightToSap
	{
		const int MIN_DOC_NUMBER = 39820;

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
		#endregion

		/// <summary>
		/// Order => PurchaseInvoice (A/P).
		/// </summary>
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