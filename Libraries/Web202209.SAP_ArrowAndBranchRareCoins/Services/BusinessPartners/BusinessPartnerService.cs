using System.Data;

namespace Web202209.SAP_ArrowAndBranchRareCoins.Services.BusinessPartners
{
	public partial class BusinessPartnerService : BaseService, IBusinessPartnerService
	{
		/// <inheritdoc/>
		public virtual void TransferToDbo()
		{
			_dbContext.Database.ExecuteSqlCommand("EXEC [Import].[BusinessPartnerTables_TransferToDbo]");
		}

		/// <inheritdoc/>
		public virtual void TruncateTable()
		{
			base.TruncateTable("Import", "BusinessPartner");
		}

		/// <inheritdoc/>
		public virtual bool TryBulkCopy(DataTable dt, out string errorMessage)
		{
			return base.TryBulkCopy(dt, "Import.BusinessPartner", out errorMessage);
		}
	}
}