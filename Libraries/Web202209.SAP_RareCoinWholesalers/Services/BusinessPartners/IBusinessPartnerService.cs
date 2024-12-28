using System.Collections.Generic;
using System.Data;
using Web202209.SAP_RareCoinWholesalers.Domain;

namespace Web202209.SAP_RareCoinWholesalers.Services.BusinessPartners
{
	/// <summary>
	/// BusinessPartner service interface
	/// </summary>
	public interface IBusinessPartnerService
	{
		/// <summary>
		/// Gets all BusinessPartners.
		/// </summary>
		IList<BusinessPartner> GetAll();
		/// <summary>
		/// Transfers [BusinessPartner] to [dbo].
		/// </summary>
		void TransferToDbo();
		/// <summary>
		/// Truncates the [Import].[BusinessPartner] table.
		/// </summary>
		void TruncateTable();
		/// <summary>
		/// Tries to perform <see cref="SqlBulkCopy"/> to fast-import a <see cref="DataTable"/> into a SQL table.
		/// </summary>
		/// <param name="dt">The <see cref="DataTable"/> to import.</param>
		/// <param name="destinationTableName">The destination table name to insert into.</param>
		/// <param name="errorMessage">The output error message if any. Otherwise, empty string.</param>
		/// <returns>True if inserted successfully. False otherwise.</returns>
		bool TryBulkCopy(DataTable dt, out string errorMessage);
	}
}