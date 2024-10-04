using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseInvoices;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.Orders;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		private static IList<PurchaseInvoice> PurchaseInvoices;
		private static readonly IList<Order> Orders = _orderService.GetDistinctOrders();
		private static readonly IOrderService _orderService = new OrderService();

		#region Utilities
		private static PurchaseInvoice ToPurchaseInvoice(Order ent)
		{
			return new PurchaseInvoice {
				//CardCode = customer.CustID,
				//CardName = CommonUtil.ToTitleCase(customer.CustName),
				//CardType = _orderService.DetermineBpType(customer.CustID, customer.CustName),
				//FederalTaxID = customer.CustReseller ?? "",
				//Phone1 = customer.CustPhone1 ?? "",
				//Phone2 = customer.CustPhone2 ?? "",
				//EmailAddress = CommonUtil.IsValidEmail(customer.CustContact) ? CommonUtil.FormatEmail(customer.CustContact) : "",
				//Address = CommonUtil.ToTitleCase($"{customer.CustAddress1 ?? ""} {customer.CustAddress2 ?? ""}".Trim()),
				//MailAddress = CommonUtil.ToTitleCase($"{customer.CustAddress1 ?? ""} {customer.CustAddress2 ?? ""}".Trim()),
				//ZipCode = customer.CustZip ?? "",
				//MailZipCode = customer.CustZip ?? "",
				//City = CommonUtil.ToTitleCase(customer.CustCity ?? ""),
				//MailCity = CommonUtil.ToTitleCase(customer.CustCity ?? ""),
				//BillToState = customer.CustState ?? "",
				//ShipToState = customer.CustState ?? "",
				//Notes = customer.BuildNotes(),
			};
		}
		#endregion

		public static async Task CreatePurchaseInvoicesAsync()
		{
			var createList = (from ent in Orders // left join
							  from b in PurchaseInvoices.Where(x => x.DocEntry == ent.OrderID).DefaultIfEmpty()
							  where b == null || b.DocEntry == null
							  select ent).ToList();

			PurchaseInvoice bp;
			var folder = $"C:/Logs/Sap.Tests/{DateTime.Now:yyyy MM}/";
			Directory.CreateDirectory(folder);
			var log = "CustID,CustName,CardName,CardType,CustReseller,FederalTaxID,CustPhone1,Phone1,CustPhone2,Phone2,CustContact,EmailAddress,CustAddress1,CustAddress2,Address,CustZip,ZipCode,CustCity,City,CustState,BillToState,CustTerms,CustTaxCode,Notes\r\n";
			var _purchaseInvoiceService = new Api.Services.PurchaseInvoiceService(ServiceLayer);

			//foreach (var v in createList) {
			//	bp = ToPurchaseInvoice(v);
			//	log = $"{log}\"{v.CustID}\",\"{v.CustName}\",\"{bp.CardName}\",\"{bp.CardType}\",\"{v.CustReseller}\",\"{bp.FederalTaxID}\",\"{v.CustPhone1}\",\"{bp.Phone1}\",\"{v.CustPhone2}\",\"{bp.Phone2}\",\"{v.CustContact}\",\"{bp.EmailAddress}\",\"{v.CustAddress1}\",\"{v.CustAddress2}\",\"{bp.Address}\",\"{v.CustZip}\",\"{bp.ZipCode}\",\"{v.CustCity}\",\"{bp.City}\",\"{v.CustState}\",\"{bp.BillToState}\",\"{v.CustTerms}\",\"{v.CustTaxCode}\",\"{bp.Notes}\"\r\n";

			//	var x = await _purchaseInvoiceService.TryCreate(bp);

			//	if (x.Item1 == null)
			//		Common.nLog.Error(x.errorMsg);
			//}

			File.WriteAllText($"{folder}CreatePurchaseInvoicesAsync {DateTime.Now:dd HHmm ssff}.csv", log);
		}
	}
}