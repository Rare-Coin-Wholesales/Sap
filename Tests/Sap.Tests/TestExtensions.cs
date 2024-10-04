namespace Sap.Tests
{
	public static class TestExtensions
	{
		public static void ShouldBeEmpty<T>(this IEnumerable<T> actual)
		{
			Assert.Empty(actual);
		}

		public static void ShouldNotBeEmpty<T>(this IEnumerable<T> actual)
		{
			Assert.NotEmpty(actual);
		}

		public static void ShouldBeFalse(this bool source)
		{
			Assert.False(source);
		}

		public static void ShouldBeTrue(this bool source)
		{
			Assert.True(source);
		}

		public static void ShouldBeNull(this object actual)
		{
			Assert.Null(actual);
		}

		public static void ShouldNotBeNull(this object actual)
		{
			Assert.NotNull(actual);
		}

		public static void ShouldBeTheSameAs(this object actual, object expected)
		{
			Assert.Same(expected, actual);
		}

		public static void ShouldNotBeTheSameAs(this object actual, object expected)
		{
			Assert.NotSame(expected, actual);
		}

		public static T ShouldEqual<T>(this T actual, object expected)
		{
			Assert.Equal(expected, actual);
			return actual;
		}

		public static T ShouldNotEqual<T>(this T actual, object expected)
		{
			Assert.NotEqual(expected, actual);
			return actual;
		}

		public static T ShouldNotBeNull<T>(this T obj)
		{
			Assert.NotNull(obj);
			return obj;
		}
	}
}