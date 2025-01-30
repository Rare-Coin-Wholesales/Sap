using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.VendorPayments;

namespace Sap.Api
{
	public partial class ServiceLayer : SLConnection
	{
		protected static void SetLineDocEntry(IList<VendorPayment> list)
		{
			foreach (var item in list) {
				foreach (var line in item.PaymentChecks)
					line.DocEntry = item.DocEntry;
				foreach (var line in item.PaymentInvoices)
					line.VendorPaymentDocEntry = item.DocEntry;
			}
		}

		public async Task CancelAsync(VendorPayment x)
		{
			await Request($"VendorPayments({x.DocEntry})/Cancel").PostAsync();
		}

		protected async Task<VendorPayment> CreateAsync(VendorPayment x)
		{
			var created = await Request("VendorPayments").PostAsync<VendorPayment>(x);
			return created;
		}

		public async Task<IList<VendorPayment>> GetAllVendorPaymentsAsync()
		{
			var all = await Request("VendorPayments").GetAllAsync<VendorPayment>();
			SetLineDocEntry(all);
			return all;
		}

		public async Task<VendorPayment> GetVendorPaymentAsync(object id)
		{
			var entity = await Request("VendorPayments", id).GetAsync<VendorPayment>();
			SetLineDocEntry(new List<VendorPayment> { entity });
			return entity;
		}

		public async Task<IList<VendorPayment>> GetVendorPaymentsByDocDateAsync(DateTime minDate, int pageSize)
		{
			var list = await Request("VendorPayments")
				.Filter($"DocDate ge {minDate:yyyy-MM-dd}")
				.WithPageSize(pageSize)
				.OrderBy("DocDate desc")
				.WithCaseInsensitive()
				.GetAsync<List<VendorPayment>>();

			SetLineDocEntry(list);
			return list;
		}

		public void LogToCsv(IList<VendorPayment> list)
		{
			var log = "DocDate,DocEntry,DocNum,CardCode,CardName,TransferSum,Reference1,Reference2\r\n";

			foreach (var v in list)
				log = $"{log}\"{v.DocDate:yyyy-MM-dd}\",\"{v.DocEntry}\",\"{v.DocNum}\",\"{v.CardCode}\",\"{v.CardName}\",\"{v.TransferSum:n2}\",\"{v.Reference1}\",\"{v.Reference2}\"{Environment.NewLine}";

			Directory.CreateDirectory(FileOutputFolder);
			File.WriteAllText($"{FileOutputFolder}VendorPayments {DateTime.Now:HHmm ssff}.csv", log);
		}

		public async Task PatchAsync(VendorPayment x)
		{
			await Request("VendorPayments", x.DocEntry).PatchAsync(x);
		}

		public async Task<(VendorPayment, string ErrorMsg)> TryCreateAsync(VendorPayment x)
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