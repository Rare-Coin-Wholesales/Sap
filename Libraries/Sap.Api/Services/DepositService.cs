using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.Deposits;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		protected static void SetLineAbsEntry(IList<Deposit> list)
		{
			foreach (var item in list)
				foreach (var line in item.CheckLines)
					line.DepositAbsEntry = item.AbsEntry;
		}

		public async Task CancelAsync(Deposit x)
		{
			await Request($"Deposits({x.AbsEntry})/Cancel").PostAsync();
		}

		protected async Task<Deposit> CreateAsync(Deposit x)
		{
			var created = await Request("Deposits").PostAsync<Deposit>(x);
			return created;
		}

		public async Task<IList<Deposit>> GetAllDepositsAsync()
		{
			var all = await Request("Deposits").GetAllAsync<Deposit>();
			SetLineAbsEntry(all);
			return all;
		}

		public async Task<Deposit> GetDepositAsync(object id)
		{
			var entity = await Request("Deposits", id).GetAsync<Deposit>();
			SetLineAbsEntry(new List<Deposit> { entity });
			return entity;
		}

		public async Task<IList<Deposit>> GetDepositsByDepositDateAsync(DateTime minDate)
		{
			var list = await Request("Deposits")
				.Filter($"DepositDate ge {minDate:yyyy-MM-dd}")
				.WithPageSize(100)
				.WithCaseInsensitive()
				.GetAsync<List<Deposit>>();

			SetLineAbsEntry(list);
			return list;
		}

		public void LogToCsv(IList<Deposit> list)
		{
			var log = "DepositNumber,AbsEntry,DepositDate,DepositAccount,BankReference,JournalRemarks,TotalLC,TotalSC\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.DepositNumber}\",\"{v.AbsEntry}\",\"{v.DepositDate:yyyy-MM-dd}\",\"{v.DepositAccount}\",\"{v.BankReference}\",\"{v.JournalRemarks}\",\"{v.TotalLC:n2}\",\"{v.TotalSC:n2}\"{Environment.NewLine}";

			Directory.CreateDirectory(FileOutputFolder);
			File.WriteAllText($"{FileOutputFolder}Deposits {DateTime.Now:HHmm ssff}.csv", log);
		}

		public async Task PatchAsync(Deposit x)
		{
			await Request("Deposits", x.AbsEntry).PatchAsync(x);
		}

		public async Task<(Deposit, string ErrorMsg)> TryCreateAsync(Deposit x)
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