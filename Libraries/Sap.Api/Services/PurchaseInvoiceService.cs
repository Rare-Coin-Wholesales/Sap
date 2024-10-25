using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseInvoices;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		public async Task CancelAsync(PurchaseInvoice x)
		{
			x.CancelDate = DateTime.UtcNow;
			x.Cancelled = CANCELLED_YES;
			x.CancelStatus = CANCEL_STATUS_YES;
			await PatchAsync(x);
		}

		protected async Task<PurchaseInvoice> CreateAsync(PurchaseInvoice x)
		{
			var created = await Request("PurchaseInvoices").PostAsync<PurchaseInvoice>(x);
			return created;
		}

		public async Task<IList<PurchaseInvoice>> GetAllPurchaseInvoicesAsync()
		{
			var all = await Request("PurchaseInvoices").GetAllAsync<PurchaseInvoice>();
			return all;
		}

		public async Task<PurchaseInvoice> GetPurchaseInvoiceAsync(object id)
		{
			var entity = await Request("PurchaseInvoices", id).GetAsync<PurchaseInvoice>();
			return entity;
		}

		public void LogToCsv(IList<PurchaseInvoice> list)
		{
			var log = "DocEntry,DocNum,DocType,CardCode,Comments\r\n";

			foreach (var v in list)
				log = String.Format($"{log}\"{v.DocEntry}\",\"{v.DocNum}\",\"{v.DocType}\",\"{v.CardCode}\",\"{v.Comments}\"{Environment.NewLine}");

			var folder = String.Format("C:/Logs/Sap.Api/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}PurchaseInvoices {1:dd HHmm ssff}.csv", folder, DateTime.Now), log);
		}

		public async Task PatchAsync(PurchaseInvoice x)
		{
			x.CreationDate = null;
			x.UpdateDate = null;
			x.UpdateTime = null;
			await Request("PurchaseInvoices", x.DocEntry).PatchAsync(x);
		}

		public async Task<(PurchaseInvoice, string)> TryCreateAsync(PurchaseInvoice x)
		{
			try {
				return (await CreateAsync(x), null);
			}

			catch (Exception ex) {
				return (null, GetErrorMessage(ex));
			}
		}
	}
}