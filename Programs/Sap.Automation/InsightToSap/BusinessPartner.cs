using System.Linq;
using System.Threading.Tasks;
using Sap.Api.Domain.BusinessPartners;
using Sap.Core;
using ScarletWitch.Sap_RareCoinWholesalers.Services.BusinessPartners;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.UnixCustomers;

namespace Sap.Automation
{
	public static partial class InsightToSap
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

		public static async Task CreateMissingCustomers()
		{
			AddErrorLogs();
			var unixCustomers = _unixCustomerService.GetRecent();

			if (unixCustomers == null || unixCustomers.Count == 0)
				return;

			_exportManager.ExportToCsv(unixCustomers);
			var businessPartners = _businessPartnerService.GetAll();
			var missing = (from x in unixCustomers // left join
						   from y in businessPartners.Where(y => y.CardCode == x.CustID).DefaultIfEmpty()
						   where y == null || y.CardCode == null
						   select x).ToList();

			foreach (var bp in missing) {
				var created = await Common.RcwServiceLayer.TryCreateAsync(ToCustomer(bp));

				if (created.Item1 == null)
					Common.nLog.Warn(created.Item2);
			}
		}

		public static async Task CreateMissingVendors()
		{
			AddErrorLogs();
			var unixCustomers = _unixCustomerService.GetRecent();

			if (unixCustomers == null || unixCustomers.Count == 0)
				return;

			_exportManager.ExportToCsv(unixCustomers);
			var businessPartners = _businessPartnerService.GetAll();
			var missing = (from x in unixCustomers // left join
						   from y in businessPartners.Where(y => y.CardCode == x.VendorId).DefaultIfEmpty()
						   where y == null || y.CardCode == null
						   select x).ToList();

			foreach (var bp in missing) {
				var created = await Common.RcwServiceLayer.TryCreateAsync(ToSupplier(bp));

				if (created.Item1 == null)
					Common.nLog.Warn(created.Item2);
			}
		}
	}
}