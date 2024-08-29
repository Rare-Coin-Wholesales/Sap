using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.ChartOfAccounts
{
	/// <summary>
	/// ChartOfAccount service interface
	/// </summary>
	public interface IChartOfAccountService
	{
		/// <summary>
		/// Inserts a <see cref="ChartOfAccount"/>.
		/// </summary>
		/// <param name="x">The <see cref="ChartOfAccount"/>.</param>
		void Insert(ChartOfAccount x);
		/// <summary>
		/// Truncates the <see cref="ChartOfAccount"/> table.
		/// </summary>
		void TruncateTable();
	}
}