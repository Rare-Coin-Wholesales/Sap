using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.FAAccountDeterminations
{
	/// <summary>
	/// FAAccountDetermination service interface
	/// </summary>
	public interface IFAAccountDeterminationService
	{
		/// <summary>
		/// Inserts a <see cref="FAAccountDetermination"/>.
		/// </summary>
		/// <param name="x">The <see cref="FAAccountDetermination"/>.</param>
		void Insert(FAAccountDetermination x);
		/// <summary>
		/// Truncates the <see cref="FAAccountDetermination"/> table.
		/// </summary>
		void TruncateTable();
	}
}