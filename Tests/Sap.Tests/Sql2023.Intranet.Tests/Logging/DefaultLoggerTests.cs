using Sap.Tests;
using Sql2023.Intranet.Domain.Logging;
using Sql2023.Intranet.Services.Logging;

namespace Sql2023.Intranet.Tests.Logging
{
	public class DefaultLoggerTests
	{
		private readonly ILogger _logger = new DefaultLogger();

		[Fact]
		public void Test_Exists()
		{
			Log test;

			#region Test 1
			test = new Log {
				CreatedOnUtc = DateTime.UtcNow,
				ShortMessage = $"Test {DateTime.UtcNow:HH:mm:ss.fff}",
			};

			_logger.Exists(test).ShouldBeFalse();
			#endregion

			#region Test 2
			test = new Log {
				CreatedOnUtc = DateTime.Parse("2024-09-19 20:49:59.683"),
				ShortMessage = "AsdF",
			};

			_logger.Exists(test).ShouldBeTrue();
			#endregion

			#region Test 3
			test = new Log {
				CreatedOnUtc = DateTime.Parse("2024-09-19 20:49:59.693"),
				ShortMessage = "AsdF",
			};

			_logger.Exists(test).ShouldBeFalse();
			#endregion
		}

		[Fact]
		public void Test_GetCount()
		{
			Log test;

			#region Test 1
			test = new Log {
				CreatedOnUtc = DateTime.UtcNow,
				ShortMessage = $"Test {DateTime.UtcNow:HH:mm:ss.fff}",
			};

			_logger.GetCount(test).ShouldEqual(0);
			#endregion

			#region Test 2
			//test = new Log {
			//	CreatedOnUtc = DateTime.UtcNow,
			//	ShortMessage = "Sep 19 2024  2:49PM",
			//};

			//_logger.GetCount(test).ShouldEqual(3);
			#endregion
		}

		[Fact]
		public void Test_Insert()
		{
			Log test;
			var now = DateTime.Now;

			#region Test 1
			test = new Log {
				CreatedOnUtc = DateTime.UtcNow,
				ShortMessage = $"Test {now:HH:mm:ss.fff}",
			};

			_logger.Insert(test).ShouldNotBeNull();
			#endregion

			#region Test 2
			//test = new Log {
			//	CreatedOnUtc = DateTime.UtcNow,
			//	ShortMessage = "Sep 19 2024  2:49PM",
			//};

			//_logger.Insert(test).ShouldNotBeNull();
			#endregion
		}
	}
}