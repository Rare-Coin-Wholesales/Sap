using System;
using System.Collections.Generic;
using System.IO;

namespace Rcw.Sap
{
	public partial class ApInvoice
	{
		private readonly char[] SEPARATOR = new char[] { '/' };
		public string DocumentType;
		public string VendorId;
		public string VendorDocNumberStr;
		public string DateStr;
		public string AmountStr;

		public string SapVendorId
		{
			get {
				return $"V{VendorId}";
			}
		}

		public int VendorDocNumber
		{
			get {
				if (int.TryParse(VendorDocNumberStr, out var result))
					return result;

				return 0;
			}
		}

		public DateTime? Date
		{
			get {
				if (DateTime.TryParse(DateStr, out var date))
					return date;

				var split = DateStr.Split(SEPARATOR, StringSplitOptions.RemoveEmptyEntries);

				if (int.TryParse(split[0], out var month)) {
					if (int.TryParse(split[1], out var day)) {
						if (int.TryParse(split[2], out var year))
							return new DateTime(year, month, day);
					}
				}

				return null;
			}
		}

		public decimal? Amount
		{
			get {
				if (decimal.TryParse(AmountStr, out var amount))
					return amount;

				return null;
			}
		}

		public static void ToCsv(IList<ApInvoice> list)
		{
			var log = "DocumentType,VendorId,SAP Id,VendorDoc#,Date,Amount\r\n";

			foreach (var v in list)
				log = String.Format($"{log}\"{v.DocumentType}\",\"{v.VendorId}\",\"{v.SapVendorId}\",\"{v.VendorDocNumberStr}\",\"{v.DateStr}\",\"{v.Amount:n2}\"{Environment.NewLine}");

			var folder = String.Format("C:/Logs/Rcw.Sap/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}ApInvoices {1:dd HHmm ssff}.csv", folder, DateTime.Now), log);
		}
	}
}