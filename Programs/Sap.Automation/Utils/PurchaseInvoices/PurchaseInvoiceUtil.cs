using System;
using System.Threading.Tasks;
using B1SLayer;
using ScarletWitch.Sap_ArrowAndBranchWinery.Services.PurchaseInvoices;

namespace Sap.Automation
{
	public partial class PurchaseInvoiceUtil
	{
		private readonly PurchaseInvoiceService _purchaseInvoiceService = new PurchaseInvoiceService();

		public async Task GetAllPurchaseInvoices(SLConnection serviceLayer)
		{
			Common.logger.Trace("Begin method GetAllPurchaseInvoices().");
			var list = await new Api.Services.PurchaseInvoiceService(serviceLayer).GetAll();

			if (list == null || list.Count == 0) {
				Common.logger.Warn("List is empty.");
				return;
			}
			else {
				_purchaseInvoiceService.TruncateTable();

				foreach (var v in list) {
					try {
						_purchaseInvoiceService.Insert(Common._mapper.ToSql(v));

						foreach (var line in v.DocumentLines) {
							try {
								_purchaseInvoiceService.Insert(Common._mapper.ToSql(line));
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
