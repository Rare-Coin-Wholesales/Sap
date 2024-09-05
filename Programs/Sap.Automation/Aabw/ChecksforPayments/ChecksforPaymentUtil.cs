using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.ChecksforPayments;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.ChecksforPayments;

namespace Sap.Aabw.Automation
{
	public partial class ChecksforPaymentUtil
	{
		private readonly ChecksforPaymentService _checksforPaymentService = new ChecksforPaymentService();

		public async Task GetAllChecksforPayments(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllChecksforPayments().");
			var list = await serviceLayer.Request(ChecksforPaymentRequest.ACTION).GetAllAsync<ChecksforPayment>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_checksforPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_checksforPaymentService.Insert(Common._aabwMapper.ToSql(v));

						foreach (var line in v.ChecksforPaymentLines) {
							try {
								line.CheckKey = v.CheckKey.ToString();
								_checksforPaymentService.Insert(Common._aabwMapper.ToSql(line));
							}

							catch (Exception ex) {
								#region Log
								if (ex.InnerException == null)
									Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
								else
									throw;
								#endregion
							}
						}
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
