using System;
using System.Threading.Tasks;
using Sap.Api.Domain.IncomingPayments;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.IncomingPayments;

namespace Aabrc.Sap
{
	public partial class IncomingPaymentUtil
	{
		private readonly IncomingPaymentService _incomingPaymentService = new IncomingPaymentService();

		public async Task GetAllIncomingPayments()
		{
			Program.nLog.Trace("Begin method GetAllIncomingPayments().");
			var list = await Program._serviceLayer.Request(IncomingPaymentRequest.ACTION).GetAllAsync<IncomingPayment>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_incomingPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_incomingPaymentService.Insert(Program._mapper.ToSql(v));
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
