using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.PurchaseQuotations
{
	/// <summary>
	/// PurchaseQuotation service interface
	/// </summary>
	public interface IPurchaseQuotationService
	{
		/// <summary>
		/// Inserts a <see cref="PurchaseQuotation"/>.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseQuotation"/>.</param>
		void Insert(PurchaseQuotation x);
		/// <summary>
		/// Truncates the <see cref="PurchaseQuotation"/> table.
		/// </summary>
		void TruncateTable();
	}
}