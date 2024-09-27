namespace Sap.Tests
{
	public static class TestExtensions
	{
		/// <summary>
		/// Asserts Null.
		/// </summary>
		/// <param name="actual"></param>
		public static void ShouldBeNull(this object actual)
		{
			Assert.Null(actual);
		}

		/// <summary>
		/// Asserts Not Null.
		/// </summary>
		/// <param name="actual"></param>
		public static void ShouldNotBeNull(this object actual)
		{
			Assert.NotNull(actual);
		}

		/// <summary>
		/// Asserts Same.
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		public static void ShouldBeTheSameAs(this object actual, object expected)
		{
			Assert.Same(expected, actual);
		}

		/// <summary>
		/// Asserts Not Same.
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		public static void ShouldBeNotBeTheSameAs(this object actual, object expected)
		{
			Assert.NotSame(expected, actual);
		}

		/// <summary>
		/// Asserts True.
		/// </summary>
		/// <param name="source"></param>
		public static void ShouldBeTrue(this bool source)
		{
			Assert.True(source);
		}

		/// <summary>
		/// Asserts False.
		/// </summary>
		/// <param name="source"></param>
		public static void ShouldBeFalse(this bool source)
		{
			Assert.False(source);
		}

		///<summary>
		/// Asserts that two objects are equal.
		///</summary>
		///<param name="actual"></param>
		///<param name="expected"></param>
		///<param name="message"></param>
		///<exception cref="AssertionException"></exception>
		public static void ShouldEqual(this object actual, object expected)
		{
			Assert.Equal(expected, actual);
		}

		///<summary>
		/// Asserts that two objects are not equal.
		///</summary>
		///<param name="actual"></param>
		///<param name="expected"></param>
		///<param name="message"></param>
		///<exception cref="AssertionException"></exception>
		public static void ShouldNotEqual(this object actual, object expected)
		{
			Assert.NotEqual(expected, actual);
		}
	}
}