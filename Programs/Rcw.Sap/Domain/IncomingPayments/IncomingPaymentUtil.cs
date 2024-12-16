using System;
using System.Threading.Tasks;
using NLog;
using Sap.Api.Domain.IncomingPayments;
using Sap.Core;
using ScarletWitch.Sap_RareCoinWholesalers.Services.IncomingPayments;

namespace Rcw.Sap
{
	public partial class IncomingPaymentUtil
	{
		private readonly IncomingPaymentService _incomingPaymentService = new IncomingPaymentService();

		public async Task GetAllIncomingPayments()
		{
			Program.nLog.Info("Begin method GetAllIncomingPayments().");
			var list = await Program._serviceLayer.Request(IncomingPaymentRequest.ACTION).GetAllAsync<IncomingPayment>();

			if (list == null || list.Count == 0)
				Program.nLog.Warn("There are no IncomingPayments to import.");
			else {
				_incomingPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_incomingPaymentService.Insert(Program._mapper.ToSql(v));
					}

					catch (Exception ex) {
						Program.nLog.Warn(ex.CustomMessage("Exception thrown running _incomingPaymentService.Insert(Program._mapper.ToSql(v))."));
					}
				}
			}

			Program.nLog.Info("End method GetAllIncomingPayments().");
			LogManager.Flush();
		}
	}
}