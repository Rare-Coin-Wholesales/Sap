using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.BillOfExchangeTransactions;

namespace Sap.Automation
{
	public partial class BillOfExchangeTransactionUtil
	{
		private readonly BillOfExchangeTransactionService _billOfExchangeTransactionService = new BillOfExchangeTransactionService();

		public void GetAllBillOfExchangeTransactions()
		{
			Common.logger.Trace("Begin method GetAllBillOfExchangeTransactions().");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListBillOfExchangeTransactions();

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
