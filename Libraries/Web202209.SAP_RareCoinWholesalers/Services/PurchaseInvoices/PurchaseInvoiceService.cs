using System.Collections.Generic;
using System.Linq;
using Web202209.SAP_RareCoinWholesalers.Domain;

namespace Web202209.SAP_RareCoinWholesalers.Services.PurchaseInvoices
{
	/// <summary>
	/// PurchaseInvoice service
	/// </summary>
	public partial class PurchaseInvoiceService : BaseService, IPurchaseInvoiceService
	{
		/// <inheritdoc/>
		public virtual IList<PurchaseInvoice> GetAll()
		{
			return (from x in _dbContext.PurchaseInvoices
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<PurchaseInvoice> GetAllValid()
		{
			var query = (from x in _dbContext.PurchaseInvoices
						 where x.CancelStatus == CANCEL_STATUS_NO &&
							   x.CardCode != null && x.CardCode.Trim() != "" &&
							   x.NumAtCard != null && x.NumAtCard.Trim() != ""
						 select x).ToList();

			return query.Where(x => decimal.TryParse(x.NumAtCard, out _)).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<PurchaseInvoice> GetForEsds()
		{
			var query = (from x in _dbContext.PurchaseInvoices
						 where x.DocDate != null && x.DocTotal != null &&
							   x.CardCode != null && x.CardCode.Trim() != ""
						 select x).ToList();

			return query;
		}
	}
}