using System;
using System.Collections.Generic;
using System.IO;

namespace Rcw.Sap
{
	public partial class ArInvoice
	{
		private readonly char[] SEPARATOR = new char[] { '/' };
		public string Type;
		public string TypeID;
		public string InvoiceStr;
		public string DateStr;
		public string Customer;
		public string CustomerPO;
		public string TermsCode;
		public string SalesOrder;
		public string CostStr;
		public string AmountStr;
		public string FreightStr;
		public string TaxStr;
		public string SalesPerson;
		public string Batch;

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

		public int Invoice
		{
			get {
				if (int.TryParse(InvoiceStr, out var result))
					return result;

				return 0;
			}
		}

		public decimal Cost
		{
			get {
				if (decimal.TryParse(CostStr, out var result))
					return result;

				return 0;
			}
		}

		public decimal Amount
		{
			get {
				if (decimal.TryParse(AmountStr, out var result))
					return result;

				return 0;
			}
		}

		public decimal Freight
		{
			get {
				if (decimal.TryParse(FreightStr, out var result))
					return result;

				return 0;
			}
		}

		public decimal Tax
		{
			get {
				if (decimal.TryParse(TaxStr, out var result))
					return result;

				return 0;
			}
		}

		public static void ToCsv(IList<ArInvoice> list)
		{
			var log = "Type,TypeID,Invoice,Date,Customer,CustomerPO,TermsCode,SalesOrder,Cost,Amount,Freight,Tax,SalesPerson,Batch\r\n";

			foreach (var v in list)
				log = String.Format($"{log}\"{v.Type}\",\"{v.TypeID}\",\"{v.InvoiceStr}\",\"{v.DateStr}\",\"{v.Customer}\",\"{v.CustomerPO}\",\"{v.TermsCode}\",\"{v.SalesOrder}\",\"{v.Cost:n2}\",\"{v.Amount:n2}\",\"{v.Freight:n2}\",\"{v.Tax:n2}\",\"{v.SalesPerson}\",\"{v.Batch}\"{Environment.NewLine}");

			var folder = String.Format("C:/Logs/Rcw.Sap/{0:yyyy MM}/{0:dd}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}ArInvoices {1:HHmm ssff}.csv", folder, DateTime.Now), log);
		}
	}
}