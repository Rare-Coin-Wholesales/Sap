using System;
using System.Threading.Tasks;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.BusinessPartners;

namespace Aabrc.Sap
{
	public partial class BusinessPartnerUtil
	{
		private readonly BusinessPartnerService _businessPartnerService = new BusinessPartnerService();

		public async Task GetAllBusinessPartners()
		{
			Program.nLog.Trace("Begin method GetAllBusinessPartners().");
			var list = await Program._serviceLayer.GetAllBusinessPartnersAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				_businessPartnerService.TruncateTable();

				foreach (var v in list) {
					try {
						_businessPartnerService.Insert(Program._mapper.ToSql(v));

						#region Insert BPAddress
						foreach (var line in v.BPAddresses) {
							try {
								_businessPartnerService.Insert(Program._mapper.ToSql(line));
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
						#endregion

						#region Insert BPIntrastatExtension
						//_businessPartnerService.Insert(Program._mapper.ToSql(v.BPIntrastatExtension));
						#endregion

						#region Insert BPPaymentMethod
						foreach (var line in v.BPPaymentMethods) {
							try {
								_businessPartnerService.Insert(Program._mapper.ToSql(line));
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
						#endregion

						#region Insert ContactEmployee
						foreach (var line in v.ContactEmployees) {
							try {
								_businessPartnerService.Insert(Program._mapper.ToSql(line));
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
						#endregion
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
