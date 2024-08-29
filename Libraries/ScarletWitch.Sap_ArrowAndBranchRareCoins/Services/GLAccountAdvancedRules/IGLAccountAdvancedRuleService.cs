using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.GLAccountAdvancedRules
{
	/// <summary>
	/// GLAccountAdvancedRule service interface
	/// </summary>
	public interface IGLAccountAdvancedRuleService
	{
		/// <summary>
		/// Inserts a <see cref="GLAccountAdvancedRule"/>.
		/// </summary>
		/// <param name="x">The <see cref="GLAccountAdvancedRule"/>.</param>
		void Insert(GLAccountAdvancedRule x);
		/// <summary>
		/// Truncates the <see cref="GLAccountAdvancedRule"/> table.
		/// </summary>
		void TruncateTable();
	}
}