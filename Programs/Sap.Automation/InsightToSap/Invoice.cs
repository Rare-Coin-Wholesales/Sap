using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.Invoices;
using Sql2023.Intranet.Services.Invoices;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		private const string ACCOUNTS_RECEIVABLE = "_SYS00000000010";
		private const string INCOME_SALES_RETAIL_CA = "_SYS00000000079";
		private const string INCOME_SALES_RETAIL_OUT_OF_STATE = "_SYS00000000080";
		private const string INCOME_SALES_WHOLESALE_CA = "_SYS00000000078";
		private static readonly IInvoiceService _intranetInvoiceService = new InvoiceService();

		/// <summary>
		/// Determines the Income Sales Account based on the State.
		/// </summary>
		/// <param name="x">The <see cref="Invoice"/>.</param>
		/// <returns>The AccountCode as a string.</returns>
		private static string DetermineAccount(Sql2023.Intranet.Domain.Invoice x)
		{
			if (x == null || String.IsNullOrWhiteSpace(x.ShipToState))
				return INCOME_SALES_RETAIL_OUT_OF_STATE;
			if (x.ShipToState.Equals("CA", StringComparison.OrdinalIgnoreCase) ||
				x.ShipToState.Equals("California", StringComparison.OrdinalIgnoreCase))
				return INCOME_SALES_RETAIL_CA;

			return INCOME_SALES_RETAIL_OUT_OF_STATE;
		}

		private static IList<Invoice_DocumentLine> GetDocumentLines(Sql2023.Intranet.Domain.Invoice x)
		{
			decimal lineTotal;
			var list = new List<Invoice_DocumentLine>();
			var lineItems = _intranetInvoiceService.GetLineItemsByInvoiceId(x.InvoiceID);

			if (lineItems == null || lineItems.Count == 0)
				return list;

			foreach (var item in lineItems.OrderBy(y => y.InvoiceLine).ToList()) {
				lineTotal = (item.Price ?? 0) * (item.QtyOrdered ?? 1);
				list.Add(new Invoice_DocumentLine {
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
					AccountCode = DetermineAccount(x),
				});
			}

			return list;
		}

		private static Invoice ToInvoice(Sql2023.Intranet.Domain.Invoice x)
		{
			return new Invoice {
				NumAtCard = x.InvoiceID.ToString(),
				DocType = DOCUMENT_SERVICE,
				CreationDate = x.DateEntered,
				DocDate = x.DateEntered,
				DocDueDate = x.DateEntered,
				TaxDate = x.DateEntered,
				UpdateDate = x.DateEntered,
				DocTotal = x.TotalSales,
				DocTotalSys = x.TotalSales,
				Address = x.ShipToAddress1,
				Address2 = x.ShipToAddress2,
				CardCode = $"{x.Cust_}",
				JournalMemo = $"A/R Invoices - {x.Cust_}",
				ControlAccount = ACCOUNTS_RECEIVABLE,
				DocumentLines = GetDocumentLines(x),
			};
		}

		/// <summary>
		/// Invoice => Invoice (A/R).
		/// </summary>
		public static async Task CreateMissingInvoices()
		{
			AddErrorLogs();
			var invoices = _intranetInvoiceService.GetRecent();

			if (invoices == null || invoices.Count == 0)
				return;

			_exportManager.ExportToCsv(invoices);
			var sapRcwInvoices = _scarInvoiceService.GetAll();
			var missingInvoices = (from x in invoices // left join
								   from y in sapRcwInvoices.Where(y => y.NumAtCard != null && (
										y.NumAtCard.StartsWith(x.InvoiceID.ToString()) || y.NumAtCard.EndsWith(x.InvoiceID.ToString())))
								   .DefaultIfEmpty()
								   where y == null || y.NumAtCard == null
								   select x).ToList();

			foreach (var invoice in missingInvoices) {
				var created = await Common.RcwServiceLayer.TryCreateAsync(ToInvoice(invoice));

				if (created.Item1 == null)
					Common.nLog.Warn(created.Item2);
			}
		}
	}
}