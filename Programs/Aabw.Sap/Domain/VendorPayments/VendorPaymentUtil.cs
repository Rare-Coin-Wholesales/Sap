using System;
using System.Threading.Tasks;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.VendorPayments;

namespace Aabw.Sap
{
	public partial class VendorPaymentUtil
	{
		DateTime EndTimeUtc, StartTimeUtc;
		private readonly IVendorPaymentService _vendorPaymentService = new VendorPaymentService();

		public async Task GetAllVendorPayments()
		{
			Program.nLog.Info("Begin method GetAllVendorPayments().");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetAllVendorPaymentsAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_vendorPaymentService.TruncateTable();

				if (_vendorPaymentService.TryBulkCopy(dt, out var errorMsg)) {
					InsertPaymentChecks(list);
					InsertPaymentInvoices(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_vendorPaymentService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetAllVendorPayments().");
			LogSummary();
		}

		public async Task GetVendorPaymentsByDocDate(DateTime minDate, int pageSize)
		{
			Program.nLog.Info($"Begin method GetVendorPaymentsByDocDate(DateTime minDate='{minDate}', int pageSize='{pageSize}').");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetVendorPaymentsByDocDateAsync(minDate, pageSize);

			if (list == null || list.Count == 0) {
				Program.nLog.Info($"No new VendorPayments after {minDate:MMM d, yyyy}{Environment.NewLine}");
				return;
			}
			else {
				Program.nLog.Info($"{list.Count} VendorPayments found.");
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_vendorPaymentService.TruncateTable();

				if (_vendorPaymentService.TryBulkCopy(dt, out var errorMsg)) {
					InsertPaymentChecks(list);
					InsertPaymentInvoices(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_vendorPaymentService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetVendorPaymentsByDocDate(DateTime minDate, int pageSize).");
			LogSummary();
		}

		void LogSummary()
		{
			var ts = EndTimeUtc - StartTimeUtc;
			Program.nLog.Info("VendorPayments Summary:");

			if (ts.TotalSeconds < 61)
				Program.nLog.Info("It took {0} sec to complete{1}", ts.ToString(@"s\.fff"), Environment.NewLine);
			else if (ts.TotalMinutes < 61)
				Program.nLog.Info("It took {0}m {1}s to complete{2}", ts.Minutes, ts.Seconds, Environment.NewLine);
			else
				Program.nLog.Info("It took {0}h {1}m to complete{2}", ts.Hours, ts.Minutes, Environment.NewLine);
		}
	}
}