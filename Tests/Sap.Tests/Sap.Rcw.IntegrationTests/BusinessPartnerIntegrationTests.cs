using B1SLayer;
using Sap.Api.Domain.BusinessPartners;
using Sap.ApiToScarRcwMapper;
using Sap.Core;
using Sap.Services.Security;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.Export;
using Sql2023.Intranet.Services.Logging;
using Sql2023.Intranet.Services.UnixCustomers;

namespace Sap.Rcw.IntegrationTests
{
	public partial class BusinessPartnerIntegrationTests
	{
		private const string TEST_COMPANY_DB = "A21384_RCW_T01";
		private static IList<BusinessPartner> BusinessPartners;
		private static IList<UnixCustomer> UnixCustomers;
		private static readonly IExportManager _exportManager = new ExportManager();
		private static readonly IUnixCustomerService _unixCustomerService = new UnixCustomerService();
		private static readonly IEncryptionUtil _encryptionUtil = new EncryptionUtil();
		private static readonly ILogger _logger = new DefaultLogger();
		private static readonly Mapper _mapper = new();
		private static readonly string Rcw_CompanyDb = CommonUtil.GetEnvironmentVariable("SAP_Rcw_CompanyDb");
		private static readonly string BaseUrl = CommonUtil.GetEnvironmentVariable("SAP_BaseUrl");
		private static readonly string Password = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("SAP_Rcw_Password"));
		private static readonly string Username = CommonUtil.GetEnvironmentVariable("SAP_Username");

		private static readonly SLConnection ServiceLayer = new SLConnection(BaseUrl, TEST_COMPANY_DB, Username, Password);
		private readonly ScarletWitch.Sap_RareCoinWholesalers.Services.BusinessPartners.BusinessPartnerService _businessPartnerService = new();

		#region Utilities
		private static BusinessPartner ToBusinessPartner(UnixCustomer customer)
		{
			return new BusinessPartner {
				CardCode = customer.CustID,
				CardName = CommonUtil.ToTitleCase(customer.CustName),
				CardType = _unixCustomerService.DetermineBpType(customer.CustID, customer.CustName),
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

		[Fact]
		public static async Task Test_CreateBusinessPartnersAsync()
		{
			var task = ServiceLayer.Request(BusinessPartnerRequest.ACTION).GetAllAsync<BusinessPartner>();
			UnixCustomers = _unixCustomerService.GetAll();
			await task;
			BusinessPartners = task.Result;

			var createList = (from u in UnixCustomers // left join
							  from b in BusinessPartners.Where(x => x.CardCode == u.CustID).DefaultIfEmpty()
							  where b == null || b.CardCode == null
							  select u).ToList();

			BusinessPartner bp;
			var folder = $"C:/Logs/Sap.Tests/{DateTime.Now:yyyy MM}/";
			Directory.CreateDirectory(folder);
			var log = "CustID,CustName,CardName,CardType,CustReseller,FederalTaxID,CustPhone1,Phone1,CustPhone2,Phone2,CustContact,EmailAddress,CustAddress1,CustAddress2,Address,CustZip,ZipCode,CustCity,City,CustState,BillToState,CustTerms,CustTaxCode,Notes\r\n";
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);

			foreach (var v in createList) {
				bp = ToBusinessPartner(v);
				log = $"{log}\"{v.CustID}\",\"{v.CustName}\",\"{bp.CardName}\",\"{bp.CardType}\",\"{v.CustReseller}\",\"{bp.FederalTaxID}\",\"{v.CustPhone1}\",\"{bp.Phone1}\",\"{v.CustPhone2}\",\"{bp.Phone2}\",\"{v.CustContact}\",\"{bp.EmailAddress}\",\"{v.CustAddress1}\",\"{v.CustAddress2}\",\"{bp.Address}\",\"{v.CustZip}\",\"{bp.ZipCode}\",\"{v.CustCity}\",\"{bp.City}\",\"{v.CustState}\",\"{bp.BillToState}\",\"{v.CustTerms}\",\"{v.CustTaxCode}\",\"{bp.Notes}\"\r\n";

				// Don't actually create
				//var x = await _businessPartnerService.TryCreate(bp);
			}

			_exportManager.WriteToCsvFile(log, "Test_CreateBusinessPartnersAsync");
			Assert.True(true);
		}

		/// <summary>
		/// Invoice => [Sales] Invoice (A/R).
		/// </summary>
		[Fact]
		public async void Test_CreateMissingInvoiceUnixCustomers()
		{
			var invoiceUnixCustomers = _unixCustomerService.GetInvoiceUnixCustomers();

			if (invoiceUnixCustomers == null || invoiceUnixCustomers.Count == 0)
				return;

			invoiceUnixCustomers = invoiceUnixCustomers.OrderBy(x => x.CustID).ToList();
			_exportManager.ExportToCsv(invoiceUnixCustomers);
			BusinessPartner bp;
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);

			foreach (var cust in invoiceUnixCustomers) {
				try {
					bp = ToCustomer(cust);
					var x = await _businessPartnerService.TryCreate(bp);
				}

				#region catch (Exception ex)
				catch (Exception ex) {
					if (ex.InnerException == null)
						_logger.InsertWarning(ex);
					else
						throw;
				}
				#endregion
			}
		}

		/// <summary>
		/// Order => PurchaseInvoice (A/P).
		/// </summary>
		[Fact]
		public async void Test_CreateMissingOrderUnixCustomers()
		{
			var orderUnixCustomers = _unixCustomerService.GetOrderUnixCustomers();

			if (orderUnixCustomers == null || orderUnixCustomers.Count == 0)
				return;

			orderUnixCustomers = orderUnixCustomers.OrderBy(x => x.CustID).ToList();
			_exportManager.ExportToCsv(orderUnixCustomers);
			BusinessPartner bp;
			var _businessPartnerService = new Api.Services.BusinessPartnerService(ServiceLayer);

			foreach (var cust in orderUnixCustomers) {
				try {
					bp = ToSupplier(cust);
					var x = await _businessPartnerService.TryCreate(bp);
				}

				#region catch (Exception ex)
				catch (Exception ex) {
					if (ex.InnerException == null)
						_logger.InsertWarning(ex);
					else
						throw;
				}
				#endregion
			}
		}

		[Fact]
		public async Task Test_GetAllBusinessPartnersAsync()
		{
			var _businessPartnerServiceNew = new Api.Services.BusinessPartnerService(ServiceLayer);
			var list = await _businessPartnerServiceNew.GetAll();

			if (list == null || list.Count == 0)
				Assert.False(false);
			else {
				_businessPartnerService.TruncateTable();

				foreach (var v in list) {
					try {
						_businessPartnerService.Insert(_mapper.ToSql(v));
						Assert.True(true);

						#region Insert BPAddress
						foreach (var line in v.BPAddresses) {
							try {
								_businessPartnerService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
						#endregion

						#region Insert BPPaymentMethod
						foreach (var line in v.BPPaymentMethods) {
							try {
								_businessPartnerService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
						#endregion

						#region Insert ContactEmployee
						foreach (var line in v.ContactEmployees) {
							try {
								_businessPartnerService.Insert(_mapper.ToSql(line));
								Assert.True(true);
							}

							catch {
								Assert.True(false);
							}
						}
						#endregion
					}

					catch {
						Assert.True(false);
					}
				}
			}

			//var log = "DocEntry,DocNum,DocType,CardCode,Comments\r\n";

			//foreach (var v in list)
			//	log = String.Format($"{log}{v.DocEntry},{v.DocNum},{v.DocType},{v.CardCode},{v.Comments}{Environment.NewLine}");

			//var folder = String.Format("C:/Logs/Sap.Tests/{0:yyyy MM}/", DateTime.Now);
			//Directory.CreateDirectory(folder);
			//File.WriteAllText(String.Format("{0}{1:dd HH mmss} Test_GetAllBusinessPartnersAsync.csv", folder, DateTime.Now), log);
		}
	}
}