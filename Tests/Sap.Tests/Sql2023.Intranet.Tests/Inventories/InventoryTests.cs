using Sap.Tests;
using Sql2023.Intranet.Services.Inventories;

namespace Sql2023.Intranet.Tests.Inventories
{
	public class InventoryServiceTests
	{
		private static readonly IInventoryService _service = new InventoryService();

		[Fact]
		public void Test_GetDescription()
		{
			string result;

			result = _service.GetDescription(1003);
			result.ShouldEqual("1888 LIBERTY 5C");

			result = _service.GetDescription(1004);
			result.ShouldEqual("1893 LIBERTY 5C");

			result = _service.GetDescription(1006);
			result.ShouldEqual("1866 SHIELD 5C. J-508");

			result = _service.GetDescription(1010);
			result.ShouldEqual("1883 SHIELD 5C. SHIELD");
		}
	}
}