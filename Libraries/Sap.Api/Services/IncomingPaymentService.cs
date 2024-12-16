using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.IncomingPayments;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		public async Task CancelAsync(IncomingPayment x)
		{
			await Request($"IncomingPayments({x.DocEntry})/Cancel").PostAsync();
		}

		protected async Task<IncomingPayment> CreateAsync(IncomingPayment x)
		{
			var created = await Request("IncomingPayments").PostAsync<IncomingPayment>(x);
			return created;
		}

		public async Task<IList<IncomingPayment>> GetAllIncomingPaymentsAsync()
		{
			var all = await Request("IncomingPayments").GetAllAsync<IncomingPayment>();
			return all;
		}

		public async Task<IncomingPayment> GetIncomingPaymentAsync(object id)
		{
			var entity = await Request("IncomingPayments", id).GetAsync<IncomingPayment>();
			return entity;
		}

		public void LogToCsv(IList<IncomingPayment> list)
		{
			var log = "DocEntry,DocNum,Cancelled,CardCode,CardName,Remarks\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.DocEntry}\",\"{v.DocNum}\",\"{v.Cancelled}\",\"{v.CardCode}\",\"{v.CardName}\",\"{v.Remarks}\"{Environment.NewLine}";

			var folder = String.Format("C:/Logs/SAP Automation/{0:yyyy MM}/", DateTime.Now);
			Directory.CreateDirectory(folder);
			File.WriteAllText(String.Format("{0}IncomingPayments {1:dd HHmm ssff}.csv", folder, DateTime.Now), log);
		}

		public async Task PatchAsync(IncomingPayment x)
		{
			await Request("IncomingPayments", x.DocEntry).PatchAsync(x);
		}

		public async Task<(IncomingPayment, string ErrorMsg)> TryCreateAsync(IncomingPayment x)
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