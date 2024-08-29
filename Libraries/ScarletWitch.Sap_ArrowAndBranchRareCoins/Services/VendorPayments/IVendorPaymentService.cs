using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.VendorPayments
{
	/// <summary>
	/// VendorPayment service interface
	/// </summary>
	public interface IVendorPaymentService
	{
		/// <summary>
		/// Inserts a <see cref="PaymentCheck"/>.
		/// </summary>
		/// <param name="x">The <see cref="PaymentCheck"/>.</param>
		void Insert(PaymentCheck x);
		/// <summary>
		/// Inserts a <see cref="PaymentInvoice"/>.
		/// </summary>
		/// <param name="x">The <see cref="PaymentInvoice"/>.</param>
		void Insert(PaymentInvoice x);
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