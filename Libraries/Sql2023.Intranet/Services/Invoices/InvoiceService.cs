using System;
using System.Collections.Generic;
using System.Linq;
using Sap.Core;
using Sap.Services.Security;
using Sql2023.Intranet.Domain;

namespace Sql2023.Intranet.Services.Invoices
{
	/// <summary>
	/// Invoice service
	/// </summary>
	public partial class InvoiceService : IInvoiceService
	{
		private readonly IEncryptionUtil _encryptionUtil;
		private readonly IntranetDb _dbContext;
		private readonly string _connectionString;
		private static readonly DateTime MinDate = DateTime.Today.AddDays(-92); // 3 months ago

		/// <summary>
		/// Ctor
		/// </summary>
		public InvoiceService()
		{
			_encryptionUtil = new EncryptionUtil();
			_connectionString = _encryptionUtil.Decrypt(CommonUtil.GetEnvironmentVariable("Sql2023.Intranet"));
			_dbContext = new IntranetDb(_connectionString);
		}

		/// <inheritdoc/>
		public virtual IList<InvoiceLineItem> GetLineItemsByInvoiceId(int id)
		{
			return (from x in _dbContext.InvoiceLineItems
					where x.InvoiceID == id
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<Invoice> GetRecentInvoices()
		{
			var query =  (from line in _dbContext.InvoiceLineItems
						  join ent in _dbContext.Invoices on line.InvoiceID equals ent.InvoiceID
						  where ent.DateEntered > MinDate
						  select ent).GroupBy(x => x.InvoiceID).Select(grp => grp.FirstOrDefault());

			return query.ToList();
		}
	}
}