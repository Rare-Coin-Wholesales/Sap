using System;
using System.Collections.Generic;
using System.Linq;
using Sql2023.Intranet.Domain;
using Sql2023.Intranet.Services.CompanyNamePartials;
using Sql2023.Intranet.Services.Invoices;
using Sql2023.Intranet.Services.Orders;

namespace Sql2023.Intranet.Services.UnixCustomers
{
	/// <summary>
	/// UnixCustomer service
	/// </summary>
	public partial class UnixCustomerService : BaseService, IUnixCustomerService
	{
		private readonly ICompanyNamePartialService _companyNamePartialService = new CompanyNamePartialService();
		private readonly IInvoiceService _invoiceService = new InvoiceService();
		private readonly IOrderService _orderService = new OrderService();

		/// <inheritdoc/>
		public virtual string DetermineBpType(string id, string name)
		{
			if (String.IsNullOrWhiteSpace(id))
				return "C";
			if (_companyNamePartialService.ContainsPartial(name))
				return "S";
			if (long.TryParse(id, out _))
				return "C";

			return "S";
		}

		/// <inheritdoc/>
		public virtual IList<UnixCustomer> GetAll()
		{
			return (from x in _dbContext.UnixCustomers
					select x).ToList();
		}

		/// <inheritdoc/>
		public virtual IList<UnixCustomer> GetRecent()
		{
			var invoiceCustomers = _invoiceService.GetRecentCustomerIds();
			var orderCustomers = _orderService.GetRecentCustomerIds();
			var union = orderCustomers.Union(invoiceCustomers);

			return (from x in _dbContext.UnixCustomers
					join y in union on x.CustID equals y
					select x).ToList();
		}
	}
}