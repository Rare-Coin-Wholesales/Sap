using System;
using System.Threading.Tasks;
using Sap.Core;
using Web202209.SAP_RareCoinWholesalers.Services.PurchaseInvoices;

namespace Rcw.Sap
{
	public partial class PurchaseInvoiceUtil
	{
		DateTime EndTimeUtc, StartTimeUtc;
		private readonly IPurchaseInvoiceService _purchaseInvoiceService = new PurchaseInvoiceService();

		public async Task GetAllPurchaseInvoices()
		{
			Program.nLog.Info("Begin method GetAllPurchaseInvoices().");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetAllPurchaseInvoicesAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_purchaseInvoiceService.TruncateTable();

				if (_purchaseInvoiceService.TryBulkCopy(dt, out var errorMsg)) {
					InsertDocumentLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_purchaseInvoiceService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetAllPurchaseInvoices().");
			LogSummary();
		}

		public async Task GetPurchaseInvoicesByUpdateDate(DateTime minDate, int pageSize)
		{
			Program.nLog.Info($"Begin method GetPurchaseInvoicesByUpdateDate(DateTime minDate='{minDate}', int pageSize='{pageSize}').");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetPurchaseInvoicesByUpdateDateAsync(minDate, pageSize);

			if (list == null || list.Count == 0) {
				Program.nLog.Info($"No new PurchaseInvoices after {minDate:MMM d, yyyy}{Environment.NewLine}");
				return;
			}
			else {
				Program.nLog.Info($"{list.Count} PurchaseInvoices found.");
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_purchaseInvoiceService.TruncateTable();

				if (_purchaseInvoiceService.TryBulkCopy(dt, out var errorMsg)) {
					InsertDocumentLines(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_purchaseInvoiceService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetPurchaseInvoicesByUpdateDate(DateTime minDate, int pageSize).");
			LogSummary();
		}

		void LogSummary()
		{
			var ts = EndTimeUtc - StartTimeUtc;
			Program.nLog.Info("PurchaseInvoices Summary:");

			if (ts.TotalSeconds < 61)
				Program.nLog.Info("It took {0} sec to complete{1}", ts.ToString(@"s\.fff"), Environment.NewLine);
			else if (ts.TotalMinutes < 61)
				Program.nLog.Info("It took {0}m {1}s to complete{2}", ts.Minutes, ts.Seconds, Environment.NewLine);
			else
				Program.nLog.Info("It took {0}h {1}m to complete{2}", ts.Hours, ts.Minutes, Environment.NewLine);
		}
	}
}