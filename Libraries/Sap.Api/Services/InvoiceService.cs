using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.Invoices;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		public async Task CancelAsync(Invoice x)
		{
			await Request($"Invoices({x.DocEntry})/Cancel").PostAsync();
		}

		protected async Task<Invoice> CreateAsync(Invoice x)
		{
			var created = await Request("Invoices").PostAsync<Invoice>(x);
			return created;
		}

		public async Task<IList<Invoice>> GetAllInvoicesAsync()
		{
			var all = await Request("Invoices").GetAllAsync<Invoice>();
			return all;
		}

		public async Task<Invoice> GetInvoiceAsync(object id)
		{
			var entity = await Request("Invoices", id).GetAsync<Invoice>();
			return entity;
		}

		public async Task<IList<Invoice>> GetInvoicesByUpdateDateAsync(DateTime minDate, int pageSize)
		{
			var list = await Request("Invoices")
				.Filter($"UpdateDate ge {minDate:yyyy-MM-dd}")
				.WithPageSize(pageSize)
				.OrderBy("UpdateDate desc")
				.WithCaseInsensitive()
				.GetAsync<List<Invoice>>();

			return list;
		}

		public void LogToCsv(IList<Invoice> list)
		{
			var log = "DocEntry,DocNum,NumAtCard,Cancelled,CancelStatus,CardCode,CancelDate,CardName,Comments\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.DocEntry}\",\"{v.DocNum}\",\"{v.NumAtCard}\",\"{v.Cancelled}\",\"{v.CancelStatus}\",\"{v.CardCode}\",\"{v.CancelDate}\",\"{v.CardName}\",\"{v.Comments}\"{Environment.NewLine}";

			Directory.CreateDirectory(FileOutputFolder);
			File.WriteAllText($"{FileOutputFolder}Invoices {DateTime.Now:HHmm ssff}.csv", log);
		}

		public async Task PatchAsync(Invoice x)
		{
			x.CreationDate = null;
			x.UpdateDate = null;
			x.UpdateTime = null;
			await Request("Invoices", x.DocEntry).PatchAsync(x);
		}

		public async Task<(Invoice, string ErrorMsg)> TryCreateAsync(Invoice x)
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