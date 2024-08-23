using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseQuotations;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseQuotations;

namespace Sap.Automation
{
	public partial class PurchaseQuotationUtil
	{
		private readonly PurchaseQuotationService _purchaseQuotationService = new PurchaseQuotationService();

		public async Task GetAllPurchaseQuotations(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllPurchaseQuotations().");
			var list = await serviceLayer.Request(PurchaseQuotationRequest.ACTION).GetAllAsync<PurchaseQuotation>();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_purchaseQuotationService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseQuotationService.Insert(Common._mapper.ToSql(v));
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
