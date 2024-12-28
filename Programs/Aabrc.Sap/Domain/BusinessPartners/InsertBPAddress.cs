using System.Collections.Generic;
using Sap.Api.Domain.BusinessPartners;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchRareCoins.Services.BusinessPartners;

namespace Aabrc.Sap
{
	public partial class BusinessPartnerUtil
	{
		private readonly IBPAddressService _bpAddressService = new BPAddressService();

		private void InsertBPAddresss(IList<BusinessPartner> list)
		{
			var docLines = new List<BPAddress>();

			foreach (var v in list)
				docLines.AddRange(v.BPAddresses);

			var dt = CommonUtil.ToDataTable(docLines);
			_bpAddressService.TruncateTable();

			if (!_bpAddressService.TryBulkCopy(dt, out var errorMsg))
				Program.nLog.Error(errorMsg);
		}
	}
}