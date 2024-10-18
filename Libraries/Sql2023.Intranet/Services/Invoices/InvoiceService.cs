using System;
using System.Collections.Generic;
using System.Linq;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Invoices
{
	/// <summary>
	/// Invoice service
	/// </summary>
	public partial class InvoiceService : BaseService, IInvoiceService
	{
		private static readonly DateTime MinDate = DateTime.Today.AddDays(-92); // 3 months ago

		/// <inheritdoc/>
		public virtual IList<InvoiceLineItem> GetLineItemsByInvoiceId(int id)
		{
			return (from x in _dbContext.InvoiceLineItems
					where x.InvoiceID == id
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<Invoice> GetRecent()
		{
			var query =  (from line in _dbContext.InvoiceLineItems
						  join ent in _dbContext.Invoices on line.InvoiceID equals ent.InvoiceID
						  where ent.DateEntered > MinDate
						  select ent).GroupBy(x => x.InvoiceID).Select(grp => grp.FirstOrDefault());

			return query.ToList();
		}

		/// <inheritdoc/>
		public virtual IList<string> GetRecentCustomerIds()
		{
			var query =  (from x in _dbContext.Invoices
						  where x.DateEntered > MinDate
						  select x.Cust_).GroupBy(x => x).Select(grp => grp.FirstOrDefault());

			return query.ToList();
		}
	}
}