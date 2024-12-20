using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Sap.Core;

namespace Rcw.Sap
{
	partial class Program
	{
		static List<ArInvoice> ArInvoices;

		private static void GetArInvoices()
		{
			DataTable dt;
			ArInvoices = new List<ArInvoice>();

			foreach (var v in ArInvFiles) {
				dt = CommonUtil.ToDataTable(v, TAB, true);

				foreach (DataRow row in dt.Rows) {
					ArInvoices.Add(new ArInvoice {
						Type = row[0].ToString(),
						TypeID = row[1].ToString(),
						InvoiceStr = row[2].ToString(),
						DateStr = row[3].ToString(),
						Customer = row[4].ToString(),
						CustomerPO = row[5].ToString(),
						TermsCode = row[6].ToString(),
						SalesOrder = row[7].ToString(),
						CostStr = row[8].ToString(),
						AmountStr = row[9].ToString(),
						FreightStr = row[10].ToString(),
						TaxStr = row[11].ToString(),
						SalesPerson = row[12].ToString(),
						Batch = row[13].ToString(),
					});
				}
			}

			ArInvoices = ArInvoices.Where(x => x.Date >= SapStartDate && x.Date > ThreeMonthsAgo).ToList();
			ArInvoice.ToCsv(ArInvoices);
		}

		public static bool TryGetArInvoices(out string errorMsg)
		{
			try {
				GetArInvoices();
				errorMsg = string.Empty;
				return true;
			}

			catch (Exception ex) {
				errorMsg = ex.CustomMessage("Exception thrown in GetArInvoices().");
				return false;
			}
		}
	}
}