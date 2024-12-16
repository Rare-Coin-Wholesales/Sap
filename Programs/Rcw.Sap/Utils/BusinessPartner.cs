using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.BusinessPartners;
using Sap.Core;
using ScarletWitch.Sap_RareCoinWholesalers.Services.BusinessPartners;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.UnixCustomers;

namespace Rcw.Sap
{
	partial class Program
	{
		private static readonly IBusinessPartnerService _businessPartnerService = new BusinessPartnerService();
		private static readonly IUnixCustomerService _unixCustomerService = new UnixCustomerService();

		private static BusinessPartner ToCustomer(UnixCustomer customer)
		{
			return new BusinessPartner {
				CardCode = $"{customer.CustID}",
				CardName = CommonUtil.ToTitleCase(customer.CustName),
				CardType = "C",
				FederalTaxID = customer.CustReseller ?? "",
				Phone1 = customer.CustPhone1 ?? "",
				Phone2 = customer.CustPhone2 ?? "",
				EmailAddress = CommonUtil.IsValidEmail(customer.CustContact) ? CommonUtil.FormatEmail(customer.CustContact) : "",
				Address = CommonUtil.ToTitleCase($"{customer.CustAddress1 ?? ""} {customer.CustAddress2 ?? ""}".Trim()),
				MailAddress = CommonUtil.ToTitleCase($"{customer.CustAddress1 ?? ""} {customer.CustAddress2 ?? ""}".Trim()),
				ZipCode = customer.CustZip ?? "",
				MailZipCode = customer.CustZip ?? "",
				City = CommonUtil.ToTitleCase(customer.CustCity ?? ""),
				MailCity = CommonUtil.ToTitleCase(customer.CustCity ?? ""),
				BillToState = customer.CustState ?? "",
				ShipToState = customer.CustState ?? "",
				Notes = customer.BuildNotes(),
			};
		}

		private static BusinessPartner ToSupplier(UnixCustomer customer)
		{
			return new BusinessPartner {
				CardCode = $"{customer.VendorId}",
				CardName = CommonUtil.ToTitleCase(customer.CustName),
				CardType = "S",
				FederalTaxID = customer.CustReseller ?? "",
				Phone1 = customer.CustPhone1 ?? "",
				Phone2 = customer.CustPhone2 ?? "",
				EmailAddress = CommonUtil.IsValidEmail(customer.CustContact) ? CommonUtil.FormatEmail(customer.CustContact) : "",
				Address = CommonUtil.ToTitleCase($"{customer.CustAddress1 ?? ""} {customer.CustAddress2 ?? ""}".Trim()),
				MailAddress = CommonUtil.ToTitleCase($"{customer.CustAddress1 ?? ""} {customer.CustAddress2 ?? ""}".Trim()),
				ZipCode = customer.CustZip ?? "",
				MailZipCode = customer.CustZip ?? "",
				City = CommonUtil.ToTitleCase(customer.CustCity ?? ""),
				MailCity = CommonUtil.ToTitleCase(customer.CustCity ?? ""),
				BillToState = customer.CustState ?? "",
				ShipToState = customer.CustState ?? "",
				Notes = customer.BuildNotes(),
			};
		}

		public static async Task CreateMissingApInvoiceVendors()
		{
			var vendors = ApInvoices;

			if (vendors == null || vendors.Count == 0)
				return;

			var unixCustomers = _unixCustomerService.GetAll();
			unixCustomers = (from uc in unixCustomers
							 join v in vendors on uc.CustID equals v.VendorId
							 select uc).Distinct().ToList();

			var businessPartners = _businessPartnerService.GetAll();
			List<UnixCustomer> missing;

			#region Customers
			missing = (from x in unixCustomers // left join
					   from y in businessPartners.Where(y => y.CardCode == x.CustID).DefaultIfEmpty()
					   where y == null || y.CardCode == null
					   select x).ToList();

			if (missing != null && missing.Count > 0)
				_exportManager.ExportToCsv(missing);

			foreach (var bp in missing) {
				var created = await _serviceLayer.TryCreateAsync(ToCustomer(bp));

				if (created.Item1 == null) { // IndexOf() returns -1 if the string is not found
					if (created.ErrorMsg.IndexOf("already assigned to a business partner", StringComparison.OrdinalIgnoreCase) < 0)
						nLog.Error(created.ErrorMsg);
				}
			}
			#endregion

			#region Vendors
			missing = (from x in unixCustomers // left join
					   from y in businessPartners.Where(y => y.CardCode == x.VendorId).DefaultIfEmpty()
					   where y == null || y.CardCode == null
					   select x).ToList();

			if (missing != null && missing.Count > 0)
				_exportManager.ExportToCsv(missing);

			foreach (var bp in missing) {
				var created = await _serviceLayer.TryCreateAsync(ToSupplier(bp));

				if (created.Item1 == null) { // IndexOf() returns -1 if the string is not found
					if (created.ErrorMsg.IndexOf("already assigned to a business partner", StringComparison.OrdinalIgnoreCase) < 0)
						nLog.Error(created.ErrorMsg);
				}
			}
			#endregion
		}

		public static async Task CreateMissingArInvoiceCustomers()
		{
			var customers = ArInvoices.Where(x => x.Customer != null && x.Customer != "").ToList();

			if (customers == null || customers.Count == 0)
				return;

			var unixCustomers = _unixCustomerService.GetAll();
			unixCustomers = (from uc in unixCustomers
							 join c in customers on uc.CustID equals c.Customer
							 select uc).Distinct().ToList();

			var businessPartners = _businessPartnerService.GetAll();
			List<UnixCustomer> missing;

			#region Customers
			missing = (from x in unixCustomers // left join
					   from y in businessPartners.Where(y => y.CardCode == x.CustID).DefaultIfEmpty()
					   where y == null || y.CardCode == null
					   select x).ToList();

			if (missing != null && missing.Count > 0)
				_exportManager.ExportToCsv(missing);

			foreach (var bp in missing) {
				var created = await _serviceLayer.TryCreateAsync(ToCustomer(bp));

				if (created.Item1 == null) { // IndexOf() returns -1 if the string is not found
					if (created.ErrorMsg.IndexOf("already assigned to a business partner", StringComparison.OrdinalIgnoreCase) < 0)
						nLog.Error(created.ErrorMsg);
				}
			}
			#endregion

			#region Vendors
			missing = (from x in unixCustomers // left join
					   from y in businessPartners.Where(y => y.CardCode == x.VendorId).DefaultIfEmpty()
					   where y == null || y.CardCode == null
					   select x).ToList();

			if (missing != null && missing.Count > 0)
				_exportManager.ExportToCsv(missing);

			foreach (var bp in missing) {
				var created = await _serviceLayer.TryCreateAsync(ToSupplier(bp));

				if (created.Item1 == null) { // IndexOf() returns -1 if the string is not found
					if (created.ErrorMsg.IndexOf("already assigned to a business partner", StringComparison.OrdinalIgnoreCase) < 0)
						nLog.Error(created.ErrorMsg);
				}
			}
			#endregion
		}
	}
}