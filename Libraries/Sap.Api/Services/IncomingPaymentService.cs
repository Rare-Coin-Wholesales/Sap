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
		protected static void SetLineDocEntry(IList<IncomingPayment> list)
		{
			foreach (var payment in list)
				foreach (var check in payment.PaymentChecks)
					check.IncomingPaymentDocEntry = payment.DocEntry;
		}

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
			SetLineDocEntry(all);
			return all;
		}

		public async Task<IncomingPayment> GetIncomingPaymentAsync(object id)
		{
			var entity = await Request("IncomingPayments", id).GetAsync<IncomingPayment>();
			return entity;
		}

		public async Task<IList<IncomingPayment>> GetIncomingPaymentsByDocDateAsync(DateTime minDate)
		{
			var list = await Request("IncomingPayments")
				.Filter($"DocDate ge {minDate:yyyy-MM-dd}")
				.WithPageSize(100)
				.WithCaseInsensitive()
				.GetAsync<List<IncomingPayment>>();

			SetLineDocEntry(list);
			return list;
		}

		public void LogToCsv(IList<IncomingPayment> list)
		{
			var log = "DocEntry,DocNum,DocDate,CardCode,CardName,TransferSum,Remarks,TransferReference,Reference2,CounterReference\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.DocEntry}\",\"{v.DocNum}\",\"{v.DocDate:yyyy-MM-dd}\",\"{v.CardCode}\",\"{v.CardName}\",\"{v.TransferSum:n2}\",\"{v.Remarks}\",\"{v.TransferReference}\",\"{v.Reference2}\",\"{v.CounterReference}\"{Environment.NewLine}";

			var folder = String.Format("C:/Logs/Sap.Api/{0:yyyy MM}/", DateTime.Now);
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
				return (null, GetFullErrorText(ex, null));
			}
		}
	}
}