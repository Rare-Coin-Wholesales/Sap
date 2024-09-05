using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.TransactionCodes;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.TransactionCodes;

namespace Sap.Aabrc.Automation
{
	public partial class TransactionCodeUtil
	{
		private readonly TransactionCodeService _transactionCodeService = new TransactionCodeService();

		public async Task GetAllTransactionCodes(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllTransactionCodes().");
			var list = await serviceLayer.Request(TransactionCodeRequest.ACTION).GetAllAsync<TransactionCode>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_transactionCodeService.TruncateTable();

				foreach (var v in list) {
					try {
						_transactionCodeService.Insert(Common._aabrcMapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabrcMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
