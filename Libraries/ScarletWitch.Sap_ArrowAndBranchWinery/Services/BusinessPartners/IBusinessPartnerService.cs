using ScarletWitch.Sap_ArrowAndBranchWinery.Domain;

namespace ScarletWitch.Sap_ArrowAndBranchWinery.Services.BusinessPartners
{
	/// <summary>
	/// BusinessPartner service interface
	/// </summary>
	public interface IBusinessPartnerService
	{
		/// <summary>
		/// Inserts a <see cref="BPAddress"/>.
		/// </summary>
		/// <param name="x">The <see cref="BPAddress"/>.</param>
		void Insert(BPAddress x);
		/// <summary>
		/// Inserts a <see cref="BPIntrastatExtension"/>.
		/// </summary>
		/// <param name="x">The <see cref="BPIntrastatExtension"/>.</param>
		void Insert(BPIntrastatExtension x);
		/// <summary>
		/// Inserts a <see cref="BPPaymentMethod"/>.
		/// </summary>
		/// <param name="x">The <see cref="BPPaymentMethod"/>.</param>
		void Insert(BPPaymentMethod x);
		/// <summary>
		/// Inserts a <see cref="BusinessPartner"/>.
		/// </summary>
		/// <param name="x">The <see cref="BusinessPartner"/>.</param>
		/// <summary>
		void Insert(BusinessPartner x);
		/// <summary>
		/// Inserts a <see cref="ContactEmployee"/>.
		/// </summary>
		/// <param name="x">The <see cref="ContactEmployee"/>.</param>
		void Insert(ContactEmployee x);
		/// <summary>
		/// Truncates the <see cref="BusinessPartner"/> table.
		/// </summary>
		void TruncateTable();
	}
}