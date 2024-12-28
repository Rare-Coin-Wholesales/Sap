using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseCreditNotes;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		public async Task CancelAsync(PurchaseCreditNote x)
		{
			await Request($"PurchaseCreditNotes({x.DocEntry})/Cancel").PostAsync();
		}

		protected async Task<PurchaseCreditNote> CreateAsync(PurchaseCreditNote x)
		{
			var created = await Request("PurchaseCreditNotes").PostAsync<PurchaseCreditNote>(x);
			return created;
		}

		public async Task<IList<PurchaseCreditNote>> GetAllPurchaseCreditNotesAsync()
		{
			var all = await Request("PurchaseCreditNotes").GetAllAsync<PurchaseCreditNote>();
			return all;
		}

		public async Task<PurchaseCreditNote> GetPurchaseCreditNoteAsync(object id)
		{
			var entity = await Request("PurchaseCreditNotes", id).GetAsync<PurchaseCreditNote>();
			return entity;
		}

		public void LogToCsv(IList<PurchaseCreditNote> list)
		{
			var log = "DocEntry,DocNum,NumAtCard,Cancelled,CancelStatus,CardCode,CancelDate,CardName,Comments\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.DocEntry}\",\"{v.DocNum}\",\"{v.NumAtCard}\",\"{v.Cancelled}\",\"{v.CancelStatus}\",\"{v.CardCode}\",\"{v.CancelDate}\",\"{v.CardName}\",\"{v.Comments}\"{Environment.NewLine}";

			Directory.CreateDirectory(FileOutputFolder);
			File.WriteAllText($"{FileOutputFolder}PurchaseCreditNotes {DateTime.Now:HHmm ssff}.csv", log);
		}

		public async Task PatchAsync(PurchaseCreditNote x)
		{
			x.CreationDate = null;
			x.UpdateDate = null;
			x.UpdateTime = null;
			await Request("PurchaseCreditNotes", x.DocEntry).PatchAsync(x);
		}

		public async Task<(PurchaseCreditNote, string ErrorMsg)> TryCreateAsync(PurchaseCreditNote x)
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