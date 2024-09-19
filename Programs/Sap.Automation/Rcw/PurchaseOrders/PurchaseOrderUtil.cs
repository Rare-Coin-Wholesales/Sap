using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseOrders;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseOrders;

namespace Sap.Rcw.Automation
{
	public partial class PurchaseOrderUtil
	{
		private readonly PurchaseOrderService _purchaseOrderService = new PurchaseOrderService();

		public async Task GetAllPurchaseOrders(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllPurchaseOrders().");
			var list = await serviceLayer.Request(PurchaseOrderRequest.ACTION).GetAllAsync<PurchaseOrder>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_purchaseOrderService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseOrderService.Insert(Common._rcwMapper.ToSql(v));
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
