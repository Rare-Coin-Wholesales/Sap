using System;
using System.Threading.Tasks;
using Sap.Api.Domain.ChecksforPayments;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.ChecksforPayments;

namespace Aabw.Sap
{
	public partial class ChecksforPaymentUtil
	{
		private readonly ChecksforPaymentService _checksforPaymentService = new ChecksforPaymentService();

		public async Task GetAllChecksforPayments()
		{
			Program.nLog.Trace("Begin method GetAllChecksforPayments().");
			var list = await Program._serviceLayer.Request(ChecksforPaymentRequest.ACTION).GetAllAsync<ChecksforPayment>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_checksforPaymentService.TruncateTable();

				foreach (var v in list) {
					try {
						_checksforPaymentService.Insert(Program._mapper.ToSql(v));

						foreach (var line in v.ChecksforPaymentLines) {
							try {
								line.CheckKey = v.CheckKey.ToString();
								_checksforPaymentService.Insert(Program._mapper.ToSql(line));
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
