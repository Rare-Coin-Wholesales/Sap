using System;
using System.Threading.Tasks;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchRareCoins.Services.BusinessPartners;

namespace Aabrc.Sap
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
			Program.nLog.Info("Begin method GetBusinessPartnersByUpdateDate(DateTime minDate, int pageSize).");
			StartTimeUtc = DateTime.UtcNow;
			var list = await Program._serviceLayer.GetBusinessPartnersByUpdateDateAsync(minDate, pageSize);

			if (list == null || list.Count == 0)
				return;
			else {
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
				Program.nLog.Info("It took {0} sec to complete", ts.ToString(@"s\.fff"));
			else if (ts.TotalMinutes < 61)
				Program.nLog.Info("It took {0}m {1}s to complete", ts.Minutes, ts.Seconds);
			else
				Program.nLog.Info("It took {0}h {1}m to complete", ts.Hours, ts.Minutes);

			Program.nLog.Info("");
		}
	}
}