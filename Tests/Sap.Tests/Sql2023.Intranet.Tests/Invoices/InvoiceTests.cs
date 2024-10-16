using Sap.Tests;
using Sql2023.Intranet.Services.Export;
using Sql2023.Intranet.Services.Invoices;

namespace Sql2023.Intranet.Tests.Invoices
{
	public class InvoiceServiceTests
	{
		private static readonly IExportManager _exportManager = new ExportManager();
		private static readonly IInvoiceService _service = new InvoiceService();

		[Fact]
		public void Test_GetRecentInvoiceCoinIds()
		{

		}
	}
}