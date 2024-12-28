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
			await Request($"PurchaseInvoices({x.DocEntry})/Cancel").PostAsync();
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

		public async Task<IList<PurchaseInvoice>> GetPurchaseInvoicesByUpdateDateAsync(DateTime minDate)
		{
			var list = await Request("PurchaseInvoices")
				.Filter($"UpdateDate ge {minDate:yyyy-MM-dd}")
				.WithPageSize(100)
				.WithCaseInsensitive()
				.GetAsync<List<PurchaseInvoice>>();

			return list;
		}

		public async Task<PurchaseInvoice> GetPurchaseInvoiceAsync(object id)
		{
			var entity = await Request("PurchaseInvoices", id).GetAsync<PurchaseInvoice>();
			return entity;
		}

		public void LogToCsv(IList<PurchaseInvoice> list)
		{
			var log = "DocEntry,DocNum,NumAtCard,Cancelled,CancelStatus,CardCode,CancelDate,CardName,Comments\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.DocEntry}\",\"{v.DocNum}\",\"{v.NumAtCard}\",\"{v.Cancelled}\",\"{v.CancelStatus}\",\"{v.CardCode}\",\"{v.CancelDate}\",\"{v.CardName}\",\"{v.Comments}\"{Environment.NewLine}";

			Directory.CreateDirectory(FileOutputFolder);
			File.WriteAllText($"{FileOutputFolder}PurchaseInvoices {DateTime.Now:HHmm ssff}.csv", log);
		}

		public async Task PatchAsync(PurchaseInvoice x)
		{
			x.CreationDate = null;
			x.UpdateDate = null;
			x.UpdateTime = null;
			await Request("PurchaseInvoices", x.DocEntry).PatchAsync(x);
		}

		public async Task<(PurchaseInvoice, string ErrorMsg)> TryCreateAsync(PurchaseInvoice x)
		{
			try {
				return (await CreateAsync(x), null);
			}

			catch (Exception ex) {
				return (null, GetFullErrorText(ex, null));
			}
		}
	}
}