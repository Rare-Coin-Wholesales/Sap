using B1SLayer;
using Sap.Api;
using Sap.Api.Domain.BusinessPartners;
using Sap.ApiToScarRcwMapper;
using Sap.Core;
using Sap.Services.Security;
using Sap.Tests;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Domain.Logging;
using Sql2023.Intranet.Services.Export;
using Sql2023.Intranet.Services.Logging;
using Sql2023.Intranet.Services.UnixCustomers;

namespace Sap.Rcw.IntegrationTests
{
	public partial class BusinessPartnerIntegrationTests
	{
		private const string TEST_COMPANY_DB = "A21384_RCW_T01";
		private static readonly IExportManager _exportManager = new ExportManager();
		private static readonly IUnixCustomerService _unixCustomerService = new UnixCustomerService();
		private static readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly ILogger _logger = new DefaultLogger();
		private static readonly Mapper _mapper = new();
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");

		private static readonly ServiceLayer _testServiceLayer = new ServiceLayer(BaseUrl, TEST_COMPANY_DB, Username, Password);

		#region Utilities
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
				CardCode = $"V{customer.CustID}",
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
		#endregion

		/// <summary>
		/// Invoice => [Sales] Invoice (A/R).
		/// </summary>
		[Fact]
		public async void Test_CreateMissingInvoiceUnixCustomers()
		{
			_testServiceLayer.AddErrorLogs();
			var invoiceUnixCustomers = _unixCustomerService.GetRecent();

			if (invoiceUnixCustomers == null || invoiceUnixCustomers.Count == 0)
				return;

			invoiceUnixCustomers = invoiceUnixCustomers.OrderBy(x => x.CustID).ToList();
			_exportManager.ExportToCsv(invoiceUnixCustomers);
			BusinessPartner bp;

			foreach (var cust in invoiceUnixCustomers) {
				bp = ToCustomer(cust);
				var created = await _testServiceLayer.TryCreateAsync(bp);

				if (created.Item1 == null)
					_logger.Insert(LogLevel.Warning, created.Item2);
			}
		}

		/// <summary>
		/// Order => PurchaseInvoice (A/P).
		/// </summary>
		[Fact]
		public async void Test_CreateMissingOrderUnixCustomers()
		{
			_testServiceLayer.AddErrorLogs();
			var orderUnixCustomers = _unixCustomerService.GetRecent();

			if (orderUnixCustomers == null || orderUnixCustomers.Count == 0)
				return;

			orderUnixCustomers = orderUnixCustomers.OrderBy(x => x.CustID).ToList();
			_exportManager.ExportToCsv(orderUnixCustomers);
			BusinessPartner bp;

			foreach (var cust in orderUnixCustomers) {
				bp = ToCustomer(cust);
				var created = await _testServiceLayer.TryCreateAsync(bp);

				if (created.Item1 == null)
					_logger.Insert(LogLevel.Warning, created.Item2);
			}
		}

		[Fact]
		public async Task Test_GetAllBusinessPartnersAsync()
		{
			_testServiceLayer.AddErrorLogs();
			var all = await _testServiceLayer.GetAllBusinessPartnersAsync();
			all.ShouldNotBeNull();
			_testServiceLayer.LogToCsv(all);
		}
	}
}