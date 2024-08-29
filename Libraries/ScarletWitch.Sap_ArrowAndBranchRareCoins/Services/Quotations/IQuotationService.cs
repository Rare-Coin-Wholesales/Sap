using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.Quotations
{
	/// <summary>
	/// Quotation service interface
	/// </summary>
	public interface IQuotationService
	{
		/// <summary>
		/// Inserts a <see cref="Quotation"/>.
		/// </summary>
		/// <param name="x">The <see cref="Quotation"/>.</param>
		void Insert(Quotation x);
		/// <summary>
		/// Truncates the <see cref="Quotation"/> table.
		/// </summary>
		void TruncateTable();
	}
}