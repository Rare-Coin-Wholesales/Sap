using System.Collections.Generic;
using System.Data;
using System.Linq;
using Web202209.SAP_RareCoinWholesalers.Domain;

namespace Web202209.SAP_RareCoinWholesalers.Services.BusinessPartners
{
	public partial class BusinessPartnerService : BaseService, IBusinessPartnerService
	{
		/// <inheritdoc/>
		public virtual IList<BusinessPartner> GetAll()
		{
			return (from x in _dbContext.BusinessPartners
					select x).ToList();
		}

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