using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseOrders;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseOrders;

namespace Sap.Automation
{
	public partial class PurchaseOrderUtil
	{
		private readonly PurchaseOrderService _purchaseOrderService = new PurchaseOrderService();

		public async Task GetAllPurchaseOrders(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllPurchaseOrders().");
			var list = await serviceLayer.Request(PurchaseOrderRequest.ACTION).GetAllAsync<PurchaseOrder>();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_purchaseOrderService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseOrderService.Insert(Common._mapper.ToSql(v));
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
