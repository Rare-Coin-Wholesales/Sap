using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Sap.Core;

namespace Sap.Automation
{
	partial class InsightToSap
	{
		const string TAB = "\t";
		static List<ApInvoice> ApInvoices;

		private static void GetApInvoices()
		{
			DataTable dt;
			ApInvoices = new List<ApInvoice>();

			foreach (var v in ApInvFiles) {
				dt = CommonUtil.ToDataTable(v, TAB, true);

				foreach (DataRow row in dt.Rows) {
					ApInvoices.Add(new ApInvoice {
						DocumentType = row[0].ToString(),
						VendorId = row[1].ToString(),
						VendorDocNumberStr = row[2].ToString(),
						DateStr = row[3].ToString(),
						AmountStr = row[4].ToString(),
					});
				}
			}

			ApInvoices = ApInvoices.Where(x => x.Date >= SapStartDate && x.Date > ThreeMonthsAgo).ToList();
			ApInvoice.ToCsv(ApInvoices);
		}

		public static bool TryGetApInvoices(out string errorMsg)
		{
			try {
				GetApInvoices();
				errorMsg = string.Empty;
				return true;
			}

			catch (Exception ex) {
				errorMsg = ex.CustomMessage("Exception thrown in GetApInvoices().");
				return false;
			}
		}
	}
}