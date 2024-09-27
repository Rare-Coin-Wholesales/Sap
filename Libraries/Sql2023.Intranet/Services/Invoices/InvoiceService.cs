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
		private readonly EncryptionUtil _encryptionUtil;
		private readonly IntranetDb _dbContext;
		private readonly string _connectionString;

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
		public virtual IList<Invoice> GetAll()
		{
			return (from x in _dbContext.Invoices
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<InvoiceLineItem> GetAllLineItems()
		{
			return (from x in _dbContext.InvoiceLineItems
					select x).ToList();
		}
	}
}