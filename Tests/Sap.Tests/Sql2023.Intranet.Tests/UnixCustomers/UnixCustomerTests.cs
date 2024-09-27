using Sap.Tests;
using Sql2023.Intranet.Services.UnixCustomers;

namespace Sql2023.Intranet.Tests.UnixCustomers
{
	public class UnixCustomerServiceTests
	{
		private bool OutputToCsv = false; // true/false
		private readonly IUnixCustomerService _service = new UnixCustomerService();

		[Fact]
		public void Test_GetAll()
		{
			var list = _service.GetAll();
			list.ShouldNotBeNull();
			list.Count.ShouldNotEqual(0);

			if (OutputToCsv) {
				var log = "UnixCustID,CustID,CustName,CustContact,CustAddress1,CustAddress2,CustCity,CustState,CustZip,CustTaxCode,CustPhone1,CustPhone2,CustReseller,CustTerms,GM_AccountNo\r\n";

				foreach (var v in list)
					log = $"{log}\"{v.UnixCustID}\",\"{v.CustID}\",\"{v.CustName}\",\"{v.CustContact}\",\"{v.CustAddress1}\",\"{v.CustAddress2}\",\"{v.CustCity}\",\"{v.CustState}\",\"{v.CustZip}\",\"{v.CustTaxCode}\",\"{v.CustPhone1}\",\"{v.CustPhone2}\",\"{v.CustReseller}\",\"{v.CustTerms}\",\"{v.GM_AccountNo}\"{Environment.NewLine}";

				var folder = $"C:/Logs/Sap.Tests/{DateTime.Now:yyyy MM}/";
				Directory.CreateDirectory(folder);
				File.WriteAllText($"{folder}UnixCustomerServiceTests.Test_GetAll {DateTime.Now:dd HHmm ssff}.csv", log);
			}
		}
	}
}