using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.Invoices;
using Sql2023.Intranet.Services.Invoices;

namespace Rcw.Sap
{
	partial class Program
	{
		private static readonly IInvoiceService _intranetInvoiceService = new InvoiceService();

		#region Utilities
		/// <summary>
		/// Determines if the State is California or not.
		/// </summary>
		/// <param name="state">The State.</param>
		/// <returns>True if California. False otherwise.</returns>
		private static bool IsCalifornia(string state)
		{
			if (String.IsNullOrWhiteSpace(state))
				return false;
			if (state.Equals("CA", StringComparison.OrdinalIgnoreCase) || state.Equals("California", StringComparison.OrdinalIgnoreCase))
				return true;

			return false;
		}

		private static Invoice_DocumentLine GetCogsSalesLine(ArInvoice x, string description)
		{
			return new Invoice_DocumentLine {
				ItemDescription = description,
				Quantity = 1,
				Price = -x.Cost,
				PriceAfterVAT = -x.Cost,
				LineTotal = -x.Cost,
				TaxTotal = 0,
				TaxCode = TAX_EXEMPT,
				RowTotalSC = -x.Cost,
				UnitPrice = -x.Cost,
				OpenAmount = -x.Cost,
				OpenAmountSC = -x.Cost,
				GrossPrice = -x.Cost,
				GrossTotal = -x.Cost,
				GrossTotalSC = -x.Cost,
				DiscountPercent = 0,
				AccountCode = COGS_SALES_RETAIL_OUT_OF_STATE,
			};
		}

		private static Invoice_DocumentLine GetIncomeSalesLine(ArInvoice x, string description)
		{
			return new Invoice_DocumentLine {
				ItemDescription = description,
				Quantity = 1,
				Price = x.Amount,
				PriceAfterVAT = x.Amount,
				LineTotal = x.Amount,
				TaxTotal = x.Tax,
				TaxCode = TAX_EXEMPT,
				RowTotalSC = x.Amount,
				UnitPrice = x.Amount,
				OpenAmount = x.Amount,
				OpenAmountSC = x.Amount,
				GrossPrice = x.Amount,
				GrossTotal = x.Amount,
				GrossTotalSC = x.Amount,
				DiscountPercent = 0,
				AccountCode = INCOME_SALES_RETAIL_OUT_OF_STATE,
			};
		}

		private static Invoice_DocumentLine GetInventoryLine(ArInvoice x, string description)
		{
			return new Invoice_DocumentLine {
				ItemDescription = description,
				Quantity = 1,
				Price = x.Cost,
				PriceAfterVAT = x.Cost,
				LineTotal = x.Cost,
				TaxTotal = 0,
				TaxCode = TAX_EXEMPT,
				RowTotalSC = x.Cost,
				UnitPrice = x.Cost,
				OpenAmount = x.Cost,
				OpenAmountSC = x.Cost,
				GrossPrice = x.Cost,
				GrossTotal = x.Cost,
				GrossTotalSC = x.Cost,
				DiscountPercent = 0,
				AccountCode = INVENTORY_COIN,
			};
		}

		private static IList<Invoice_DocumentLine> GetDocumentLines(ArInvoice x)
		{
			var description = "Coin(s)";
			var list = new List<Invoice_DocumentLine>();
			var lineItems = _intranetInvoiceService.GetLineItemsByInvoiceId(x.Invoice);

			if (lineItems.Any()) {
				foreach (var item in lineItems.OrderBy(y => y.CoinID).ToList())
					description += $" {item.CoinID},";

				description = description.Substring(0, description.Length - 1);
			}

			list.Add(GetIncomeSalesLine(x, description));
			list.Add(GetInventoryLine(x, description));
			list.Add(GetCogsSalesLine(x, description));
			return list;
		}

		private static Invoice ToInvoice(ArInvoice x)
		{
			return new Invoice {
				NumAtCard = x.Invoice.ToString(),
				DocType = DOCUMENT_SERVICE,
				DocDate = x.Date ?? null,
				DocDueDate = x.Date ?? null,
				TaxDate = x.Date ?? null,
				DocTotal = x.Amount,
				DocTotalSys = x.Amount,
				Address = "",
				Address2 = "",
				CardCode = x.Customer,
				JournalMemo = $"A/R Invoices - {x.Customer}",
				ControlAccount = ACCOUNTS_RECEIVABLE,
				DiscountPercent = 0,
				Comments = x.SalesOrder ?? "",
				DocumentLines = GetDocumentLines(x),
			};
		}
		#endregion

		/// <summary>
		/// Invoice => Invoice (A/R).
		/// </summary>
		public static async Task CreateMissingPdsjs()
		{
			if (TryGetArInvFiles(out var errorMsg)) {
				if (TryGetArInvoices(out var errorMsg2)) {
					await CreateMissingArInvoiceCustomers();
					var invoices = ArInvoices.Where(x => x.Invoice > MIN_DOC_NUMBER).ToList();

					if (invoices == null || invoices.Count == 0)
						return;

					var scarInvoices = _invoiceService.GetForPdsjs();
					var missingInvoices = (from x in invoices // left join
										   from y in scarInvoices.Where(y => y.NumAtCard == x.InvoiceStr).DefaultIfEmpty()
										   where y == null || y.NumAtCard == null
										   select x).ToList();

					if (missingInvoices.Any())
						ArInvoice.ToCsv(missingInvoices);

					foreach (var invoice in missingInvoices) {
						var created = await _serviceLayer.TryCreateAsync(ToInvoice(invoice));

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