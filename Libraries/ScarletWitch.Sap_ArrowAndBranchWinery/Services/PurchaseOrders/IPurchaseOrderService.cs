using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseOrders
{
	/// <summary>
	/// PurchaseOrder service interface
	/// </summary>
	public interface IPurchaseOrderService
	{
		/// <summary>
		/// Inserts a <see cref="PurchaseOrder"/>.
		/// </summary>
		/// <param name="x">The <see cref="PurchaseOrder"/>.</param>
		void Insert(PurchaseOrder x);
		/// <summary>
		/// Truncates the <see cref="PurchaseOrder"/> table.
		/// </summary>
		void TruncateTable();
	}
}