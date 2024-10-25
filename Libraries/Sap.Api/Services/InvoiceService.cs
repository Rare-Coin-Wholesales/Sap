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
			x.CancelDate = DateTime.UtcNow;
			x.Cancelled = CANCELLED_YES;
			x.CancelStatus = CANCEL_STATUS_YES;
			await PatchAsync(x);
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

		public void LogToCsv(IList<Invoice> list)
		{
			var log = "DocEntry,DocNum,DocType,CardCode,Comments\r\n";

			foreach (var v in list)
				log = String.Format($"{log}\"{v.DocEntry}\",\"{v.DocNum}\",\"{v.DocType}\",\"{v.CardCode}\",\"{v.Comments}\"{Environment.NewLine}");

			var folder = String.Format("C:/Logs/Sap.Api/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}Invoices {1:dd HHmm ssff}.csv", folder, DateTime.Now), log);
		}

		public async Task PatchAsync(Invoice x)
		{
			x.CreationDate = null;
			x.UpdateDate = null;
			x.UpdateTime = null;
			await Request("Invoices", x.DocEntry).PatchAsync(x);
		}

		public async Task<(Invoice, string)> TryCreateAsync(Invoice x)
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