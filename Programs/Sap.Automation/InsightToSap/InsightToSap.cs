using System.Threading.Tasks;

namespace Sap.Automation
{
	public static partial class InsightToSap
	{
		private const string DOCUMENT_SERVICE = "dDocument_Service";
		private const string TAX_EXEMPT = "EX";

		public static async Task ProcessAsync()
		{
			Common.RcwServiceLayer.AddErrorLogs();
			await CreateMissingCustomers();
			await CreateMissingVendors();
			//await CreateMissingInvoices();
			//await CreateMissingPurchaseInvoices();
		}
	}
}