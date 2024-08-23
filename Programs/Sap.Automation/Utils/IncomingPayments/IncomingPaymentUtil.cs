using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.IncomingPayments;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.IncomingPayments;

namespace Sap.Automation
{
	public partial class IncomingPaymentUtil
	{
		private readonly IncomingPaymentService _incomingPaymentService = new IncomingPaymentService();

		public async Task GetAllIncomingPayments(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllIncomingPayments().");
			var list = await serviceLayer.Request(IncomingPaymentRequest.ACTION).GetAllAsync<IncomingPayment>();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_incomingPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_incomingPaymentService.Insert(Common._mapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.logger.Warn("{0}{2}Exception thrown running _service.Insert(Common._mapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
