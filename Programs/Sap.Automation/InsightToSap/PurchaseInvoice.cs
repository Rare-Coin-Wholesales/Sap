using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseInvoices;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.Orders;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		private static IList<PurchaseInvoice> PurchaseInvoices;
		private static readonly IList<Order> Orders = _orderService.GetAll();
		private static readonly IList<OrderLineItem> OrderLineItems = _orderService.GetAllLineItems();
		private static readonly IOrderService _orderService = new OrderService();

		#region Utilities
		private static PurchaseInvoice ToPurchaseInvoice(Order order)
		{
			return new PurchaseInvoice {
				//CardCode = order.CustID,
				//CardName = CommonUtil.ToTitleCase(order.CustName),
				//CardType = CommonUtil.DetermineBpType(order.CustID),
				//FederalTaxID = order.CustReseller ?? "",
				//Phone1 = order.CustPhone1 ?? "",
				//Phone2 = order.CustPhone2 ?? "",
				//EmailAddress = CommonUtil.IsValidEmail(order.CustContact) ? CommonUtil.FormatEmail(order.CustContact) : "",
				//Address = CommonUtil.ToTitleCase($"{order.CustAddress1 ?? ""} {order.CustAddress2 ?? ""}".Trim()),
				//MailAddress = CommonUtil.ToTitleCase($"{order.CustAddress1 ?? ""} {order.CustAddress2 ?? ""}".Trim()),
				//ZipCode = order.CustZip ?? "",
				//MailZipCode = order.CustZip ?? "",
				//City = CommonUtil.ToTitleCase(order.CustCity ?? ""),
				//MailCity = CommonUtil.ToTitleCase(order.CustCity ?? ""),
				//BillToState = order.CustState ?? "",
				//ShipToState = order.CustState ?? "",
				//Notes = BuildNotes(order),
			};
		}
		#endregion

		public static async Task CreatePurchaseInvoicesAsync()
		{
			var createList = (from l in OrderLineItems // left join
							  join o in Orders on l.OrderID equals o.OrderID
							  from p in PurchaseInvoices.Where(x => x.DocEntry == o.OrderID).DefaultIfEmpty()
							  where p == null || p.DocEntry == null
							  select o).ToList();

			PurchaseInvoice pi;
			var folder = $"C:/Logs/Sap.Tests/{DateTime.Now:yyyy MM}/";
			Directory.CreateDirectory(folder);
			var log = "DocEntry,DocNum,DocType\r\n";
			var _purchaseInvoiceService = new Api.Services.PurchaseInvoiceService(ServiceLayer);

			foreach (var v in createList) {
				//pi = ToPurchaseInvoice(v);
				//log = $"{log}\"{v.OrderID}\",\"{pi.DocEntry}\",\"{v.OrderID}\",\"{pi.DocNum}\",\"{v.CustReseller}\",\"{pi.DocType}\"\r\n";

				//var x = await _purchaseInvoiceService.TryCreate(pi);

				//if (x.Item1 == null)
				//	Common.nLog.Error(x.errorMsg);
			}

			File.WriteAllText($"{folder}CreatePurchaseInvoicesAsync {DateTime.Now:dd HHmm ssff}.csv", log);
		}
	}
}