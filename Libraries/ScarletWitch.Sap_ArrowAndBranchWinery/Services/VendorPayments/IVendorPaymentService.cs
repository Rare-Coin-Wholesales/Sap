using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.VendorPayments
{
	/// <summary>
	/// VendorPayment service interface
	/// </summary>
	public interface IVendorPaymentService
	{
		/// <summary>
		/// Inserts a <see cref="VendorPayment"/>.
		/// </summary>
		/// <param name="x">The <see cref="VendorPayment"/>.</param>
		void Insert(VendorPayment x);
		/// <summary>
		/// Truncates the <see cref="VendorPayment"/> table.
		/// </summary>
		void TruncateTable();
	}
}