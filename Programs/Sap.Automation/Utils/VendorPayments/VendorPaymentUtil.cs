using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.VendorPayments;

namespace Sap.Automation
{
	public partial class VendorPaymentUtil
	{
		private readonly VendorPaymentService _vendorPaymentService = new VendorPaymentService();

		public void GetAllVendorPayments()
		{
			Common.logger.Trace("Begin method GetAllVendorPayments().");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListVendorPayments();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_vendorPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_vendorPaymentService.Insert(Common._mapper.ToSql(v));

						foreach (var line in v.PaymentChecks) {
							try {
								line.DocEntry = v.DocEntry;
								_vendorPaymentService.Insert(Common._mapper.ToSql(line));
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

						foreach (var line in v.PaymentInvoices) {
							try {
								line.VendorPaymentDocEntry = v.DocEntry;
								_vendorPaymentService.Insert(Common._mapper.ToSql(line));
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