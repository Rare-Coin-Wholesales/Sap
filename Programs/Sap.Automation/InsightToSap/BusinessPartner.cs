using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.BusinessPartners;
using Sap.Core;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.UnixCustomers;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		private static IList<BusinessPartner> BusinessPartners;
		private static readonly IList<UnixCustomer> UnixCustomers = _unixCustomerService.GetAll();
		private static readonly IUnixCustomerService _unixCustomerService = new UnixCustomerService();

		#region Utilities
		/// <summary>
		/// Builds Notes based on CustTerms, CustTaxCode, and CustContact.
		/// </summary>
		/// <param name="customer">The <see cref="UnixCustomer"/> to build notes from.</param>
		/// <returns>The notes.</returns>
		private static string BuildNotes(UnixCustomer customer)
		{
			if (customer == null || String.IsNullOrWhiteSpace(customer.CustID))
				return string.Empty;

			var temp = "";

			if (!String.IsNullOrWhiteSpace(customer.CustTerms))
				temp = $"{temp}Terms: {customer.CustTerms}. ";
			if (!String.IsNullOrWhiteSpace(customer.CustTaxCode))
				temp = $"{temp}TaxCode: {customer.CustTaxCode}. ";
			if (!String.IsNullOrWhiteSpace(customer.CustContact) && !CommonUtil.IsValidEmail(customer.CustContact))
				temp = $"{temp}Contact: {CommonUtil.ToTitleCase(customer.CustContact)}";

			return temp.Trim();
		}

		private static BusinessPartner ToBusinessPartner(UnixCustomer customer)
		{
			return new BusinessPartner {
				CardCode = customer.CustID,
				CardName = CommonUtil.ToTitleCase(customer.CustName),
				CardType = CommonUtil.DetermineBpType(customer.CustID),
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
				Notes = BuildNotes(customer),
			};
		}
		#endregion

		public static async Task CreateBusinessPartnersAsync()
		{
			var createList = (from u in UnixCustomers // left join
							  from b in BusinessPartners.Where(x => x.CardCode == u.CustID).DefaultIfEmpty()
							  where b == null || b.CardCode == null
							  select u).ToList();

			BusinessPartner bp;
			var folder = $"C:/Logs/Sap.Tests/{DateTime.Now:yyyy MM}/";
			Directory.CreateDirectory(folder);
			var log = "CustID,CustName,CardName,CardType,CustReseller,FederalTaxID,CustPhone1,Phone1,CustPhone2,Phone2,CustContact,EmailAddress,CustAddress1,CustAddress2,Address,CustZip,ZipCode,CustCity,City,CustState,BillToState,CustTerms,CustTaxCode,Notes\r\n";
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);

			foreach (var v in createList.Take(10)) {
				bp = ToBusinessPartner(v);
				log = $"{log}\"{v.CustID}\",\"{v.CustName}\",\"{bp.CardName}\",\"{bp.CardType}\",\"{v.CustReseller}\",\"{bp.FederalTaxID}\",\"{v.CustPhone1}\",\"{bp.Phone1}\",\"{v.CustPhone2}\",\"{bp.Phone2}\",\"{v.CustContact}\",\"{bp.EmailAddress}\",\"{v.CustAddress1}\",\"{v.CustAddress2}\",\"{bp.Address}\",\"{v.CustZip}\",\"{bp.ZipCode}\",\"{v.CustCity}\",\"{bp.City}\",\"{v.CustState}\",\"{bp.BillToState}\",\"{v.CustTerms}\",\"{v.CustTaxCode}\",\"{bp.Notes}\"\r\n";

				var x = await _businessPartnerService.TryCreate(bp);

				if (x.Item1 == null)
					Common.nLog.Error(x.errorMsg);
			}

			File.WriteAllText($"{folder}CreateBusinessPartnersAsync {DateTime.Now:dd HHmm ssff}.csv", log);
		}

		public static void UpdateBusinessPartners()
		{
			var updateList = (from b in BusinessPartners
							  join u in UnixCustomers on b.CardCode equals u.CustID
							  select new {UnixCustomers = u, BusinessPartners = b}).ToList();

			var log = "UnixCustID,CustID,CustName,CustContact,CustAddress1,CustAddress2,CustCity,CustState,CustZip,CustTaxCode,CustPhone1,CustPhone2,CustReseller,CustTerms,GM_AccountNo\r\n";

			foreach (var v in updateList)
				log = $"{log}\"{v.UnixCustomers.UnixCustID}\",\"{v.UnixCustomers.CustID}\",\"{v.UnixCustomers.CustName}\",\"{v.UnixCustomers.CustContact}\",\"{v.UnixCustomers.CustAddress1}\",\"{v.UnixCustomers.CustAddress2}\",\"{v.UnixCustomers.CustCity}\",\"{v.UnixCustomers.CustState}\",\"{v.UnixCustomers.CustZip}\",\"{v.UnixCustomers.CustTaxCode}\",\"{v.UnixCustomers.CustPhone1}\",\"{v.UnixCustomers.CustPhone2}\",\"{v.UnixCustomers.CustReseller}\",\"{v.UnixCustomers.CustTerms}\",\"{v.UnixCustomers.GM_AccountNo}\"{Environment.NewLine}";

			var folder = $"C:/Logs/Sap.Tests/{DateTime.Now:yyyy MM}/";
			Directory.CreateDirectory(folder);
			File.WriteAllText($"{folder}UpdateList {DateTime.Now:dd HHmm ssff}.csv", log);
		}
	}
}