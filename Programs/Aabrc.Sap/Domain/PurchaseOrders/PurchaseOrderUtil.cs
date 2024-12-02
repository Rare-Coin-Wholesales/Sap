using System;
using System.Threading.Tasks;
using Sap.Api.Domain.PurchaseOrders;
using ScarletWitch.Sap_ArrowAndBranchRareCoins.Services.PurchaseOrders;

namespace Aabrc.Sap
{
	public partial class PurchaseOrderUtil
	{
		private readonly PurchaseOrderService _purchaseOrderService = new PurchaseOrderService();

		public async Task GetAllPurchaseOrders()
		{
			Program.nLog.Trace("Begin method GetAllPurchaseOrders().");
			var list = await Program._serviceLayer.Request(PurchaseOrderRequest.ACTION).GetAllAsync<PurchaseOrder>();

			if (list == null || list.Count == 0) {
				Program.nLog.Warn("List is empty.");
				return;
			}
			else {
				_purchaseOrderService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseOrderService.Insert(Program._mapper.ToSql(v));
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
