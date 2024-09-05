using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.BusinessPartners;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.BusinessPartners;

namespace Sap.Aabw.Automation
{
	public partial class BusinessPartnerUtil
	{
		private readonly BusinessPartnerService _businessPartnerService = new BusinessPartnerService();

		public async Task GetAllBusinessPartners(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllBusinessPartners().");
			var list = await serviceLayer.Request(BusinessPartnerRequest.ACTION).GetAllAsync<BusinessPartner>();

			if (list == null || list.Count == 0)
				return;
			else {
				_businessPartnerService.TruncateTable();

				foreach (var v in list) {
					try {
						_businessPartnerService.Insert(Common._aabwMapper.ToSql(v));

						#region Insert BPAddress
						foreach (var line in v.BPAddresses) {
							try {
								_businessPartnerService.Insert(Common._aabwMapper.ToSql(line));
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
						#endregion

						#region Insert BPIntrastatExtension
						//_businessPartnerService.Insert(Common._aabwMapper.ToSql(v.BPIntrastatExtension));
						#endregion

						#region Insert BPPaymentMethod
						foreach (var line in v.BPPaymentMethods) {
							try {
								_businessPartnerService.Insert(Common._aabwMapper.ToSql(line));
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
						#endregion

						#region Insert ContactEmployee
						foreach (var line in v.ContactEmployees) {
							try {
								_businessPartnerService.Insert(Common._aabwMapper.ToSql(line));
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
						#endregion
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
