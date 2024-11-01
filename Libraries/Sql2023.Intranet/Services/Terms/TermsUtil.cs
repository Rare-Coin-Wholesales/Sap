namespace Sql2023.Intranet.Services.Terms
{
	public static partial class TermsUtil
	{
		/// <summary>
		/// Gets how many days to add, based on the Terms Code.
		/// </summary>
		/// <param name="termCode">The Terms Code.</param>
		/// <returns>The number of days to add.</returns>
		public static int GetAddDays(string termCode)
		{
			if (string.IsNullOrWhiteSpace(termCode))
				return 0;

			termCode = termCode.Trim().ToUpperInvariant();

			switch (termCode) {
				#region case "3 WEEKS":
				case "3 WEEKS":
					return 21;
				#endregion
				#region case "30 DAYS", "30-60 DAYS", "30-60-90":
				case "30 DAYS":
				case "30-60 DAYS":
				case "30-60-90":
					return 30;
				#endregion
				#region case "45 DAYS":
				case "45 DAYS":
					return 45;
				#endregion
				#region case "60 DAYS":
				case "60 DAYS":
					return 60;
				#endregion
				#region case "90 DAYS":
				case "90 DAYS":
					return 90;
				#endregion
				#region case "CCE TRADE NET 7 DAYS", "MEMO ONE WEEK":
				case "CCE TRADE NET 7 DAYS":
				case "MEMO ONE WEEK":
					return 7;
				#endregion
				#region case "MEMO OVERNIGHT":
				case "MEMO OVERNIGHT":
					return 1;
				#endregion
				#region case "MEMO THREE DAYS":
				case "MEMO THREE DAYS":
					return 3;
				#endregion
				#region case "ONE WEEK":
				case "ONE WEEK":
					return 7;
				#endregion
				#region case "TWO WEEKS":
				case "TWO WEEKS":
					return 14;
				#endregion
				default:
					return 0;
			}
		}
	}
}