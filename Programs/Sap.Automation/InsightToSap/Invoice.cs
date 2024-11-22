using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.Invoices;
using Sql2023.Intranet.Services.Invoices;
using Sql2023.Intranet.Services.Terms;

namespace Sap.Automation
{
	internal partial class InsightToSap
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

		#region Itemized
		private static Invoice_DocumentLine GetCogsSalesLineItemized(Sql2023.Intranet.Domain.InvoiceLineItem item, string state)
		{
			var total = (item.Cost ?? 0) * -(item.QtyOrdered ?? 1);

			return new Invoice_DocumentLine {
				ItemDescription = $"Coin {item.CoinID}",
				Quantity = item.QtyOrdered,
				Price = total,
				PriceAfterVAT = total,
				LineTotal = total,
				TaxTotal = 0,
				TaxCode = TAX_EXEMPT,
				RowTotalSC = total,
				UnitPrice = -item.Cost,
				OpenAmount = total,
				OpenAmountSC = total,
				GrossPrice = total,
				GrossTotal = total,
				GrossTotalSC = total,
				DiscountPercent = 0,
				AccountCode = IsCalifornia(state) ? COGS_SALES_RETAIL_CA : COGS_SALES_RETAIL_OUT_OF_STATE,
			};
		}

		private static Invoice_DocumentLine GetIncomeSalesLineItemized(Sql2023.Intranet.Domain.InvoiceLineItem item, string state)
		{
			var total = (item.Price ?? 0) * (item.QtyOrdered ?? 1);

			return new Invoice_DocumentLine {
				ItemDescription = $"Coin {item.CoinID}",
				Quantity = item.QtyOrdered,
				Price = total,
				PriceAfterVAT = total,
				LineTotal = total,
				TaxTotal = 0,
				TaxCode = TAX_EXEMPT,
				RowTotalSC = total,
				UnitPrice = item.Price,
				OpenAmount = total,
				OpenAmountSC = total,
				GrossPrice = total,
				GrossTotal = total,
				GrossTotalSC = total,
				DiscountPercent = 0,
				AccountCode = IsCalifornia(state) ? INCOME_SALES_RETAIL_CA : INCOME_SALES_RETAIL_OUT_OF_STATE,
			};
		}

		private static Invoice_DocumentLine GetInventoryLineItemized(Sql2023.Intranet.Domain.InvoiceLineItem item)
		{
			var total = (item.Cost ?? 0) * (item.QtyOrdered ?? 1);

			return new Invoice_DocumentLine {
				ItemDescription = $"Coin {item.CoinID}",
				Quantity = item.QtyOrdered,
				Price = total,
				PriceAfterVAT = total,
				LineTotal = total,
				TaxTotal = 0,
				TaxCode = TAX_EXEMPT,
				RowTotalSC = total,
				UnitPrice = item.Cost,
				OpenAmount = total,
				OpenAmountSC = total,
				GrossPrice = total,
				GrossTotal = total,
				GrossTotalSC = total,
				DiscountPercent = 0,
				AccountCode = INVENTORY_COIN,
			};
		}

		private static IList<Invoice_DocumentLine> GetDocumentLinesItemized(Sql2023.Intranet.Domain.Invoice x)
		{
			var list = new List<Invoice_DocumentLine>();
			var lineItems = _intranetInvoiceService.GetLineItemsByInvoiceId(x.InvoiceID);

			if (lineItems == null || lineItems.Count == 0)
				return list;

			foreach (var item in lineItems.OrderBy(y => y.InvoiceLine).ToList()) {
				list.Add(GetIncomeSalesLineItemized(item, x.ShipToState));
				list.Add(GetInventoryLineItemized(item));
				list.Add(GetCogsSalesLineItemized(item, x.ShipToState));
			}

			return list;
		}
		#endregion

		#region Rolled-Up
		private static Invoice_DocumentLine GetCogsSalesLineRolledUp(Sql2023.Intranet.Domain.Invoice x, string description)
		{
			return new Invoice_DocumentLine {
				ItemDescription = description,
				Quantity = 1,
				Price = -x.TotalCost,
				PriceAfterVAT = -x.TotalCost,
				LineTotal = -x.TotalCost,
				TaxTotal = 0,
				TaxCode = TAX_EXEMPT,
				RowTotalSC = -x.TotalCost,
				UnitPrice = -x.TotalCost,
				OpenAmount = -x.TotalCost,
				OpenAmountSC = -x.TotalCost,
				GrossPrice = -x.TotalCost,
				GrossTotal = -x.TotalCost,
				GrossTotalSC = -x.TotalCost,
				DiscountPercent = 0,
				AccountCode = IsCalifornia(x.ShipToState) ? COGS_SALES_RETAIL_CA : COGS_SALES_RETAIL_OUT_OF_STATE,
			};
		}

		private static Invoice_DocumentLine GetIncomeSalesLineRolledUp(Sql2023.Intranet.Domain.Invoice x, string description)
		{
			return new Invoice_DocumentLine {
				ItemDescription = description,
				Quantity = 1,
				Price = x.TotalSales,
				PriceAfterVAT = x.TotalSales,
				LineTotal = x.TotalSales,
				TaxTotal = x.TaxAmount,
				TaxCode = TAX_EXEMPT,
				RowTotalSC = x.TotalSales,
				UnitPrice = x.TotalSales,
				OpenAmount = x.TotalSales,
				OpenAmountSC = x.TotalSales,
				GrossPrice = x.TotalSales,
				GrossTotal = x.TotalSales,
				GrossTotalSC = x.TotalSales,
				DiscountPercent = 0,
				AccountCode = IsCalifornia(x.ShipToState) ? INCOME_SALES_RETAIL_CA : INCOME_SALES_RETAIL_OUT_OF_STATE,
			};
		}

		private static Invoice_DocumentLine GetInventoryLineRolledUp(Sql2023.Intranet.Domain.Invoice x, string description)
		{
			return new Invoice_DocumentLine {
				ItemDescription = description,
				Quantity = 1,
				Price = x.TotalCost,
				PriceAfterVAT = x.TotalCost,
				LineTotal = x.TotalCost,
				TaxTotal = 0,
				TaxCode = TAX_EXEMPT,
				RowTotalSC = x.TotalCost,
				UnitPrice = x.TotalCost,
				OpenAmount = x.TotalCost,
				OpenAmountSC = x.TotalCost,
				GrossPrice = x.TotalCost,
				GrossTotal = x.TotalCost,
				GrossTotalSC = x.TotalCost,
				DiscountPercent = 0,
				AccountCode = INVENTORY_COIN,
			};
		}

		private static IList<Invoice_DocumentLine> GetDocumentLinesRolledUp(Sql2023.Intranet.Domain.Invoice x)
		{
			var list = new List<Invoice_DocumentLine>();
			var lineItems = _intranetInvoiceService.GetLineItemsByInvoiceId(x.InvoiceID);

			if (lineItems == null || lineItems.Count == 0)
				return list;

			var description = "Coin(s) ";

			foreach (var item in lineItems.OrderBy(y => y.CoinID).ToList())
				description += $"{item.CoinID}, ";
			
			description = description.Substring(0, description.Length - 2);
			list.Add(GetIncomeSalesLineRolledUp(x, description));
			list.Add(GetInventoryLineRolledUp(x, description));
			list.Add(GetCogsSalesLineRolledUp(x, description));
			return list;
		}
		#endregion

		private static Invoice ToInvoice(Sql2023.Intranet.Domain.Invoice x)
		{
			return new Invoice {
				NumAtCard = x.InvoiceID.ToString(),
				DocType = DOCUMENT_SERVICE,
				DocDate = x.DateInvoiced ?? x.DateEntered,
				DocDueDate = (x.DateInvoiced ?? x.DateEntered).Value.AddDays(TermsUtil.GetAddDays(x.Terms)),
				TaxDate = x.DateInvoiced ?? x.DateEntered,
				DocTotal = x.TotalSales,
				DocTotalSys = x.TotalSales,
				Address = x.ShipToAddress1,
				Address2 = x.ShipToAddress2,
				CardCode = $"{x.Cust_}",
				JournalMemo = $"A/R Invoices - {x.Cust_}",
				ControlAccount = ACCOUNTS_RECEIVABLE,
				DiscountPercent = 0,
				Comments = x.OrderNumber ?? "",
				//DocumentLines = GetDocumentLinesItemized(x), // itemized
				DocumentLines = GetDocumentLinesRolledUp(x), // rolled-up
			};
		}
		#endregion

		/// <summary>
		/// Invoice => Invoice (A/R).
		/// </summary>
		public static async Task CreateMissingInvoices()
		{
			var invoices = _intranetInvoiceService.GetRecent().Where(x => x.DateInvoiced >= SapStartDate).ToList();

			if (invoices == null || invoices.Count == 0)
				return;

			var sapRcwInvoices = _scarInvoiceService.GetAllValid();
			var missingInvoices = (from x in invoices // left join
								   from y in sapRcwInvoices.Where(y => y.NumAtCard == x.InvoiceID.ToString()).DefaultIfEmpty()
								   where y == null || y.NumAtCard == null
								   select x).ToList();

			if (missingInvoices != null && missingInvoices.Count > 0)
				_exportManager.ExportToCsv(missingInvoices);

			foreach (var invoice in missingInvoices) {
				var created = await Common.RcwServiceLayer.TryCreateAsync(ToInvoice(invoice));

				if (created.Item1 == null)
					Common.nLog.Error(created.ErrorMsg);
			}
		}
	}
}