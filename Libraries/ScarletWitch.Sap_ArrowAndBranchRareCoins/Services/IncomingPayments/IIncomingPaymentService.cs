using ScarletWitch.Sap_ArrowAndBranchRareCoins.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.IncomingPayments
{
	/// <summary>
	/// IncomingPayment service interface
	/// </summary>
	public interface IIncomingPaymentService
	{
		/// <summary>
		/// Inserts a <see cref="IncomingPayment"/>.
		/// </summary>
		/// <param name="x">The <see cref="IncomingPayment"/>.</param>
		void Insert(IncomingPayment x);
		/// <summary>
		/// Truncates the <see cref="IncomingPayment"/> table.
		/// </summary>
		void TruncateTable();
	}
}