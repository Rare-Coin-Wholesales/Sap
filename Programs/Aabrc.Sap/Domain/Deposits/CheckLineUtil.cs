using System.Collections.Generic;
using Sap.Api.Domain.Deposits;
using Sap.Core;
using Web202209.SAP_ArrowAndBranchRareCoins.Services.Deposits;

namespace Aabrc.Sap
{
	public partial class DepositUtil
	{
		private readonly ICheckLineService _checkLineService = new CheckLineService();

		private void InsertCheckLines(IList<Deposit> list)
		{
			var docLines = new List<CheckLine>();

			foreach (var v in list)
				docLines.AddRange(v.CheckLines);

			var dt = CommonUtil.ToDataTable(docLines);
			_checkLineService.TruncateTable();

			if (!_checkLineService.TryBulkCopy(dt, out var errorMsg))
				Program.nLog.Error(errorMsg);
		}
	}
}