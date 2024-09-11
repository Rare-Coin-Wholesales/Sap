using System;
using System.Threading.Tasks;
using B1SLayer;
using Sap.Api.Domain.SalesTaxInvoices;
using Sap.Automation;
using ScarletWitch.Sap_RareCoinWholesalers.Services.SalesTaxInvoices;

namespace Sap.Rcw.Automation
{
	public partial class SalesTaxInvoiceUtil
	{
		private readonly SalesTaxInvoiceService _salesTaxInvoiceService = new SalesTaxInvoiceService();

		public async Task GetAllSalesTaxInvoices(SLConnection serviceLayer)
		{
			Common.nLog.Trace("Begin method GetAllSalesTaxInvoices().");
			var list = await serviceLayer.Request(SalesTaxInvoiceRequest.ACTION).GetAllAsync<SalesTaxInvoice>();

			if (list == null || list.Count == 0) {
				Common.nLog.Warn("List is empty.");
				return;
			}
			else {
				_salesTaxInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_salesTaxInvoiceService.Insert(Common._rcwMapper.ToSql(v));
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
