using System;
using System.Threading.Tasks;
using Sap.Api.Domain.VendorPayments;
using ScarletWitch.Sap_RareCoinWholesalers.Services.VendorPayments;

namespace Rcw.Sap
{
	public partial class VendorPaymentUtil
	{
		private readonly VendorPaymentService _vendorPaymentService = new VendorPaymentService();

		public async Task GetAllVendorPayments()
		{
			Program.nLog.Trace("Begin method GetAllVendorPayments().");
			var list = await Program._serviceLayer.Request(VendorPaymentRequest.ACTION).GetAllAsync<VendorPayment>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_vendorPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_vendorPaymentService.Insert(Program._mapper.ToSql(v));

						foreach (var line in v.PaymentChecks) {
							try {
								line.DocEntry = v.DocEntry;
								_vendorPaymentService.Insert(Program._mapper.ToSql(line));
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

						foreach (var line in v.PaymentInvoices) {
							try {
								line.VendorPaymentDocEntry = v.DocEntry;
								_vendorPaymentService.Insert(Program._mapper.ToSql(line));
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