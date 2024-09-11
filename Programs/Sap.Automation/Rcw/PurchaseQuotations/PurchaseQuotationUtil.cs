using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseQuotations;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseQuotations;

namespace Sap.Rcw.Automation
{
	public partial class PurchaseQuotationUtil
	{
		private readonly PurchaseQuotationService _purchaseQuotationService = new PurchaseQuotationService();

		public async Task GetAllPurchaseQuotations(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllPurchaseQuotations().");
			var list = await serviceLayer.Request(PurchaseQuotationRequest.ACTION).GetAllAsync<PurchaseQuotation>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_purchaseQuotationService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseQuotationService.Insert(Common._rcwMapper.ToSql(v));
					}

					catch (Exception ex) {
						#region Log
						if (ex.InnerException == null)
							Common.nLog.Warn("{0}{2}Exception thrown running _service.Insert(Common._rcwMapper.ToSql(v)).{2}{1}{2}{2}", ex.Message, ex, Environment.NewLine);
						else
							throw;
						#endregion
					}
				}
			}
		}
	}
}
