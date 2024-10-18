using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Automation;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.BusinessPartners;

namespace Sap.Aabrc.Automation
{
	public partial class BusinessPartnerUtil
	{
		private readonly BusinessPartnerService _businessPartnerService = new BusinessPartnerService();

		public async Task GetAllBusinessPartners(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllBusinessPartners().");
			var list = await Common.AabrcServiceLayer.GetAllBusinessPartnersAsync();

			if (list == null || list.Count == 0)
				return;
			else {
				_businessPartnerService.TruncateTable();

				foreach (var v in list) {
					try {
						_businessPartnerService.Insert(Common._aabrcMapper.ToSql(v));

						#region Insert BPAddress
						foreach (var line in v.BPAddresses) {
							try {
								_businessPartnerService.Insert(Common._aabrcMapper.ToSql(line));
							}

							catch (Exception ex) {
								#region Log
								if (ex.InnerException == null)
									Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabrcMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
								else
									throw;
								#endregion
							}
						}
						#endregion

						#region Insert BPIntrastatExtension
						//_businessPartnerService.Insert(Common._aabrcMapper.ToSql(v.BPIntrastatExtension));
						#endregion

						#region Insert BPPaymentMethod
						foreach (var line in v.BPPaymentMethods) {
							try {
								_businessPartnerService.Insert(Common._aabrcMapper.ToSql(line));
							}

							catch (Exception ex) {
								#region Log
								if (ex.InnerException == null)
									Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabrcMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
								else
									throw;
								#endregion
							}
						}
						#endregion

						#region Insert ContactEmployee
						foreach (var line in v.ContactEmployees) {
							try {
								_businessPartnerService.Insert(Common._aabrcMapper.ToSql(line));
							}

							catch (Exception ex) {
								#region Log
								if (ex.InnerException == null)
									Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabrcMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
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
							Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._aabrcMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
