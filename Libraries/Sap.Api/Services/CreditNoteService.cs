using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.CreditNotes;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		public async Task CancelAsync(CreditNote x)
		{
			await Request($"CreditNotes({x.DocEntry})/Cancel").PostAsync();
		}

		protected async Task<CreditNote> CreateAsync(CreditNote x)
		{
			var created = await Request("CreditNotes").PostAsync<CreditNote>(x);
			return created;
		}

		public async Task<IList<CreditNote>> GetAllCreditNotesAsync()
		{
			var all = await Request("CreditNotes").GetAllAsync<CreditNote>();
			return all;
		}

		public async Task<CreditNote> GetCreditNoteAsync(object id)
		{
			var entity = await Request("CreditNotes", id).GetAsync<CreditNote>();
			return entity;
		}

		public void LogToCsv(IList<CreditNote> list)
		{
			var log = "DocEntry,DocNum,NumAtCard,Cancelled,CancelStatus,CardCode,CancelDate,CardName,Comments\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.DocEntry}\",\"{v.DocNum}\",\"{v.NumAtCard}\",\"{v.Cancelled}\",\"{v.CancelStatus}\",\"{v.CardCode}\",\"{v.CancelDate}\",\"{v.CardName}\",\"{v.Comments}\"{Environment.NewLine}";

			Directory.CreateDirectory(FileOutputFolder);
			File.WriteAllText($"{FileOutputFolder}CreditNotes {DateTime.Now:HHmm ssff}.csv", log);
		}

		public async Task PatchAsync(CreditNote x)
		{
			x.CreationDate = null;
			x.UpdateDate = null;
			x.UpdateTime = null;
			await Request("CreditNotes", x.DocEntry).PatchAsync(x);
		}

		public async Task<(CreditNote, string ErrorMsg)> TryCreateAsync(CreditNote x)
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