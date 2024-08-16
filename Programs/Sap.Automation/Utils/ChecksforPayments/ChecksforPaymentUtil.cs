using System;
using Sap.Api.Http;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.ChecksforPayments;

namespace Sap.Automation
{
	public partial class ChecksforPaymentUtil
	{
		private readonly ChecksforPaymentService _checksforPaymentService = new ChecksforPaymentService();

		public void GetAllChecksforPayments()
		{
			Common.logger.Trace("Begin method GetAllChecksforPayments().");
			var client = new SapClient(Common.BaseUrl);
			var _ = client.Login(Common.CompanyDb, Common.Username, Common.Password);
			var list = client.ListChecksforPayments();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_checksforPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_checksforPaymentService.Insert(Common._mapper.ToSql(v));

						foreach (var line in v.ChecksforPaymentLines) {
							try {
								line.CheckKey = v.CheckKey.ToString();
								_checksforPaymentService.Insert(Common._mapper.ToSql(line));
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
