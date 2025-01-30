using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.ChecksforPayments;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		protected static void SetLineCheckKey(IList<ChecksforPayment> list)
		{
			foreach (var item in list)
				foreach (var line in item.ChecksforPaymentLines)
					line.CheckKey = item.CheckKey;
		}

		public async Task CancelAsync(ChecksforPayment x)
		{
			await Request($"ChecksforPayment({x.CheckKey})/Cancel").PostAsync();
		}

		protected async Task<ChecksforPayment> CreateAsync(ChecksforPayment x)
		{
			var created = await Request("ChecksforPayment").PostAsync<ChecksforPayment>(x);
			return created;
		}

		public async Task<IList<ChecksforPayment>> GetAllChecksforPaymentAsync()
		{
			var all = await Request("ChecksforPayment").GetAllAsync<ChecksforPayment>();
			SetLineCheckKey(all);
			return all;
		}

		public async Task<ChecksforPayment> GetChecksforPaymentAsync(object id)
		{
			var entity = await Request("ChecksforPayment", id).GetAsync<ChecksforPayment>();
			SetLineCheckKey(new List<ChecksforPayment> { entity });
			return entity;
		}

		public async Task<IList<ChecksforPayment>> GetChecksforPaymentByUpdateDateAsync(DateTime minDate, int pageSize)
		{
			var list = await Request("ChecksforPayment")
				.Filter($"UpdateDate ge {minDate:yyyy-MM-dd}")
				.WithPageSize(pageSize)
				.OrderBy("UpdateDate desc")
				.WithCaseInsensitive()
				.GetAsync<List<ChecksforPayment>>();

			SetLineCheckKey(list);
			return list;
		}

		public void LogToCsv(IList<ChecksforPayment> list)
		{
			var log = "CheckKey,CheckNumber,CheckDate,CheckAmount,VendorName,UpdateDate,CreationDate\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.CheckKey}\",\"{v.CheckNumber}\",\"{v.CheckDate:yyyy-MM-dd}\",\"{v.CheckAmount:n2}\",\"{v.VendorName}\",\"{v.UpdateDate:yyyy-MM-dd}\",\"{v.CreationDate:yyyy-MM-dd}\"{Environment.NewLine}";

			Directory.CreateDirectory(FileOutputFolder);
			File.WriteAllText($"{FileOutputFolder}ChecksforPayment {DateTime.Now:HHmm ssff}.csv", log);
		}

		public async Task PatchAsync(ChecksforPayment x)
		{
			x.CreationDate = null;
			x.UpdateDate = null;
			await Request("ChecksforPayment", x.CheckKey).PatchAsync(x);
		}

		public async Task<(ChecksforPayment, string ErrorMsg)> TryCreateAsync(ChecksforPayment x)
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