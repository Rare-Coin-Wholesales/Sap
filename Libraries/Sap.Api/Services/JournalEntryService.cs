using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.JournalEntries;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		protected static void SetLineJdtNum(IList<JournalEntry> list)
		{
			foreach (var x in list)
				foreach (var y in x.JournalEntryLines)
					y.JdtNum = x.JdtNum;
		}

		public async Task CancelAsync(JournalEntry x)
		{
			await Request($"JournalEntries({x.JdtNum})/Cancel").PostAsync();
		}

		protected async Task<JournalEntry> CreateAsync(JournalEntry x)
		{
			var created = await Request("JournalEntries").PostAsync<JournalEntry>(x);
			return created;
		}

		public async Task<IList<JournalEntry>> GetAllJournalEntriesAsync()
		{
			var all = await Request("JournalEntries").GetAllAsync<JournalEntry>();
			SetLineJdtNum(all);
			return all;
		}

		public async Task<JournalEntry> GetJournalEntryAsync(object id)
		{
			var entity = await Request("JournalEntries", id).GetAsync<JournalEntry>();
			return entity;
		}

		public async Task<IList<JournalEntry>> GetJournalEntriesByReferenceDateAsync(DateTime minDate)
		{
			var list = await Request("JournalEntries")
				.Filter($"ReferenceDate ge {minDate:yyyy-MM-dd}")
				.WithPageSize(100)
				.WithCaseInsensitive()
				.GetAsync<List<JournalEntry>>();

			SetLineJdtNum(list);
			return list;
		}

		public void LogToCsv(IList<JournalEntry> list)
		{
			var log = "JdtNum,ReferenceDate,Reference2\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.JdtNum}\",\"{v.ReferenceDate:yyyy-MM-dd}\",\"{v.Reference2}\"{Environment.NewLine}";

			var folder = String.Format("C:/Logs/Sap.Api/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}JournalEntries {1:dd HHmm ssff}.csv", folder, DateTime.Now), log);
		}

		public async Task PatchAsync(JournalEntry x)
		{
			await Request("JournalEntries", x.JdtNum).PatchAsync(x);
		}

		public async Task<(JournalEntry, string ErrorMsg)> TryCreateAsync(JournalEntry x)
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