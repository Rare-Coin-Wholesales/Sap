using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.Invoices;

namespace Sap.Api.Services
{
	public partial class InvoiceService : BaseService
	{
		public const string ACTION = "Invoices";

		public InvoiceService(SLConnection ServiceLayer) : base(ServiceLayer) { }

		public async void CancelAsync(Invoice x)
		{
			x.CancelDate = DateTime.UtcNow;
			x.Cancelled = CANCELLED_YES;
			x.CancelStatus = CANCEL_STATUS_YES;

			try {
				await ServiceLayer.Request(ACTION, x.DocEntry).PatchAsync(x);
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "InvoiceService.CancelAsync(Invoice x)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		public async Task<Invoice> CreateAsync(Invoice x)
		{
			try {
				var created = await ServiceLayer.Request(ACTION).PostAsync<Invoice>(x);
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
				var list = await ServiceLayer.Request(ACTION).GetAllAsync<Invoice>();
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
				var x = await ServiceLayer.Request(ACTION, docEntry).GetAsync<Invoice>();
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

		public async void UpdateAsync(Invoice x)
		{
			try {
				await ServiceLayer.Request(ACTION, x.DocEntry).PatchAsync(x);
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "InvoiceService.UpdateAsync(Invoice x)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}
	}
}