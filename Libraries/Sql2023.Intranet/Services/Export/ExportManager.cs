using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Export
{
	/// <summary>
	/// Export manager class
	/// </summary>
	public partial class ExportManager : IExportManager
	{
		private const string COMMA = ",";

		/// <inheritdoc/>
		public virtual void ExportCoinIdsToCsv(IList<int> list)
		{
			if (list == null)
				throw new ArgumentNullException("list", "List is required.");

			var sb = new StringBuilder($"CoinID{Environment.NewLine}");

			foreach (var item in list)
				sb.Append($"{item}{Environment.NewLine}"); //new line

			WriteToCsvFile(sb.ToString(), "CoinIDs");
		}

		/// <inheritdoc/>
		public virtual void ExportToCsv(IList<Inventory> list)
		{
			if (list == null)
				throw new ArgumentNullException("list", "List is required.");

			var sb = new StringBuilder($"InvID,Description,Cost,Rock,Wholesale{Environment.NewLine}");

			foreach (var item in list) {
				sb.Append($"\"{item.InventoryID}\"{COMMA}");
				sb.Append($"\"{item.InventoryDescription1}\"{COMMA}");
				sb.Append($"\"{item.InventoryCost}\"{COMMA}");
				sb.Append($"\"{item.InventoryRock}\"{COMMA}");
				sb.Append($"\"{item.InventoryWholesale}\"{Environment.NewLine}"); //new line
			}

			WriteToCsvFile(sb.ToString(), "Inventory");
		}

		/// <inheritdoc/>
		public virtual void ExportToCsv(IList<Invoice> list)
		{
			if (list == null)
				throw new ArgumentNullException("list", "List is required.");

			var sb = new StringBuilder($"InvoiceID,Cust#,ShipToName1,ShipToName2,ShipToAddress1,ShipToAddress2,ShipToCity,ShipToState,ShipToZip,Territory,SalesRep,Terms,OrderNumber,TaxCode,DateEntered,DateInvoiced,DateShipped,CustomerPO,ShipVia,ShipTracking,ShipDateActual,TotalSales,TotalSalesTaxable,TotalCost,TotalRock,TaxAmount{Environment.NewLine}");

			foreach (var item in list) {
				sb.Append($"\"{item.InvoiceID}\"{COMMA}");
				sb.Append($"\"{item.Cust_}\"{COMMA}");
				sb.Append($"\"{item.ShipToName1}\"{COMMA}");
				sb.Append($"\"{item.ShipToName2}\"{COMMA}");
				sb.Append($"\"{item.ShipToAddress1}\"{COMMA}");
				sb.Append($"\"{item.ShipToAddress2}\"{COMMA}");
				sb.Append($"\"{item.ShipToCity}\"{COMMA}");
				sb.Append($"\"{item.ShipToState}\"{COMMA}");
				sb.Append($"\"{item.ShipToZip}\"{COMMA}");
				sb.Append($"\"{item.Territory}\"{COMMA}");
				sb.Append($"\"{item.SalesRep}\"{COMMA}");
				sb.Append($"\"{item.Terms}\"{COMMA}");
				sb.Append($"\"{item.OrderNumber}\"{COMMA}");
				sb.Append($"\"{item.TaxCode}\"{COMMA}");
				sb.Append($"\"{item.DateEntered}\"{COMMA}");
				sb.Append($"\"{item.DateInvoiced}\"{COMMA}");
				sb.Append($"\"{item.DateShipped}\"{COMMA}");
				sb.Append($"\"{item.CustomerPO}\"{COMMA}");
				sb.Append($"\"{item.ShipVia}\"{COMMA}");
				sb.Append($"\"{item.ShipTracking}\"{COMMA}");
				sb.Append($"\"{item.ShipDateActual}\"{COMMA}");
				sb.Append($"\"{item.TotalSales}\"{COMMA}");
				sb.Append($"\"{item.TotalSalesTaxable}\"{COMMA}");
				sb.Append($"\"{item.TotalCost}\"{COMMA}");
				sb.Append($"\"{item.TotalRock}\"{COMMA}");
				sb.Append($"\"{item.TaxAmount}\"{Environment.NewLine}"); //new line
			}

			WriteToCsvFile(sb.ToString(), "Invoices");
		}

		/// <inheritdoc/>
		public virtual void ExportToCsv(IList<Order> list)
		{
			if (list == null)
				throw new ArgumentNullException("list", "List is required.");

			var sb = new StringBuilder($"OrderID,Cust#,ShipToName1,ShipToName2,ShipToAddress1,ShipToAddress2,ShipToCity,ShipToState,ShipToZip,Territory,SalesRep,Terms,TaxCode,SpecialInstructions,Taxable,DateEntered,DatePromised,DateRevised,CustomerPO,Revised,ShipVia,ShipTracking,ShipDateActual,TotalSales,TotalCost,TotalRock,TaxAmount{Environment.NewLine}");

			foreach (var item in list) {
				sb.Append($"\"{item.OrderID}\"{COMMA}");
				sb.Append($"\"{item.Cust_}\"{COMMA}");
				sb.Append($"\"{item.ShipToName1}\"{COMMA}");
				sb.Append($"\"{item.ShipToName2}\"{COMMA}");
				sb.Append($"\"{item.ShipToAddress1}\"{COMMA}");
				sb.Append($"\"{item.ShipToAddress2}\"{COMMA}");
				sb.Append($"\"{item.ShipToCity}\"{COMMA}");
				sb.Append($"\"{item.ShipToState}\"{COMMA}");
				sb.Append($"\"{item.ShipToZip}\"{COMMA}");
				sb.Append($"\"{item.Territory}\"{COMMA}");
				sb.Append($"\"{item.SalesRep}\"{COMMA}");
				sb.Append($"\"{item.Terms}\"{COMMA}");
				sb.Append($"\"{item.TaxCode}\"{COMMA}");
				sb.Append($"\"{item.SpecialInstructions}\"{COMMA}");
				sb.Append($"\"{item.Taxable}\"{COMMA}");
				sb.Append($"\"{item.DateEntered}\"{COMMA}");
				sb.Append($"\"{item.DatePromised}\"{COMMA}");
				sb.Append($"\"{item.DateRevised}\"{COMMA}");
				sb.Append($"\"{item.CustomerPO}\"{COMMA}");
				sb.Append($"\"{item.Revised}\"{COMMA}");
				sb.Append($"\"{item.ShipVia}\"{COMMA}");
				sb.Append($"\"{item.ShipTracking}\"{COMMA}");
				sb.Append($"\"{item.ShipDateActual}\"{COMMA}");
				sb.Append($"\"{item.TotalSales}\"{COMMA}");
				sb.Append($"\"{item.TotalCost}\"{COMMA}");
				sb.Append($"\"{item.TotalRock}\"{COMMA}");
				sb.Append($"\"{item.TaxAmount}\"{Environment.NewLine}"); //new line
			}

			WriteToCsvFile(sb.ToString(), "Orders");
		}

		/// <inheritdoc/>
		public virtual void ExportToCsv(IList<UnixCustomer> list)
		{
			if (list == null)
				throw new ArgumentNullException("list", "List is required.");

			var sb = new StringBuilder($"CustID,CustName,CustContact,CustAddress1,CustAddress2,CustCity,CustState,CustZip,CustTaxCode,CustPhone1,CustPhone2,CustReseller,CustTerms,GM_AccountNo{Environment.NewLine}");

			foreach (var item in list) {
				sb.Append($"\"{item.CustID}\"{COMMA}");
				sb.Append($"\"{item.CustName}\"{COMMA}");
				sb.Append($"\"{item.CustContact}\"{COMMA}");
				sb.Append($"\"{item.CustAddress1}\"{COMMA}");
				sb.Append($"\"{item.CustAddress2}\"{COMMA}");
				sb.Append($"\"{item.CustCity}\"{COMMA}");
				sb.Append($"\"{item.CustState}\"{COMMA}");
				sb.Append($"\"{item.CustZip}\"{COMMA}");
				sb.Append($"\"{item.CustTaxCode}\"{COMMA}");
				sb.Append($"\"{item.CustPhone1}\"{COMMA}");
				sb.Append($"\"{item.CustPhone2}\"{COMMA}");
				sb.Append($"\"{item.CustReseller}\"{COMMA}");
				sb.Append($"\"{item.CustTerms}\"{COMMA}");
				sb.Append($"\"{item.GM_AccountNo}\"{Environment.NewLine}"); //new line
			}

			WriteToCsvFile(sb.ToString(), "UnixCustomers");
		}

		/// <inheritdoc/>
		public virtual void WriteToCsvFile(string data, string entityName)
		{
			var now = DateTime.Now;
			var folder = $"C:/Logs/SAP Automation/{now:yyyy MM}/";
			Directory.CreateDirectory(folder);
			File.WriteAllText($"{folder}{entityName} {now:dd HHmm ssff}.csv", data);
		}

		/// <inheritdoc/>
		public virtual void WriteToFile(string data, string entityName)
		{
			var now = DateTime.Now;
			var folder = $"C:/Logs/SAP Automation/{now:yyyy MM}/";
			Directory.CreateDirectory(folder);
			File.WriteAllText($"{folder}{entityName} {now:dd HHmm ssff}.log", data);
		}
	}
}