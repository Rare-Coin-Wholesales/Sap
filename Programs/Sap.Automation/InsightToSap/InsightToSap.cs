using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.BusinessPartners;
using Sap.Api.Domain.PurchaseInvoices;
using Sap.Automation.Logging;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		//private static readonly SLConnection ServiceLayer = new SLConnection(Common.BaseUrl, Common.Rcw_CompanyDb, Common.Username, Common.Rcw_Password);
		private static readonly SLConnection ServiceLayer = new SLConnection(Common.BaseUrl, "A21384_ABRL_T01", Common.Username, Common.Password);
		public static DefaultLogger defaultLogger = new DefaultLogger();

		public static async Task ProcessAsync()
		{
			defaultLogger.AddTraceAndErrorLogs(ServiceLayer);
			BusinessPartners = await ServiceLayer.Request(BusinessPartnerRequest.ACTION).GetAllAsync<BusinessPartner>();
			PurchaseInvoices = await ServiceLayer.Request(PurchaseInvoiceRequest.ACTION).GetAllAsync<PurchaseInvoice>();
			//UpdateBusinessPartners();
			await CreateBusinessPartnersAsync();
		}
	}
}