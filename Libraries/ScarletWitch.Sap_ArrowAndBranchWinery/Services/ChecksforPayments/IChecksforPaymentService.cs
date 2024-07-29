using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.ChecksforPayments
{
	/// <summary>
	/// ChecksforPayment service interface
	/// </summary>
	public interface IChecksforPaymentService
	{
		/// <summary>
		/// Inserts a <see cref="ChecksforPayment"/>.
		/// </summary>
		/// <param name="x">The <see cref="ChecksforPayment"/>.</param>
		void Insert(ChecksforPayment x);
		/// <summary>
		/// Truncates the <see cref="ChecksforPayment"/> table.
		/// </summary>
		void TruncateTable();
	}
}