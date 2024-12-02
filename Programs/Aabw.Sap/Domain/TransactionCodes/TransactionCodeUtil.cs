using System;
using System.Threading.Tasks;
using Sap.Api.Domain.TransactionCodes;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.TransactionCodes;

namespace Aabw.Sap
{
	public partial class TransactionCodeUtil
	{
		private readonly TransactionCodeService _transactionCodeService = new TransactionCodeService();

		public async Task GetAllTransactionCodes()
		{
			Program.nLog.Trace("Begin method GetAllTransactionCodes().");
			var list = await Program._serviceLayer.Request(TransactionCodeRequest.ACTION).GetAllAsync<TransactionCode>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_transactionCodeService.TruncateTable();

				foreach (var v in list) {
					try {
						_transactionCodeService.Insert(Program._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Program.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Program._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
