using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.PurchaseTaxInvoices;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.PurchaseTaxInvoices;

namespace Sap.Rcw.Automation
{
	public partial class PurchaseTaxInvoiceUtil
	{
		private readonly PurchaseTaxInvoiceService _purchaseTaxInvoiceService = new PurchaseTaxInvoiceService();

		public async Task GetAllPurchaseTaxInvoices(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllPurchaseTaxInvoices().");
			var list = await serviceLayer.Request(PurchaseTaxInvoiceRequest.ACTION).GetAllAsync<PurchaseTaxInvoice>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_purchaseTaxInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseTaxInvoiceService.Insert(Common._rcwMapper.ToSql(v));
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
