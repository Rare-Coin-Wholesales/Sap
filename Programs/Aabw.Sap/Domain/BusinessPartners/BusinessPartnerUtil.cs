using System;
using System.Threading.Tasks;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchWinery.Services.BusinessPartners;

namespace Aabw.Sap
{
	public partial class BusinessPartnerUtil
	{
		DateTime EndTimeUtc, StartTimeUtc;
		private readonly BusinessPartnerService _businessPartnerService = new BusinessPartnerService();

		public async Task GetAllBusinessPartners()
		{
			Program.nLog.Info("Begin method GetAllBusinessPartners().");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetAllBusinessPartnersAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_businessPartnerService.TruncateTable();

				if (_businessPartnerService.TryBulkCopy(dt, out var errorMsg)) {
					InsertBPAddresss(list);
					InsertContactEmployee(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_businessPartnerService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetAllBusinessPartners().");
			LogSummary();
		}

		public async Task GetBusinessPartnersByUpdateDate(DateTime minDate, int pageSize)
		{
			Program.nLog.Info($"Begin method GetBusinessPartnersByUpdateDate(DateTime minDate='{minDate}', int pageSize='{pageSize}').");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetBusinessPartnersByUpdateDateAsync(minDate, pageSize);

			if (list == null || list.Count == 0) {
				Program.nLog.Info($"No new BusinessPartners after {minDate:MMM d, yyyy}{Environment.NewLine}");
				return;
			}
			else {
				Program.nLog.Info($"{list.Count} BusinessPartners found.");
				Program._serviceLayer.LogToCsv(list);
				var dt = CommonUtil.ToDataTable(list);
				_businessPartnerService.CheckColumnMappings(dt, "Import", "BusinessPartner");
				_businessPartnerService.TruncateTable();

				if (_businessPartnerService.TryBulkCopy(dt, out var errorMsg)) {
					InsertBPAddresss(list);
					InsertContactEmployee(list);
				}

				else
					Program.nLog.Error(errorMsg);
			}

			_businessPartnerService.TransferToDbo();
			EndTimeUtc = DateTime.UtcNow;
			Program.nLog.Info("End method GetBusinessPartnersByUpdateDate(DateTime minDate, int pageSize).");
			LogSummary();
		}

		void LogSummary()
		{
			var ts = EndTimeUtc - StartTimeUtc;
			Program.nLog.Info("BusinessPartners Summary:");

			if (ts.TotalSeconds < 61)
				Program.nLog.Info("It took {0} sec to complete{1}", ts.ToString(@"s\.fff"), Environment.NewLine);
			else if (ts.TotalMinutes < 61)
				Program.nLog.Info("It took {0}m {1}s to complete{2}", ts.Minutes, ts.Seconds, Environment.NewLine);
			else
				Program.nLog.Info("It took {0}h {1}m to complete{2}", ts.Hours, ts.Minutes, Environment.NewLine);
		}
	}
}