using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.Invoices;

namespace Sap.Api.Services
{
	public partial class InvoiceService : BaseService
	{
		public const string INVOICES = "Invoices";

		public InvoiceService(SLConnection ServiceLayer) : base(ServiceLayer) { }

		public async Task<Invoice> CreateAsync(Invoice x)
		{
			try {
				var created = await ServiceLayer.Request(INVOICES).PostAsync<Invoice>(x.ToJson());
				return created;
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "InvoiceService.CreateAsync(Invoice x)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		public async Task<IList<Invoice>> GetAll()
		{
			try {
				var list = await ServiceLayer.Request(INVOICES).GetAllAsync<Invoice>();
				return list;
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "InvoiceService.GetAll()");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		public async Task<Invoice> GetByDocEntry(int docEntry)
		{
			try {
				var x = await ServiceLayer.Request(INVOICES, docEntry).GetAsync<Invoice>();
				return x;
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "InvoiceService.GetByDocEntry(int docEntry)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		public async void PatchAsync(Invoice x)
		{
			try {
				await ServiceLayer.Request(INVOICES, x.DocEntry).PatchAsync(x.ToJson());
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "InvoiceService.PatchAsync(Invoice x)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}
	}
}