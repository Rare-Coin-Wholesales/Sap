using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.BillOfExchangeTransactions;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.BillOfExchangeTransactions;

namespace Sap.Automation
{
	public partial class BillOfExchangeTransactionUtil
	{
		private readonly BillOfExchangeTransactionService _billOfExchangeTransactionService = new BillOfExchangeTransactionService();

		public async Task GetAllBillOfExchangeTransactions(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllBillOfExchangeTransactions().");
			var list = await serviceLayer.Request(BillOfExchangeTransactionRequest.ACTION).GetAllAsync<BillOfExchangeTransaction>();

			if (list == null || list.Count == 0)
				return;
			else {
				_billOfExchangeTransactionService.TruncateTable();

				foreach (var v in list) {
					try {
						_billOfExchangeTransactionService.Insert(Common._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.logger.Warn("{0}{2}Exception thrown running _billOfExchangeTransactionService.Insert(Common._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
