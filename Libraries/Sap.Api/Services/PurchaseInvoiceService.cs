using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseInvoices;

namespace Sap.Api.Services
{
	public partial class PurchaseInvoiceService : BaseService
	{
		public const string ACTION = "PurchaseInvoices";

		public PurchaseInvoiceService(SLConnection ServiceLayer) : base(ServiceLayer) { }

		public async void CancelAsync(PurchaseInvoice x)
		{
			x.CancelDate = DateTime.UtcNow;
			x.Cancelled = CANCELLED_YES;
			x.CancelStatus = CANCEL_STATUS_YES;

			try {
				await ServiceLayer.Request(ACTION, x.DocEntry).PatchAsync(x);
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "PurchaseInvoiceService.CancelAsync(PurchaseInvoice x)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		public async Task<PurchaseInvoice> CreateAsync(PurchaseInvoice x)
		{
			var created = await ServiceLayer.Request(ACTION).PostAsync<PurchaseInvoice>(x);
			return created;
		}

		public async Task<IList<PurchaseInvoice>> GetAll()
		{
			try {
				var list = await ServiceLayer.Request(ACTION).GetAllAsync<PurchaseInvoice>();
				return list;
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "PurchaseInvoiceService.GetAll()");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		public async Task<PurchaseInvoice> GetByDocEntry(int docEntry)
		{
			try {
				var x = await ServiceLayer.Request(ACTION, docEntry).GetAsync<PurchaseInvoice>();
				return x;
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "PurchaseInvoiceService.GetByDocEntry(int docEntry)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}

		public async void UpdateAsync(PurchaseInvoice x)
		{
			try {
				await ServiceLayer.Request(ACTION, x.DocEntry).PatchAsync(x);
			}

			catch (Exception ex) {
				#region Handle exception
				var msg = GetFullErrorText(ex, "PurchaseInvoiceService.UpdateAsync(PurchaseInvoice x)");

				if (String.IsNullOrWhiteSpace(msg))
					throw;
				else
					throw new Exception(msg);
				#endregion
			}
		}
	}
}