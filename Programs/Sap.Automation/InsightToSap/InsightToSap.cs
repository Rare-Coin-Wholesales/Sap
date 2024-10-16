using System.Threading.Tasks;
using Sap.Api;
using Sap.Api.Domain.BusinessPartners;
using Sap.Api.Domain.PurchaseInvoices;
using Sap.Automation.Logging;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		private const string TEST_COMPANY_DB = "A21384_RCW_T01";
		private static readonly ServiceLayer _rcwServiceLayer = new ServiceLayer(Common.BaseUrl, Common.Rcw_CompanyDb, Common.Username, Common.Rcw_Password);
		private static readonly ServiceLayer _testServiceLayer = new ServiceLayer(Common.BaseUrl, TEST_COMPANY_DB, Common.Username, Common.Rcw_Password);
		public static DefaultLogger defaultLogger = new DefaultLogger();

		public static async Task ProcessAsync()
		{
			_testServiceLayer.AddErrorLogs();
			//BusinessPartners = await ServiceLayer.Request(BusinessPartnerRequest.ACTION).GetAllAsync<BusinessPartner>();
			//PurchaseInvoices = await ServiceLayer.Request(PurchaseInvoiceRequest.ACTION).GetAllAsync<PurchaseInvoice>();
			//UpdateBusinessPartners();
			await CreateBusinessPartnersAsync();
		}
	}
}