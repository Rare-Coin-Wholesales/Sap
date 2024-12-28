using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseInvoices;

namespace Rcw.Sap
{
	partial class Program
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

					var scarPurchaseInvoices = _purchaseInvoiceService.GetForEsds();
					var missingPurchaseInvoices = (from x in purchaseInvoices // left join
												   from y in scarPurchaseInvoices.Where(y => y.NumAtCard == x.VendorDocNumberStr).DefaultIfEmpty()
												   where y == null || y.NumAtCard == null
												   select x).ToList();

					if (missingPurchaseInvoices.Any())
						ApInvoice.ToCsv(missingPurchaseInvoices);

					foreach (var purchaseInvoice in missingPurchaseInvoices) {
						var created = await _serviceLayer.TryCreateAsync(ToPurchaseInvoice(purchaseInvoice));

						if (created.Item1 == null) {
							if (!created.ErrorMsg.StartsWith("10001467 ") && // IndexOf() returns -1 if the string is not found
								created.ErrorMsg.IndexOf("There is already a record with duplicated customer", StringComparison.OrdinalIgnoreCase) < 0)
								nLog.Error(created.ErrorMsg);
						}
					}
				}

				else
					nLog.Error(errorMsg2);
			}

			else
				nLog.Error(errorMsg);
		}
	}
}